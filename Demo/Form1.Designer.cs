namespace Demo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lInfo = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bRs232Discon = new System.Windows.Forms.Button();
            this.bRs232Con = new System.Windows.Forms.Button();
            this.cCommPort = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tRfPwr = new System.Windows.Forms.TrackBar();
            this.cRfFreq = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bRfQuery = new System.Windows.Forms.Button();
            this.bRfSet = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ant4 = new System.Windows.Forms.CheckBox();
            this.ant3 = new System.Windows.Forms.CheckBox();
            this.ant2 = new System.Windows.Forms.CheckBox();
            this.ant1 = new System.Windows.Forms.CheckBox();
            this.bAntQuery = new System.Windows.Forms.Button();
            this.bAntSet = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSetAccessPWD = new System.Windows.Forms.Button();
            this.bEpcInit = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tEpcAccess = new System.Windows.Forms.TextBox();
            this.tEpcKill = new System.Windows.Forms.TextBox();
            this.tEpcData = new System.Windows.Forms.TextBox();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.cEpcWordcnt = new System.Windows.Forms.ComboBox();
            this.cEpcWordptr = new System.Windows.Forms.ComboBox();
            this.cEpcMembank = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tEpcSpeed = new System.Windows.Forms.TrackBar();
            this.cEpcTimes = new System.Windows.Forms.ComboBox();
            this.bEpcKill = new System.Windows.Forms.Button();
            this.btnSecLock = new System.Windows.Forms.Button();
            this.btnSecWrite = new System.Windows.Forms.Button();
            this.bEpcWrite = new System.Windows.Forms.Button();
            this.btnSecRead = new System.Windows.Forms.Button();
            this.bEpcRead = new System.Windows.Forms.Button();
            this.bEpcId = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chkFilter = new System.Windows.Forms.CheckBox();
            this.bClear = new System.Windows.Forms.Button();
            this.lvTagList = new System.Windows.Forms.ListView();
            this.clhNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTagData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTimes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bReset = new System.Windows.Forms.Button();
            this.timerScanEPC = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.timerPing = new System.Windows.Forms.Timer(this.components);
            this.btntxt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRfPwr)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tEpcSpeed)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lInfo
            // 
            this.lInfo.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lInfo.FormattingEnabled = true;
            this.lInfo.HorizontalScrollbar = true;
            this.lInfo.ItemHeight = 12;
            this.lInfo.Location = new System.Drawing.Point(6, 25);
            this.lInfo.Name = "lInfo";
            this.lInfo.ScrollAlwaysVisible = true;
            this.lInfo.Size = new System.Drawing.Size(367, 316);
            this.lInfo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bRs232Discon);
            this.groupBox1.Controls.Add(this.bRs232Con);
            this.groupBox1.Controls.Add(this.cCommPort);
            this.groupBox1.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RS232";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "COMM PORT";
            // 
            // bRs232Discon
            // 
            this.bRs232Discon.BackColor = System.Drawing.Color.SlateGray;
            this.bRs232Discon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bRs232Discon.ForeColor = System.Drawing.Color.Gold;
            this.bRs232Discon.Location = new System.Drawing.Point(133, 87);
            this.bRs232Discon.Name = "bRs232Discon";
            this.bRs232Discon.Size = new System.Drawing.Size(77, 31);
            this.bRs232Discon.TabIndex = 5;
            this.bRs232Discon.Text = "Discon";
            this.bRs232Discon.UseVisualStyleBackColor = false;
            this.bRs232Discon.Click += new System.EventHandler(this.bRs232Discon_Click);
            // 
            // bRs232Con
            // 
            this.bRs232Con.BackColor = System.Drawing.Color.SlateGray;
            this.bRs232Con.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bRs232Con.ForeColor = System.Drawing.Color.Gold;
            this.bRs232Con.Location = new System.Drawing.Point(35, 87);
            this.bRs232Con.Name = "bRs232Con";
            this.bRs232Con.Size = new System.Drawing.Size(77, 31);
            this.bRs232Con.TabIndex = 4;
            this.bRs232Con.Text = "Connect";
            this.bRs232Con.UseVisualStyleBackColor = false;
            this.bRs232Con.Click += new System.EventHandler(this.bRs232Con_Click);
            // 
            // cCommPort
            // 
            this.cCommPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cCommPort.FormattingEnabled = true;
            this.cCommPort.Location = new System.Drawing.Point(123, 24);
            this.cCommPort.Name = "cCommPort";
            this.cCommPort.Size = new System.Drawing.Size(87, 22);
            this.cCommPort.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tRfPwr);
            this.groupBox3.Controls.Add(this.cRfFreq);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.bRfQuery);
            this.groupBox3.Controls.Add(this.bRfSet);
            this.groupBox3.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox3.Location = new System.Drawing.Point(12, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 135);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RF Setting";
            // 
            // tRfPwr
            // 
            this.tRfPwr.Location = new System.Drawing.Point(66, 22);
            this.tRfPwr.Maximum = 30;
            this.tRfPwr.Name = "tRfPwr";
            this.tRfPwr.Size = new System.Drawing.Size(159, 45);
            this.tRfPwr.TabIndex = 9;
            // 
            // cRfFreq
            // 
            this.cRfFreq.FormattingEnabled = true;
            this.cRfFreq.Items.AddRange(new object[] {
            "CHINA",
            "AMERICA",
            "EUROPE",
            "OTHER"});
            this.cRfFreq.Location = new System.Drawing.Point(123, 64);
            this.cRfFreq.Name = "cRfFreq";
            this.cRfFreq.Size = new System.Drawing.Size(87, 22);
            this.cRfFreq.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 14);
            this.label5.TabIndex = 7;
            this.label5.Text = "FREQ TYPE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "POWER";
            // 
            // bRfQuery
            // 
            this.bRfQuery.BackColor = System.Drawing.Color.SlateGray;
            this.bRfQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bRfQuery.ForeColor = System.Drawing.Color.Gold;
            this.bRfQuery.Location = new System.Drawing.Point(133, 98);
            this.bRfQuery.Name = "bRfQuery";
            this.bRfQuery.Size = new System.Drawing.Size(77, 28);
            this.bRfQuery.TabIndex = 5;
            this.bRfQuery.Text = "Query";
            this.bRfQuery.UseVisualStyleBackColor = false;
            this.bRfQuery.Click += new System.EventHandler(this.bRfQuery_Click);
            // 
            // bRfSet
            // 
            this.bRfSet.BackColor = System.Drawing.Color.SlateGray;
            this.bRfSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bRfSet.ForeColor = System.Drawing.Color.Gold;
            this.bRfSet.Location = new System.Drawing.Point(35, 98);
            this.bRfSet.Name = "bRfSet";
            this.bRfSet.Size = new System.Drawing.Size(77, 28);
            this.bRfSet.TabIndex = 4;
            this.bRfSet.Text = "Set";
            this.bRfSet.UseVisualStyleBackColor = false;
            this.bRfSet.Click += new System.EventHandler(this.bRfSet_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ant4);
            this.groupBox4.Controls.Add(this.ant3);
            this.groupBox4.Controls.Add(this.ant2);
            this.groupBox4.Controls.Add(this.ant1);
            this.groupBox4.Controls.Add(this.bAntQuery);
            this.groupBox4.Controls.Add(this.bAntSet);
            this.groupBox4.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox4.Location = new System.Drawing.Point(12, 467);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(237, 105);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ANT Setting";
            // 
            // ant4
            // 
            this.ant4.AutoSize = true;
            this.ant4.Location = new System.Drawing.Point(81, 69);
            this.ant4.Name = "ant4";
            this.ant4.Size = new System.Drawing.Size(54, 18);
            this.ant4.TabIndex = 9;
            this.ant4.Text = "ANT4";
            this.ant4.UseVisualStyleBackColor = true;
            // 
            // ant3
            // 
            this.ant3.AutoSize = true;
            this.ant3.Location = new System.Drawing.Point(21, 69);
            this.ant3.Name = "ant3";
            this.ant3.Size = new System.Drawing.Size(54, 18);
            this.ant3.TabIndex = 8;
            this.ant3.Text = "ANT3";
            this.ant3.UseVisualStyleBackColor = true;
            // 
            // ant2
            // 
            this.ant2.AutoSize = true;
            this.ant2.Location = new System.Drawing.Point(81, 30);
            this.ant2.Name = "ant2";
            this.ant2.Size = new System.Drawing.Size(54, 18);
            this.ant2.TabIndex = 7;
            this.ant2.Text = "ANT2";
            this.ant2.UseVisualStyleBackColor = true;
            // 
            // ant1
            // 
            this.ant1.AutoSize = true;
            this.ant1.Location = new System.Drawing.Point(21, 30);
            this.ant1.Name = "ant1";
            this.ant1.Size = new System.Drawing.Size(54, 18);
            this.ant1.TabIndex = 6;
            this.ant1.Text = "ANT1";
            this.ant1.UseVisualStyleBackColor = true;
            // 
            // bAntQuery
            // 
            this.bAntQuery.BackColor = System.Drawing.Color.SlateGray;
            this.bAntQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bAntQuery.ForeColor = System.Drawing.Color.Gold;
            this.bAntQuery.Location = new System.Drawing.Point(141, 65);
            this.bAntQuery.Name = "bAntQuery";
            this.bAntQuery.Size = new System.Drawing.Size(77, 28);
            this.bAntQuery.TabIndex = 5;
            this.bAntQuery.Text = "Query";
            this.bAntQuery.UseVisualStyleBackColor = false;
            this.bAntQuery.Click += new System.EventHandler(this.bAntQuery_Click);
            // 
            // bAntSet
            // 
            this.bAntSet.BackColor = System.Drawing.Color.SlateGray;
            this.bAntSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bAntSet.ForeColor = System.Drawing.Color.Gold;
            this.bAntSet.Location = new System.Drawing.Point(141, 22);
            this.bAntSet.Name = "bAntSet";
            this.bAntSet.Size = new System.Drawing.Size(77, 28);
            this.bAntSet.TabIndex = 4;
            this.bAntSet.Text = "Set";
            this.bAntSet.UseVisualStyleBackColor = false;
            this.bAntSet.Click += new System.EventHandler(this.bAntSet_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnSetAccessPWD);
            this.groupBox6.Controls.Add(this.bEpcInit);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.tEpcAccess);
            this.groupBox6.Controls.Add(this.tEpcKill);
            this.groupBox6.Controls.Add(this.tEpcData);
            this.groupBox6.Controls.Add(this.cmbLevel);
            this.groupBox6.Controls.Add(this.cEpcWordcnt);
            this.groupBox6.Controls.Add(this.cEpcWordptr);
            this.groupBox6.Controls.Add(this.cEpcMembank);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.tEpcSpeed);
            this.groupBox6.Controls.Add(this.cEpcTimes);
            this.groupBox6.Controls.Add(this.bEpcKill);
            this.groupBox6.Controls.Add(this.btnSecLock);
            this.groupBox6.Controls.Add(this.btnSecWrite);
            this.groupBox6.Controls.Add(this.bEpcWrite);
            this.groupBox6.Controls.Add(this.btnSecRead);
            this.groupBox6.Controls.Add(this.bEpcRead);
            this.groupBox6.Controls.Add(this.bEpcId);
            this.groupBox6.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox6.Location = new System.Drawing.Point(274, 329);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(358, 404);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ISO18000-6C(EPC G2)";
            // 
            // btnSetAccessPWD
            // 
            this.btnSetAccessPWD.BackColor = System.Drawing.Color.SlateGray;
            this.btnSetAccessPWD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetAccessPWD.ForeColor = System.Drawing.Color.Gold;
            this.btnSetAccessPWD.Location = new System.Drawing.Point(232, 239);
            this.btnSetAccessPWD.Name = "btnSetAccessPWD";
            this.btnSetAccessPWD.Size = new System.Drawing.Size(120, 31);
            this.btnSetAccessPWD.TabIndex = 29;
            this.btnSetAccessPWD.Text = "Set Password";
            this.btnSetAccessPWD.UseVisualStyleBackColor = false;
            this.btnSetAccessPWD.Click += new System.EventHandler(this.btnSetAccessPWD_Click);
            // 
            // bEpcInit
            // 
            this.bEpcInit.BackColor = System.Drawing.Color.SlateGray;
            this.bEpcInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bEpcInit.ForeColor = System.Drawing.Color.Gold;
            this.bEpcInit.Location = new System.Drawing.Point(250, 169);
            this.bEpcInit.Name = "bEpcInit";
            this.bEpcInit.Size = new System.Drawing.Size(90, 28);
            this.bEpcInit.TabIndex = 29;
            this.bEpcInit.Text = "Init";
            this.bEpcInit.UseVisualStyleBackColor = false;
            this.bEpcInit.Click += new System.EventHandler(this.bEpcInit_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(10, 362);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(112, 16);
            this.label19.TabIndex = 28;
            this.label19.Text = "Kill Password";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(8, 323);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 16);
            this.label20.TabIndex = 27;
            this.label20.Text = "Password Level";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(8, 284);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 16);
            this.label18.TabIndex = 27;
            this.label18.Text = "Access Password";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(10, 239);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 16);
            this.label17.TabIndex = 26;
            this.label17.Text = "Data(Hex)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(8, 135);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 16);
            this.label16.TabIndex = 25;
            this.label16.Text = "MemBank";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(10, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 16);
            this.label15.TabIndex = 24;
            this.label15.Text = "WordCnt";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(8, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 16);
            this.label14.TabIndex = 22;
            this.label14.Text = "WordPtr";
            // 
            // tEpcAccess
            // 
            this.tEpcAccess.Location = new System.Drawing.Point(139, 283);
            this.tEpcAccess.MaxLength = 8;
            this.tEpcAccess.Name = "tEpcAccess";
            this.tEpcAccess.Size = new System.Drawing.Size(87, 26);
            this.tEpcAccess.TabIndex = 23;
            // 
            // tEpcKill
            // 
            this.tEpcKill.Location = new System.Drawing.Point(139, 361);
            this.tEpcKill.Name = "tEpcKill";
            this.tEpcKill.Size = new System.Drawing.Size(87, 26);
            this.tEpcKill.TabIndex = 22;
            // 
            // tEpcData
            // 
            this.tEpcData.Location = new System.Drawing.Point(97, 239);
            this.tEpcData.Name = "tEpcData";
            this.tEpcData.Size = new System.Drawing.Size(125, 26);
            this.tEpcData.TabIndex = 21;
            this.tEpcData.TextChanged += new System.EventHandler(this.tEpcData_TextChanged);
            // 
            // cmbLevel
            // 
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Items.AddRange(new object[] {
            "00",
            "01",
            "10",
            "11"});
            this.cmbLevel.Location = new System.Drawing.Point(139, 322);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(87, 24);
            this.cmbLevel.TabIndex = 20;
            // 
            // cEpcWordcnt
            // 
            this.cEpcWordcnt.FormattingEnabled = true;
            this.cEpcWordcnt.Location = new System.Drawing.Point(97, 207);
            this.cEpcWordcnt.Name = "cEpcWordcnt";
            this.cEpcWordcnt.Size = new System.Drawing.Size(87, 24);
            this.cEpcWordcnt.TabIndex = 20;
            // 
            // cEpcWordptr
            // 
            this.cEpcWordptr.FormattingEnabled = true;
            this.cEpcWordptr.Location = new System.Drawing.Point(97, 170);
            this.cEpcWordptr.Name = "cEpcWordptr";
            this.cEpcWordptr.Size = new System.Drawing.Size(87, 24);
            this.cEpcWordptr.TabIndex = 19;
            // 
            // cEpcMembank
            // 
            this.cEpcMembank.FormattingEnabled = true;
            this.cEpcMembank.Items.AddRange(new object[] {
            "RESERVE",
            "EPC",
            "TID",
            "USER"});
            this.cEpcMembank.Location = new System.Drawing.Point(97, 135);
            this.cEpcMembank.Name = "cEpcMembank";
            this.cEpcMembank.Size = new System.Drawing.Size(87, 24);
            this.cEpcMembank.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(18, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Times";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(16, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Speed";
            // 
            // tEpcSpeed
            // 
            this.tEpcSpeed.Location = new System.Drawing.Point(71, 43);
            this.tEpcSpeed.Name = "tEpcSpeed";
            this.tEpcSpeed.Size = new System.Drawing.Size(155, 45);
            this.tEpcSpeed.TabIndex = 15;
            // 
            // cEpcTimes
            // 
            this.cEpcTimes.FormattingEnabled = true;
            this.cEpcTimes.Items.AddRange(new object[] {
            "Continours",
            "1",
            "10",
            "100",
            "1000",
            "5000"});
            this.cEpcTimes.Location = new System.Drawing.Point(97, 93);
            this.cEpcTimes.Name = "cEpcTimes";
            this.cEpcTimes.Size = new System.Drawing.Size(87, 24);
            this.cEpcTimes.TabIndex = 14;
            // 
            // bEpcKill
            // 
            this.bEpcKill.BackColor = System.Drawing.Color.SlateGray;
            this.bEpcKill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bEpcKill.ForeColor = System.Drawing.Color.Gold;
            this.bEpcKill.Location = new System.Drawing.Point(250, 204);
            this.bEpcKill.Name = "bEpcKill";
            this.bEpcKill.Size = new System.Drawing.Size(90, 28);
            this.bEpcKill.TabIndex = 9;
            this.bEpcKill.Text = "Kill";
            this.bEpcKill.UseVisualStyleBackColor = false;
            this.bEpcKill.Click += new System.EventHandler(this.bEpcKill_Click);
            // 
            // btnSecLock
            // 
            this.btnSecLock.BackColor = System.Drawing.Color.SlateGray;
            this.btnSecLock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSecLock.ForeColor = System.Drawing.Color.Gold;
            this.btnSecLock.Location = new System.Drawing.Point(250, 361);
            this.btnSecLock.Name = "btnSecLock";
            this.btnSecLock.Size = new System.Drawing.Size(90, 28);
            this.btnSecLock.TabIndex = 8;
            this.btnSecLock.Text = "Sec Lock";
            this.btnSecLock.UseVisualStyleBackColor = false;
            this.btnSecLock.Click += new System.EventHandler(this.btnSecLock_Click);
            // 
            // btnSecWrite
            // 
            this.btnSecWrite.BackColor = System.Drawing.Color.SlateGray;
            this.btnSecWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSecWrite.ForeColor = System.Drawing.Color.Gold;
            this.btnSecWrite.Location = new System.Drawing.Point(250, 320);
            this.btnSecWrite.Name = "btnSecWrite";
            this.btnSecWrite.Size = new System.Drawing.Size(90, 28);
            this.btnSecWrite.TabIndex = 7;
            this.btnSecWrite.Text = "Sec Write";
            this.btnSecWrite.UseVisualStyleBackColor = false;
            this.btnSecWrite.Click += new System.EventHandler(this.btnSecWrite_Click);
            // 
            // bEpcWrite
            // 
            this.bEpcWrite.BackColor = System.Drawing.Color.SlateGray;
            this.bEpcWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bEpcWrite.ForeColor = System.Drawing.Color.Gold;
            this.bEpcWrite.Location = new System.Drawing.Point(250, 134);
            this.bEpcWrite.Name = "bEpcWrite";
            this.bEpcWrite.Size = new System.Drawing.Size(90, 28);
            this.bEpcWrite.TabIndex = 7;
            this.bEpcWrite.Text = "Write";
            this.bEpcWrite.UseVisualStyleBackColor = false;
            this.bEpcWrite.Click += new System.EventHandler(this.bEpcWrite_Click);
            // 
            // btnSecRead
            // 
            this.btnSecRead.BackColor = System.Drawing.Color.SlateGray;
            this.btnSecRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSecRead.ForeColor = System.Drawing.Color.Gold;
            this.btnSecRead.Location = new System.Drawing.Point(250, 281);
            this.btnSecRead.Name = "btnSecRead";
            this.btnSecRead.Size = new System.Drawing.Size(90, 28);
            this.btnSecRead.TabIndex = 6;
            this.btnSecRead.Text = "Sec Read";
            this.btnSecRead.UseVisualStyleBackColor = false;
            this.btnSecRead.Click += new System.EventHandler(this.btnSecRead_Click);
            // 
            // bEpcRead
            // 
            this.bEpcRead.BackColor = System.Drawing.Color.SlateGray;
            this.bEpcRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bEpcRead.ForeColor = System.Drawing.Color.Gold;
            this.bEpcRead.Location = new System.Drawing.Point(250, 95);
            this.bEpcRead.Name = "bEpcRead";
            this.bEpcRead.Size = new System.Drawing.Size(90, 28);
            this.bEpcRead.TabIndex = 6;
            this.bEpcRead.Text = "Read";
            this.bEpcRead.UseVisualStyleBackColor = false;
            this.bEpcRead.Click += new System.EventHandler(this.bEpcRead_Click);
            // 
            // bEpcId
            // 
            this.bEpcId.BackColor = System.Drawing.Color.SlateGray;
            this.bEpcId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bEpcId.ForeColor = System.Drawing.Color.Gold;
            this.bEpcId.Location = new System.Drawing.Point(250, 27);
            this.bEpcId.Name = "bEpcId";
            this.bEpcId.Size = new System.Drawing.Size(90, 55);
            this.bEpcId.TabIndex = 5;
            this.bEpcId.Text = "Identify";
            this.bEpcId.UseVisualStyleBackColor = false;
            this.bEpcId.Click += new System.EventHandler(this.bEpcId_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chkFilter);
            this.groupBox7.Controls.Add(this.bClear);
            this.groupBox7.Controls.Add(this.lvTagList);
            this.groupBox7.Controls.Add(this.lInfo);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox7.Location = new System.Drawing.Point(647, 13);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(380, 758);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Opration Info.";
            // 
            // chkFilter
            // 
            this.chkFilter.AutoSize = true;
            this.chkFilter.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkFilter.ForeColor = System.Drawing.Color.Yellow;
            this.chkFilter.Location = new System.Drawing.Point(15, 727);
            this.chkFilter.Name = "chkFilter";
            this.chkFilter.Size = new System.Drawing.Size(126, 20);
            this.chkFilter.TabIndex = 9;
            this.chkFilter.Text = "Filter Same";
            this.chkFilter.UseVisualStyleBackColor = true;
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.Color.SlateGray;
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bClear.ForeColor = System.Drawing.Color.Gold;
            this.bClear.Location = new System.Drawing.Point(216, 712);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(157, 40);
            this.bClear.TabIndex = 11;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // lvTagList
            // 
            this.lvTagList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhNo,
            this.clhTagData,
            this.clhTimes});
            this.lvTagList.Location = new System.Drawing.Point(6, 341);
            this.lvTagList.Name = "lvTagList";
            this.lvTagList.Size = new System.Drawing.Size(367, 369);
            this.lvTagList.TabIndex = 14;
            this.lvTagList.UseCompatibleStateImageBehavior = false;
            this.lvTagList.View = System.Windows.Forms.View.Details;
            this.lvTagList.SelectedIndexChanged += new System.EventHandler(this.lvTagList_SelectedIndexChanged);
            // 
            // clhNo
            // 
            this.clhNo.Tag = "clhNo";
            this.clhNo.Text = "NO.";
            this.clhNo.Width = 40;
            // 
            // clhTagData
            // 
            this.clhTagData.Tag = "clhTagData";
            this.clhTagData.Text = "Tag Data";
            this.clhTagData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhTagData.Width = 240;
            // 
            // clhTimes
            // 
            this.clhTimes.Tag = "clhTimes";
            this.clhTimes.Text = "Times";
            this.clhTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clhTimes.Width = 50;
            // 
            // bReset
            // 
            this.bReset.BackColor = System.Drawing.Color.SlateGray;
            this.bReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bReset.ForeColor = System.Drawing.Color.Gold;
            this.bReset.Location = new System.Drawing.Point(279, 740);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(123, 47);
            this.bReset.TabIndex = 8;
            this.bReset.Text = "Reset Reader";
            this.bReset.UseVisualStyleBackColor = false;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // timerScanEPC
            // 
            this.timerScanEPC.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SlateGray;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.ForeColor = System.Drawing.Color.Gold;
            this.btnExit.Location = new System.Drawing.Point(413, 742);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 47);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timerPing
            // 
            this.timerPing.Interval = 3000;
            this.timerPing.Tick += new System.EventHandler(this.timerPing_Tick);
            // 
            // btntxt
            // 
            this.btntxt.Location = new System.Drawing.Point(539, 745);
            this.btntxt.Name = "btntxt";
            this.btntxt.Size = new System.Drawing.Size(75, 40);
            this.btntxt.TabIndex = 22;
            this.btntxt.Text = "Save Data";
            this.btntxt.UseVisualStyleBackColor = true;
            this.btntxt.Click += new System.EventHandler(this.btntxt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1034, 795);
            this.Controls.Add(this.btntxt);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox7);
            this.Name = "Form1";
            this.Text = "UHF Reader Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRfPwr)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tEpcSpeed)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bRs232Con;
        private System.Windows.Forms.ComboBox cCommPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bRs232Discon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bRfQuery;
        private System.Windows.Forms.Button bRfSet;
        private System.Windows.Forms.ComboBox cRfFreq;
        private System.Windows.Forms.TrackBar tRfPwr;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox ant4;
        private System.Windows.Forms.CheckBox ant3;
        private System.Windows.Forms.CheckBox ant2;
        private System.Windows.Forms.CheckBox ant1;
        private System.Windows.Forms.Button bAntQuery;
        private System.Windows.Forms.Button bAntSet;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button bEpcKill;
        private System.Windows.Forms.Button bEpcWrite;
        private System.Windows.Forms.Button bEpcRead;
        private System.Windows.Forms.Button bEpcId;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar tEpcSpeed;
        private System.Windows.Forms.ComboBox cEpcTimes;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tEpcAccess;
        private System.Windows.Forms.TextBox tEpcKill;
        private System.Windows.Forms.TextBox tEpcData;
        private System.Windows.Forms.ComboBox cEpcWordcnt;
        private System.Windows.Forms.ComboBox cEpcWordptr;
        private System.Windows.Forms.ComboBox cEpcMembank;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Timer timerScanEPC;
        private System.Windows.Forms.Button bEpcInit;
        private System.Windows.Forms.Button btnSetAccessPWD;
        private System.Windows.Forms.Button btnSecLock;
        private System.Windows.Forms.Button btnSecWrite;
        private System.Windows.Forms.Button btnSecRead;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.ListView lvTagList;
        private System.Windows.Forms.ColumnHeader clhTagData;
        private System.Windows.Forms.ColumnHeader clhTimes;
        private System.Windows.Forms.CheckBox chkFilter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timerPing;
        private System.Windows.Forms.Button btntxt;
        private System.Windows.Forms.ColumnHeader clhNo;
    }
}

