using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace BK8500_Interface
{
    public partial class BK8500_Interface : Form
    {
        //global declarations 
        SerialPort comBK8500;
        static int txSent = 0;
        static byte[] rxData;
        static int rxFlag = 0;
        static int comTimeout = 0;
        static byte operatingMode = 0x00;
        static byte constantMode = 0;
        static byte tranOperation = 0;
        static byte loadOnOff = 0;
        decimal currentSampleTime = 0;
        List<txData> txList = new List<txData>();

        struct txData
        {
            public byte[] txPacket;
            public string message;
        }

        txData txBK8500 = new txData();

        public BK8500_Interface()
        {
            InitializeComponent();
        }

        private void BK8500_Interface_Load(object sender, EventArgs e)
        {
            comBK8500 = new SerialPort();
            rxData = new byte[26];
            TMR1.Interval = 100;
            lblTranAUnits.Text = "A";
            lblTranBUnits.Text = "A";
            tmrParse.Start();
            
        }

        //****************************************************************************************************
        //                                     TX PACKET BUILDERS
        //****************************************************************************************************

        //Transient Value Update Packet Builder
        //****************************************************************************************************
        //takes the values from the transient tab and formats them for transmit
        private void txPacketBuilder(byte address, byte command, decimal valA, decimal timA, decimal valB, decimal timB, byte tranOp, int multiplier)
        {
            byte[] txTempPacket = new byte[26];
            int txTotal = new int();
            txTempPacket[0] = 0xAA;
            txTempPacket[1] = address;
            txTempPacket[2] = command;
            uint tempValA = (uint)(valA * multiplier);
            byte[] tempValABytes = BitConverter.GetBytes(tempValA);
            txTempPacket[3] = tempValABytes[0];
            txTempPacket[4] = tempValABytes[1];
            txTempPacket[5] = tempValABytes[2];
            txTempPacket[6] = tempValABytes[3];
            ushort tempTimA = (ushort)(timA * 10);
            byte[] tempTimABytes = BitConverter.GetBytes(tempTimA);
            txTempPacket[7] = tempTimABytes[0];
            txTempPacket[8] = tempTimABytes[1];
            uint tempValB = (uint)(valB * multiplier);
            byte[] tempValBBytes = BitConverter.GetBytes(tempValB);
            txTempPacket[9] = tempValBBytes[0];
            txTempPacket[10] = tempValBBytes[1];
            txTempPacket[11] = tempValBBytes[2];
            txTempPacket[12] = tempValBBytes[3];
            ushort tempTimB = (ushort)(timB * 10);
            byte[] tempTimBBytes = BitConverter.GetBytes(tempTimB);
            txTempPacket[13] = tempTimBBytes[0];
            txTempPacket[14] = tempTimBBytes[1];
            txTempPacket[15] = tranOp;
            //Checksum 
            for (int i = 0; i < 25; i++)
            {
                txTotal = txTotal + txTempPacket[i];
            }
            txTempPacket[25] = (byte)txTotal;
            txBK8500.txPacket = txTempPacket;
        }

        //Single Byte Param Packet Builder
        //****************************************************************************************************
        //takes a command and a single param and formats it for transmit. Also supports commands without
        //params by entering in "0x00" for the param (used for many commands)
        private void txPacketBuilder(byte address, byte command, byte param)
        {
            byte[] txTempPacket = new byte[26];
            int txTotal = new int();
            txTempPacket[0] = 0xAA;
            txTempPacket[1] = address;
            txTempPacket[2] = command;
            txTempPacket[3] = param;
            for (int i = 0; i < 25; i++)
            {
                txTotal = txTotal + txTempPacket[i];
            }
            txTempPacket[25] = (byte)txTotal;
            txBK8500.txPacket = txTempPacket;
        }

        //Single Integer param Packet Builder
        //****************************************************************************************************
        //takes a command and a single integer param and formats it for transmit. (used for manual value update)
        private void txPacketBuilder(byte address, byte command, decimal val, int multiplier)
        {
            byte[] txTempPacket = new byte[26];
            int txTotal = new int();
            txTempPacket[0] = 0xAA;
            txTempPacket[1] = address;
            txTempPacket[2] = command;
            uint tempVal = (uint)(val * multiplier);
            byte[] tempValBytes = BitConverter.GetBytes(tempVal);
            txTempPacket[3] = tempValBytes[0];
            txTempPacket[4] = tempValBytes[1];
            txTempPacket[5] = tempValBytes[2];
            txTempPacket[6] = tempValBytes[3];
            for (int i = 0; i < 25; i++)
            {
                txTotal = txTotal + txTempPacket[i];
            }
            txTempPacket[25] = (byte)txTotal;
            txBK8500.txPacket = txTempPacket;
        }

        //Single Short param Packet Builder
        //****************************************************************************************************
        //takes a command and a single short param and formats it for transmit. (used for list steps update)
        private void txPacketBuilder(byte address, byte command, int step)
        {
            byte[] txTempPacket = new byte[26];
            int txTotal = new int();
            txTempPacket[0] = 0xAA;
            txTempPacket[1] = address;
            txTempPacket[2] = command;
            ushort tempStep = (ushort)(step);
            byte[] tempStepBytes = BitConverter.GetBytes(tempStep);
            txTempPacket[3] = tempStepBytes[0];
            txTempPacket[4] = tempStepBytes[1];
            for (int i = 0; i < 25; i++)
            {
                txTotal = txTotal + txTempPacket[i];
            }
            txTempPacket[25] = (byte)txTotal;
            txBK8500.txPacket = txTempPacket;
        }

        //List step Packet Builder
        //****************************************************************************************************
        //takes the values entered in for a single list step and formats them for transmit. 
        private void txPacketBuilder(byte address, byte command, int step, decimal time, decimal val, int multiplier)
        {
            byte[] txTempPacket = new byte[26];
            int txTotal = new int();
            txTempPacket[0] = 0xAA;
            txTempPacket[1] = address;
            txTempPacket[2] = command;
            ushort tempStep = (ushort)(step);
            byte[] tempStepBytes = BitConverter.GetBytes(tempStep);
            txTempPacket[3] = tempStepBytes[0];
            txTempPacket[4] = tempStepBytes[1];
            uint tempVal = (uint)(val * multiplier);
            byte[] tempValBytes = BitConverter.GetBytes(tempVal);
            txTempPacket[5] = tempValBytes[0];
            txTempPacket[6] = tempValBytes[1];
            txTempPacket[7] = tempValBytes[2];
            txTempPacket[8] = tempValBytes[3];
            ushort tempTime = (ushort)(time * 10);
            byte[] tempTimeBytes = BitConverter.GetBytes(tempTime);
            txTempPacket[9] = tempTimeBytes[0];
            txTempPacket[10] = tempTimeBytes[1];
            for (int i = 0; i < 25; i++)
            {
                txTotal = txTotal + txTempPacket[i];
            }
            txTempPacket[25] = (byte)txTotal;
            txBK8500.txPacket = txTempPacket;
        }

        //Keeps the log from racking up too much memory during long periods of operation
        private void LogOverflowCheck()
        {
            //limits the log size to 100 lines
            if (lbLog.Items.Count >= 100)
            {
                lbLog.Items.RemoveAt(99);
            }
        }

        //Toggles remote sensing on and off depending on user input
        private void chbRemoteSensing_CheckedChanged(object sender, EventArgs e)
        {
            if (comBK8500.IsOpen)
            {
                if (chbRemoteSensing.Checked)
                {
                    //remote sensing on command
                    txBK8500 = new txData();
                    txBK8500.message = string.Format("Remote Sense: {0}", chbRemoteSensing.Checked);
                    txPacketBuilder((byte)nudAddress.Value, 0x56, 0x01); //0x56 = remote sense command, 0x01 = on
                    txList.Add(txBK8500);
                }
                else
                {
                    //remote sensing off command
                    txBK8500 = new txData();
                    txBK8500.message = string.Format("Remote Sense: {0}", chbRemoteSensing.Checked);
                    txPacketBuilder((byte)nudAddress.Value, 0x56, 0x00); //0x56 = remote sense command, 0x00 = off
                    txList.Add(txBK8500);
                }
            }
            else
            {
                lbLog.Items.Insert(0, "Connection: No com port registered.");
                LogOverflowCheck();
            }
        }

        //Test Button!!!!
        private void btnTest_Click(object sender, EventArgs e)
        {
            txBK8500 = new txData();
            txBK8500.message = "List File Select: 1";
            txPacketBuilder((byte)nudAddress.Value, 0x4C, 0x01);
            txList.Add(txBK8500);
            
        }

        //****************************************************************************************************
        //                                     COM PORT BLOCK
        //****************************************************************************************************
        private void btnRefreshCOM_Click(object sender, EventArgs e)
        {
            cboCOMPort.Items.Clear(); //clears the combo box 
            foreach (string name in SerialPort.GetPortNames()) //adds an item to the combo box for each com port in use
            {
                cboCOMPort.Items.Add(name);
            }
            if (cboCOMPort.Items.Count > 0)  //auto selects the first item if there are items in the combo box
            {
                cboCOMPort.SelectedIndex = 0;
            }
        }

        private void btnOpenCOM_Click(object sender, EventArgs e)
        {
            // Open MODEM => PIC Serial Port
            if (cboCOMPort.SelectedItem != null) //if there is a com port selected in the combo box, open it
            {
                comBK8500.PortName = cboCOMPort.SelectedItem.ToString();
                comBK8500.BaudRate = 9600;
                comBK8500.Parity = Parity.None;
                comBK8500.StopBits = StopBits.One;
                comBK8500.DataBits = 8;
                comBK8500.Handshake = Handshake.None;
                comBK8500.RtsEnable = true;
                comBK8500.DtrEnable = true;
                comBK8500.ReceivedBytesThreshold = 26;
                comBK8500.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                
                try
                {
                    comBK8500.Open(); //opens the com port for use

                    if (comBK8500.IsOpen) //if the port was opened successfully
                    {
                        cboCOMPort.Enabled = false;
                        btnRefreshCOM.Enabled = false;
                        btnOpenCOM.Enabled = false;
                        btnCloseCOM.Enabled = true;

                        //enable remote communication with the Load box
                        txBK8500 = new txData();
                        txBK8500.message = "Remote Connection Enable";
                        txPacketBuilder((byte)nudAddress.Value, 0x20, 0x01); //0x20 = Remote communication command, 0x01 = on
                        txList.Add(txBK8500);

                        //enable software triggering
                        txBK8500 = new txData();
                        txBK8500.message = "Software Trigger Enable";
                        txPacketBuilder((byte)nudAddress.Value, 0x58, 0x02); //0x58 = Set Trigger source command, 0x02 = trigger from serial com
                        txList.Add(txBK8500);
                        
                    }
                    else
                    {
                        lbLog.Items.Insert(0, "Failed to open port " + comBK8500.PortName);
                        LogOverflowCheck();
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    //if the port is already in use
                    lbLog.Items.Insert(0, "Failed to open port. " + comBK8500.PortName + " appears to be opened in another application!");
                    LogOverflowCheck();
                    return;
                }
            }
            else
            {
                lbLog.Items.Insert(0, "Connection: No com port selected.");
                LogOverflowCheck();
            }
        }

        private void btnCloseCOM_Click(object sender, EventArgs e)
        {
            //releases the com port for use elsewere
            if (comBK8500.IsOpen)
            {
                comBK8500.Close();
                cboCOMPort.Enabled = true;
                btnOpenCOM.Enabled = true;
                btnRefreshCOM.Enabled = true;
                btnCloseCOM.Enabled = false;
            }
        }

        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            //received threshold is set to 26 bytes during port opening operations
            SerialPort sp = (SerialPort)sender;
            if (sp.BytesToRead == 26)
            {
                //data should be structured in 26 byte packets 
                //first byte is always 0xAA
                //last byte is always a checksum
                sp.Read(rxData, 0, sp.BytesToRead);
                byte rxTotal = 0;
                for (byte i = 0; i < 25; i++)
                {
                    rxTotal = (byte)(rxTotal + rxData[i]);
                }
                if ((rxData[25] == rxTotal) && (rxData[0] == 0xAA))//verifies the first and last bytes are correct before declaring that data has been received
                {
                    rxFlag = 1;
                }
                else
                {
                    rxFlag = 0;
                }
            }
            else
            {
                sp.DiscardInBuffer();// if, for some odd reason, there is not 26 bytes, discard the data
            }
            return;
        }
       
        //************************************************************************************************
        //                                      MODE SELECTION BOX
        //************************************************************************************************

        private void rdoConstantAmps_CheckedChanged(object sender, EventArgs e)
        {
            //updates the nudManualValue element to units and limits for Current
            if (rdoConstantAmps.Checked)
            {
                constantMode = 0x00;
                rdoConstantVoltage.Checked = false;
                rdoConstantPower.Checked = false;
                rdoConstantResistance.Checked = false;

                nudManualValue.Value = 1;
                nudManualValue.Increment = .001M;
                nudManualValue.DecimalPlaces = 3;
                nudManualValue.Maximum = 30;
                nudManualValue.Minimum = .001M;
                lblManualUnits.Text = "Current (A)";
                tbarManualValue.Value = 1000;
                tbarManualValue.Maximum = 30000;
                tbarManualValue.Minimum = 1;
                tbarManualValue.TickFrequency = 3000;


                nudTranAValue.Value = 1;
                nudTranAValue.Increment = .001M;
                nudTranAValue.DecimalPlaces = 3;
                nudTranAValue.Maximum = 30;
                nudTranAValue.Minimum = .001M;
                lblTranAUnits.Text = "A";
                nudTranBValue.Value = 1;
                nudTranBValue.Increment = .001M;
                nudTranBValue.DecimalPlaces = 3;
                nudTranBValue.Maximum = 30;
                nudTranBValue.Minimum = .001M;
                lblTranBUnits.Text = "A";               
            }
        }

        private void rdoConstantVoltage_CheckedChanged(object sender, EventArgs e)
        {
            //updates the nudManualValue element to units and limits for Voltage
            if (rdoConstantVoltage.Checked)
            {
                constantMode = 0x01;
                rdoConstantAmps.Checked = false;
                rdoConstantPower.Checked = false;
                rdoConstantResistance.Checked = false;

                nudManualValue.Value = 1;
                nudManualValue.Increment = .01M;
                nudManualValue.DecimalPlaces = 2;
                nudManualValue.Maximum = 120;
                nudManualValue.Minimum = .01M;
                lblManualUnits.Text = "Voltage (V)";
                tbarManualValue.Value = 100;
                tbarManualValue.Maximum = 12000;
                tbarManualValue.Minimum = 1;
                tbarManualValue.TickFrequency = 1000;

                nudTranAValue.Value = 1;
                nudTranAValue.Increment = .01M;
                nudTranAValue.DecimalPlaces = 2;
                nudTranAValue.Maximum = 120;
                nudTranAValue.Minimum = .01M;
                lblTranAUnits.Text = "V";
                nudTranBValue.Value = 1;
                nudTranBValue.Increment = .01M;
                nudTranBValue.DecimalPlaces = 2;
                nudTranBValue.Maximum = 120;
                nudTranBValue.Minimum = .01M;
                lblTranBUnits.Text = "V";
            }
        }

        private void rdoConstantPower_CheckedChanged(object sender, EventArgs e)
        {
            //updates the nudManualValue element to units and limits for Power
            if (rdoConstantPower.Checked)
            {
                constantMode = 0x02;
                rdoConstantAmps.Checked = false;
                rdoConstantVoltage.Checked = false;
                rdoConstantResistance.Checked = false;

                nudManualValue.Value = 1;
                nudManualValue.Increment = .001M;
                nudManualValue.DecimalPlaces = 3;
                nudManualValue.Maximum = 300;
                nudManualValue.Minimum = .001M;
                lblManualUnits.Text = "Power (W)";
                tbarManualValue.Value = 1000;
                tbarManualValue.Maximum = 300000;
                tbarManualValue.Minimum = 1;
                tbarManualValue.TickFrequency = 30000;

                nudTranAValue.Value = 1;
                nudTranAValue.Increment = .001M;
                nudTranAValue.DecimalPlaces = 3;
                nudTranAValue.Maximum = 300;
                nudTranAValue.Minimum = .001M;
                lblTranAUnits.Text = "W";
                nudTranBValue.Value = 1;
                nudTranBValue.Increment = .001M;
                nudTranBValue.DecimalPlaces = 3;
                nudTranBValue.Maximum = 300;
                nudTranBValue.Minimum = .001M;
                lblTranBUnits.Text = "W";
            }
        }

        private void rdoConstantResistance_CheckedChanged(object sender, EventArgs e)
        {
            //updates the nudManualValue element to units and limits for Resistance
            if (rdoConstantResistance.Checked)
            {
                constantMode = 0x03;
                rdoConstantAmps.Checked = false;
                rdoConstantVoltage.Checked = false;
                rdoConstantPower.Checked = false;

                nudManualValue.Value = 1;
                nudManualValue.Increment = 1;
                nudManualValue.DecimalPlaces = 0;
                nudManualValue.Maximum = 4000;
                nudManualValue.Minimum = 1;
                lblManualUnits.Text = "Resistance (Ohm)";
                tbarManualValue.Value = 1;
                tbarManualValue.Maximum = 4000;
                tbarManualValue.Minimum = 1;
                tbarManualValue.TickFrequency = 400;

                nudTranAValue.Value = 1;
                nudTranAValue.Increment = 1;
                nudTranAValue.DecimalPlaces = 0;
                nudTranAValue.Maximum = 4000;
                nudTranAValue.Minimum = 1;
                lblTranAUnits.Text = "Ohm";
                nudTranBValue.Value = 1;
                nudTranBValue.Increment = 1;
                nudTranBValue.DecimalPlaces = 0;
                nudTranBValue.Maximum = 4000;
                nudTranBValue.Minimum = 1;
                lblTranBUnits.Text = "Ohm";
            }
        }
        //************************************************************************************************
        //                                      GRAPH CONTROL
        //************************************************************************************************

        private void chbPlotAmps_CheckedChanged(object sender, EventArgs e)
        {
            //turns the graph of the Current on and off (if it is off, it is still being logged just not displayed)
            if (chbPlotAmps.Checked == true)
            {
                chtManualReadValues.Series["Current (A)"].Enabled = true;
            }
            else
            {
                chtManualReadValues.Series["Current (A)"].Enabled = false;
            }
        }

        private void chbPlotVoltage_CheckedChanged(object sender, EventArgs e)
        {
            //turns the graph of the Voltage on and off (if it is off, it is still being logged just not displayed)
            if (chbPlotVoltage.Checked == true)
            {
                chtManualReadValues.Series["Voltage (V)"].Enabled = true;
            }
            else
            {
                chtManualReadValues.Series["Voltage (V)"].Enabled = false;
            }
        }

        private void chbPlotPower_CheckedChanged(object sender, EventArgs e)
        {
            //turns the graph of the Power on and off (if it is off, it is still being logged just not displayed)
            if (chbPlotPower.Checked == true)
            {
                chtManualReadValues.Series["Power (W)"].Enabled = true;
            }
            else
            {
                chtManualReadValues.Series["Power (W)"].Enabled = false;
            }
        }

        private void btnStartReading_Click(object sender, EventArgs e)
        {
            //Starts logging data on the graph
            if (comBK8500.IsOpen)
            {
                btnStartReading.Enabled = false;
                btnStopReading.Enabled = true;
                TMR1.Start(); //Starts the TMR that sends periodic read data commands to the load
            }
            else
            {
                lbLog.Items.Insert(0, "Connection: No com port registered.");
                LogOverflowCheck();
            }
        }

        private void btnStopReading_Click(object sender, EventArgs e)
        {
            //Stops logging data on the graph
            btnStartReading.Enabled = true;
            btnStopReading.Enabled = false;
            TMR1.Stop(); //Stops the TMR that sends periodic read data commands to the load
        }

        private void btnClearChart_Click(object sender, EventArgs e)
        {
            //discards all the logged data and resets the graph 
            chtManualReadValues.Series["Current (A)"].Points.Clear();
            chtManualReadValues.Series["Voltage (V)"].Points.Clear();
            chtManualReadValues.Series["Power (W)"].Points.Clear();
            currentSampleTime = 0; //resets the time stamp that is used for the graph
        }

        private void TMR1_Tick(object sender, EventArgs e)
        {
            //update graph with new data
            txBK8500 = new txData();
            txPacketBuilder((byte)nudAddress.Value, 0x5F, 0x00);
            txList.Add(txBK8500);
            currentSampleTime = currentSampleTime + nudSampleTime.Value;
        }

        private void btnSaveGraph_Click(object sender, EventArgs e)
        {
            //displays a save dialog box for saving the graph data
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "comma separated value file|*.csv";
            saveFileDialog1.Title = "Save Location";
            saveFileDialog1.ShowDialog();

            // builds a .csv file out of the graph data 
            string[] lines = new string[chtManualReadValues.Series["Current (A)"].Points.Count + 1];
            lines[0] = "Time (s),Current (A),Voltage (V),Watts (W)";
            for (int i = 1; i < (chtManualReadValues.Series["Current (A)"].Points.Count + 1); i++)
            {
                lines[i] = string.Format("{0},{1},{2},{3}",
                    chtManualReadValues.Series["Current (A)"].Points[i - 1].XValue,
                    chtManualReadValues.Series["Current (A)"].Points[i - 1].YValues[0],
                    chtManualReadValues.Series["Voltage (V)"].Points[i - 1].YValues[0],
                    chtManualReadValues.Series["Power (W)"].Points[i - 1].YValues[0]);
            }
            using (StreamWriter outputFile = new StreamWriter(saveFileDialog1.FileName))
            {
                foreach (string element in lines)
                    outputFile.WriteLine(element);
            }
        }


        //************************************************************************************************
        //                                      MANUAL TAB
        //************************************************************************************************

        private void nudManualValue_ValueChanged(object sender, EventArgs e)
        {
            //syncs the value of the tbar to the value of the nud
            if (rdoConstantAmps.Checked)
            {
                tbarManualValue.Value = (int)(nudManualValue.Value * 1000);
            }
            if (rdoConstantVoltage.Checked)
            {
                tbarManualValue.Value = (int)(nudManualValue.Value * 100);
            }
            if (rdoConstantPower.Checked)
            {
                tbarManualValue.Value = (int)(nudManualValue.Value * 1000);
            }
            if (rdoConstantResistance.Checked)
            {
                tbarManualValue.Value = (int)nudManualValue.Value;
            }
        }

        private void tbarManualValue_Scroll(object sender, EventArgs e)
        {
            //syncs the value of the nud to the value of the tbar
            if (rdoConstantAmps.Checked)
            {
                nudManualValue.Value = (decimal)tbarManualValue.Value / 1000;
            }
            if (rdoConstantVoltage.Checked)
            {
                nudManualValue.Value = (decimal)tbarManualValue.Value / 100;
            }
            if (rdoConstantPower.Checked)
            {
                nudManualValue.Value = (decimal)tbarManualValue.Value / 1000;
            }
            if (rdoConstantResistance.Checked)
            {
                nudManualValue.Value = (decimal)tbarManualValue.Value;
            }
        }

        private void btnManualUpdate_Click(object sender, EventArgs e)
        {
            if (comBK8500.IsOpen)
            {
                operatingMode = 0x00; //fixed operating mode

                //sets operating mode for Manual use
                txBK8500 = new txData();
                txBK8500.message = string.Format("Operating Mode Update: {0}", operatingMode);
                txPacketBuilder((byte)nudAddress.Value, 0x5D, operatingMode); //0x5D = Set Operating Mode Command
                txList.Add(txBK8500);

                //sets the unit to be held constant
                txBK8500 = new txData();
                txBK8500.message = string.Format("Constant Unit Update: {0}", constantMode);
                txPacketBuilder((byte)nudAddress.Value, 0x28, constantMode); //0x28 = Set Constant Unit Mode Command
                txList.Add(txBK8500);

                //sets the value to be held constant depending on the units
                txBK8500 = new txData();
                txBK8500.message = string.Format("Manual Value Update: {0}", nudManualValue.Value);
                switch (constantMode)
                {
                    case 0x00:
                        txPacketBuilder((byte)nudAddress.Value, 0x2A, nudManualValue.Value, 10000); //0x2A = Set Constant Current Value Command, 10000 = format scaling factor
                        break;
                    case 0x01:
                        txPacketBuilder((byte)nudAddress.Value, 0x2C, nudManualValue.Value, 1000); //0x2C = Set Constant Voltage Value Command, 1000 = format scaling factor
                        break;
                    case 0x02:
                        txPacketBuilder((byte)nudAddress.Value, 0x2E, nudManualValue.Value, 1000); //0x2E = Set Constant Power Value Command, 1000 = format scaling factor
                        break;
                    case 0x03:
                        txPacketBuilder((byte)nudAddress.Value, 0x30, nudManualValue.Value, 1000); //0x30 = Set Constant Resistance Value Command, 1000 = format scaling factor
                        break;
                    default:
                        break;
                }
                txList.Add(txBK8500);
            }
            else
            {
                lbLog.Items.Insert(0, "Connection: No com port registered.");
                LogOverflowCheck();
            }
        }

        private void nudSampleTime_ValueChanged(object sender, EventArgs e)
        {
            //updates the TMR interval based on the sample time
            TMR1.Interval = (int)(nudSampleTime.Value * 1000);
        }

        private void btnLoadTurnOn_Click(object sender, EventArgs e)
        {
            if (comBK8500.IsOpen)
            {
                if (loadOnOff == 0x00)
                {
                    loadOnOff = 0x01; //turns the load on
                }
                else
                {
                    loadOnOff = 0x00; //turns the load off
                }

                //toggles the Load on or off
                txBK8500 = new txData();
                txBK8500.message = string.Format("Load Enable = {0}", loadOnOff);
                txPacketBuilder((byte)nudAddress.Value, 0x21, loadOnOff); //0x21 = Set Load on/off state command
                txList.Add(txBK8500);
            }
            else
            {
                lbLog.Items.Insert(0, "Connection: No com port registered.");
                LogOverflowCheck();
            }
        }

        //************************************************************************************************
        //                                      TRANSIENT TAB
        //************************************************************************************************

        private void rdoTranContinuous_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTranContinuous.Checked)
            {
                tranOperation = 0x00; //continuous timed switching mode
                rdoTranPulse.Checked = false;
                rdoTranToggle.Checked = false;
                nudTranATime.Enabled = true;
                nudTranBTime.Enabled = true;
            }
        }

        private void rdoTranPulse_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTranPulse.Checked)
            {
                tranOperation = 0x01; //triggered pulse mode
                rdoTranContinuous.Checked = false;
                rdoTranToggle.Checked = false;
                nudTranATime.Enabled = false;
                nudTranBTime.Enabled = true;
            }
        }

        private void rdoTranToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTranToggle.Checked)
            {
                tranOperation = 0x02; //triggered toggle mode
                rdoTranContinuous.Checked = false;
                rdoTranPulse.Checked = false;
                nudTranATime.Enabled = false;
                nudTranBTime.Enabled = false;
            }
        }

        private void btnTranTrigger_Click(object sender, EventArgs e)
        {
            if (comBK8500.IsOpen)
            {
                //trigger the device
                txBK8500 = new txData();
                txBK8500.message = "Trigger Device";
                txPacketBuilder((byte)nudAddress.Value, 0x5A, 0x00); //0x5A = device trigger command, 0x00 = empty param (no param needed)
                txList.Add(txBK8500);
            }
            else
            {
                lbLog.Items.Insert(0, "Connection: No com port registered.");
                LogOverflowCheck();
            }
        }

        private void btnUpdateTran_Click(object sender, EventArgs e)
        {
            if (comBK8500.IsOpen)
            {
                operatingMode = 0x00; //Transient operation mode

                //update the operation mode
                txBK8500 = new txData();
                txBK8500.message = string.Format("Operating Mode Update: {0}", operatingMode);
                txPacketBuilder((byte)nudAddress.Value, 0x5D, operatingMode); //0x5D = set operating mode command
                txList.Add(txBK8500);

                //update the constant unit mode
                txBK8500 = new txData();
                txBK8500.message = string.Format("Constant Unit Update: {0}", constantMode);
                txPacketBuilder((byte)nudAddress.Value, 0x28, constantMode); //0x28 = set constant unit mode command
                txList.Add(txBK8500);

                //update the transient values
                txBK8500 = new txData();
                txBK8500.message = string.Format("Transiant Settings Update: ValA = {0} TimeA = {1} ValB = {2} TimeB = {3}",
                    nudTranAValue.Value, nudTranATime.Value, nudTranBValue.Value, nudTranBTime.Value);
                switch (constantMode)
                {
                    case 0x00:
                        //transiant Constant current mode
                        txPacketBuilder((byte)nudAddress.Value, 0x32, nudTranAValue.Value, nudTranATime.Value, nudTranBValue.Value, nudTranBTime.Value, tranOperation, 10000);
                        //0x32 = set Constant Current mode values command
                        break;
                    case 0x01:
                        //Transiant Constant Voltage mode
                        txPacketBuilder((byte)nudAddress.Value, 0x34, nudTranAValue.Value, nudTranATime.Value, nudTranBValue.Value, nudTranBTime.Value, tranOperation, 1000);
                        //0x34 = set Constant Voltage mode values command
                        break;
                    case 0x02:
                        //Transiant Constant wattage mode
                        txPacketBuilder((byte)nudAddress.Value, 0x36, nudTranAValue.Value, nudTranATime.Value, nudTranBValue.Value, nudTranBTime.Value, tranOperation, 1000);
                        //0x36 = set Constant Power mode values command
                        break;
                    case 0x03:
                        //Transiant Constant Resistance mode
                        txPacketBuilder((byte)nudAddress.Value, 0x38, nudTranAValue.Value, nudTranATime.Value, nudTranBValue.Value, nudTranBTime.Value, tranOperation, 1000);
                        //0x38 = set Constant Resistance mode values command
                        break;
                    default:
                        break;
                }
                txList.Add(txBK8500);
            }
            else
            {
                lbLog.Items.Insert(0, "Connection: No com port registered.");
                LogOverflowCheck();
            }
        }

        private void btnEnableTrans_Click(object sender, EventArgs e)
        {
            if (operatingMode == 0x00)
            {
                operatingMode = 0x02; //transient operation mode

                //update the operating mode
                txBK8500 = new txData();
                txBK8500.message = string.Format("Operating Mode Update: {0}", operatingMode);
                txPacketBuilder((byte)nudAddress.Value, 0x5D, operatingMode); //0x5D = set operating mode command
                txList.Add(txBK8500);
            }
            else
            {
                operatingMode = 0x00; //fixed operating mode

                //update the operating mode
                txBK8500 = new txData();
                txBK8500.message = string.Format("Operating Mode Update: {0}", operatingMode);
                txPacketBuilder((byte)nudAddress.Value, 0x5D, operatingMode); //0x5D = set operating mode command
                txList.Add(txBK8500);
            }
        }

        //************************************************************************************************
        //                                      LIST TAB
        //************************************************************************************************

        private void btnUpdateList_Click(object sender, EventArgs e)
        {
            if (comBK8500.IsOpen)
            {
                //updates the memory partition for the Load Box
                txBK8500 = new txData();
                txBK8500.message = "List Memory Usage Update";
                txPacketBuilder((byte)nudAddress.Value, 0x4A, 0x01); //0x4A = Set Memory partition command, 0x01 = 1 list of 1000 commands
                txList.Add(txBK8500);

                //updates the list constant unit mode
                txBK8500 = new txData();
                txBK8500.message = string.Format("List Constant Unit Update: {0}", constantMode);
                txPacketBuilder((byte)nudAddress.Value, 0x3A, constantMode); //0x3A = Sets the constant unit mode for list operations
                txList.Add(txBK8500);
                
                //updates whether the list is repeated after running all the steps
                txBK8500 = new txData();
                txBK8500.message = string.Format("List Repeat: {0}", chbListRepeat.Checked);
                if (chbListRepeat.Checked)
                {
                    txPacketBuilder((byte)nudAddress.Value, 0x3C, 0x01); //0x3C = set List repeat mode command, 0x01 = list repeats
                }
                else
                {
                    txPacketBuilder((byte)nudAddress.Value, 0x3C, 0x00); //0x3C = set List repeat mode command, 0x00 = list does not repeats
                }
                txList.Add(txBK8500);

                //updates the number of steps being used by the list
                txBK8500 = new txData();
                txBK8500.message = string.Format("List Step #: {0}",dgvList.RowCount-1);               
                txPacketBuilder((byte)nudAddress.Value, 0x3E, dgvList.RowCount-1); //0x3E = set # of List Steps command
                txList.Add(txBK8500);
                                
                for (int step = 0; step < dgvList.RowCount-1; step++)
                {
                    //sets the values of a list step
                    txBK8500 = new txData();
                    txBK8500.message = string.Format("List Step: Step:{0} Time:{1} Value:{2}", step + 1, Convert.ToDecimal(dgvList.Rows[step].Cells["Time"].Value), Convert.ToDecimal(dgvList.Rows[step].Cells["Value"].Value));
                    switch (constantMode)
                    {
                        case 0x00:
                            txPacketBuilder((byte)nudAddress.Value, 0x40, step+1, Convert.ToDecimal(dgvList.Rows[step].Cells["Time"].Value), Convert.ToDecimal(dgvList.Rows[step].Cells["Value"].Value), 10000);
                            //0x40 = set constant current step values command, 10000 = formating scale factor 
                            break;
                        case 0x01:
                            txPacketBuilder((byte)nudAddress.Value, 0x42, step+1, Convert.ToDecimal(dgvList.Rows[step].Cells["Time"].Value), Convert.ToDecimal(dgvList.Rows[step].Cells["Value"].Value), 1000);
                            //0x42 = set constant voltage step values command, 1000 = formating scale factor 
                            break;
                        case 0x02:
                            txPacketBuilder((byte)nudAddress.Value, 0x44, step+1, Convert.ToDecimal(dgvList.Rows[step].Cells["Time"].Value), Convert.ToDecimal(dgvList.Rows[step].Cells["Value"].Value), 1000);
                            //0x44 = set constant power step values command, 1000 = formating scale factor 
                            break;
                        case 0x03:
                            txPacketBuilder((byte)nudAddress.Value, 0x46, step+1, Convert.ToDecimal(dgvList.Rows[step].Cells["Time"].Value), Convert.ToDecimal(dgvList.Rows[step].Cells["Value"].Value), 1000);
                            //0x46 = set constant resistance step values command, 1000 = formating scale factor 
                            break;
                        default:                    
                            break;
                    }
                    txList.Add(txBK8500);
                }

                //saves all the settings to a list file 
                txBK8500 = new txData();
                txBK8500.message = "List File Select: 1";
                txPacketBuilder((byte)nudAddress.Value, 0x4C, 0x01); //0x4C = save list file command, 0x01 = memory location to save list to
                txList.Add(txBK8500);
            }
            else
            {
                lbLog.Items.Insert(0, "Connection: No com port registered.");
                LogOverflowCheck();
            }
        }

        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            //for testing purposes
            lblTest.Text = string.Format("Row = {0} Column = {1}", dgvList.SelectedCells[0].RowIndex, dgvList.SelectedCells[0].ColumnIndex);
        }

        private void btnEnableList_Click(object sender, EventArgs e)
        {
            //toggles the list operating mode
            if (operatingMode == 0x00)
            {
                operatingMode = 0x03; //List Operating Mode

                //updates the operating Mode
                txBK8500 = new txData();
                txBK8500.message = string.Format("Operating Mode Update: {0}", operatingMode);
                txPacketBuilder((byte)nudAddress.Value, 0x5D, operatingMode); //0x5D = set operating mode command
                txList.Add(txBK8500);
            }
            else
            {
                operatingMode = 0x00; //Fixed Operating Mode

                //updates the operating Mode
                txBK8500 = new txData();
                txBK8500.message = string.Format("Operating Mode Update: {0}", operatingMode);
                txPacketBuilder((byte)nudAddress.Value, 0x5D, operatingMode); //0x5D = set operating mode command
                txList.Add(txBK8500);
            }
        }

        private void btnStartList_Click(object sender, EventArgs e)
        {
            // Triggers the device to start the list 
            if (comBK8500.IsOpen)
            {
                //Triggers the device
                txBK8500 = new txData();
                txBK8500.message = "Trigger Device";
                txPacketBuilder((byte)nudAddress.Value, 0x5A, 0x00); //0x5A = Trigger device command, 0x00 =  empty param (command has no params)
                txList.Add(txBK8500);
            }
            else
            {
                lbLog.Items.Insert(0, "Connection: No com port registered.");
                LogOverflowCheck();
            }
        }

        

        //************************************************************************************************
        //                                      MAX ALLOWANCE GROUP
        //************************************************************************************************

        private void btnMaxValueUpdate_Click(object sender, EventArgs e)
        {
            if (comBK8500.IsOpen)
            {
                //Sets Max Current Draw 
                txBK8500 = new txData();
                txBK8500.message = string.Format("Max Current Update: {0}", nudMaxAmps.Value);
                txPacketBuilder((byte)nudAddress.Value, 0x24, nudMaxAmps.Value, 10000); //0x24 = Set max Current command, 10000 = formating scale factor
                txList.Add(txBK8500);

                txBK8500 = new txData();
                txBK8500.message = string.Format("Max Voltage Update: {0}", nudMaxVoltage.Value);
                txPacketBuilder((byte)nudAddress.Value, 0x22, nudMaxVoltage.Value, 1000); //0x22 = Set max voltage command, 1000 = formating scale factor
                txList.Add(txBK8500);

                txBK8500 = new txData();
                txBK8500.message = string.Format("Max Power Update: {0}", nudMaxWatts.Value);
                txPacketBuilder((byte)nudAddress.Value, 0x26, nudMaxWatts.Value, 1000); //0x26 = Set max Power command, 1000 = formating scale factor
                txList.Add(txBK8500);
            }
            else
            {
                lbLog.Items.Insert(0, "Connection: No com port registered.");
                LogOverflowCheck();
            }
        }

        //************************************************************************************************
        //                                      TX RX PARSING
        //************************************************************************************************

        private void tmrParse_Tick(object sender, EventArgs e)
        {
            if (comTimeout <= 1000) //no response timeout (timeout is in units of 10ms)
            {
                //if the program has not sent data recently and has not received data recently, send the next TX in line
                if ((txSent == 0) && (rxFlag == 0))
                {
                    if (txList.Count != 0)
                    {
                        //writes the tx packet's accompanied message to the log if there is one
                        if (txList[0].message != null)
                        {
                            lbLog.Items.Insert(0, txList[0].message);
                        }

                        //checks tx packet for appropriate length then sends it
                        if (txList[0].txPacket.Length == 26)
                        {
                            comBK8500.Write(txList[0].txPacket, 0, 26); //sends the tx packet
                            txList.RemoveAt(0); //removes the tx packet from the queue after sending it
                            comTimeout = 0; //restarts the timeout
                            txSent = 1; //indicates tx packet has been sent and that a reponse is iminent
                        }
                        else
                        {
                            lbLog.Items.Insert(0, string.Format("Bad Packet Lenght: {0}",txList[0].txPacket.Length));
                            txList.Clear();
                        }
                    }
                }

                //increments the timeout counter while waiting for a response
                if ((txSent == 1) && (rxFlag == 0))
                {
                    comTimeout++;
                }

                //if data is received before data is sent, toss the data
                if ((txSent == 0) && (rxFlag == 1))
                {
                    rxFlag = 0;
                }

                //When the response is received from the sent command, the data is parsed
                if ((txSent == 1) && (rxFlag == 1))
                {
                    rxFlag = 0;
                    txSent = 0;
                    switch (rxData[2])
                    {
                        case 0x12: //if the response is a status packet
                            if (rxData[3] == 0x80)
                            {
                                //success
                                lbLog.Items.Insert(0, "Success");
                                LogOverflowCheck();
                            }
                            if (rxData[3] == 0x90)
                            {
                                //bad checksum
                                lbLog.Items.Insert(0, "Failed - Bad Checksum");
                                LogOverflowCheck();
                            }
                            if (rxData[3] == 0xA0)
                            {
                                //bad parameter
                                lbLog.Items.Insert(0, "Failed - Command parameter is invalid or formatted wrong.");
                                LogOverflowCheck();
                            }
                            if (rxData[3] == 0xB0)
                            {
                                //unrecognized command
                                lbLog.Items.Insert(0, "Failed - Command not recognized.");
                                LogOverflowCheck();
                            }
                            if (rxData[3] == 0xC0)
                            {
                                //invalid command
                                lbLog.Items.Insert(0, "Failed - Recieved Command could not be carried out.");
                                LogOverflowCheck();
                            }
                            break;
                        case 0x5F: //if the response is from a read data command
                            //parse the data into integer format
                            int AmpsVal = ((int)rxData[10] << 24) + ((int)rxData[9] << 16) + ((int)rxData[8] << 8) + rxData[7];
                            int VoltageVal = ((int)rxData[6] << 24) + ((int)rxData[5] << 16) + ((int)rxData[4] << 8) + rxData[3];
                            int PowerVal = ((int)rxData[14] << 24) + ((int)rxData[13] << 16) + ((int)rxData[12] << 8) + rxData[11];

                            //add log entry for read
                            lbLog.Items.Insert(0, string.Format("Read Data: T{0}: Amps={1}, Voltage={2}, Watts={3}", currentSampleTime, AmpsVal, VoltageVal, PowerVal));
                            LogOverflowCheck();

                            //update graph with new data
                            chtManualReadValues.Series["Current (A)"].Points.AddXY(currentSampleTime, ((decimal)AmpsVal / 10000));
                            chtManualReadValues.Series["Voltage (V)"].Points.AddXY(currentSampleTime, ((decimal)VoltageVal / 1000));
                            chtManualReadValues.Series["Power (W)"].Points.AddXY(currentSampleTime, ((decimal)PowerVal / 1000));
                            break;
                        default:
                            //if the packet is not recognized, print out a chunk of the packet in the log
                            lbLog.Items.Insert(0,string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}",
                                rxData[3],rxData[4],rxData[5],rxData[6],rxData[7],rxData[8],rxData[9],rxData[10],rxData[11],
                                rxData[12],rxData[13],rxData[14],rxData[15],rxData[16]));
                            break;
                    }
                }
            }
            else
            {
                //if the timeout occurs
                txSent = 0; //reset flags
                rxFlag = 0; //reset flags
                comTimeout = 0; //reset timeout counter
                lbLog.Items.Insert(0, "Timed Out"); //log that a timeout occured
                txList.Clear(); //clear the queue of all tx Packets to preserve order of operations
                
            }
        }
    }
}
