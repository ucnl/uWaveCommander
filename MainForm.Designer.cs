namespace uWaveCommander
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.linkBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.infoBtn = new System.Windows.Forms.ToolStripButton();
            this.logBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.logOpenCurrentBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.logPlaybackBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.logClearEmptyItemsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.logArchiveAllItemsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.logDeleteAllItemsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.logDoThemAllBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.utilsBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.utilsRunAnotherInstanceBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mainSplit = new System.Windows.Forms.SplitContainer();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.deviceSettingsTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.deviceSettingsSalinityEdit = new System.Windows.Forms.NumericUpDown();
            this.deviceSettingsGravityAccEdit = new System.Windows.Forms.NumericUpDown();
            this.deviceSettingsCommandModeByDefaultChb = new System.Windows.Forms.CheckBox();
            this.deviceSettingsACKonTxFinishedChb = new System.Windows.Forms.CheckBox();
            this.deviceSettingsTxChIDCbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deviceSettingsRxChIDCbx = new System.Windows.Forms.ComboBox();
            this.deviceInfoTxb = new System.Windows.Forms.RichTextBox();
            this.deviceSettingsToolStrip = new System.Windows.Forms.ToolStrip();
            this.queryDeviceInfoBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.defaultDeviceSettingsBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.applyDeviceSettingsBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator34 = new System.Windows.Forms.ToolStripSeparator();
            this.remReqTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.remReqTxb = new System.Windows.Forms.RichTextBox();
            this.remReqStatTxb = new System.Windows.Forms.RichTextBox();
            this.remoteRequestsBottomToolStrip = new System.Windows.Forms.ToolStrip();
            this.remReqTxbClearBtn = new System.Windows.Forms.ToolStripButton();
            this.remReqTxbIsAutoscrollBtn = new System.Windows.Forms.ToolStripButton();
            this.remReqTxbCopy2ClipboardBtn = new System.Windows.Forms.ToolStripButton();
            this.remoteRequestsTopToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.remReqTxChIDCbx = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.remReqRxChIDCbx = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.remReqIDCbx = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.isRemoteRequestsAutoChb = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.remReqSendBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator30 = new System.Windows.Forms.ToolStripSeparator();
            this.ptModeTab = new System.Windows.Forms.TabPage();
            this.packetModeLogTxb = new System.Windows.Forms.RichTextBox();
            this.packetModeBottom2ToolStrip = new System.Windows.Forms.ToolStrip();
            this.ptModeTxbClearBtn = new System.Windows.Forms.ToolStripButton();
            this.ptModeTxbAutoscrollBtn = new System.Windows.Forms.ToolStripButton();
            this.ptTxbCopyToClipboardBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.ptModeRequestTargetAddressCbx = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel10 = new System.Windows.Forms.ToolStripLabel();
            this.ptModeRequestDataIDCbx = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.ptModeSendRequestBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.packetModeBottomToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.ptModePacketTargetAddressCbx = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.ptModePacketTriesCbx = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.ptModePacketTxb = new System.Windows.Forms.ToolStripTextBox();
            this.ptModePacketSendBtn = new System.Windows.Forms.ToolStripButton();
            this.ptModePacketSendAbortBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.packetModeTopToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.ptModeLocalAddressCbx = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.packetModeIsSaveToFlashBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.ptModeQuerySettingsBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator28 = new System.Windows.Forms.ToolStripSeparator();
            this.ptModeApplySettingsBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator29 = new System.Windows.Forms.ToolStripSeparator();
            this.lsTab = new System.Windows.Forms.TabPage();
            this.lsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton26 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator31 = new System.Windows.Forms.ToolStripSeparator();
            this.localSensors2IsSaveToFlashBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator32 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel12 = new System.Windows.Forms.ToolStripLabel();
            this.ls2UpdatePeriodCbx = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator33 = new System.Windows.Forms.ToolStripSeparator();
            this.ls2ApplyBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator35 = new System.Windows.Forms.ToolStripSeparator();
            this.localSensorsTopToolStrip = new System.Windows.Forms.ToolStrip();
            this.lsIsPressureBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            this.lsIsTemperatureBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator23 = new System.Windows.Forms.ToolStripSeparator();
            this.lsIsDepthBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator24 = new System.Windows.Forms.ToolStripSeparator();
            this.lsIsVoltageBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator25 = new System.Windows.Forms.ToolStripSeparator();
            this.localSensors1IsSaveToFlashBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator26 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel11 = new System.Windows.Forms.ToolStripLabel();
            this.ls1UpdatePeriodCbx = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator27 = new System.Windows.Forms.ToolStripSeparator();
            this.ls1ApplyBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator36 = new System.Windows.Forms.ToolStripSeparator();
            this.localSensorsBottomToolStrip = new System.Windows.Forms.ToolStrip();
            this.lsChartsClearBtn = new System.Windows.Forms.ToolStripButton();
            this.aqpngTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.aqpngSaveToFlashChb = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.aqpngModeCbx = new System.Windows.Forms.ComboBox();
            this.aqpngPeriodMsEdit = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.aqpngRCTxIDCbx = new System.Windows.Forms.ComboBox();
            this.aqpngRCRxIDCbx = new System.Windows.Forms.ComboBox();
            this.aqpgnDataIDCbx = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.aqpngIsPTModeChb = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.aqpngPTTargetAddressEdit = new System.Windows.Forms.NumericUpDown();
            this.aqpngTopToolStrip = new System.Windows.Forms.ToolStrip();
            this.aqpngQueryBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator37 = new System.Windows.Forms.ToolStripSeparator();
            this.aqpngSetDefaultsBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator38 = new System.Windows.Forms.ToolStripSeparator();
            this.aqpngApplyBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator39 = new System.Windows.Forms.ToolStripSeparator();
            this.logTxb = new System.Windows.Forms.RichTextBox();
            this.logBookToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.logViewClearBtn = new System.Windows.Forms.ToolStripButton();
            this.logViewAutoscrollBtn = new System.Windows.Forms.ToolStripButton();
            this.logViewCopyToClipboardBtn = new System.Windows.Forms.ToolStripButton();
            this.logOpenCurrent2Btn = new System.Windows.Forms.ToolStripButton();
            this.bottomToolStrip = new System.Windows.Forms.ToolStrip();
            this.portStatusLbl = new System.Windows.Forms.ToolStripLabel();
            this.screenShotBtn = new System.Windows.Forms.ToolStripButton();
            this.logLbl = new System.Windows.Forms.ToolStripLabel();
            this.mainToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).BeginInit();
            this.mainSplit.Panel1.SuspendLayout();
            this.mainSplit.Panel2.SuspendLayout();
            this.mainSplit.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.deviceSettingsTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceSettingsSalinityEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceSettingsGravityAccEdit)).BeginInit();
            this.deviceSettingsToolStrip.SuspendLayout();
            this.remReqTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.remoteRequestsBottomToolStrip.SuspendLayout();
            this.remoteRequestsTopToolStrip.SuspendLayout();
            this.ptModeTab.SuspendLayout();
            this.packetModeBottom2ToolStrip.SuspendLayout();
            this.packetModeBottomToolStrip.SuspendLayout();
            this.packetModeTopToolStrip.SuspendLayout();
            this.lsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lsChart)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.localSensorsTopToolStrip.SuspendLayout();
            this.localSensorsBottomToolStrip.SuspendLayout();
            this.aqpngTab.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aqpngPeriodMsEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aqpngPTTargetAddressEdit)).BeginInit();
            this.aqpngTopToolStrip.SuspendLayout();
            this.logBookToolStrip.SuspendLayout();
            this.bottomToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainToolStrip
            // 
            resources.ApplyResources(this.mainToolStrip, "mainToolStrip");
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linkBtn,
            this.toolStripSeparator1,
            this.infoBtn,
            this.logBtn,
            this.toolStripSeparator6,
            this.utilsBtn});
            this.mainToolStrip.Name = "mainToolStrip";
            // 
            // linkBtn
            // 
            this.linkBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.linkBtn, "linkBtn");
            this.linkBtn.Name = "linkBtn";
            this.linkBtn.Click += new System.EventHandler(this.linkBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // infoBtn
            // 
            this.infoBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.infoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.infoBtn, "infoBtn");
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // logBtn
            // 
            this.logBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.logBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOpenCurrentBtn,
            this.logPlaybackBtn,
            this.toolStripSeparator3,
            this.logClearEmptyItemsBtn,
            this.logArchiveAllItemsBtn,
            this.toolStripSeparator4,
            this.logDeleteAllItemsBtn,
            this.logDoThemAllBtn});
            resources.ApplyResources(this.logBtn, "logBtn");
            this.logBtn.Name = "logBtn";
            // 
            // logOpenCurrentBtn
            // 
            resources.ApplyResources(this.logOpenCurrentBtn, "logOpenCurrentBtn");
            this.logOpenCurrentBtn.Name = "logOpenCurrentBtn";
            this.logOpenCurrentBtn.Click += new System.EventHandler(this.logOpenCurrentBtn_Click);
            // 
            // logPlaybackBtn
            // 
            resources.ApplyResources(this.logPlaybackBtn, "logPlaybackBtn");
            this.logPlaybackBtn.Name = "logPlaybackBtn";
            this.logPlaybackBtn.Click += new System.EventHandler(this.logPlaybackBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // logClearEmptyItemsBtn
            // 
            resources.ApplyResources(this.logClearEmptyItemsBtn, "logClearEmptyItemsBtn");
            this.logClearEmptyItemsBtn.Name = "logClearEmptyItemsBtn";
            this.logClearEmptyItemsBtn.Click += new System.EventHandler(this.logClearEmptyItemsBtn_Click);
            // 
            // logArchiveAllItemsBtn
            // 
            resources.ApplyResources(this.logArchiveAllItemsBtn, "logArchiveAllItemsBtn");
            this.logArchiveAllItemsBtn.Name = "logArchiveAllItemsBtn";
            this.logArchiveAllItemsBtn.Click += new System.EventHandler(this.logArchiveAllItemsBtn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // logDeleteAllItemsBtn
            // 
            resources.ApplyResources(this.logDeleteAllItemsBtn, "logDeleteAllItemsBtn");
            this.logDeleteAllItemsBtn.Name = "logDeleteAllItemsBtn";
            this.logDeleteAllItemsBtn.Click += new System.EventHandler(this.logDeleteAllItemsBtn_Click);
            // 
            // logDoThemAllBtn
            // 
            resources.ApplyResources(this.logDoThemAllBtn, "logDoThemAllBtn");
            this.logDoThemAllBtn.Name = "logDoThemAllBtn";
            this.logDoThemAllBtn.Click += new System.EventHandler(this.logDoThemAllBtn_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // utilsBtn
            // 
            this.utilsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.utilsBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilsRunAnotherInstanceBtn,
            this.toolStripSeparator7});
            resources.ApplyResources(this.utilsBtn, "utilsBtn");
            this.utilsBtn.Name = "utilsBtn";
            // 
            // utilsRunAnotherInstanceBtn
            // 
            resources.ApplyResources(this.utilsRunAnotherInstanceBtn, "utilsRunAnotherInstanceBtn");
            this.utilsRunAnotherInstanceBtn.Name = "utilsRunAnotherInstanceBtn";
            this.utilsRunAnotherInstanceBtn.Click += new System.EventHandler(this.utilsRunAnotherInstanceBtn_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // mainSplit
            // 
            resources.ApplyResources(this.mainSplit, "mainSplit");
            this.mainSplit.Name = "mainSplit";
            // 
            // mainSplit.Panel1
            // 
            this.mainSplit.Panel1.Controls.Add(this.mainTabControl);
            // 
            // mainSplit.Panel2
            // 
            this.mainSplit.Panel2.Controls.Add(this.logTxb);
            this.mainSplit.Panel2.Controls.Add(this.logBookToolStrip);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.deviceSettingsTab);
            this.mainTabControl.Controls.Add(this.remReqTab);
            this.mainTabControl.Controls.Add(this.ptModeTab);
            this.mainTabControl.Controls.Add(this.lsTab);
            this.mainTabControl.Controls.Add(this.aqpngTab);
            resources.ApplyResources(this.mainTabControl, "mainTabControl");
            this.mainTabControl.HotTrack = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.mainTabControl_Selecting);
            // 
            // deviceSettingsTab
            // 
            this.deviceSettingsTab.Controls.Add(this.tableLayoutPanel1);
            this.deviceSettingsTab.Controls.Add(this.deviceInfoTxb);
            this.deviceSettingsTab.Controls.Add(this.deviceSettingsToolStrip);
            resources.ApplyResources(this.deviceSettingsTab, "deviceSettingsTab");
            this.deviceSettingsTab.Name = "deviceSettingsTab";
            this.deviceSettingsTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.deviceSettingsSalinityEdit, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.deviceSettingsGravityAccEdit, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.deviceSettingsCommandModeByDefaultChb, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.deviceSettingsACKonTxFinishedChb, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.deviceSettingsTxChIDCbx, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.deviceSettingsRxChIDCbx, 1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // deviceSettingsSalinityEdit
            // 
            this.deviceSettingsSalinityEdit.DecimalPlaces = 1;
            resources.ApplyResources(this.deviceSettingsSalinityEdit, "deviceSettingsSalinityEdit");
            this.deviceSettingsSalinityEdit.Name = "deviceSettingsSalinityEdit";
            // 
            // deviceSettingsGravityAccEdit
            // 
            this.deviceSettingsGravityAccEdit.DecimalPlaces = 4;
            resources.ApplyResources(this.deviceSettingsGravityAccEdit, "deviceSettingsGravityAccEdit");
            this.deviceSettingsGravityAccEdit.Name = "deviceSettingsGravityAccEdit";
            // 
            // deviceSettingsCommandModeByDefaultChb
            // 
            resources.ApplyResources(this.deviceSettingsCommandModeByDefaultChb, "deviceSettingsCommandModeByDefaultChb");
            this.deviceSettingsCommandModeByDefaultChb.Name = "deviceSettingsCommandModeByDefaultChb";
            this.deviceSettingsCommandModeByDefaultChb.UseVisualStyleBackColor = true;
            // 
            // deviceSettingsACKonTxFinishedChb
            // 
            resources.ApplyResources(this.deviceSettingsACKonTxFinishedChb, "deviceSettingsACKonTxFinishedChb");
            this.deviceSettingsACKonTxFinishedChb.Name = "deviceSettingsACKonTxFinishedChb";
            this.deviceSettingsACKonTxFinishedChb.UseVisualStyleBackColor = true;
            // 
            // deviceSettingsTxChIDCbx
            // 
            this.deviceSettingsTxChIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceSettingsTxChIDCbx.FormattingEnabled = true;
            resources.ApplyResources(this.deviceSettingsTxChIDCbx, "deviceSettingsTxChIDCbx");
            this.deviceSettingsTxChIDCbx.Name = "deviceSettingsTxChIDCbx";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // deviceSettingsRxChIDCbx
            // 
            this.deviceSettingsRxChIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deviceSettingsRxChIDCbx.FormattingEnabled = true;
            resources.ApplyResources(this.deviceSettingsRxChIDCbx, "deviceSettingsRxChIDCbx");
            this.deviceSettingsRxChIDCbx.Name = "deviceSettingsRxChIDCbx";
            // 
            // deviceInfoTxb
            // 
            resources.ApplyResources(this.deviceInfoTxb, "deviceInfoTxb");
            this.deviceInfoTxb.AutoWordSelection = true;
            this.deviceInfoTxb.Name = "deviceInfoTxb";
            this.deviceInfoTxb.ReadOnly = true;
            // 
            // deviceSettingsToolStrip
            // 
            resources.ApplyResources(this.deviceSettingsToolStrip, "deviceSettingsToolStrip");
            this.deviceSettingsToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.deviceSettingsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryDeviceInfoBtn,
            this.toolStripSeparator8,
            this.defaultDeviceSettingsBtn,
            this.toolStripSeparator17,
            this.applyDeviceSettingsBtn,
            this.toolStripSeparator34});
            this.deviceSettingsToolStrip.Name = "deviceSettingsToolStrip";
            // 
            // queryDeviceInfoBtn
            // 
            this.queryDeviceInfoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.queryDeviceInfoBtn, "queryDeviceInfoBtn");
            this.queryDeviceInfoBtn.Name = "queryDeviceInfoBtn";
            this.queryDeviceInfoBtn.Click += new System.EventHandler(this.queryDeviceInfoBtn_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            // 
            // defaultDeviceSettingsBtn
            // 
            this.defaultDeviceSettingsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.defaultDeviceSettingsBtn, "defaultDeviceSettingsBtn");
            this.defaultDeviceSettingsBtn.Name = "defaultDeviceSettingsBtn";
            this.defaultDeviceSettingsBtn.Click += new System.EventHandler(this.defaultDeviceSettingsBtn_Click);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            resources.ApplyResources(this.toolStripSeparator17, "toolStripSeparator17");
            // 
            // applyDeviceSettingsBtn
            // 
            this.applyDeviceSettingsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.applyDeviceSettingsBtn, "applyDeviceSettingsBtn");
            this.applyDeviceSettingsBtn.Name = "applyDeviceSettingsBtn";
            this.applyDeviceSettingsBtn.Click += new System.EventHandler(this.applyDeviceSettingsBtn_Click);
            // 
            // toolStripSeparator34
            // 
            this.toolStripSeparator34.Name = "toolStripSeparator34";
            resources.ApplyResources(this.toolStripSeparator34, "toolStripSeparator34");
            // 
            // remReqTab
            // 
            this.remReqTab.Controls.Add(this.splitContainer1);
            this.remReqTab.Controls.Add(this.remoteRequestsBottomToolStrip);
            this.remReqTab.Controls.Add(this.remoteRequestsTopToolStrip);
            resources.ApplyResources(this.remReqTab, "remReqTab");
            this.remReqTab.Name = "remReqTab";
            this.remReqTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.remReqTxb);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.remReqStatTxb);
            // 
            // remReqTxb
            // 
            resources.ApplyResources(this.remReqTxb, "remReqTxb");
            this.remReqTxb.Name = "remReqTxb";
            this.remReqTxb.ReadOnly = true;
            this.remReqTxb.TextChanged += new System.EventHandler(this.remReqTxb_TextChanged);
            // 
            // remReqStatTxb
            // 
            resources.ApplyResources(this.remReqStatTxb, "remReqStatTxb");
            this.remReqStatTxb.Name = "remReqStatTxb";
            this.remReqStatTxb.ReadOnly = true;
            // 
            // remoteRequestsBottomToolStrip
            // 
            resources.ApplyResources(this.remoteRequestsBottomToolStrip, "remoteRequestsBottomToolStrip");
            this.remoteRequestsBottomToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.remoteRequestsBottomToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remReqTxbClearBtn,
            this.remReqTxbIsAutoscrollBtn,
            this.remReqTxbCopy2ClipboardBtn});
            this.remoteRequestsBottomToolStrip.Name = "remoteRequestsBottomToolStrip";
            // 
            // remReqTxbClearBtn
            // 
            this.remReqTxbClearBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.remReqTxbClearBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.remReqTxbClearBtn, "remReqTxbClearBtn");
            this.remReqTxbClearBtn.Name = "remReqTxbClearBtn";
            this.remReqTxbClearBtn.Click += new System.EventHandler(this.remReqTxbClearBtn_Click);
            // 
            // remReqTxbIsAutoscrollBtn
            // 
            this.remReqTxbIsAutoscrollBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.remReqTxbIsAutoscrollBtn.Checked = true;
            this.remReqTxbIsAutoscrollBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.remReqTxbIsAutoscrollBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.remReqTxbIsAutoscrollBtn, "remReqTxbIsAutoscrollBtn");
            this.remReqTxbIsAutoscrollBtn.Name = "remReqTxbIsAutoscrollBtn";
            this.remReqTxbIsAutoscrollBtn.Click += new System.EventHandler(this.remReqTxbIsAutoscrollBtn_Click);
            // 
            // remReqTxbCopy2ClipboardBtn
            // 
            this.remReqTxbCopy2ClipboardBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.remReqTxbCopy2ClipboardBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.remReqTxbCopy2ClipboardBtn, "remReqTxbCopy2ClipboardBtn");
            this.remReqTxbCopy2ClipboardBtn.Name = "remReqTxbCopy2ClipboardBtn";
            this.remReqTxbCopy2ClipboardBtn.Click += new System.EventHandler(this.remReqTxbCopy2ClipboardBtn_Click);
            // 
            // remoteRequestsTopToolStrip
            // 
            resources.ApplyResources(this.remoteRequestsTopToolStrip, "remoteRequestsTopToolStrip");
            this.remoteRequestsTopToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.remoteRequestsTopToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.remReqTxChIDCbx,
            this.toolStripSeparator9,
            this.toolStripLabel3,
            this.remReqRxChIDCbx,
            this.toolStripSeparator10,
            this.toolStripLabel4,
            this.remReqIDCbx,
            this.toolStripSeparator11,
            this.isRemoteRequestsAutoChb,
            this.toolStripSeparator12,
            this.remReqSendBtn,
            this.toolStripSeparator30});
            this.remoteRequestsTopToolStrip.Name = "remoteRequestsTopToolStrip";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            resources.ApplyResources(this.toolStripLabel2, "toolStripLabel2");
            // 
            // remReqTxChIDCbx
            // 
            this.remReqTxChIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.remReqTxChIDCbx.DropDownWidth = 100;
            this.remReqTxChIDCbx.Name = "remReqTxChIDCbx";
            resources.ApplyResources(this.remReqTxChIDCbx, "remReqTxChIDCbx");
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            resources.ApplyResources(this.toolStripLabel3, "toolStripLabel3");
            // 
            // remReqRxChIDCbx
            // 
            this.remReqRxChIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.remReqRxChIDCbx.Name = "remReqRxChIDCbx";
            resources.ApplyResources(this.remReqRxChIDCbx, "remReqRxChIDCbx");
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            resources.ApplyResources(this.toolStripSeparator10, "toolStripSeparator10");
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            resources.ApplyResources(this.toolStripLabel4, "toolStripLabel4");
            // 
            // remReqIDCbx
            // 
            this.remReqIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.remReqIDCbx.DropDownWidth = 200;
            this.remReqIDCbx.Name = "remReqIDCbx";
            resources.ApplyResources(this.remReqIDCbx, "remReqIDCbx");
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            resources.ApplyResources(this.toolStripSeparator11, "toolStripSeparator11");
            // 
            // isRemoteRequestsAutoChb
            // 
            this.isRemoteRequestsAutoChb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.isRemoteRequestsAutoChb, "isRemoteRequestsAutoChb");
            this.isRemoteRequestsAutoChb.Name = "isRemoteRequestsAutoChb";
            this.isRemoteRequestsAutoChb.Click += new System.EventHandler(this.isRemoteRequestsAutoChb_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            resources.ApplyResources(this.toolStripSeparator12, "toolStripSeparator12");
            // 
            // remReqSendBtn
            // 
            this.remReqSendBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.remReqSendBtn, "remReqSendBtn");
            this.remReqSendBtn.Name = "remReqSendBtn";
            this.remReqSendBtn.Click += new System.EventHandler(this.remReqSendBtn_Click);
            // 
            // toolStripSeparator30
            // 
            this.toolStripSeparator30.Name = "toolStripSeparator30";
            resources.ApplyResources(this.toolStripSeparator30, "toolStripSeparator30");
            // 
            // ptModeTab
            // 
            this.ptModeTab.Controls.Add(this.packetModeLogTxb);
            this.ptModeTab.Controls.Add(this.packetModeBottom2ToolStrip);
            this.ptModeTab.Controls.Add(this.packetModeBottomToolStrip);
            this.ptModeTab.Controls.Add(this.packetModeTopToolStrip);
            resources.ApplyResources(this.ptModeTab, "ptModeTab");
            this.ptModeTab.Name = "ptModeTab";
            this.ptModeTab.UseVisualStyleBackColor = true;
            // 
            // packetModeLogTxb
            // 
            resources.ApplyResources(this.packetModeLogTxb, "packetModeLogTxb");
            this.packetModeLogTxb.Name = "packetModeLogTxb";
            this.packetModeLogTxb.ReadOnly = true;
            this.packetModeLogTxb.TextChanged += new System.EventHandler(this.packetModeLogTxb_TextChanged);
            // 
            // packetModeBottom2ToolStrip
            // 
            resources.ApplyResources(this.packetModeBottom2ToolStrip, "packetModeBottom2ToolStrip");
            this.packetModeBottom2ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.packetModeBottom2ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ptModeTxbClearBtn,
            this.ptModeTxbAutoscrollBtn,
            this.ptTxbCopyToClipboardBtn,
            this.toolStripLabel9,
            this.ptModeRequestTargetAddressCbx,
            this.toolStripSeparator19,
            this.toolStripLabel10,
            this.ptModeRequestDataIDCbx,
            this.toolStripSeparator20,
            this.ptModeSendRequestBtn,
            this.toolStripSeparator21});
            this.packetModeBottom2ToolStrip.Name = "packetModeBottom2ToolStrip";
            // 
            // ptModeTxbClearBtn
            // 
            this.ptModeTxbClearBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ptModeTxbClearBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.ptModeTxbClearBtn, "ptModeTxbClearBtn");
            this.ptModeTxbClearBtn.Name = "ptModeTxbClearBtn";
            this.ptModeTxbClearBtn.Click += new System.EventHandler(this.ptModeTxbClearBtn_Click);
            // 
            // ptModeTxbAutoscrollBtn
            // 
            this.ptModeTxbAutoscrollBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ptModeTxbAutoscrollBtn.Checked = true;
            this.ptModeTxbAutoscrollBtn.CheckOnClick = true;
            this.ptModeTxbAutoscrollBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ptModeTxbAutoscrollBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.ptModeTxbAutoscrollBtn, "ptModeTxbAutoscrollBtn");
            this.ptModeTxbAutoscrollBtn.Name = "ptModeTxbAutoscrollBtn";
            // 
            // ptTxbCopyToClipboardBtn
            // 
            this.ptTxbCopyToClipboardBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ptTxbCopyToClipboardBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.ptTxbCopyToClipboardBtn, "ptTxbCopyToClipboardBtn");
            this.ptTxbCopyToClipboardBtn.Name = "ptTxbCopyToClipboardBtn";
            this.ptTxbCopyToClipboardBtn.Click += new System.EventHandler(this.ptTxbCopyToClipboardBtn_Click);
            // 
            // toolStripLabel9
            // 
            this.toolStripLabel9.Name = "toolStripLabel9";
            resources.ApplyResources(this.toolStripLabel9, "toolStripLabel9");
            // 
            // ptModeRequestTargetAddressCbx
            // 
            this.ptModeRequestTargetAddressCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.ptModeRequestTargetAddressCbx, "ptModeRequestTargetAddressCbx");
            this.ptModeRequestTargetAddressCbx.Name = "ptModeRequestTargetAddressCbx";
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            resources.ApplyResources(this.toolStripSeparator19, "toolStripSeparator19");
            // 
            // toolStripLabel10
            // 
            this.toolStripLabel10.Name = "toolStripLabel10";
            resources.ApplyResources(this.toolStripLabel10, "toolStripLabel10");
            // 
            // ptModeRequestDataIDCbx
            // 
            this.ptModeRequestDataIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.ptModeRequestDataIDCbx, "ptModeRequestDataIDCbx");
            this.ptModeRequestDataIDCbx.Name = "ptModeRequestDataIDCbx";
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            resources.ApplyResources(this.toolStripSeparator20, "toolStripSeparator20");
            // 
            // ptModeSendRequestBtn
            // 
            this.ptModeSendRequestBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.ptModeSendRequestBtn, "ptModeSendRequestBtn");
            this.ptModeSendRequestBtn.Name = "ptModeSendRequestBtn";
            this.ptModeSendRequestBtn.Click += new System.EventHandler(this.ptModeSendRequestBtn_Click);
            // 
            // toolStripSeparator21
            // 
            this.toolStripSeparator21.Name = "toolStripSeparator21";
            resources.ApplyResources(this.toolStripSeparator21, "toolStripSeparator21");
            // 
            // packetModeBottomToolStrip
            // 
            resources.ApplyResources(this.packetModeBottomToolStrip, "packetModeBottomToolStrip");
            this.packetModeBottomToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.packetModeBottomToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel6,
            this.ptModePacketTargetAddressCbx,
            this.toolStripSeparator15,
            this.toolStripLabel7,
            this.ptModePacketTriesCbx,
            this.toolStripSeparator16,
            this.toolStripLabel8,
            this.ptModePacketTxb,
            this.ptModePacketSendBtn,
            this.ptModePacketSendAbortBtn,
            this.toolStripSeparator18});
            this.packetModeBottomToolStrip.Name = "packetModeBottomToolStrip";
            // 
            // toolStripLabel6
            // 
            resources.ApplyResources(this.toolStripLabel6, "toolStripLabel6");
            this.toolStripLabel6.Name = "toolStripLabel6";
            // 
            // ptModePacketTargetAddressCbx
            // 
            this.ptModePacketTargetAddressCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.ptModePacketTargetAddressCbx, "ptModePacketTargetAddressCbx");
            this.ptModePacketTargetAddressCbx.Name = "ptModePacketTargetAddressCbx";
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            resources.ApplyResources(this.toolStripSeparator15, "toolStripSeparator15");
            // 
            // toolStripLabel7
            // 
            resources.ApplyResources(this.toolStripLabel7, "toolStripLabel7");
            this.toolStripLabel7.Name = "toolStripLabel7";
            // 
            // ptModePacketTriesCbx
            // 
            this.ptModePacketTriesCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.ptModePacketTriesCbx, "ptModePacketTriesCbx");
            this.ptModePacketTriesCbx.Name = "ptModePacketTriesCbx";
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            resources.ApplyResources(this.toolStripSeparator16, "toolStripSeparator16");
            // 
            // toolStripLabel8
            // 
            resources.ApplyResources(this.toolStripLabel8, "toolStripLabel8");
            this.toolStripLabel8.Name = "toolStripLabel8";
            // 
            // ptModePacketTxb
            // 
            resources.ApplyResources(this.ptModePacketTxb, "ptModePacketTxb");
            this.ptModePacketTxb.Name = "ptModePacketTxb";
            this.ptModePacketTxb.TextChanged += new System.EventHandler(this.ptModePacketTxb_TextChanged);
            // 
            // ptModePacketSendBtn
            // 
            this.ptModePacketSendBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.ptModePacketSendBtn, "ptModePacketSendBtn");
            this.ptModePacketSendBtn.Name = "ptModePacketSendBtn";
            this.ptModePacketSendBtn.Click += new System.EventHandler(this.ptModePacketSendBtn_Click);
            // 
            // ptModePacketSendAbortBtn
            // 
            this.ptModePacketSendAbortBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ptModePacketSendAbortBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.ptModePacketSendAbortBtn, "ptModePacketSendAbortBtn");
            this.ptModePacketSendAbortBtn.Name = "ptModePacketSendAbortBtn";
            this.ptModePacketSendAbortBtn.Click += new System.EventHandler(this.ptModePacketSendAbortBtn_Click);
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            resources.ApplyResources(this.toolStripSeparator18, "toolStripSeparator18");
            // 
            // packetModeTopToolStrip
            // 
            resources.ApplyResources(this.packetModeTopToolStrip, "packetModeTopToolStrip");
            this.packetModeTopToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.packetModeTopToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel5,
            this.ptModeLocalAddressCbx,
            this.toolStripSeparator13,
            this.packetModeIsSaveToFlashBtn,
            this.toolStripSeparator14,
            this.ptModeQuerySettingsBtn,
            this.toolStripSeparator28,
            this.ptModeApplySettingsBtn,
            this.toolStripSeparator29});
            this.packetModeTopToolStrip.Name = "packetModeTopToolStrip";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            resources.ApplyResources(this.toolStripLabel5, "toolStripLabel5");
            // 
            // ptModeLocalAddressCbx
            // 
            this.ptModeLocalAddressCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ptModeLocalAddressCbx.Name = "ptModeLocalAddressCbx";
            resources.ApplyResources(this.ptModeLocalAddressCbx, "ptModeLocalAddressCbx");
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            resources.ApplyResources(this.toolStripSeparator13, "toolStripSeparator13");
            // 
            // packetModeIsSaveToFlashBtn
            // 
            this.packetModeIsSaveToFlashBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.packetModeIsSaveToFlashBtn, "packetModeIsSaveToFlashBtn");
            this.packetModeIsSaveToFlashBtn.Name = "packetModeIsSaveToFlashBtn";
            this.packetModeIsSaveToFlashBtn.Click += new System.EventHandler(this.packetModeIsSaveToFlashBtn_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            resources.ApplyResources(this.toolStripSeparator14, "toolStripSeparator14");
            // 
            // ptModeQuerySettingsBtn
            // 
            this.ptModeQuerySettingsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.ptModeQuerySettingsBtn, "ptModeQuerySettingsBtn");
            this.ptModeQuerySettingsBtn.Name = "ptModeQuerySettingsBtn";
            this.ptModeQuerySettingsBtn.Click += new System.EventHandler(this.ptModeQuerySettingsBtn_Click);
            // 
            // toolStripSeparator28
            // 
            this.toolStripSeparator28.Name = "toolStripSeparator28";
            resources.ApplyResources(this.toolStripSeparator28, "toolStripSeparator28");
            // 
            // ptModeApplySettingsBtn
            // 
            this.ptModeApplySettingsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.ptModeApplySettingsBtn, "ptModeApplySettingsBtn");
            this.ptModeApplySettingsBtn.Name = "ptModeApplySettingsBtn";
            this.ptModeApplySettingsBtn.Click += new System.EventHandler(this.ptModeApplySettingsBtn_Click);
            // 
            // toolStripSeparator29
            // 
            this.toolStripSeparator29.Name = "toolStripSeparator29";
            resources.ApplyResources(this.toolStripSeparator29, "toolStripSeparator29");
            // 
            // lsTab
            // 
            this.lsTab.Controls.Add(this.lsChart);
            this.lsTab.Controls.Add(this.toolStrip1);
            this.lsTab.Controls.Add(this.localSensorsTopToolStrip);
            this.lsTab.Controls.Add(this.localSensorsBottomToolStrip);
            resources.ApplyResources(this.lsTab, "lsTab");
            this.lsTab.Name = "lsTab";
            this.lsTab.UseVisualStyleBackColor = true;
            // 
            // lsChart
            // 
            chartArea1.Name = "PressureChartArea";
            chartArea2.Name = "TemperatureChartArea";
            chartArea3.Name = "DepthChartArea";
            chartArea4.Name = "VoltageChartArea";
            chartArea5.Name = "PitchArea";
            chartArea5.Visible = false;
            chartArea6.Name = "RollChartArea";
            chartArea6.Visible = false;
            this.lsChart.ChartAreas.Add(chartArea1);
            this.lsChart.ChartAreas.Add(chartArea2);
            this.lsChart.ChartAreas.Add(chartArea3);
            this.lsChart.ChartAreas.Add(chartArea4);
            this.lsChart.ChartAreas.Add(chartArea5);
            this.lsChart.ChartAreas.Add(chartArea6);
            resources.ApplyResources(this.lsChart, "lsChart");
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Font = new System.Drawing.Font("Segoe UI", 8F);
            legend1.IsEquallySpacedItems = true;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.lsChart.Legends.Add(legend1);
            this.lsChart.Name = "lsChart";
            series1.BorderWidth = 5;
            series1.ChartArea = "PressureChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "Pressure, mBar";
            series1.Name = "Pressure";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderWidth = 5;
            series2.ChartArea = "TemperatureChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "Temperature, °C";
            series2.Name = "Temperature";
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.BorderWidth = 5;
            series3.ChartArea = "DepthChartArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.LegendText = "Depth, m";
            series3.Name = "Depth";
            series4.BorderWidth = 5;
            series4.ChartArea = "VoltageChartArea";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.LegendText = "Voltage, V";
            series4.Name = "Voltage";
            series5.BorderWidth = 5;
            series5.ChartArea = "PitchArea";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.LegendText = "Pitch, °";
            series5.Name = "Pitch";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series6.BorderWidth = 5;
            series6.ChartArea = "RollChartArea";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.LegendText = "Roll, °";
            series6.Name = "Roll";
            this.lsChart.Series.Add(series1);
            this.lsChart.Series.Add(series2);
            this.lsChart.Series.Add(series3);
            this.lsChart.Series.Add(series4);
            this.lsChart.Series.Add(series5);
            this.lsChart.Series.Add(series6);
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton26,
            this.toolStripSeparator31,
            this.localSensors2IsSaveToFlashBtn,
            this.toolStripSeparator32,
            this.toolStripLabel12,
            this.ls2UpdatePeriodCbx,
            this.toolStripSeparator33,
            this.ls2ApplyBtn,
            this.toolStripSeparator35});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripButton26
            // 
            this.toolStripButton26.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.toolStripButton26, "toolStripButton26");
            this.toolStripButton26.Name = "toolStripButton26";
            // 
            // toolStripSeparator31
            // 
            this.toolStripSeparator31.Name = "toolStripSeparator31";
            resources.ApplyResources(this.toolStripSeparator31, "toolStripSeparator31");
            // 
            // localSensors2IsSaveToFlashBtn
            // 
            this.localSensors2IsSaveToFlashBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.localSensors2IsSaveToFlashBtn, "localSensors2IsSaveToFlashBtn");
            this.localSensors2IsSaveToFlashBtn.Name = "localSensors2IsSaveToFlashBtn";
            this.localSensors2IsSaveToFlashBtn.Click += new System.EventHandler(this.localSensors2IsSaveToFlashBtn_Click);
            // 
            // toolStripSeparator32
            // 
            this.toolStripSeparator32.Name = "toolStripSeparator32";
            resources.ApplyResources(this.toolStripSeparator32, "toolStripSeparator32");
            // 
            // toolStripLabel12
            // 
            this.toolStripLabel12.Name = "toolStripLabel12";
            resources.ApplyResources(this.toolStripLabel12, "toolStripLabel12");
            // 
            // ls2UpdatePeriodCbx
            // 
            this.ls2UpdatePeriodCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ls2UpdatePeriodCbx.Name = "ls2UpdatePeriodCbx";
            resources.ApplyResources(this.ls2UpdatePeriodCbx, "ls2UpdatePeriodCbx");
            // 
            // toolStripSeparator33
            // 
            this.toolStripSeparator33.Name = "toolStripSeparator33";
            resources.ApplyResources(this.toolStripSeparator33, "toolStripSeparator33");
            // 
            // ls2ApplyBtn
            // 
            this.ls2ApplyBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.ls2ApplyBtn, "ls2ApplyBtn");
            this.ls2ApplyBtn.Name = "ls2ApplyBtn";
            this.ls2ApplyBtn.Click += new System.EventHandler(this.ls2ApplyBtn_Click);
            // 
            // toolStripSeparator35
            // 
            this.toolStripSeparator35.Name = "toolStripSeparator35";
            resources.ApplyResources(this.toolStripSeparator35, "toolStripSeparator35");
            // 
            // localSensorsTopToolStrip
            // 
            resources.ApplyResources(this.localSensorsTopToolStrip, "localSensorsTopToolStrip");
            this.localSensorsTopToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.localSensorsTopToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lsIsPressureBtn,
            this.toolStripSeparator22,
            this.lsIsTemperatureBtn,
            this.toolStripSeparator23,
            this.lsIsDepthBtn,
            this.toolStripSeparator24,
            this.lsIsVoltageBtn,
            this.toolStripSeparator25,
            this.localSensors1IsSaveToFlashBtn,
            this.toolStripSeparator26,
            this.toolStripLabel11,
            this.ls1UpdatePeriodCbx,
            this.toolStripSeparator27,
            this.ls1ApplyBtn,
            this.toolStripSeparator36});
            this.localSensorsTopToolStrip.Name = "localSensorsTopToolStrip";
            // 
            // lsIsPressureBtn
            // 
            this.lsIsPressureBtn.CheckOnClick = true;
            this.lsIsPressureBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.lsIsPressureBtn, "lsIsPressureBtn");
            this.lsIsPressureBtn.Name = "lsIsPressureBtn";
            // 
            // toolStripSeparator22
            // 
            this.toolStripSeparator22.Name = "toolStripSeparator22";
            resources.ApplyResources(this.toolStripSeparator22, "toolStripSeparator22");
            // 
            // lsIsTemperatureBtn
            // 
            this.lsIsTemperatureBtn.CheckOnClick = true;
            this.lsIsTemperatureBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.lsIsTemperatureBtn, "lsIsTemperatureBtn");
            this.lsIsTemperatureBtn.Name = "lsIsTemperatureBtn";
            // 
            // toolStripSeparator23
            // 
            this.toolStripSeparator23.Name = "toolStripSeparator23";
            resources.ApplyResources(this.toolStripSeparator23, "toolStripSeparator23");
            // 
            // lsIsDepthBtn
            // 
            this.lsIsDepthBtn.CheckOnClick = true;
            this.lsIsDepthBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.lsIsDepthBtn, "lsIsDepthBtn");
            this.lsIsDepthBtn.Name = "lsIsDepthBtn";
            // 
            // toolStripSeparator24
            // 
            this.toolStripSeparator24.Name = "toolStripSeparator24";
            resources.ApplyResources(this.toolStripSeparator24, "toolStripSeparator24");
            // 
            // lsIsVoltageBtn
            // 
            this.lsIsVoltageBtn.CheckOnClick = true;
            this.lsIsVoltageBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.lsIsVoltageBtn, "lsIsVoltageBtn");
            this.lsIsVoltageBtn.Name = "lsIsVoltageBtn";
            // 
            // toolStripSeparator25
            // 
            this.toolStripSeparator25.Name = "toolStripSeparator25";
            resources.ApplyResources(this.toolStripSeparator25, "toolStripSeparator25");
            // 
            // localSensors1IsSaveToFlashBtn
            // 
            this.localSensors1IsSaveToFlashBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.localSensors1IsSaveToFlashBtn, "localSensors1IsSaveToFlashBtn");
            this.localSensors1IsSaveToFlashBtn.Name = "localSensors1IsSaveToFlashBtn";
            this.localSensors1IsSaveToFlashBtn.Click += new System.EventHandler(this.localSensors1IsSaveToFlashBtn_Click);
            // 
            // toolStripSeparator26
            // 
            this.toolStripSeparator26.Name = "toolStripSeparator26";
            resources.ApplyResources(this.toolStripSeparator26, "toolStripSeparator26");
            // 
            // toolStripLabel11
            // 
            this.toolStripLabel11.Name = "toolStripLabel11";
            resources.ApplyResources(this.toolStripLabel11, "toolStripLabel11");
            // 
            // ls1UpdatePeriodCbx
            // 
            this.ls1UpdatePeriodCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ls1UpdatePeriodCbx.Name = "ls1UpdatePeriodCbx";
            resources.ApplyResources(this.ls1UpdatePeriodCbx, "ls1UpdatePeriodCbx");
            // 
            // toolStripSeparator27
            // 
            this.toolStripSeparator27.Name = "toolStripSeparator27";
            resources.ApplyResources(this.toolStripSeparator27, "toolStripSeparator27");
            // 
            // ls1ApplyBtn
            // 
            this.ls1ApplyBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.ls1ApplyBtn, "ls1ApplyBtn");
            this.ls1ApplyBtn.Name = "ls1ApplyBtn";
            this.ls1ApplyBtn.Click += new System.EventHandler(this.ls1ApplyBtn_Click);
            // 
            // toolStripSeparator36
            // 
            this.toolStripSeparator36.Name = "toolStripSeparator36";
            resources.ApplyResources(this.toolStripSeparator36, "toolStripSeparator36");
            // 
            // localSensorsBottomToolStrip
            // 
            resources.ApplyResources(this.localSensorsBottomToolStrip, "localSensorsBottomToolStrip");
            this.localSensorsBottomToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.localSensorsBottomToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lsChartsClearBtn});
            this.localSensorsBottomToolStrip.Name = "localSensorsBottomToolStrip";
            // 
            // lsChartsClearBtn
            // 
            this.lsChartsClearBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lsChartsClearBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.lsChartsClearBtn, "lsChartsClearBtn");
            this.lsChartsClearBtn.Name = "lsChartsClearBtn";
            this.lsChartsClearBtn.Click += new System.EventHandler(this.lsChartClearBtn_Click);
            // 
            // aqpngTab
            // 
            this.aqpngTab.Controls.Add(this.tableLayoutPanel2);
            this.aqpngTab.Controls.Add(this.aqpngTopToolStrip);
            resources.ApplyResources(this.aqpngTab, "aqpngTab");
            this.aqpngTab.Name = "aqpngTab";
            this.aqpngTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.aqpngSaveToFlashChb, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.aqpngModeCbx, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.aqpngPeriodMsEdit, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.aqpngRCTxIDCbx, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.aqpngRCRxIDCbx, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.aqpgnDataIDCbx, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.aqpngIsPTModeChb, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.aqpngPTTargetAddressEdit, 1, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // aqpngSaveToFlashChb
            // 
            resources.ApplyResources(this.aqpngSaveToFlashChb, "aqpngSaveToFlashChb");
            this.aqpngSaveToFlashChb.Name = "aqpngSaveToFlashChb";
            this.aqpngSaveToFlashChb.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // aqpngModeCbx
            // 
            this.aqpngModeCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aqpngModeCbx.FormattingEnabled = true;
            resources.ApplyResources(this.aqpngModeCbx, "aqpngModeCbx");
            this.aqpngModeCbx.Name = "aqpngModeCbx";
            this.aqpngModeCbx.SelectedIndexChanged += new System.EventHandler(this.aqpngModeCbx_SelectedIndexChanged);
            // 
            // aqpngPeriodMsEdit
            // 
            resources.ApplyResources(this.aqpngPeriodMsEdit, "aqpngPeriodMsEdit");
            this.aqpngPeriodMsEdit.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.aqpngPeriodMsEdit.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.aqpngPeriodMsEdit.Name = "aqpngPeriodMsEdit";
            this.aqpngPeriodMsEdit.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // aqpngRCTxIDCbx
            // 
            this.aqpngRCTxIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aqpngRCTxIDCbx.FormattingEnabled = true;
            resources.ApplyResources(this.aqpngRCTxIDCbx, "aqpngRCTxIDCbx");
            this.aqpngRCTxIDCbx.Name = "aqpngRCTxIDCbx";
            // 
            // aqpngRCRxIDCbx
            // 
            this.aqpngRCRxIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aqpngRCRxIDCbx.FormattingEnabled = true;
            resources.ApplyResources(this.aqpngRCRxIDCbx, "aqpngRCRxIDCbx");
            this.aqpngRCRxIDCbx.Name = "aqpngRCRxIDCbx";
            // 
            // aqpgnDataIDCbx
            // 
            this.aqpgnDataIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aqpgnDataIDCbx.FormattingEnabled = true;
            resources.ApplyResources(this.aqpgnDataIDCbx, "aqpgnDataIDCbx");
            this.aqpgnDataIDCbx.Name = "aqpgnDataIDCbx";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // aqpngIsPTModeChb
            // 
            resources.ApplyResources(this.aqpngIsPTModeChb, "aqpngIsPTModeChb");
            this.aqpngIsPTModeChb.Name = "aqpngIsPTModeChb";
            this.aqpngIsPTModeChb.UseVisualStyleBackColor = true;
            this.aqpngIsPTModeChb.CheckedChanged += new System.EventHandler(this.aqpngIsPTModeChb_CheckedChanged);
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // aqpngPTTargetAddressEdit
            // 
            resources.ApplyResources(this.aqpngPTTargetAddressEdit, "aqpngPTTargetAddressEdit");
            this.aqpngPTTargetAddressEdit.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.aqpngPTTargetAddressEdit.Name = "aqpngPTTargetAddressEdit";
            // 
            // aqpngTopToolStrip
            // 
            resources.ApplyResources(this.aqpngTopToolStrip, "aqpngTopToolStrip");
            this.aqpngTopToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.aqpngTopToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aqpngQueryBtn,
            this.toolStripSeparator37,
            this.aqpngSetDefaultsBtn,
            this.toolStripSeparator38,
            this.aqpngApplyBtn,
            this.toolStripSeparator39});
            this.aqpngTopToolStrip.Name = "aqpngTopToolStrip";
            // 
            // aqpngQueryBtn
            // 
            this.aqpngQueryBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.aqpngQueryBtn, "aqpngQueryBtn");
            this.aqpngQueryBtn.Name = "aqpngQueryBtn";
            this.aqpngQueryBtn.Click += new System.EventHandler(this.aqpngQueryBtn_Click);
            // 
            // toolStripSeparator37
            // 
            this.toolStripSeparator37.Name = "toolStripSeparator37";
            resources.ApplyResources(this.toolStripSeparator37, "toolStripSeparator37");
            // 
            // aqpngSetDefaultsBtn
            // 
            this.aqpngSetDefaultsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.aqpngSetDefaultsBtn, "aqpngSetDefaultsBtn");
            this.aqpngSetDefaultsBtn.Name = "aqpngSetDefaultsBtn";
            this.aqpngSetDefaultsBtn.Click += new System.EventHandler(this.aqpngSetDefaultsBtn_Click);
            // 
            // toolStripSeparator38
            // 
            this.toolStripSeparator38.Name = "toolStripSeparator38";
            resources.ApplyResources(this.toolStripSeparator38, "toolStripSeparator38");
            // 
            // aqpngApplyBtn
            // 
            this.aqpngApplyBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.aqpngApplyBtn, "aqpngApplyBtn");
            this.aqpngApplyBtn.Name = "aqpngApplyBtn";
            this.aqpngApplyBtn.Click += new System.EventHandler(this.aqpngApplyBtn_Click);
            // 
            // toolStripSeparator39
            // 
            this.toolStripSeparator39.Name = "toolStripSeparator39";
            resources.ApplyResources(this.toolStripSeparator39, "toolStripSeparator39");
            // 
            // logTxb
            // 
            resources.ApplyResources(this.logTxb, "logTxb");
            this.logTxb.Name = "logTxb";
            this.logTxb.ReadOnly = true;
            this.logTxb.TextChanged += new System.EventHandler(this.logTxb_TextChanged);
            // 
            // logBookToolStrip
            // 
            resources.ApplyResources(this.logBookToolStrip, "logBookToolStrip");
            this.logBookToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.logBookToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator5,
            this.logViewClearBtn,
            this.logViewAutoscrollBtn,
            this.logViewCopyToClipboardBtn,
            this.logOpenCurrent2Btn});
            this.logBookToolStrip.Name = "logBookToolStrip";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            resources.ApplyResources(this.toolStripLabel1, "toolStripLabel1");
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // logViewClearBtn
            // 
            this.logViewClearBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logViewClearBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.logViewClearBtn, "logViewClearBtn");
            this.logViewClearBtn.Name = "logViewClearBtn";
            this.logViewClearBtn.Click += new System.EventHandler(this.logViewClearBtn_Click);
            // 
            // logViewAutoscrollBtn
            // 
            this.logViewAutoscrollBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logViewAutoscrollBtn.Checked = true;
            this.logViewAutoscrollBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.logViewAutoscrollBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.logViewAutoscrollBtn, "logViewAutoscrollBtn");
            this.logViewAutoscrollBtn.Name = "logViewAutoscrollBtn";
            this.logViewAutoscrollBtn.Click += new System.EventHandler(this.logViewAutoscrollBtn_Click);
            // 
            // logViewCopyToClipboardBtn
            // 
            this.logViewCopyToClipboardBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logViewCopyToClipboardBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.logViewCopyToClipboardBtn, "logViewCopyToClipboardBtn");
            this.logViewCopyToClipboardBtn.Name = "logViewCopyToClipboardBtn";
            this.logViewCopyToClipboardBtn.Click += new System.EventHandler(this.logViewCopyToClipboardBtn_Click);
            // 
            // logOpenCurrent2Btn
            // 
            this.logOpenCurrent2Btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.logOpenCurrent2Btn, "logOpenCurrent2Btn");
            this.logOpenCurrent2Btn.Name = "logOpenCurrent2Btn";
            this.logOpenCurrent2Btn.Click += new System.EventHandler(this.logOpenCurrentBtn_Click);
            // 
            // bottomToolStrip
            // 
            resources.ApplyResources(this.bottomToolStrip, "bottomToolStrip");
            this.bottomToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bottomToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portStatusLbl,
            this.screenShotBtn,
            this.logLbl});
            this.bottomToolStrip.Name = "bottomToolStrip";
            // 
            // portStatusLbl
            // 
            this.portStatusLbl.Name = "portStatusLbl";
            resources.ApplyResources(this.portStatusLbl, "portStatusLbl");
            // 
            // screenShotBtn
            // 
            this.screenShotBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.screenShotBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.screenShotBtn, "screenShotBtn");
            this.screenShotBtn.Name = "screenShotBtn";
            this.screenShotBtn.Click += new System.EventHandler(this.screenShotBtn_Click);
            // 
            // logLbl
            // 
            this.logLbl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.logLbl.IsLink = true;
            this.logLbl.Name = "logLbl";
            resources.ApplyResources(this.logLbl, "logLbl");
            this.logLbl.Click += new System.EventHandler(this.logLbl_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bottomToolStrip);
            this.Controls.Add(this.mainSplit);
            this.Controls.Add(this.mainToolStrip);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.mainSplit.Panel1.ResumeLayout(false);
            this.mainSplit.Panel2.ResumeLayout(false);
            this.mainSplit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplit)).EndInit();
            this.mainSplit.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.deviceSettingsTab.ResumeLayout(false);
            this.deviceSettingsTab.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceSettingsSalinityEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceSettingsGravityAccEdit)).EndInit();
            this.deviceSettingsToolStrip.ResumeLayout(false);
            this.deviceSettingsToolStrip.PerformLayout();
            this.remReqTab.ResumeLayout(false);
            this.remReqTab.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.remoteRequestsBottomToolStrip.ResumeLayout(false);
            this.remoteRequestsBottomToolStrip.PerformLayout();
            this.remoteRequestsTopToolStrip.ResumeLayout(false);
            this.remoteRequestsTopToolStrip.PerformLayout();
            this.ptModeTab.ResumeLayout(false);
            this.ptModeTab.PerformLayout();
            this.packetModeBottom2ToolStrip.ResumeLayout(false);
            this.packetModeBottom2ToolStrip.PerformLayout();
            this.packetModeBottomToolStrip.ResumeLayout(false);
            this.packetModeBottomToolStrip.PerformLayout();
            this.packetModeTopToolStrip.ResumeLayout(false);
            this.packetModeTopToolStrip.PerformLayout();
            this.lsTab.ResumeLayout(false);
            this.lsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lsChart)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.localSensorsTopToolStrip.ResumeLayout(false);
            this.localSensorsTopToolStrip.PerformLayout();
            this.localSensorsBottomToolStrip.ResumeLayout(false);
            this.localSensorsBottomToolStrip.PerformLayout();
            this.aqpngTab.ResumeLayout(false);
            this.aqpngTab.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aqpngPeriodMsEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aqpngPTTargetAddressEdit)).EndInit();
            this.aqpngTopToolStrip.ResumeLayout(false);
            this.aqpngTopToolStrip.PerformLayout();
            this.logBookToolStrip.ResumeLayout(false);
            this.logBookToolStrip.PerformLayout();
            this.bottomToolStrip.ResumeLayout(false);
            this.bottomToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton linkBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton infoBtn;
        private System.Windows.Forms.ToolStripDropDownButton logBtn;
        private System.Windows.Forms.ToolStripMenuItem logOpenCurrentBtn;
        private System.Windows.Forms.ToolStripMenuItem logPlaybackBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem logClearEmptyItemsBtn;
        private System.Windows.Forms.ToolStripMenuItem logArchiveAllItemsBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem logDeleteAllItemsBtn;
        private System.Windows.Forms.ToolStripMenuItem logDoThemAllBtn;
        private System.Windows.Forms.SplitContainer mainSplit;
        private System.Windows.Forms.ToolStrip logBookToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton logViewClearBtn;
        private System.Windows.Forms.ToolStripButton logViewAutoscrollBtn;
        private System.Windows.Forms.ToolStripButton logViewCopyToClipboardBtn;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage deviceSettingsTab;
        private System.Windows.Forms.TabPage remReqTab;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripDropDownButton utilsBtn;
        private System.Windows.Forms.ToolStripMenuItem utilsRunAnotherInstanceBtn;
        private System.Windows.Forms.TabPage ptModeTab;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.TabPage lsTab;
        private System.Windows.Forms.ToolStrip bottomToolStrip;
        private System.Windows.Forms.RichTextBox logTxb;
        private System.Windows.Forms.ToolStripLabel portStatusLbl;
        private System.Windows.Forms.ToolStripButton screenShotBtn;
        private System.Windows.Forms.ToolStripButton logOpenCurrent2Btn;
        private System.Windows.Forms.ToolStripLabel logLbl;
        private System.Windows.Forms.ToolStrip deviceSettingsToolStrip;
        private System.Windows.Forms.ToolStripButton queryDeviceInfoBtn;
        private System.Windows.Forms.ToolStripButton applyDeviceSettingsBtn;
        private System.Windows.Forms.ToolStripButton defaultDeviceSettingsBtn;
        private System.Windows.Forms.TabPage aqpngTab;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStrip remoteRequestsTopToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox remReqTxChIDCbx;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripComboBox remReqRxChIDCbx;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripComboBox remReqIDCbx;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton isRemoteRequestsAutoChb;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton remReqSendBtn;
        private System.Windows.Forms.ToolStrip remoteRequestsBottomToolStrip;
        private System.Windows.Forms.ToolStrip packetModeBottomToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripComboBox ptModePacketTargetAddressCbx;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripComboBox ptModePacketTriesCbx;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.ToolStripTextBox ptModePacketTxb;
        private System.Windows.Forms.ToolStripButton ptModePacketSendBtn;
        private System.Windows.Forms.ToolStripButton ptModePacketSendAbortBtn;
        private System.Windows.Forms.ToolStrip packetModeTopToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox ptModeLocalAddressCbx;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripButton packetModeIsSaveToFlashBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripButton ptModeApplySettingsBtn;
        private System.Windows.Forms.ToolStripButton ptModeQuerySettingsBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStrip packetModeBottom2ToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private System.Windows.Forms.ToolStripComboBox ptModeRequestTargetAddressCbx;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator19;
        private System.Windows.Forms.ToolStripLabel toolStripLabel10;
        private System.Windows.Forms.ToolStripComboBox ptModeRequestDataIDCbx;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator20;
        private System.Windows.Forms.ToolStripButton ptModeSendRequestBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator21;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator18;
        private System.Windows.Forms.RichTextBox packetModeLogTxb;
        private System.Windows.Forms.ToolStripButton remReqTxbClearBtn;
        private System.Windows.Forms.ToolStripButton remReqTxbIsAutoscrollBtn;
        private System.Windows.Forms.ToolStripButton remReqTxbCopy2ClipboardBtn;
        private System.Windows.Forms.ToolStripButton ptModeTxbClearBtn;
        private System.Windows.Forms.ToolStripButton ptModeTxbAutoscrollBtn;
        private System.Windows.Forms.ToolStripButton ptTxbCopyToClipboardBtn;
        private System.Windows.Forms.ToolStrip localSensorsBottomToolStrip;
        private System.Windows.Forms.ToolStripButton lsChartsClearBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown deviceSettingsSalinityEdit;
        private System.Windows.Forms.NumericUpDown deviceSettingsGravityAccEdit;
        private System.Windows.Forms.CheckBox deviceSettingsCommandModeByDefaultChb;
        private System.Windows.Forms.CheckBox deviceSettingsACKonTxFinishedChb;
        private System.Windows.Forms.ComboBox deviceSettingsTxChIDCbx;
        private System.Windows.Forms.RichTextBox deviceInfoTxb;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator31;
        private System.Windows.Forms.ToolStripButton localSensors2IsSaveToFlashBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator32;
        private System.Windows.Forms.ToolStripButton ls2ApplyBtn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel12;
        private System.Windows.Forms.ToolStripComboBox ls2UpdatePeriodCbx;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator33;
        private System.Windows.Forms.ToolStrip localSensorsTopToolStrip;
        private System.Windows.Forms.ToolStripButton lsIsPressureBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator22;
        private System.Windows.Forms.ToolStripButton lsIsTemperatureBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator23;
        private System.Windows.Forms.ToolStripButton lsIsDepthBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator24;
        private System.Windows.Forms.ToolStripButton lsIsVoltageBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator25;
        private System.Windows.Forms.ToolStripButton localSensors1IsSaveToFlashBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator26;
        private System.Windows.Forms.ToolStripButton ls1ApplyBtn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel11;
        private System.Windows.Forms.ToolStripComboBox ls1UpdatePeriodCbx;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator27;
        private System.Windows.Forms.ComboBox deviceSettingsRxChIDCbx;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator34;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator30;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator28;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator29;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator35;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator36;
        private System.Windows.Forms.ToolStripLabel toolStripButton26;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox remReqTxb;
        private System.Windows.Forms.RichTextBox remReqStatTxb;
        private System.Windows.Forms.DataVisualization.Charting.Chart lsChart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox aqpngSaveToFlashChb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox aqpngModeCbx;
        private System.Windows.Forms.ToolStrip aqpngTopToolStrip;
        private System.Windows.Forms.ToolStripButton aqpngQueryBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator37;
        private System.Windows.Forms.ToolStripButton aqpngSetDefaultsBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator38;
        private System.Windows.Forms.ToolStripButton aqpngApplyBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator39;
        private System.Windows.Forms.NumericUpDown aqpngPeriodMsEdit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox aqpngRCTxIDCbx;
        private System.Windows.Forms.ComboBox aqpngRCRxIDCbx;
        private System.Windows.Forms.ComboBox aqpgnDataIDCbx;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox aqpngIsPTModeChb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown aqpngPTTargetAddressEdit;
    }
}

