namespace BK8500_Interface
{
    partial class BK8500_Interface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCOMPort = new System.Windows.Forms.ComboBox();
            this.btnCloseCOM = new System.Windows.Forms.Button();
            this.btnOpenCOM = new System.Windows.Forms.Button();
            this.btnRefreshCOM = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnManualUpdate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbarManualValue = new System.Windows.Forms.TrackBar();
            this.nudManualValue = new System.Windows.Forms.NumericUpDown();
            this.lblManualUnits = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEnableTrans = new System.Windows.Forms.Button();
            this.btnTranTrigger = new System.Windows.Forms.Button();
            this.btnUpdateTran = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rdoTranToggle = new System.Windows.Forms.RadioButton();
            this.rdoTranContinuous = new System.Windows.Forms.RadioButton();
            this.rdoTranPulse = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTranBS = new System.Windows.Forms.Label();
            this.lblTranAS = new System.Windows.Forms.Label();
            this.nudTranBTime = new System.Windows.Forms.NumericUpDown();
            this.nudTranATime = new System.Windows.Forms.NumericUpDown();
            this.lblTranBUnits = new System.Windows.Forms.Label();
            this.lblTranAUnits = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTranA = new System.Windows.Forms.Label();
            this.nudTranBValue = new System.Windows.Forms.NumericUpDown();
            this.nudTranAValue = new System.Windows.Forms.NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnStartList = new System.Windows.Forms.Button();
            this.chbListRepeat = new System.Windows.Forms.CheckBox();
            this.btnEnableList = new System.Windows.Forms.Button();
            this.btnUpdateList = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chbPlotPower = new System.Windows.Forms.CheckBox();
            this.chbPlotVoltage = new System.Windows.Forms.CheckBox();
            this.chbPlotAmps = new System.Windows.Forms.CheckBox();
            this.lblSampleTimeS = new System.Windows.Forms.Label();
            this.lblSampleTime = new System.Windows.Forms.Label();
            this.nudSampleTime = new System.Windows.Forms.NumericUpDown();
            this.btnLoadTurnOn = new System.Windows.Forms.Button();
            this.btnStopReading = new System.Windows.Forms.Button();
            this.btnStartReading = new System.Windows.Forms.Button();
            this.chtManualReadValues = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoConstantAmps = new System.Windows.Forms.RadioButton();
            this.rdoConstantVoltage = new System.Windows.Forms.RadioButton();
            this.rdoConstantPower = new System.Windows.Forms.RadioButton();
            this.rdoConstantResistance = new System.Windows.Forms.RadioButton();
            this.TMR1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.nudAddress = new System.Windows.Forms.NumericUpDown();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.btnClearChart = new System.Windows.Forms.Button();
            this.btnSaveGraph = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.chbRemoteSensing = new System.Windows.Forms.CheckBox();
            this.btnMaxValueUpdate = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nudMaxWatts = new System.Windows.Forms.NumericUpDown();
            this.lblMaxWatts = new System.Windows.Forms.Label();
            this.lblMaxVoltage = new System.Windows.Forms.Label();
            this.lblMaxAmps = new System.Windows.Forms.Label();
            this.nudMaxVoltage = new System.Windows.Forms.NumericUpDown();
            this.nudMaxAmps = new System.Windows.Forms.NumericUpDown();
            this.tmrParse = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarManualValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudManualValue)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTranBTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTranATime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTranBValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTranAValue)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSampleTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtManualReadValues)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddress)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxWatts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxAmps)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboCOMPort);
            this.groupBox1.Controls.Add(this.btnCloseCOM);
            this.groupBox1.Controls.Add(this.btnOpenCOM);
            this.groupBox1.Controls.Add(this.btnRefreshCOM);
            this.groupBox1.Location = new System.Drawing.Point(917, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Port";
            // 
            // cboCOMPort
            // 
            this.cboCOMPort.FormattingEnabled = true;
            this.cboCOMPort.Location = new System.Drawing.Point(6, 19);
            this.cboCOMPort.Name = "cboCOMPort";
            this.cboCOMPort.Size = new System.Drawing.Size(150, 21);
            this.cboCOMPort.TabIndex = 3;
            // 
            // btnCloseCOM
            // 
            this.btnCloseCOM.Enabled = false;
            this.btnCloseCOM.Location = new System.Drawing.Point(6, 112);
            this.btnCloseCOM.Name = "btnCloseCOM";
            this.btnCloseCOM.Size = new System.Drawing.Size(150, 27);
            this.btnCloseCOM.TabIndex = 2;
            this.btnCloseCOM.Text = "Close COM Port";
            this.btnCloseCOM.UseVisualStyleBackColor = true;
            this.btnCloseCOM.Click += new System.EventHandler(this.btnCloseCOM_Click);
            // 
            // btnOpenCOM
            // 
            this.btnOpenCOM.Location = new System.Drawing.Point(6, 79);
            this.btnOpenCOM.Name = "btnOpenCOM";
            this.btnOpenCOM.Size = new System.Drawing.Size(150, 27);
            this.btnOpenCOM.TabIndex = 1;
            this.btnOpenCOM.Text = "Open COM Port";
            this.btnOpenCOM.UseVisualStyleBackColor = true;
            this.btnOpenCOM.Click += new System.EventHandler(this.btnOpenCOM_Click);
            // 
            // btnRefreshCOM
            // 
            this.btnRefreshCOM.Location = new System.Drawing.Point(6, 46);
            this.btnRefreshCOM.Name = "btnRefreshCOM";
            this.btnRefreshCOM.Size = new System.Drawing.Size(150, 27);
            this.btnRefreshCOM.TabIndex = 0;
            this.btnRefreshCOM.Text = "Refresh";
            this.btnRefreshCOM.UseVisualStyleBackColor = true;
            this.btnRefreshCOM.Click += new System.EventHandler(this.btnRefreshCOM_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(243, 445);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnManualUpdate);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(235, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manual Control";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnManualUpdate
            // 
            this.btnManualUpdate.Location = new System.Drawing.Point(6, 386);
            this.btnManualUpdate.Name = "btnManualUpdate";
            this.btnManualUpdate.Size = new System.Drawing.Size(223, 27);
            this.btnManualUpdate.TabIndex = 22;
            this.btnManualUpdate.Text = "Update Load with Manual Values";
            this.btnManualUpdate.UseVisualStyleBackColor = true;
            this.btnManualUpdate.Click += new System.EventHandler(this.btnManualUpdate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbarManualValue);
            this.groupBox3.Controls.Add(this.nudManualValue);
            this.groupBox3.Controls.Add(this.lblManualUnits);
            this.groupBox3.Location = new System.Drawing.Point(60, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(110, 233);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Set Value";
            // 
            // tbarManualValue
            // 
            this.tbarManualValue.Location = new System.Drawing.Point(31, 68);
            this.tbarManualValue.Maximum = 30000;
            this.tbarManualValue.Minimum = 1;
            this.tbarManualValue.Name = "tbarManualValue";
            this.tbarManualValue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarManualValue.Size = new System.Drawing.Size(45, 159);
            this.tbarManualValue.TabIndex = 11;
            this.tbarManualValue.TickFrequency = 3000;
            this.tbarManualValue.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbarManualValue.Value = 1;
            this.tbarManualValue.Scroll += new System.EventHandler(this.tbarManualValue_Scroll);
            // 
            // nudManualValue
            // 
            this.nudManualValue.DecimalPlaces = 3;
            this.nudManualValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nudManualValue.Location = new System.Drawing.Point(13, 42);
            this.nudManualValue.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudManualValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nudManualValue.Name = "nudManualValue";
            this.nudManualValue.Size = new System.Drawing.Size(83, 20);
            this.nudManualValue.TabIndex = 10;
            this.nudManualValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudManualValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudManualValue.ValueChanged += new System.EventHandler(this.nudManualValue_ValueChanged);
            // 
            // lblManualUnits
            // 
            this.lblManualUnits.Location = new System.Drawing.Point(0, 16);
            this.lblManualUnits.Name = "lblManualUnits";
            this.lblManualUnits.Size = new System.Drawing.Size(111, 23);
            this.lblManualUnits.TabIndex = 6;
            this.lblManualUnits.Text = "Current (A)";
            this.lblManualUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEnableTrans);
            this.tabPage2.Controls.Add(this.btnTranTrigger);
            this.tabPage2.Controls.Add(this.btnUpdateTran);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(235, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transient Control";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEnableTrans
            // 
            this.btnEnableTrans.Location = new System.Drawing.Point(6, 324);
            this.btnEnableTrans.Name = "btnEnableTrans";
            this.btnEnableTrans.Size = new System.Drawing.Size(223, 27);
            this.btnEnableTrans.TabIndex = 28;
            this.btnEnableTrans.Text = "Enable/Disable Transient Function";
            this.btnEnableTrans.UseVisualStyleBackColor = true;
            this.btnEnableTrans.Click += new System.EventHandler(this.btnEnableTrans_Click);
            // 
            // btnTranTrigger
            // 
            this.btnTranTrigger.Location = new System.Drawing.Point(6, 357);
            this.btnTranTrigger.Name = "btnTranTrigger";
            this.btnTranTrigger.Size = new System.Drawing.Size(223, 56);
            this.btnTranTrigger.TabIndex = 4;
            this.btnTranTrigger.Text = "Trigger";
            this.btnTranTrigger.UseVisualStyleBackColor = true;
            this.btnTranTrigger.Click += new System.EventHandler(this.btnTranTrigger_Click);
            // 
            // btnUpdateTran
            // 
            this.btnUpdateTran.Location = new System.Drawing.Point(6, 291);
            this.btnUpdateTran.Name = "btnUpdateTran";
            this.btnUpdateTran.Size = new System.Drawing.Size(223, 27);
            this.btnUpdateTran.TabIndex = 3;
            this.btnUpdateTran.Text = "Update Load with Transient Settings";
            this.btnUpdateTran.UseVisualStyleBackColor = true;
            this.btnUpdateTran.Click += new System.EventHandler(this.btnUpdateTran_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rdoTranToggle);
            this.groupBox6.Controls.Add(this.rdoTranContinuous);
            this.groupBox6.Controls.Add(this.rdoTranPulse);
            this.groupBox6.Location = new System.Drawing.Point(6, 147);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(223, 89);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Transient Settings";
            // 
            // rdoTranToggle
            // 
            this.rdoTranToggle.AutoSize = true;
            this.rdoTranToggle.Location = new System.Drawing.Point(6, 65);
            this.rdoTranToggle.Name = "rdoTranToggle";
            this.rdoTranToggle.Size = new System.Drawing.Size(106, 17);
            this.rdoTranToggle.TabIndex = 5;
            this.rdoTranToggle.TabStop = true;
            this.rdoTranToggle.Text = "Triggered Toggle";
            this.rdoTranToggle.UseVisualStyleBackColor = true;
            this.rdoTranToggle.CheckedChanged += new System.EventHandler(this.rdoTranToggle_CheckedChanged);
            // 
            // rdoTranContinuous
            // 
            this.rdoTranContinuous.AutoSize = true;
            this.rdoTranContinuous.Checked = true;
            this.rdoTranContinuous.Location = new System.Drawing.Point(6, 19);
            this.rdoTranContinuous.Name = "rdoTranContinuous";
            this.rdoTranContinuous.Size = new System.Drawing.Size(78, 17);
            this.rdoTranContinuous.TabIndex = 3;
            this.rdoTranContinuous.TabStop = true;
            this.rdoTranContinuous.Text = "Continuous";
            this.rdoTranContinuous.UseVisualStyleBackColor = true;
            this.rdoTranContinuous.CheckedChanged += new System.EventHandler(this.rdoTranContinuous_CheckedChanged);
            // 
            // rdoTranPulse
            // 
            this.rdoTranPulse.AutoSize = true;
            this.rdoTranPulse.Location = new System.Drawing.Point(6, 42);
            this.rdoTranPulse.Name = "rdoTranPulse";
            this.rdoTranPulse.Size = new System.Drawing.Size(99, 17);
            this.rdoTranPulse.TabIndex = 4;
            this.rdoTranPulse.TabStop = true;
            this.rdoTranPulse.Text = "Triggered Pulse";
            this.rdoTranPulse.UseVisualStyleBackColor = true;
            this.rdoTranPulse.CheckedChanged += new System.EventHandler(this.rdoTranPulse_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblTranBS);
            this.groupBox5.Controls.Add(this.lblTranAS);
            this.groupBox5.Controls.Add(this.nudTranBTime);
            this.groupBox5.Controls.Add(this.nudTranATime);
            this.groupBox5.Controls.Add(this.lblTranBUnits);
            this.groupBox5.Controls.Add(this.lblTranAUnits);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.lblTranA);
            this.groupBox5.Controls.Add(this.nudTranBValue);
            this.groupBox5.Controls.Add(this.nudTranAValue);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(223, 135);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Set Values";
            // 
            // lblTranBS
            // 
            this.lblTranBS.AutoSize = true;
            this.lblTranBS.Location = new System.Drawing.Point(129, 105);
            this.lblTranBS.Name = "lblTranBS";
            this.lblTranBS.Size = new System.Drawing.Size(20, 13);
            this.lblTranBS.TabIndex = 9;
            this.lblTranBS.Text = "ms";
            // 
            // lblTranAS
            // 
            this.lblTranAS.AutoSize = true;
            this.lblTranAS.Location = new System.Drawing.Point(129, 53);
            this.lblTranAS.Name = "lblTranAS";
            this.lblTranAS.Size = new System.Drawing.Size(20, 13);
            this.lblTranAS.TabIndex = 8;
            this.lblTranAS.Text = "ms";
            // 
            // nudTranBTime
            // 
            this.nudTranBTime.DecimalPlaces = 1;
            this.nudTranBTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudTranBTime.Location = new System.Drawing.Point(55, 103);
            this.nudTranBTime.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.nudTranBTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudTranBTime.Name = "nudTranBTime";
            this.nudTranBTime.Size = new System.Drawing.Size(68, 20);
            this.nudTranBTime.TabIndex = 7;
            this.nudTranBTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTranBTime.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nudTranATime
            // 
            this.nudTranATime.DecimalPlaces = 1;
            this.nudTranATime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudTranATime.Location = new System.Drawing.Point(55, 51);
            this.nudTranATime.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.nudTranATime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudTranATime.Name = "nudTranATime";
            this.nudTranATime.Size = new System.Drawing.Size(68, 20);
            this.nudTranATime.TabIndex = 6;
            this.nudTranATime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTranATime.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblTranBUnits
            // 
            this.lblTranBUnits.AutoSize = true;
            this.lblTranBUnits.Location = new System.Drawing.Point(129, 79);
            this.lblTranBUnits.Name = "lblTranBUnits";
            this.lblTranBUnits.Size = new System.Drawing.Size(40, 13);
            this.lblTranBUnits.TabIndex = 5;
            this.lblTranBUnits.Text = "UNITS";
            // 
            // lblTranAUnits
            // 
            this.lblTranAUnits.AutoSize = true;
            this.lblTranAUnits.Location = new System.Drawing.Point(129, 27);
            this.lblTranAUnits.Name = "lblTranAUnits";
            this.lblTranAUnits.Size = new System.Drawing.Size(40, 13);
            this.lblTranAUnits.TabIndex = 4;
            this.lblTranAUnits.Text = "UNITS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "B Value:";
            // 
            // lblTranA
            // 
            this.lblTranA.AutoSize = true;
            this.lblTranA.Location = new System.Drawing.Point(6, 27);
            this.lblTranA.Name = "lblTranA";
            this.lblTranA.Size = new System.Drawing.Size(47, 13);
            this.lblTranA.TabIndex = 2;
            this.lblTranA.Text = "A Value:";
            // 
            // nudTranBValue
            // 
            this.nudTranBValue.DecimalPlaces = 2;
            this.nudTranBValue.Location = new System.Drawing.Point(55, 77);
            this.nudTranBValue.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudTranBValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudTranBValue.Name = "nudTranBValue";
            this.nudTranBValue.Size = new System.Drawing.Size(68, 20);
            this.nudTranBValue.TabIndex = 1;
            this.nudTranBValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTranBValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // nudTranAValue
            // 
            this.nudTranAValue.DecimalPlaces = 2;
            this.nudTranAValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudTranAValue.Location = new System.Drawing.Point(55, 25);
            this.nudTranAValue.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudTranAValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudTranAValue.Name = "nudTranAValue";
            this.nudTranAValue.Size = new System.Drawing.Size(68, 20);
            this.nudTranAValue.TabIndex = 0;
            this.nudTranAValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTranAValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnStartList);
            this.tabPage3.Controls.Add(this.chbListRepeat);
            this.tabPage3.Controls.Add(this.btnEnableList);
            this.tabPage3.Controls.Add(this.btnUpdateList);
            this.tabPage3.Controls.Add(this.dgvList);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(235, 419);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "List Control";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnStartList
            // 
            this.btnStartList.Location = new System.Drawing.Point(3, 390);
            this.btnStartList.Name = "btnStartList";
            this.btnStartList.Size = new System.Drawing.Size(229, 26);
            this.btnStartList.TabIndex = 27;
            this.btnStartList.Text = "Start List Operation";
            this.btnStartList.UseVisualStyleBackColor = true;
            this.btnStartList.Click += new System.EventHandler(this.btnStartList_Click);
            // 
            // chbListRepeat
            // 
            this.chbListRepeat.AutoSize = true;
            this.chbListRepeat.Checked = true;
            this.chbListRepeat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbListRepeat.Location = new System.Drawing.Point(8, 301);
            this.chbListRepeat.Name = "chbListRepeat";
            this.chbListRepeat.Size = new System.Drawing.Size(61, 17);
            this.chbListRepeat.TabIndex = 27;
            this.chbListRepeat.Text = "Repeat";
            this.chbListRepeat.UseVisualStyleBackColor = true;
            // 
            // btnEnableList
            // 
            this.btnEnableList.Location = new System.Drawing.Point(3, 357);
            this.btnEnableList.Name = "btnEnableList";
            this.btnEnableList.Size = new System.Drawing.Size(229, 27);
            this.btnEnableList.TabIndex = 27;
            this.btnEnableList.Text = "Enable List Mode";
            this.btnEnableList.UseVisualStyleBackColor = true;
            this.btnEnableList.Click += new System.EventHandler(this.btnEnableList_Click);
            // 
            // btnUpdateList
            // 
            this.btnUpdateList.Location = new System.Drawing.Point(3, 324);
            this.btnUpdateList.Name = "btnUpdateList";
            this.btnUpdateList.Size = new System.Drawing.Size(229, 27);
            this.btnUpdateList.TabIndex = 30;
            this.btnUpdateList.Text = "Update List Values";
            this.btnUpdateList.UseVisualStyleBackColor = true;
            this.btnUpdateList.Click += new System.EventHandler(this.btnUpdateList_Click);
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Value});
            this.dgvList.Location = new System.Drawing.Point(3, 3);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(229, 292);
            this.dgvList.TabIndex = 27;
            this.dgvList.SelectionChanged += new System.EventHandler(this.dgvList_SelectionChanged);
            // 
            // Time
            // 
            this.Time.HeaderText = "Time (ms)";
            this.Time.Name = "Time";
            this.Time.Width = 90;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.Width = 90;
            // 
            // chbPlotPower
            // 
            this.chbPlotPower.AutoSize = true;
            this.chbPlotPower.Checked = true;
            this.chbPlotPower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbPlotPower.Location = new System.Drawing.Point(561, 422);
            this.chbPlotPower.Name = "chbPlotPower";
            this.chbPlotPower.Size = new System.Drawing.Size(77, 17);
            this.chbPlotPower.TabIndex = 22;
            this.chbPlotPower.Text = "Plot Power";
            this.chbPlotPower.UseVisualStyleBackColor = true;
            this.chbPlotPower.CheckedChanged += new System.EventHandler(this.chbPlotPower_CheckedChanged);
            // 
            // chbPlotVoltage
            // 
            this.chbPlotVoltage.AutoSize = true;
            this.chbPlotVoltage.Checked = true;
            this.chbPlotVoltage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbPlotVoltage.Location = new System.Drawing.Point(561, 399);
            this.chbPlotVoltage.Name = "chbPlotVoltage";
            this.chbPlotVoltage.Size = new System.Drawing.Size(83, 17);
            this.chbPlotVoltage.TabIndex = 21;
            this.chbPlotVoltage.Text = "Plot Voltage";
            this.chbPlotVoltage.UseVisualStyleBackColor = true;
            this.chbPlotVoltage.CheckedChanged += new System.EventHandler(this.chbPlotVoltage_CheckedChanged);
            // 
            // chbPlotAmps
            // 
            this.chbPlotAmps.AutoSize = true;
            this.chbPlotAmps.Checked = true;
            this.chbPlotAmps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbPlotAmps.Location = new System.Drawing.Point(561, 376);
            this.chbPlotAmps.Name = "chbPlotAmps";
            this.chbPlotAmps.Size = new System.Drawing.Size(81, 17);
            this.chbPlotAmps.TabIndex = 20;
            this.chbPlotAmps.Text = "Plot Current";
            this.chbPlotAmps.UseVisualStyleBackColor = true;
            this.chbPlotAmps.CheckedChanged += new System.EventHandler(this.chbPlotAmps_CheckedChanged);
            // 
            // lblSampleTimeS
            // 
            this.lblSampleTimeS.AutoSize = true;
            this.lblSampleTimeS.Location = new System.Drawing.Point(523, 400);
            this.lblSampleTimeS.Name = "lblSampleTimeS";
            this.lblSampleTimeS.Size = new System.Drawing.Size(18, 13);
            this.lblSampleTimeS.TabIndex = 19;
            this.lblSampleTimeS.Text = "(s)";
            // 
            // lblSampleTime
            // 
            this.lblSampleTime.AutoSize = true;
            this.lblSampleTime.Location = new System.Drawing.Point(386, 400);
            this.lblSampleTime.Name = "lblSampleTime";
            this.lblSampleTime.Size = new System.Drawing.Size(71, 13);
            this.lblSampleTime.TabIndex = 19;
            this.lblSampleTime.Text = "Sample Time:";
            // 
            // nudSampleTime
            // 
            this.nudSampleTime.DecimalPlaces = 2;
            this.nudSampleTime.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudSampleTime.Location = new System.Drawing.Point(463, 398);
            this.nudSampleTime.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudSampleTime.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nudSampleTime.Name = "nudSampleTime";
            this.nudSampleTime.Size = new System.Drawing.Size(54, 20);
            this.nudSampleTime.TabIndex = 19;
            this.nudSampleTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSampleTime.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nudSampleTime.ValueChanged += new System.EventHandler(this.nudSampleTime_ValueChanged);
            // 
            // btnLoadTurnOn
            // 
            this.btnLoadTurnOn.Location = new System.Drawing.Point(566, 463);
            this.btnLoadTurnOn.Name = "btnLoadTurnOn";
            this.btnLoadTurnOn.Size = new System.Drawing.Size(236, 69);
            this.btnLoadTurnOn.TabIndex = 24;
            this.btnLoadTurnOn.Text = "Load On/Off";
            this.btnLoadTurnOn.UseVisualStyleBackColor = true;
            this.btnLoadTurnOn.Click += new System.EventHandler(this.btnLoadTurnOn_Click);
            // 
            // btnStopReading
            // 
            this.btnStopReading.Enabled = false;
            this.btnStopReading.Location = new System.Drawing.Point(6, 412);
            this.btnStopReading.Name = "btnStopReading";
            this.btnStopReading.Size = new System.Drawing.Size(114, 27);
            this.btnStopReading.TabIndex = 21;
            this.btnStopReading.Text = "Stop Reading Data";
            this.btnStopReading.UseVisualStyleBackColor = true;
            this.btnStopReading.Click += new System.EventHandler(this.btnStopReading_Click);
            // 
            // btnStartReading
            // 
            this.btnStartReading.Location = new System.Drawing.Point(6, 379);
            this.btnStartReading.Name = "btnStartReading";
            this.btnStartReading.Size = new System.Drawing.Size(114, 27);
            this.btnStartReading.TabIndex = 20;
            this.btnStartReading.Text = "Start Reading Data";
            this.btnStartReading.UseVisualStyleBackColor = true;
            this.btnStartReading.Click += new System.EventHandler(this.btnStartReading_Click);
            // 
            // chtManualReadValues
            // 
            chartArea1.Name = "ChartArea1";
            this.chtManualReadValues.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtManualReadValues.Legends.Add(legend1);
            this.chtManualReadValues.Location = new System.Drawing.Point(6, 19);
            this.chtManualReadValues.Name = "chtManualReadValues";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Current (A)";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Voltage (V)";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "Power (W)";
            this.chtManualReadValues.Series.Add(series1);
            this.chtManualReadValues.Series.Add(series2);
            this.chtManualReadValues.Series.Add(series3);
            this.chtManualReadValues.Size = new System.Drawing.Size(632, 354);
            this.chtManualReadValues.TabIndex = 19;
            this.chtManualReadValues.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoConstantAmps);
            this.groupBox2.Controls.Add(this.rdoConstantVoltage);
            this.groupBox2.Controls.Add(this.rdoConstantPower);
            this.groupBox2.Controls.Add(this.rdoConstantResistance);
            this.groupBox2.Location = new System.Drawing.Point(917, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 110);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mode Selection";
            // 
            // rdoConstantAmps
            // 
            this.rdoConstantAmps.AutoSize = true;
            this.rdoConstantAmps.Checked = true;
            this.rdoConstantAmps.Location = new System.Drawing.Point(6, 19);
            this.rdoConstantAmps.Name = "rdoConstantAmps";
            this.rdoConstantAmps.Size = new System.Drawing.Size(104, 17);
            this.rdoConstantAmps.TabIndex = 2;
            this.rdoConstantAmps.TabStop = true;
            this.rdoConstantAmps.Text = "Constant Current";
            this.rdoConstantAmps.UseVisualStyleBackColor = true;
            this.rdoConstantAmps.CheckedChanged += new System.EventHandler(this.rdoConstantAmps_CheckedChanged);
            // 
            // rdoConstantVoltage
            // 
            this.rdoConstantVoltage.AutoSize = true;
            this.rdoConstantVoltage.Location = new System.Drawing.Point(6, 42);
            this.rdoConstantVoltage.Name = "rdoConstantVoltage";
            this.rdoConstantVoltage.Size = new System.Drawing.Size(106, 17);
            this.rdoConstantVoltage.TabIndex = 3;
            this.rdoConstantVoltage.Text = "Constant Voltage";
            this.rdoConstantVoltage.UseVisualStyleBackColor = true;
            this.rdoConstantVoltage.CheckedChanged += new System.EventHandler(this.rdoConstantVoltage_CheckedChanged);
            // 
            // rdoConstantPower
            // 
            this.rdoConstantPower.AutoSize = true;
            this.rdoConstantPower.Location = new System.Drawing.Point(6, 65);
            this.rdoConstantPower.Name = "rdoConstantPower";
            this.rdoConstantPower.Size = new System.Drawing.Size(100, 17);
            this.rdoConstantPower.TabIndex = 4;
            this.rdoConstantPower.Text = "Constant Power";
            this.rdoConstantPower.UseVisualStyleBackColor = true;
            this.rdoConstantPower.CheckedChanged += new System.EventHandler(this.rdoConstantPower_CheckedChanged);
            // 
            // rdoConstantResistance
            // 
            this.rdoConstantResistance.AutoSize = true;
            this.rdoConstantResistance.Location = new System.Drawing.Point(6, 88);
            this.rdoConstantResistance.Name = "rdoConstantResistance";
            this.rdoConstantResistance.Size = new System.Drawing.Size(123, 17);
            this.rdoConstantResistance.TabIndex = 5;
            this.rdoConstantResistance.Text = "Constant Resistance";
            this.rdoConstantResistance.UseVisualStyleBackColor = true;
            this.rdoConstantResistance.CheckedChanged += new System.EventHandler(this.rdoConstantResistance_CheckedChanged);
            // 
            // TMR1
            // 
            this.TMR1.Interval = 1000;
            this.TMR1.Tick += new System.EventHandler(this.TMR1_Tick);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.nudAddress);
            this.groupBox7.Location = new System.Drawing.Point(917, 280);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(163, 45);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Address of Load";
            // 
            // nudAddress
            // 
            this.nudAddress.Hexadecimal = true;
            this.nudAddress.Location = new System.Drawing.Point(35, 19);
            this.nudAddress.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nudAddress.Name = "nudAddress";
            this.nudAddress.Size = new System.Drawing.Size(95, 20);
            this.nudAddress.TabIndex = 0;
            this.nudAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(12, 463);
            this.lbLog.Name = "lbLog";
            this.lbLog.ScrollAlwaysVisible = true;
            this.lbLog.Size = new System.Drawing.Size(548, 69);
            this.lbLog.TabIndex = 25;
            // 
            // btnClearChart
            // 
            this.btnClearChart.Location = new System.Drawing.Point(126, 379);
            this.btnClearChart.Name = "btnClearChart";
            this.btnClearChart.Size = new System.Drawing.Size(114, 27);
            this.btnClearChart.TabIndex = 25;
            this.btnClearChart.Text = "Clear Graph";
            this.btnClearChart.UseVisualStyleBackColor = true;
            this.btnClearChart.Click += new System.EventHandler(this.btnClearChart_Click);
            // 
            // btnSaveGraph
            // 
            this.btnSaveGraph.Location = new System.Drawing.Point(126, 412);
            this.btnSaveGraph.Name = "btnSaveGraph";
            this.btnSaveGraph.Size = new System.Drawing.Size(114, 27);
            this.btnSaveGraph.TabIndex = 26;
            this.btnSaveGraph.Text = "Save Graph to .csv";
            this.btnSaveGraph.UseVisualStyleBackColor = true;
            this.btnSaveGraph.Click += new System.EventHandler(this.btnSaveGraph_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.chbPlotPower);
            this.groupBox8.Controls.Add(this.chtManualReadValues);
            this.groupBox8.Controls.Add(this.chbPlotVoltage);
            this.groupBox8.Controls.Add(this.chbPlotAmps);
            this.groupBox8.Controls.Add(this.btnStartReading);
            this.groupBox8.Controls.Add(this.lblSampleTimeS);
            this.groupBox8.Controls.Add(this.btnSaveGraph);
            this.groupBox8.Controls.Add(this.nudSampleTime);
            this.groupBox8.Controls.Add(this.lblSampleTime);
            this.groupBox8.Controls.Add(this.btnStopReading);
            this.groupBox8.Controls.Add(this.btnClearChart);
            this.groupBox8.Location = new System.Drawing.Point(261, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(650, 445);
            this.groupBox8.TabIndex = 27;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Graph Controls";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(808, 463);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(103, 69);
            this.btnTest.TabIndex = 28;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(949, 506);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(28, 13);
            this.lblTest.TabIndex = 29;
            this.lblTest.Text = "Test";
            // 
            // chbRemoteSensing
            // 
            this.chbRemoteSensing.AutoSize = true;
            this.chbRemoteSensing.Location = new System.Drawing.Point(926, 463);
            this.chbRemoteSensing.Name = "chbRemoteSensing";
            this.chbRemoteSensing.Size = new System.Drawing.Size(126, 17);
            this.chbRemoteSensing.TabIndex = 30;
            this.chbRemoteSensing.Text = "Use Remote Sensing";
            this.chbRemoteSensing.UseVisualStyleBackColor = true;
            this.chbRemoteSensing.CheckedChanged += new System.EventHandler(this.chbRemoteSensing_CheckedChanged);
            // 
            // btnMaxValueUpdate
            // 
            this.btnMaxValueUpdate.Location = new System.Drawing.Point(6, 94);
            this.btnMaxValueUpdate.Name = "btnMaxValueUpdate";
            this.btnMaxValueUpdate.Size = new System.Drawing.Size(150, 26);
            this.btnMaxValueUpdate.TabIndex = 31;
            this.btnMaxValueUpdate.Text = "Update Max Allowances";
            this.btnMaxValueUpdate.UseVisualStyleBackColor = true;
            this.btnMaxValueUpdate.Click += new System.EventHandler(this.btnMaxValueUpdate_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nudMaxWatts);
            this.groupBox4.Controls.Add(this.btnMaxValueUpdate);
            this.groupBox4.Controls.Add(this.lblMaxWatts);
            this.groupBox4.Controls.Add(this.lblMaxVoltage);
            this.groupBox4.Controls.Add(this.lblMaxAmps);
            this.groupBox4.Controls.Add(this.nudMaxVoltage);
            this.groupBox4.Controls.Add(this.nudMaxAmps);
            this.groupBox4.Location = new System.Drawing.Point(917, 331);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(163, 126);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Max Allowances";
            // 
            // nudMaxWatts
            // 
            this.nudMaxWatts.DecimalPlaces = 3;
            this.nudMaxWatts.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nudMaxWatts.Location = new System.Drawing.Point(87, 68);
            this.nudMaxWatts.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudMaxWatts.Name = "nudMaxWatts";
            this.nudMaxWatts.Size = new System.Drawing.Size(69, 20);
            this.nudMaxWatts.TabIndex = 5;
            this.nudMaxWatts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMaxWatts.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // lblMaxWatts
            // 
            this.lblMaxWatts.AutoSize = true;
            this.lblMaxWatts.Location = new System.Drawing.Point(6, 70);
            this.lblMaxWatts.Name = "lblMaxWatts";
            this.lblMaxWatts.Size = new System.Drawing.Size(63, 13);
            this.lblMaxWatts.TabIndex = 2;
            this.lblMaxWatts.Text = "Max Power:";
            // 
            // lblMaxVoltage
            // 
            this.lblMaxVoltage.AutoSize = true;
            this.lblMaxVoltage.Location = new System.Drawing.Point(6, 44);
            this.lblMaxVoltage.Name = "lblMaxVoltage";
            this.lblMaxVoltage.Size = new System.Drawing.Size(69, 13);
            this.lblMaxVoltage.TabIndex = 1;
            this.lblMaxVoltage.Text = "Max Voltage:";
            // 
            // lblMaxAmps
            // 
            this.lblMaxAmps.AutoSize = true;
            this.lblMaxAmps.Location = new System.Drawing.Point(6, 18);
            this.lblMaxAmps.Name = "lblMaxAmps";
            this.lblMaxAmps.Size = new System.Drawing.Size(67, 13);
            this.lblMaxAmps.TabIndex = 0;
            this.lblMaxAmps.Text = "Max Current:";
            // 
            // nudMaxVoltage
            // 
            this.nudMaxVoltage.DecimalPlaces = 2;
            this.nudMaxVoltage.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudMaxVoltage.Location = new System.Drawing.Point(87, 42);
            this.nudMaxVoltage.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudMaxVoltage.Name = "nudMaxVoltage";
            this.nudMaxVoltage.Size = new System.Drawing.Size(69, 20);
            this.nudMaxVoltage.TabIndex = 3;
            this.nudMaxVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMaxVoltage.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // nudMaxAmps
            // 
            this.nudMaxAmps.DecimalPlaces = 3;
            this.nudMaxAmps.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nudMaxAmps.Location = new System.Drawing.Point(87, 16);
            this.nudMaxAmps.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudMaxAmps.Name = "nudMaxAmps";
            this.nudMaxAmps.Size = new System.Drawing.Size(69, 20);
            this.nudMaxAmps.TabIndex = 4;
            this.nudMaxAmps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMaxAmps.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // tmrParse
            // 
            this.tmrParse.Interval = 10;
            this.tmrParse.Tick += new System.EventHandler(this.tmrParse_Tick);
            // 
            // BK8500_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 540);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.chbRemoteSensing);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.btnLoadTurnOn);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "BK8500_Interface";
            this.Text = "BK Precision 8500 Controller";
            this.Load += new System.EventHandler(this.BK8500_Interface_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarManualValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudManualValue)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTranBTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTranATime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTranBValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTranAValue)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSampleTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtManualReadValues)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudAddress)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxWatts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxAmps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboCOMPort;
        private System.Windows.Forms.Button btnCloseCOM;
        private System.Windows.Forms.Button btnOpenCOM;
        private System.Windows.Forms.Button btnRefreshCOM;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown nudSampleTime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblManualUnits;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoConstantAmps;
        private System.Windows.Forms.RadioButton rdoConstantVoltage;
        private System.Windows.Forms.RadioButton rdoConstantPower;
        private System.Windows.Forms.RadioButton rdoConstantResistance;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtManualReadValues;
        private System.Windows.Forms.CheckBox chbPlotPower;
        private System.Windows.Forms.CheckBox chbPlotVoltage;
        private System.Windows.Forms.CheckBox chbPlotAmps;
        private System.Windows.Forms.Label lblSampleTimeS;
        private System.Windows.Forms.Label lblSampleTime;
        private System.Windows.Forms.Timer TMR1;
        private System.Windows.Forms.Button btnStopReading;
        private System.Windows.Forms.Button btnStartReading;
        private System.Windows.Forms.Button btnManualUpdate;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblTranBS;
        private System.Windows.Forms.Label lblTranAS;
        private System.Windows.Forms.NumericUpDown nudTranBTime;
        private System.Windows.Forms.NumericUpDown nudTranATime;
        private System.Windows.Forms.Label lblTranBUnits;
        private System.Windows.Forms.Label lblTranAUnits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTranA;
        private System.Windows.Forms.NumericUpDown nudTranBValue;
        private System.Windows.Forms.NumericUpDown nudTranAValue;
        private System.Windows.Forms.Button btnTranTrigger;
        private System.Windows.Forms.Button btnUpdateTran;
        private System.Windows.Forms.RadioButton rdoTranToggle;
        private System.Windows.Forms.RadioButton rdoTranContinuous;
        private System.Windows.Forms.RadioButton rdoTranPulse;
        private System.Windows.Forms.TrackBar tbarManualValue;
        private System.Windows.Forms.NumericUpDown nudManualValue;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.NumericUpDown nudAddress;
        private System.Windows.Forms.Button btnLoadTurnOn;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Button btnSaveGraph;
        private System.Windows.Forms.Button btnClearChart;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnEnableTrans;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.CheckBox chbListRepeat;
        private System.Windows.Forms.Button btnEnableList;
        private System.Windows.Forms.Button btnUpdateList;
        private System.Windows.Forms.Button btnStartList;
        private System.Windows.Forms.CheckBox chbRemoteSensing;
        private System.Windows.Forms.Button btnMaxValueUpdate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown nudMaxWatts;
        private System.Windows.Forms.Label lblMaxWatts;
        private System.Windows.Forms.Label lblMaxVoltage;
        private System.Windows.Forms.Label lblMaxAmps;
        private System.Windows.Forms.NumericUpDown nudMaxVoltage;
        private System.Windows.Forms.NumericUpDown nudMaxAmps;
        private System.Windows.Forms.Timer tmrParse;
    }
}

