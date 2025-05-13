using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using UCNLDrivers;
using UCNLNMEA;
using UCNLPhysics;
using UCNLUI;
using UCNLUI.Dialogs;
using uWaveCommander.uWave;

namespace uWaveCommander
{
    public partial class MainForm : Form
    {
        #region Properties

        bool isRestart = false;

        string logPath;
        string logFileName;
        string settingsFileName;
        string snapshotsPath;

        readonly TSLogProvider logger;
        readonly SimpleSettingsProviderXML<SettingsContainer> sProvider;
        readonly LogPlayer lPlayer;

        string instanceID = "1";
        int childID = 1;

        uWaveSerialPort uPort;
        WPManager wpManager;

        #region UI items

        #region Main device settings tab

        int deviceSettingsTxChID
        {
            get
            {
                if ((deviceSettingsTxChIDCbx.Items.Count > 0) &&
                    (deviceSettingsTxChIDCbx.SelectedIndex < 0))
                    deviceSettingsTxChIDCbx.SelectedIndex = 0;

                return int.Parse(deviceSettingsTxChIDCbx.SelectedItem.ToString());
            }
            set
            {
                UIHelpers.TrySetCbxItem(deviceSettingsTxChIDCbx, value.ToString());
            }
        }

        int deviceSettingsRxChID
        {
            get
            {
                if ((deviceSettingsRxChIDCbx.Items.Count > 0) &&
                    (deviceSettingsRxChIDCbx.SelectedIndex < 0))
                    deviceSettingsRxChIDCbx.SelectedIndex = 0;

                return int.Parse(deviceSettingsRxChIDCbx.SelectedItem.ToString());
            }
            set
            {
                UIHelpers.TrySetCbxItem(deviceSettingsRxChIDCbx, value.ToString());
            }
        }

        double deviceSettingsSalinityPSU
        {
            get => Convert.ToDouble(deviceSettingsSalinityEdit.Value);
            set => UIHelpers.SetNumericEditValue(deviceSettingsSalinityEdit, value);
        }

        double deviceSettingsGravityAccMps2
        {
            get => Convert.ToDouble(deviceSettingsGravityAccEdit.Value);
            set => UIHelpers.SetNumericEditValue(deviceSettingsGravityAccEdit, value);
        }

        bool deviceSettingsCommandModeByDefault
        {
            get => deviceSettingsCommandModeByDefaultChb.Checked;
            set => deviceSettingsCommandModeByDefaultChb.Checked = value;
        }

        bool deviceSettingsACKOnTxFinished
        {
            get => deviceSettingsACKonTxFinishedChb.Checked;
            set => deviceSettingsACKonTxFinishedChb.Checked = value;
        }

        #endregion

        #region Remote requests tab

        int remReqTxChID
        {
            get
            {
                if ((remReqTxChIDCbx.Items.Count > 0) &&
                    (remReqTxChIDCbx.SelectedIndex < 0))
                    remReqTxChIDCbx.SelectedIndex = 0;

                return int.Parse(remReqTxChIDCbx.SelectedItem.ToString());
            }
            set
            {
                UIHelpers.TrySetCbxItem(remReqTxChIDCbx, value.ToString());
            }
        }

        int remReqRxChID
        {
            get
            {
                if ((remReqRxChIDCbx.Items.Count > 0) &&
                    (remReqRxChIDCbx.SelectedIndex < 0))
                    remReqRxChIDCbx.SelectedIndex = 0;

                return int.Parse(remReqRxChIDCbx.SelectedItem.ToString());
            }
            set
            {
                UIHelpers.TrySetCbxItem(remReqRxChIDCbx, value.ToString());
            }
        }

        RC_CODES_Enum remReqID
        {
            get
            {
                if ((remReqIDCbx.Items.Count > 0) &&
                    (remReqIDCbx.SelectedIndex < 0))
                    remReqIDCbx.SelectedIndex = 0;

                return (RC_CODES_Enum)Enum.Parse(typeof(RC_CODES_Enum), remReqIDCbx.SelectedItem.ToString());
            }
            set
            {
                UIHelpers.TrySetCbxItem(remReqIDCbx, value.ToString());
            }
        }

        bool remReqIsAuto = false;
        int remReqLimit = 0;
        int remReqCnt = 0;

        bool isAutoCode = true;

        #endregion

        #region Packet mode tab

        byte ptModeLocalAddress
        {
            get
            {
                if ((ptModeLocalAddressCbx.Items.Count > 0) &&
                    (ptModeLocalAddressCbx.SelectedIndex < 0))
                    ptModeLocalAddressCbx.SelectedIndex = 0;

                return Convert.ToByte(int.Parse(ptModeLocalAddressCbx.SelectedItem.ToString()));
            }
            set
            {
                UIHelpers.TrySetCbxItem(ptModeLocalAddressCbx, value.ToString());
            }
        }

        bool ptModeIsSaveToFlash
        {
            get => packetModeIsSaveToFlashBtn.Checked;
            set => packetModeIsSaveToFlashBtn.Checked = value;
        }

        byte ptModeRequestTargetAddress
        {
            get
            {
                if ((ptModeRequestTargetAddressCbx.Items.Count > 0) &&
                    (ptModeRequestTargetAddressCbx.SelectedIndex < 0))
                    ptModeRequestTargetAddressCbx.SelectedIndex = 0;

                return Convert.ToByte(int.Parse(ptModeRequestTargetAddressCbx.SelectedItem.ToString()));
            }
            set
            {
                UIHelpers.TrySetCbxItem(ptModeRequestTargetAddressCbx, value.ToString());
            }
        }

        byte ptModePacketTargetAddress
        {
            get
            {
                if ((ptModePacketTargetAddressCbx.Items.Count > 0) &&
                    (ptModePacketTargetAddressCbx.SelectedIndex < 0))
                    ptModePacketTargetAddressCbx.SelectedIndex = 0;

                return Convert.ToByte(int.Parse(ptModePacketTargetAddressCbx.SelectedItem.ToString()));
            }
            set
            {
                UIHelpers.TrySetCbxItem(ptModePacketTargetAddressCbx, value.ToString());
            }
        }

        byte ptModePacketTries
        {
            get
            {
                if ((ptModePacketTriesCbx.Items.Count > 0) &&
                    (ptModePacketTriesCbx.SelectedIndex < 0))
                    ptModePacketTriesCbx.SelectedIndex = 0;

                return Convert.ToByte(int.Parse(ptModePacketTriesCbx.SelectedItem.ToString()));
            }
            set
            {
                UIHelpers.TrySetCbxItem(ptModePacketTriesCbx, value.ToString());
            }
        }

        DataID_Enum ptModeRequestDataID
        {
            get
            {
                if ((ptModeRequestDataIDCbx.Items.Count > 0) &&
                    (ptModeRequestDataIDCbx.SelectedIndex < 0))
                    ptModeRequestDataIDCbx.SelectedIndex = 0;

                return (DataID_Enum)Enum.Parse(typeof(DataID_Enum), ptModeRequestDataIDCbx.SelectedItem.ToString());
            }
            set
            {
                UIHelpers.TrySetCbxItem(ptModeRequestDataIDCbx, value.ToString());
            }
        }

        #endregion

        #region Local sensors tab

        bool lsIsPressure
        {
            get => lsIsPressureBtn.Checked;
            set => lsIsPressureBtn.Checked = value;
        }

        bool lsIsTemperature
        {
            get => lsIsTemperatureBtn.Checked;
            set => lsIsTemperatureBtn.Checked = value;
        }

        bool lsIsDepth
        {
            get => lsIsDepthBtn.Checked;
            set => lsIsDepthBtn.Checked = value;
        }

        bool lsIsVoltage
        {
            get => lsIsVoltageBtn.Checked;
            set => lsIsVoltageBtn.Checked = value;
        }

        bool lsIsSaveToFlash1
        {
            get => localSensors1IsSaveToFlashBtn.Checked;
            set => localSensors1IsSaveToFlashBtn.Checked = value;
        }

        AMB_PERIOD_Enum lsUpdatePeriod1
        {
            get
            {
                if ((ls1UpdatePeriodCbx.Items.Count > 0) &&
                    (ls1UpdatePeriodCbx.SelectedIndex < 0))
                    ls1UpdatePeriodCbx.SelectedIndex = 0;

                return (AMB_PERIOD_Enum)Enum.Parse(typeof(AMB_PERIOD_Enum), ls1UpdatePeriodCbx.SelectedItem.ToString());
            }
            set
            {
                UIHelpers.TrySetCbxItem(ls1UpdatePeriodCbx, value.ToString());
            }
        }

        bool lsIsSaveToFlash2
        {
            get => localSensors2IsSaveToFlashBtn.Checked;
            set => localSensors2IsSaveToFlashBtn.Checked = value;
        }

        AMB_PERIOD_Enum lsUpdatePeriod2
        {            
            get
            {
                if ((ls2UpdatePeriodCbx.Items.Count > 0) &&
                    (ls2UpdatePeriodCbx.SelectedIndex < 0))
                    ls2UpdatePeriodCbx.SelectedIndex = 0;

                return (AMB_PERIOD_Enum)Enum.Parse(typeof(AMB_PERIOD_Enum), ls2UpdatePeriodCbx.SelectedItem.ToString());
            }
            set
            {
                UIHelpers.TrySetCbxItem(ls2UpdatePeriodCbx, value.ToString());
            }
        }

        #endregion

        #region Autoquery/Pinger mode tab

        bool aqpngIsSaveToFlash
        {
            get => aqpngSaveToFlashChb.Checked;
            set => aqpngSaveToFlashChb.Checked = value;
        }

        AQPNGModeIDs aqpngMode
        {
            get
            {
                if ((aqpngModeCbx.Items.Count > 0) &&
                    (aqpngModeCbx.SelectedIndex < 0))
                    aqpngModeCbx.SelectedIndex = 0;

                return (AQPNGModeIDs)Enum.Parse(typeof(AQPNGModeIDs), aqpngModeCbx.SelectedItem.ToString());
            }
            set
            {
                UIHelpers.TrySetCbxItem(aqpngModeCbx, value.ToString());
            }
        }

        int aqpngPeriodMs
        {
            get => Convert.ToInt32(aqpngPeriodMsEdit.Value);
            set => UIHelpers.SetNumericEditValue(aqpngPeriodMsEdit, value);
        }

        int aqpngRCTxID
        {
            get
            {
                if ((aqpngRCTxIDCbx.Items.Count > 0) &&
                    (aqpngRCTxIDCbx.SelectedIndex < 0))
                    aqpngRCTxIDCbx.SelectedIndex = 0;

                return int.Parse(aqpngRCTxIDCbx.SelectedItem.ToString());
            }
            set
            {
                UIHelpers.TrySetCbxItem(aqpngRCTxIDCbx, value.ToString());
            }
        }

        int aqpngRCRxID
        {
            get
            {
                if ((aqpngRCRxIDCbx.Items.Count > 0) &&
                    (aqpngRCRxIDCbx.SelectedIndex < 0))
                    aqpngRCRxIDCbx.SelectedIndex = 0;

                return int.Parse(aqpngRCRxIDCbx.SelectedItem.ToString());
            }
            set
            {
                UIHelpers.TrySetCbxItem(aqpngRCRxIDCbx, value.ToString());
            }
        }

        int aqpgnDataID
        {
            get
            {
                if ((aqpgnDataIDCbx.Items.Count > 0) &&
                    (aqpgnDataIDCbx.SelectedIndex < 0))
                    aqpgnDataIDCbx.SelectedIndex = 0;

                return aqpgnDataIDCbx.SelectedIndex;
            }
            set
            {
                if ((value >= 0) && (value < aqpgnDataIDCbx.Items.Count))
                    aqpgnDataIDCbx.SelectedIndex = value;
            }
        }

        bool aqpngIsPTMode
        {
            get => aqpngIsPTModeChb.Checked;
            set => aqpngIsPTModeChb.Checked = value;
        }

        int aqpngPTTargetAddress
        {
            get => Convert.ToInt32(aqpngPTTargetAddressEdit.Value);
            set => UIHelpers.SetNumericEditValue(aqpngPTTargetAddressEdit, value);
        }

        #endregion


        #region uiAutomation things

        int mainTabPageIdx
        {
            get => mainTabControl.SelectedIndex;
            set => mainTabControl.SelectedIndex = value;
        }

        UIAutomation uiAuto;

        #endregion

        #endregion

        #region remReqAutoMode items        

        RC_CODES_Enum[] remReqAutoCodes = new RC_CODES_Enum[]
        {
            RC_CODES_Enum.RC_DPT_GET,
            RC_CODES_Enum.RC_TMP_GET,
            RC_CODES_Enum.RC_BAT_V_GET,
        };

        int remReqAutoCodeIdx = 0;

        RCStatistics rcStats;

        #endregion

        readonly string[] llSeparators = new string[] { " >> " };

        #endregion

        #region Constructor

        public MainForm()
        {            
            #region Early init

            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
                instanceID = args[1];

            string vString = string.Format("{0} v{1} (#{2}), {3}",
                Application.ProductName,
                Assembly.GetExecutingAssembly().GetName().Version.ToString(),
                instanceID,
                MDates.GetReferenceNote());
            this.Text = vString;

            #endregion

            #region paths & filenames

            DateTime startTime = DateTime.Now;
            settingsFileName = Path.ChangeExtension(Application.ExecutablePath, "settings");
            logPath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "LOG");
            logFileName = StrUtils.GetTimeDirTreeFileName(startTime, Application.ExecutablePath, "LOG", "log", true);
            snapshotsPath = StrUtils.GetTimeDirTree(startTime, Application.ExecutablePath, "SNAPSHOTS", false);

            #endregion

            #region logger

            logger = new TSLogProvider(logFileName);
            logger.WriteStart();
            logger.Write(vString);
            logger.TextAddedEvent += (o, e) => InvokeAppendText(logTxb, e.Text);

            #endregion

            #region settings

            sProvider = new SimpleSettingsProviderXML<SettingsContainer>
            {
                isSwallowExceptions = false
            };

            logger.Write(string.Format("Current culture: {0}", Thread.CurrentThread.CurrentUICulture.Name));
            logger.Write(string.Format("Loading settings from {0}", settingsFileName));

            try
            {
                sProvider.Load(settingsFileName);
            }
            catch (Exception ex)
            {
                ProcessException(ex, true);
            }

            logger.Write("Current application settings:");
            logger.Write(sProvider.Data.ToString());

            if (!string.IsNullOrEmpty(sProvider.Data.CultureOverride))
            {
                try
                {
                    logger.Write(string.Format("Trying using specified culture {0}", sProvider.Data.CultureOverride));
                    Thread.CurrentThread.CurrentCulture = new CultureInfo(sProvider.Data.CultureOverride);
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(sProvider.Data.CultureOverride);
                }
                catch (Exception ex)
                {
                    logger.Write(ex);
                }
            }

            #endregion

            InitializeComponent();

            #region lPlayer

            lPlayer = new LogPlayer();
            lPlayer.NewLogLineHandler += (o, e) =>
            {
                if (e.Line.StartsWith("INFO"))
                {                        
                    var splits = e.Line.Split(llSeparators, StringSplitOptions.RemoveEmptyEntries);
                    if (splits.Length == 2)
                    {
                        if (splits[0].EndsWith("(UWV)"))
                        {
                            uPort.EmulateInput(splits[1] + NMEAParser.SentenceEndDelimiter);
                        }
                    }
                }
                else if (e.Line.StartsWith(UIAutomation.LogID))
                {
                    int idx = e.Line.IndexOf(' ');
                    if (idx >= 0)
                        InvokePerformUIAction(e.Line.Substring(idx).Trim());
                }
            };
            lPlayer.LogPlaybackFinishedHandler += (o, e) =>
            {
                uPort.Stop();

                //
                logger.Write(rcStats.GetStatValue("PTM, s").GetValuesToString());
                //

                logger.Write(string.Format("Log playback finished: {0}", lPlayer.LogFileName));

                if (InvokeRequired)
                {
                    Invoke((MethodInvoker)delegate
                    {                        
                        linkBtn.Enabled = true;                        
                        logPlaybackBtn.Text = string.Format("▶ {0}", LocalisedStrings.MainForm_Playback);
                        MessageBox.Show(string.Format("{0} \"{1}\" {2}",
                            LocalisedStrings.MainForm_LogFile,
                            lPlayer.LogFileName,
                            LocalisedStrings.MainForm_PlaybackIsFinished),
                            LocalisedStrings.MainForm_Information,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    });
                }
                else
                {
                    linkBtn.Enabled = true;
                    logPlaybackBtn.Text = string.Format("▶ {0}", LocalisedStrings.MainForm_Playback);
                    MessageBox.Show(string.Format("{0} \"{1}\" {2}",
                        LocalisedStrings.MainForm_LogFile,
                        lPlayer.LogFileName,
                        LocalisedStrings.MainForm_PlaybackIsFinished),
                        LocalisedStrings.MainForm_Information,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            };

            #endregion

            #region Misc. UI init

            deviceSettingsSalinityEdit.Minimum = Convert.ToDecimal(PHX.PHX_SALINITY_PSU_MIN);
            deviceSettingsSalinityEdit.Maximum = Convert.ToDecimal(PHX.PHX_SALINITY_PSU_MAX);
            deviceSettingsSalinityPSU = PHX.PHX_FWTR_SALINITY_PSU;

            deviceSettingsGravityAccEdit.Minimum = Convert.ToDecimal(PHX.PHX_GRAVITY_ACC_MPS2_MIN);
            deviceSettingsGravityAccEdit.Maximum = Convert.ToDecimal(PHX.PHX_GRAVITY_ACC_MPS2_MAX);
            deviceSettingsGravityAccMps2 = PHX.PHX_GRAVITY_ACC_MPS2;

            remReqIDCbx.Items.Clear();
            remReqIDCbx.Items.AddRange(new object[]
            {
                RC_CODES_Enum.RC_PING.ToString(),
                RC_CODES_Enum.RC_DPT_GET.ToString(),
                RC_CODES_Enum.RC_TMP_GET.ToString(),
                RC_CODES_Enum.RC_BAT_V_GET.ToString(),
                RC_CODES_Enum.RC_USR_CMD_000.ToString(),
                RC_CODES_Enum.RC_USR_CMD_001.ToString(),
                RC_CODES_Enum.RC_USR_CMD_002.ToString(),
                RC_CODES_Enum.RC_USR_CMD_003.ToString(),
                RC_CODES_Enum.RC_USR_CMD_004.ToString(),
                RC_CODES_Enum.RC_USR_CMD_005.ToString(),
                RC_CODES_Enum.RC_USR_CMD_006.ToString(),
                RC_CODES_Enum.RC_USR_CMD_007.ToString(),
            });
            remReqID = RC_CODES_Enum.RC_DPT_GET;

            var ptAddresses = new object[256];
            for (int i = 0; i <= 255; i++)
                ptAddresses[i] = i.ToString();

            ptModeLocalAddressCbx.Items.Clear();
            ptModeLocalAddressCbx.Items.AddRange(ptAddresses);
            ptModeLocalAddress = 0;

            ptModeRequestTargetAddressCbx.Items.Clear();
            ptModeRequestTargetAddressCbx.Items.AddRange(ptAddresses);
            ptModeRequestTargetAddress = 0;

            ptModePacketTargetAddressCbx.Items.Clear();
            ptModePacketTargetAddressCbx.Items.AddRange(ptAddresses);
            ptModePacketTargetAddress = 0;

            ptModePacketTriesCbx.Items.Clear();
            ptModePacketTriesCbx.Items.AddRange(new object[]
            {
                "0", "1", "2", "4", "8", "16", "32", "64", "128", "255"
            });
            ptModePacketTries = 8;

            ptModeRequestDataIDCbx.Items.Clear();
            ptModeRequestDataIDCbx.Items.AddRange(new object[]
            {
                DataID_Enum.DID_DPT.ToString(),
                DataID_Enum.DID_TMP.ToString(),
                DataID_Enum.DID_BAT.ToString(),
            });
            ptModeRequestDataID = DataID_Enum.DID_DPT;


            object[] upd_periods_ms = new object[]
            {
                AMB_PERIOD_Enum.NEVER.ToString(),
                AMB_PERIOD_Enum.TANDEM.ToString(),
                AMB_PERIOD_Enum._1_SEC.ToString(),
                AMB_PERIOD_Enum._2_SEC.ToString(),
                AMB_PERIOD_Enum._4_SEC.ToString(),
                AMB_PERIOD_Enum._5_SEC.ToString(),
                AMB_PERIOD_Enum._6_SEC.ToString(),
                AMB_PERIOD_Enum._7_SEC.ToString(),
                AMB_PERIOD_Enum._8_SEC.ToString(),
                AMB_PERIOD_Enum._9_SEC.ToString(),
                AMB_PERIOD_Enum._10_SEC.ToString(),
                AMB_PERIOD_Enum._30_SEC.ToString(),
                AMB_PERIOD_Enum._1_MIN.ToString(),
                AMB_PERIOD_Enum._5_MIN.ToString()
            };

            ls1UpdatePeriodCbx.Items.Clear();
            ls1UpdatePeriodCbx.Items.AddRange(upd_periods_ms);
            lsUpdatePeriod1 = AMB_PERIOD_Enum._1_SEC;

            ls2UpdatePeriodCbx.Items.Clear();
            ls2UpdatePeriodCbx.Items.AddRange(upd_periods_ms);
            lsUpdatePeriod2 = AMB_PERIOD_Enum._1_SEC;

            aqpngModeCbx.Items.Clear();
            aqpngModeCbx.Items.AddRange(new object[]
            {
                AQPNGModeIDs.AQPNG_DISABLED.ToString(),
                AQPNGModeIDs.AQPNG_PINGER.ToString(),
                AQPNGModeIDs.AQPNG_MASTER.ToString(),
            });
            aqpngMode = AQPNGModeIDs.AQPNG_DISABLED;

            aqpgnDataIDCbx.Items.Clear();
            aqpgnDataIDCbx.Items.AddRange(new object[]
            {
                "DEPTH",
                "TEMPERATURE",
                "SUPPLY VOLTAGE",
                "ALL IN CYCLE"
            });
            aqpgnDataID = 0;


            #endregion

            #region wpManager

            wpManager = new WPManager();
            wpManager.IsAutoSoundSpeed = true;
            wpManager.IsAutoSalinity = false;
            wpManager.IsAutoGravity = false;
            wpManager.SoundSpeedChanged += (o, e) =>
            {
                logger.Write(string.Format(CultureInfo.InvariantCulture,
                    "INFO: SOS={0:F01} m/s", wpManager.SoundSpeed));
            };

            #endregion

            #region rcStats

            rcStats = new RCStatistics();
            rcStats.InitStatValue("AZM, °", "F01");
            rcStats.InitStatValue("PTM, s", "F06");
            rcStats.InitStatValue("DST, m", "F03");
            rcStats.InitStatValue("MSR, dB", "F01");
            rcStats.InitStatValue("BAT, V", "F01");
            rcStats.InitStatValue("DPT, m", "F01");
            rcStats.InitStatValue("TMP, °C", "F01");

            rcStats.StatisticsUpdated += (o, e) =>
            {
                UIHelpers.InvokeSetText(remReqStatTxb, rcStats.ToString());
            };

            #endregion

            #region uPort

            uPort = new uWaveSerialPort(uWave.uWave.CR_DEFAULT_BAUDRATE);
            uPort.IsTryAlways = true;
            uPort.IsLogIncoming = true;

            uPort.LogEventHandler += (o, e) => logger.Write(string.Format("{0}: {1}", e.EventType, e.LogString));
            uPort.IsActiveChanged += (o, e) =>
            {
                UIHelpers.InvokeSetCheckedState(mainToolStrip, linkBtn, uPort.IsActive);
                UIHelpers.InvokeSetEnabledState(mainToolStrip, logPlaybackBtn, !uPort.IsActive);

                InvokeUpdatePortStatusLbl(bottomToolStrip, portStatusLbl, uPort.IsActive, uPort.Detected, uPort.ToString());
                logger.Write(string.Format("{0}={1}", nameof(uPort.IsActive), uPort.IsActive));
            };
            uPort.DetectedChanged += (o, e) =>
            {
                InvokeUpdatePortStatusLbl(bottomToolStrip, portStatusLbl, uPort.IsActive, uPort.Detected, uPort.ToString());
            };
            uPort.DeviceInfoValidChanged += (o, e) =>
            {
                if (InvokeRequired)
                    Invoke((MethodInvoker)delegate { OnDeviceInfoValidChanged(); });
                else
                    OnDeviceInfoValidChanged();
            };
            uPort.IsWaitingLocalChanged += (o, e) =>
            {
                UIHelpers.InvokeSetEnabledState(mainTabControl, !uPort.IsWaitingLocal);
            };
            uPort.RCTimeoutReceived += (o, e) =>
            {
                InvokeAppendText(remReqTxb,
                    string.Format("(Tx={0}:Rx={1}) >> {2} Timeout...\r\n",
                    e.RxChID, e.TxChID, e.RCCmdID));

                rcStats.AddFail();
            };
            uPort.RCResponseReceived += (o, e) =>
            {
                var range_m = e.PropTime_sec * wpManager.SoundSpeed;

                rcStats.AddMeasurement("PTM, s", e.PropTime_sec);

                StringBuilder sb = new StringBuilder();
                sb.AppendFormat(CultureInfo.InvariantCulture,
                    "(Tx={0}:Rx={1}) >> {2} OK!\r\n ⮡ Tp={3:F05} sec ({4:F02} m), MSR={5:F01} dB",
                    e.RxChID,
                    e.TxChID, 
                    e.RCCmdID,
                    e.PropTime_sec, range_m,
                    e.MSR_db);

                if (remReqIsAuto)
                    logger.Write(string.Format("DST={0:F03}", range_m));

                if (e.IsValuePresent)
                {
                    if (e.RCCmdID == RC_CODES_Enum.RC_DPT_GET)
                    {
                        sb.AppendFormat(CultureInfo.InvariantCulture, ", Dpt={0:F01} m", e.Value);
                        rcStats.AddMeasurement("DPT, m", e.Value);
                    }
                    else if (e.RCCmdID == RC_CODES_Enum.RC_TMP_GET)
                    {
                        sb.AppendFormat(CultureInfo.InvariantCulture, ", T={0:F01}°C", e.Value);
                        wpManager.Temperature = e.Value;
                        rcStats.AddMeasurement("TMP, °C", e.Value);
                    }
                    else if (e.RCCmdID == RC_CODES_Enum.RC_BAT_V_GET)
                    {
                        sb.AppendFormat(CultureInfo.InvariantCulture, ", V={0:F01} V", e.Value);
                        rcStats.AddMeasurement("BAT, V", e.Value);
                    }
                }

                if (e.IsAzimuthPresent)
                {
                    sb.AppendFormat(CultureInfo.InvariantCulture, ", ɑ={0:F01}°", e.Azimuth);
                    rcStats.AddMeasurement("AZM, °", e.Azimuth);
                }
                sb.Append("\r\n");

                rcStats.AddMeasurement("DST, m", range_m);
                rcStats.AddMeasurement("MSR, dB", e.MSR_db);                
                rcStats.AddSuccess();

                InvokeAppendText(remReqTxb, sb.ToString());                           
            };
            uPort.RCAsyncInReceived += (o, e) =>
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat(CultureInfo.InvariantCulture,
                    "ASYNC IN >> {0}\r\n ⮡ MSR={1:F01} dB", e.RCCmdID, e.MSR_dB);

                if (e.IsAzimuthPresent)
                    sb.AppendFormat(CultureInfo.InvariantCulture,
                        ", ɑ={0:F01}°", e.Azimuth_deg);

                sb.Append("\r\n");

                InvokeAppendText(remReqTxb, sb.ToString());
            };
            uPort.IsWaitingRemoteChanged += (o, e) =>
            {
                if (!uPort.IsWaitingRemote && remReqIsAuto)
                {
                    InvokeRemoteRequestsAuto();
                }
            };
            uPort.AMBDataUpdated += (o, e) =>
            {
                if (lsChart.InvokeRequired)
                    lsChart.Invoke((MethodInvoker)delegate
                    {
                        if (uPort.Pressure_mBar.IsInitialized)
                            lsChart.Series["Pressure"].Points.Add(uPort.Pressure_mBar.Value);

                        if (uPort.Temperature_C.IsInitialized)
                            lsChart.Series["Temperature"].Points.Add(uPort.Temperature_C.Value);

                        if (uPort.Depth_m.IsInitialized)                        
                            lsChart.Series["Depth"].Points.Add(uPort.Depth_m.Value);
                        
                        if (uPort.Voltage_V.IsInitialized)                       
                            lsChart.Series["Voltage"].Points.Add(uPort.Voltage_V.Value);                        
                    });
            };
            uPort.PTCROLDataUpdated += (o, e) =>
            {
                if (lsChart.InvokeRequired)
                {
                    lsChart.Invoke((MethodInvoker)delegate
                    {                        
                        if (uPort.Pitch_deg.IsInitialized)
                            lsChart.Series["Pitch"].Points.Add(uPort.Pitch_deg.Value);

                        if (uPort.Roll_deg.IsInitialized)
                            lsChart.Series["Roll"].Points.Add(uPort.Roll_deg.Value);
                    });
                }
                else
                {
                    if (uPort.Pitch_deg.IsInitialized)
                        lsChart.Series["Pitch"].Points.Add(uPort.Pitch_deg.Value);

                    if (uPort.Roll_deg.IsInitialized)
                        lsChart.Series["Roll"].Points.Add(uPort.Roll_deg.Value);
                }
            };
            uPort.PacketModeSettingsReceived += (o, e) =>
            {
                if (InvokeRequired)
                    Invoke((MethodInvoker)delegate
                    {
                        ptModeLocalAddress = Convert.ToByte(uPort.PTAddress);
                    });
            };
            uPort.PacketReceived += (o, e) =>
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("#{0} >> \"{1}\"",
                    e.Target_ptAddress,
                    Encoding.ASCII.GetString(e.DataPacket));                

                if (!double.IsNaN(e.Azimuth))
                    sb.AppendFormat(CultureInfo.InvariantCulture, ", 𝛂={0:F01}°", e.Azimuth);

                sb.Append("\r\n");
                InvokeAppendText(packetModeLogTxb, sb.ToString());
            };
            uPort.PacketRequestTimeout += (o, e) =>
            {
                InvokeAppendText(packetModeLogTxb,
                    string.Format("#{0} >> {1} Timeout...\r\n", e.Target_ptAddress, e.DataId));
            };
            uPort.PacketResponse += (o, e) =>
            {
                StringBuilder sb = new StringBuilder();

                var range_m = e.PropagationTime_s * wpManager.SoundSpeed;

                sb.AppendFormat(CultureInfo.InvariantCulture,
                    "#{0} >> {1} OK! ({2}",
                    e.Target_ptAddress,
                    e.DataId,
                    e.DataValue);

                if (e.DataId == DataID_Enum.DID_DPT)
                    sb.Append(" m");
                else if (e.DataId == DataID_Enum.DID_TMP)
                    sb.Append(" °C");
                else if (e.DataId == DataID_Enum.DID_BAT)
                    sb.Append(" V");

                sb.AppendFormat(")\r\n⮡ Tp={0:F05} sec ({1:F02} m)",
                    e.PropagationTime_s, range_m);

                if (!double.IsNaN(e.Azimuth))
                    sb.AppendFormat(CultureInfo.InvariantCulture, ", 𝛂={0:F01}°", e.Azimuth);

                sb.Append("\r\n");
                InvokeAppendText(packetModeLogTxb, sb.ToString());
            };
            uPort.PacketTransferFailed += (o, e) =>
            {
                InvokeAppendText(packetModeLogTxb,
                    string.Format("#{0} >> \"{1}\" ({2}) FAILED!\r\n",
                    e.Target_ptAddress,
                    Encoding.ASCII.GetString(e.DataPacket),
                    e.TriesTaken));
            };
            uPort.PacketTransferred += (o, e) =>
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("#{0} >> \"{1}\" OK ({2})",
                    e.Target_ptAddress,
                    Encoding.ASCII.GetString(e.DataPacket),
                    e.TriesTaken);

                if (!double.IsNaN(e.Azimuth))
                    sb.AppendFormat(CultureInfo.InvariantCulture, ", 𝛂={0:F01}°", e.Azimuth);

                sb.Append("\r\n");
                InvokeAppendText(packetModeLogTxb, sb.ToString());
            };
            uPort.AQPNGSettingsReceived += (o, e) =>
            {
                Invoke((MethodInvoker)delegate
                {
                    aqpngMode = e.AQPNG_Mode;
                    aqpngPeriodMs = e.PeriodMs;
                    aqpgnDataID = e.DataId;
                    aqpngRCTxID = e.TxID;
                    aqpngRCRxID = e.RxID;
                    aqpngIsPTMode = e.IsPT;
                    aqpngPTTargetAddress = e.PtTargetAddr;
                });
            };

            #endregion

            #region uiAuto

            uiAuto = new UIAutomation();
            uiAuto.InitIntProperty<MainForm>(this, nameof(mainTabPageIdx));

            #endregion
        }

        #endregion

        #region Handlers

        #region UI

        #region mainToolStrip

        private void linkBtn_Click(object sender, EventArgs e)
        {
            if (uPort.IsActive)
                uPort.Stop();
            else
                uPort.Start();
        }

        private void logOpenCurrentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(logger.FileName);
            }
            catch (Exception ex)
            {
                ProcessException(ex, true);
            }
        }

        private void logPlaybackBtn_Click(object sender, EventArgs e)
        {
            if (lPlayer.IsRunning)
            {
                if (MessageBox.Show(LocalisedStrings.MainForm_LogPlaybackAbortPrompt,
                    string.Format("{0} - {1}",
                    Application.ProductName, LocalisedStrings.MainForm_Question),
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    lPlayer.RequestToStop();
            }
            else
            {
                using (OpenFileDialog oDialog = new OpenFileDialog())
                {
                    oDialog.Title = LocalisedStrings.MainForm_LogPlaybackSelectDialogTitle;
                    oDialog.DefaultExt = "log";
                    oDialog.Filter = "Log files (*.log)|*.log";

                    if (oDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        rcStats.Clear();
                        lPlayer.Playback(oDialog.FileName);

                        logPlaybackBtn.Text = string.Format("⏹ {0}", LocalisedStrings.MainForm_LogPlaybackStopBtnText);                        
                        linkBtn.Enabled = false;
                        logger.Write(string.Format("Starting log playback: {0}", lPlayer.LogFileName));
                    }
                }
            }
        }

        private void logClearEmptyItemsBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(LocalisedStrings.MainForm_LogDeleteEmptyEntriesPrompt,
                string.Format("{0} - {1}",
                Application.ProductName,
                LocalisedStrings.MainForm_Question),
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                var fNum = RemoveEmptyEntries(logPath, logger.FileName, 2048);

                MessageBox.Show(string.Format("{0} {1}", fNum, LocalisedStrings.MainForm_FilesWereDeleted),
                    string.Format("{0} - {1}",
                    Application.ProductName,
                    LocalisedStrings.MainForm_Information),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void logArchiveAllItemsBtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sDialog = new SaveFileDialog())
            {
                sDialog.Title = LocalisedStrings.MainForm_LogArchiveDialogTitle;
                sDialog.Filter = "Zip-archives (*.zip)|*.zip";
                sDialog.DefaultExt = "zip";
                sDialog.FileName = string.Format("LOG_Archive_{0}", StrUtils.GetYMDString());

                if (sDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ZipFile.CreateFromDirectory(logPath, sDialog.FileName);
                        logLbl.Text = string.Format("{0} {1}",
                           LocalisedStrings.MainForm_LogArchiveResult, Path.GetFileName(sDialog.FileName));
                        logLbl.Tag = sDialog.FileName;
                    }
                    catch (Exception ex)
                    {
                        ProcessException(ex, true);
                    }
                }
            }
        }

        private void logDeleteAllItemsBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(LocalisedStrings.MainForm_LogDeleteAllEntriesPrompt,
                                string.Format("{0} - {1}",
                                Application.ProductName, 
                                LocalisedStrings.MainForm_Warning),

                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {

                var dirNum = ClearAllEntries(logPath);

                MessageBox.Show(string.Format("{0} {1}",
                    dirNum, LocalisedStrings.MainForm_EntriesWereDeleted),
                    string.Format("{0} - {1}",
                    Application.ProductName, LocalisedStrings.MainForm_Information),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void logDoThemAllBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(LocalisedStrings.MainForm_MoveLogsToArchivePrompt,
                               string.Format("{0} - {1}",
                               Application.ProductName, 
                               LocalisedStrings.MainForm_Warning),
                               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
            {
                RemoveEmptyEntries(logPath, logFileName, 2048);

                bool archived = false;
                using (SaveFileDialog sDialog = new SaveFileDialog())
                {
                    sDialog.Title = LocalisedStrings.MainForm_MoveLogsToArchivePromptTitle;
                    sDialog.Filter = "Zip-archives (*.zip)|*.zip";
                    sDialog.DefaultExt = "zip";
                    sDialog.FileName = string.Format("LOG_Archive_{0}", StrUtils.GetYMDString());

                    if (sDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            ZipFile.CreateFromDirectory(logPath, sDialog.FileName);
                            logLbl.Text = string.Format("{0} {1}",
                               LocalisedStrings.MainForm_LogMoveToArchiveResult, Path.GetFileName(sDialog.FileName));
                            logLbl.Tag = sDialog.FileName;
                            archived = true;
                        }
                        catch (Exception ex)
                        {
                            ProcessException(ex, true);
                        }
                    }
                }

                if (!archived)
                {
                    MessageBox.Show(LocalisedStrings.MainForm_LogMoveToArchiveProblemsResult,
                        string.Format("{0} - {1}",
                        Application.ProductName, LocalisedStrings.MainForm_Error),
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    ClearAllEntries(logPath);
                }
            }
        }        

        private void utilsRunAnotherInstanceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Application.ExecutablePath,
                    string.Format("{0}-{1}", instanceID, childID));

                childID++;
            }
            catch (Exception ex)
            {
                ProcessException(ex, true);
            }
        }    

        private void infoBtn_Click(object sender, EventArgs e)
        {
            using (AboutBox aDialog = new AboutBox())
            {
                aDialog.ApplyAssembly(Assembly.GetExecutingAssembly());
                aDialog.Weblink = "www.docs.unavlab.com";
                aDialog.ShowDialog();
            }
        }

        #endregion

        #region logViewToolStrip

        private void logViewCopyToClipboardBtn_Click(object sender, EventArgs e)
        {
            logTxb.Copy();            
        }

        private void logViewAutoscrollBtn_Click(object sender, EventArgs e)
        {
            logViewAutoscrollBtn.Checked = !logViewAutoscrollBtn.Checked;
            if (logViewAutoscrollBtn.Checked)
                logTxb.ScrollToCaret();
        }

        private void logViewClearBtn_Click(object sender, EventArgs e)
        {
            logTxb.Clear();
        }

        #endregion

        #region logTxb

        private void logTxb_TextChanged(object sender, EventArgs e)
        {
            if (logViewAutoscrollBtn.Checked)
                logTxb.ScrollToCaret();

            logViewCopyToClipboardBtn.Enabled = !string.IsNullOrEmpty(logTxb.Text);
            logViewClearBtn.Enabled = !string.IsNullOrEmpty(logTxb.Text);
        }

        #endregion

        #region bottomToolStrip

        private void logLbl_Click(object sender, EventArgs e)
        {
            if (logLbl.Tag != null)
            {
                try
                {
                    Process.Start(logLbl.Tag.ToString());
                }
                catch (Exception ex)
                {
                    ProcessException(ex, true);
                }
            }
        }

        private void screenShotBtn_Click(object sender, EventArgs e)
        {
            SaveFullScreenshot(out string msg, out string pathLink);

            logLbl.Text = msg;
            if (!string.IsNullOrEmpty(pathLink))
            {
                logLbl.Tag = pathLink;
                logLbl.ToolTipText = string.Format("Open {0}", pathLink);
            }
            else
                logLbl.Tag = null;
        }

        #endregion

        #region MainForm

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            logger.FinishLog();
            logger.Flush();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !isRestart &&
                (MessageBox.Show(LocalisedStrings.MainForm_ApplicationClosePrompt,
                string.Format("{0} - {1}", Application.ProductName, LocalisedStrings.MainForm_Question),
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode == Keys.S)
                {
                    screenShotBtn_Click(screenShotBtn, null);
                    e.SuppressKeyPress = true;
                }                
                else if (e.KeyCode == Keys.L)
                {
                    if (linkBtn.Enabled)
                        linkBtn_Click(linkBtn, null);
                    e.SuppressKeyPress = true;
                }
                else if (e.KeyCode == Keys.O)
                {
                    logOpenCurrentBtn_Click(logOpenCurrentBtn, EventArgs.Empty);
                    e.SuppressKeyPress = true;
                }                
            }
        }

        #endregion

        #region mainTabControl

        private void mainTabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = !((Control)e.TabPage).Enabled;

            if (e.Cancel)
                MessageBox.Show("Turn the AUTO mode off first",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        #region deviceSettingsTab

        private void defaultDeviceSettingsBtn_Click(object sender, EventArgs e)
        {
            deviceSettingsACKOnTxFinished = false;
            deviceSettingsCommandModeByDefault = true;
            deviceSettingsGravityAccMps2 = PHX.PHX_GRAVITY_ACC_MPS2;
            deviceSettingsSalinityPSU = PHX.PHX_FWTR_SALINITY_PSU;
            deviceSettingsTxChID = 0;
            deviceSettingsRxChID = 0;
        }

        private void queryDeviceInfoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                uPort.Query_DINFO();
            }
            catch (Exception ex)
            {
                ProcessException(ex, true);
            }
        }

        private void applyDeviceSettingsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                uPort.Query_SETTINGS_WRITE(
                    deviceSettingsTxChID,
                    deviceSettingsRxChID,
                    deviceSettingsSalinityPSU,
                    deviceSettingsCommandModeByDefault,
                    deviceSettingsACKOnTxFinished,
                    deviceSettingsGravityAccMps2);
            }
            catch (Exception ex)
            {
                ProcessException(ex, true);
            }
        }

        #endregion

        #region remReqTab

        #region AUTO btn

        private void switchRemRequestsAuto(int numberOfRequests, bool isAutoCodeChange)
        {

            isAutoCode = isAutoCodeChange;

            remReqIsAuto = !remReqIsAuto;

            remReqTxChIDCbx.Enabled = !remReqIsAuto;
            remReqRxChIDCbx.Enabled = !remReqIsAuto;
            remReqIDCbx.Enabled = !remReqIsAuto;
            remReqSendBtn.Enabled = !remReqIsAuto;

            isRemoteRequestsAuto1024Chb.Checked = false;
            isRemoteRequestsAuto512Chb.Checked = false;
            isRemoteRequestsAuto256Chb.Checked = false;
            isRemoteRequestsFullyAutoChb.Checked = false;
            isRemoteRequestsAuto128Chb.Checked = false;

            foreach (var tabPage in mainTabControl.TabPages)
                ((Control)tabPage).Enabled = !remReqIsAuto;

            ((Control)remReqTab).Enabled = true;

            if (remReqIsAuto)
            {
                isRemoteRequestsAutoChb.Text = "✔ AUTO";

                remReqLimit = numberOfRequests;
                remReqCnt = 0;

                logger.Write(string.Format("REMREQ AUTO ({0}) START", numberOfRequests));                

                rcStats.Clear();
                remReqSendBtn_Click(null, null);
            }
            else
            {
                isRemoteRequestsAutoChb.Text = "AUTO";
                logger.Write("REMREQ AUTO STOP");

                //
                //logger.Write(rcStats.GetStatValue("PTM, s").GetValuesToString());
                //
            }
        }        

        private void isRemoteRequestsAuto1024Chb_Click(object sender, EventArgs e)
        {
            switchRemRequestsAuto(1024, true);
            isRemoteRequestsAuto1024Chb.Checked = remReqIsAuto;
        }

        private void isRemoteRequestsAuto512Chb_Click(object sender, EventArgs e)
        {
            switchRemRequestsAuto(512, true);
            isRemoteRequestsAuto512Chb.Checked = remReqIsAuto;
        }

        private void isRemoteRequestsAuto256Chb_Click(object sender, EventArgs e)
        {
            switchRemRequestsAuto(256, true);
            isRemoteRequestsAuto256Chb.Checked = remReqIsAuto;
        }

        private void isRemoteRequestsFullyAutoChb_Click(object sender, EventArgs e)
        {
            switchRemRequestsAuto(int.MaxValue, true);
            isRemoteRequestsFullyAutoChb.Checked = remReqIsAuto;
        }

        private void isRemoteRequestsAuto128Chb_Click(object sender, EventArgs e)
        {
            switchRemRequestsAuto(128, true);
            isRemoteRequestsAuto128Chb.Checked = remReqIsAuto;
        }


        private void isRemoteRequestsFullyAutoFixedChb_Click(object sender, EventArgs e)
        {
            switchRemRequestsAuto(int.MaxValue, false);
            isRemoteRequestsFullyAutoFixedChb.Checked = remReqIsAuto;
        }

        #endregion

        private void remReqSendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (uPort.Query_RC(remReqRxChID, remReqTxChID, remReqID))
                {
                    remReqTxb.AppendText(string.Format("(Tx={0}:Rx={1}) << {2} ?...\r\n",
                        remReqTxChID, remReqRxChID, remReqID));
                }
            }
            catch (Exception ex)
            {
                ProcessException(ex, true);
            }
        }

        private void remReqTxbIsAutoscrollBtn_Click(object sender, EventArgs e)
        {
            remReqTxbIsAutoscrollBtn.Checked = !remReqTxbIsAutoscrollBtn.Checked;
            if (remReqTxbIsAutoscrollBtn.Checked)
                remReqTxb.ScrollToCaret();
        }

        private void remReqTxb_TextChanged(object sender, EventArgs e)
        {
            if (remReqTxbIsAutoscrollBtn.Checked)
                remReqTxb.ScrollToCaret();

            remReqTxbCopy2ClipboardBtn.Enabled = !string.IsNullOrEmpty(remReqTxb.Text);
            remReqTxbClearBtn.Enabled = !string.IsNullOrEmpty(remReqTxb.Text);
        }

        private void remReqTxbCopy2ClipboardBtn_Click(object sender, EventArgs e)
        {
            remReqTxb.Copy();
        }

        private void remReqTxbClearBtn_Click(object sender, EventArgs e)
        {
            remReqTxb.Clear();
            rcStats.Clear();
            remReqStatTxb.Clear();
        }

        #endregion

        #region ptModeTab

        private void packetModeIsSaveToFlashBtn_Click(object sender, EventArgs e)
        {
            packetModeIsSaveToFlashBtn.Checked = !packetModeIsSaveToFlashBtn.Checked;
            if (packetModeIsSaveToFlashBtn.Checked)
                packetModeIsSaveToFlashBtn.Text = "✔" + LocalisedStrings.Main_Form_SaveToFlash;// Save to flash";
            else
                packetModeIsSaveToFlashBtn.Text = LocalisedStrings.Main_Form_SaveToFlash;
        }

        private void ptModeSendRequestBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (uPort.Query_PT_ITG(ptModeRequestTargetAddress, ptModeRequestDataID))
                {
                    packetModeLogTxb.AppendText(
                        string.Format("#{0} << {1} ?..\r\n",
                        ptModeRequestTargetAddress, ptModeRequestDataID));
                }
            }
            catch (Exception ex)
            {
                ProcessException(ex, true);
            }
        }

        private void ptModeQuerySettingsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                uPort.Query_PT_SETTINGS();
            }
            catch (Exception ex)
            {
                ProcessException(ex, true);
            }
        }

        private void ptModePacketSendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (uPort.Query_PT_SEND(ptModePacketTargetAddress,
                    ptModePacketTries,
                    Encoding.ASCII.GetBytes(ptModePacketTxb.Text)))
                {
                    packetModeLogTxb.AppendText(
                        string.Format("#{0} << \"{1}\" ({2}) ?...\r\n",
                        ptModePacketTargetAddress,
                        ptModePacketTxb.Text,
                        ptModePacketTries));
                }
            }
            catch (Exception ex)
            {
                ProcessException(ex, true);
            }
        }

        private void ptModePacketSendAbortBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (uPort.Query_PT_ABORT_SEND())
                {
                    packetModeLogTxb.AppendText("ABORT SEND ?..\r\n");
                }
            }
            catch (Exception ex)
            {
                ProcessException(ex, true);
            }
        }

        private void ptModeApplySettingsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                uPort.Query_PT_SETTINGS_WRITE(ptModeIsSaveToFlash, true, ptModeLocalAddress);
            }
            catch (Exception ex)
            {
                ProcessException(ex, true);
            }
        }

        private void ptTxbCopyToClipboardBtn_Click(object sender, EventArgs e)
        {
            packetModeLogTxb.Copy();
        }

        private void ptModeTxbClearBtn_Click(object sender, EventArgs e)
        {
            packetModeLogTxb.Clear();
        }

        private void packetModeLogTxb_TextChanged(object sender, EventArgs e)
        {
            ptModeTxbClearBtn.Enabled = !string.IsNullOrEmpty(packetModeLogTxb.Text);
            ptTxbCopyToClipboardBtn.Enabled = ptModeTxbClearBtn.Enabled;

            if (ptModeTxbAutoscrollBtn.Checked)
                packetModeLogTxb.ScrollToCaret();
        }

        private void ptModePacketTxb_TextChanged(object sender, EventArgs e)
        {
            ptModePacketSendBtn.Enabled = !string.IsNullOrEmpty(ptModePacketTxb.Text);
        }

        #endregion

        #region lsTab

        private void localSensors1IsSaveToFlashBtn_Click(object sender, EventArgs e)
        {
            localSensors1IsSaveToFlashBtn.Checked = !localSensors1IsSaveToFlashBtn.Checked;
            if (localSensors1IsSaveToFlashBtn.Checked)
                localSensors1IsSaveToFlashBtn.Text = "✔" + LocalisedStrings.Main_Form_SaveToFlash;
            else
                localSensors1IsSaveToFlashBtn.Text = LocalisedStrings.Main_Form_SaveToFlash;
        }

        private void localSensors2IsSaveToFlashBtn_Click(object sender, EventArgs e)
        {
            localSensors2IsSaveToFlashBtn.Checked = !localSensors2IsSaveToFlashBtn.Checked;
            if (localSensors2IsSaveToFlashBtn.Checked)
                localSensors2IsSaveToFlashBtn.Text = "✔" + LocalisedStrings.Main_Form_SaveToFlash;
            else
                localSensors2IsSaveToFlashBtn.Text = LocalisedStrings.Main_Form_SaveToFlash;
        }

        private void ls1ApplyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                uPort.Query_AMB_CFG_WRITE(lsIsSaveToFlash1,
                    (int)lsUpdatePeriod1, lsIsPressure, lsIsTemperature, lsIsDepth, lsIsVoltage);

                lsChart.ChartAreas[0].Visible = lsIsPressure;
                lsChart.ChartAreas[1].Visible = lsIsTemperature;
                lsChart.ChartAreas[2].Visible = lsIsDepth;
                lsChart.ChartAreas[3].Visible = lsIsVoltage;               

            }
            catch (Exception ex)
            {
                ProcessException(ex, true);
            }
        }

        private void ls2ApplyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                uPort.Query_PTCROL_CFG_WRITE(lsIsSaveToFlash2, (int)lsUpdatePeriod2);

                if ((!lsChart.ChartAreas[4].Visible) && (lsUpdatePeriod2 != 0))
                {
                    lsChart.ChartAreas[4].Visible = true;
                    lsChart.ChartAreas[5].Visible = true;
                    pitchDegBtn.Checked = true;
                    rollDegBtn.Checked = true;
                }
            }
            catch (Exception ex)
            {
                ProcessException(ex, true);
            }
        }

        private void lsChartClearBtn_Click(object sender, EventArgs e)
        {
            foreach (var serie in lsChart.Series)
                serie.Points.Clear();
        }


        #endregion

        #region aqpngTab

        private void aqpngQueryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                uPort.Query_AQPNG_SETTINGS();
            }
            catch (Exception ex)
            {
                ProcessException(ex, true);
            }
        }

        private void aqpngSetDefaultsBtn_Click(object sender, EventArgs e)
        {
            aqpngIsSaveToFlash = false;
            aqpngMode = AQPNGModeIDs.AQPNG_DISABLED;
            aqpngPeriodMs = 2000;
            aqpgnDataID = 3;
            aqpngRCTxID = 0;
            aqpngRCRxID = 0;
            aqpngIsPTMode = false;
            aqpngPTTargetAddress = 0;
        }

        private void aqpngApplyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                uPort.Query_AQPNG_SETTINGS_WRITE(
                    aqpngIsSaveToFlash, aqpngMode, aqpngPeriodMs,
                    aqpgnDataID, aqpngRCTxID, aqpngRCRxID, aqpngIsPTMode, aqpngPTTargetAddress);
            }
            catch (Exception ex)
            {
                ProcessException(ex, true);
            }
        }

        private void aqpngModeCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            aqpngPTTargetAddressEdit.Enabled = 
                (aqpngMode == AQPNGModeIDs.AQPNG_MASTER) &&
                (aqpngIsPTMode);
        }

        private void aqpngIsPTModeChb_CheckedChanged(object sender, EventArgs e)
        {
            aqpngPTTargetAddressEdit.Enabled =
                (aqpngMode == AQPNGModeIDs.AQPNG_MASTER) &&
                (aqpngIsPTMode);

            aqpngRCRxIDCbx.Enabled = !aqpngIsPTMode;
            aqpngRCTxIDCbx.Enabled = !aqpngIsPTMode;
        }

        #endregion

        #endregion

        #endregion

        #endregion

        #region Methods

        private void ProcessException(Exception ex, bool isMsgBox)
        {
            logger.Write(ex);

            if (isMsgBox)
                MessageBox.Show(ex.ToString(),
                    string.Format("{0} - {1}",                    
                    Application.ProductName,
                    LocalisedStrings.MainForm_Error),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void SaveFullScreenshot(out string msg, out string pathLink)
        {
            Bitmap target = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(target, this.DisplayRectangle);

            pathLink = string.Empty;

            try
            {
                if (!Directory.Exists(snapshotsPath))
                    Directory.CreateDirectory(snapshotsPath);

                var fName = string.Format("{0}.{1}", StrUtils.GetHMSString(), ImageFormat.Png);
                var path = Path.Combine(snapshotsPath, fName);
                target.Save(path, ImageFormat.Png);

                msg = string.Format("{0}: {1}", LocalisedStrings.MainForm_ScreenshotSaved, fName);
                pathLink = path;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
        }

        private int RemoveEmptyEntries(string rootPath, string exclude, int minSize)
        {
            var dirs = Directory.GetDirectories(rootPath);
            int fNum = 0;
            foreach (var item in dirs)
            {
                var fNames = Directory.GetFiles(item);

                foreach (var fName in fNames)
                {
                    if (fName != exclude)
                    {
                        FileInfo fInfo = new FileInfo(fName);
                        if (fInfo.Length <= minSize)
                        {
                            try
                            {
                                File.Delete(fName);
                                fNum++;
                            }
                            catch { }
                        }
                    }
                }

                fNames = Directory.GetFiles(item);
                if (fNames.Length == 0)
                {
                    try
                    {
                        Directory.Delete(item);
                    }
                    catch { }
                }
            }

            return fNum;
        }

        private int ClearAllEntries(string rootPath)
        {
            var dirs = Directory.GetDirectories(rootPath);
            int dirNum = 0;
            foreach (var item in dirs)
            {
                try
                {
                    Directory.Delete(item, true);
                    dirNum++;
                }
                catch (Exception ex)
                {
                    ProcessException(ex, true);
                }
            }

            return dirNum;
        }

        private void FillCbxWithNumbers(ComboBox cbx, int from, int to)
        {
            cbx.Items.Clear();
            for (int i = from; i < to; i++)
                cbx.Items.Add(i.ToString());

            if (cbx.Items.Count > 0)
                cbx.SelectedIndex = 0;
        }

        private void FillCbxWithNumbers(ToolStripComboBox cbx, int from, int to)
        {
            cbx.Items.Clear();
            for (int i = from; i < to; i++)
                cbx.Items.Add(i.ToString());

            if (cbx.Items.Count > 0)
                cbx.SelectedIndex = 0;
        }

        private void ReInitCodeChannelCbxs(int totalCodeChannel)
        {
            FillCbxWithNumbers(deviceSettingsRxChIDCbx, 0, totalCodeChannel);
            FillCbxWithNumbers(deviceSettingsTxChIDCbx, 0, totalCodeChannel);

            FillCbxWithNumbers(remReqTxChIDCbx, 0, totalCodeChannel);
            FillCbxWithNumbers(remReqRxChIDCbx, 0, totalCodeChannel);
            /// TODO: (re)init other UI controls, that select code channels
            /// 
            FillCbxWithNumbers(aqpngRCTxIDCbx, 0, totalCodeChannel);
            FillCbxWithNumbers(aqpngRCRxIDCbx, 0, totalCodeChannel);
        }

        private void OnDeviceInfoValidChanged()
        {
            mainTabControl.Enabled = uPort.IsDeviceInfoValid &&
                !uPort.IsWaitingLocal &&
                !uPort.IsWaitingRemote;

            deviceInfoTxb.Clear();

            if (uPort.IsDeviceInfoValid)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("             System: {0} v{1}\r\n", uPort.SystemMoniker, uPort.SystemVersion);
                sb.AppendFormat("               Core: {0} v{1}\r\n", uPort.CoreMoniker, uPort.CoreVersion);
                sb.AppendFormat("                S/N: {0}\r\n", uPort.SerialNumber);
                sb.AppendFormat(CultureInfo.InvariantCulture,
                                "   Payload baudrate: {0:F02} bps\r\n", uPort.AcousticBaudrate);
                sb.AppendFormat("Total code channels: {0}\r\n", uPort.TotalCodeChannels);
                sb.AppendFormat("        PTS present: {0}\r\n", uPort.IsPTS ? "yes" : "no");

                deviceInfoTxb.Text = sb.ToString();

                ReInitCodeChannelCbxs(uPort.TotalCodeChannels);

                deviceSettingsTxChID = uPort.TxChID;
                deviceSettingsRxChID = uPort.RxChID;
                deviceSettingsSalinityPSU = uPort.SalinityPSU;
                wpManager.Salinity = uPort.SalinityPSU;
                deviceSettingsCommandModeByDefault = uPort.IsCommandModeByDefault;                
            }
            else
            {
                if (remReqIsAuto)
                    switchRemRequestsAuto(0, true);
            }
        }

        #region UI Invokers

        private void InvokePerformUIAction(string uiActionName)
        {
            if (this.InvokeRequired)
                this.Invoke((MethodInvoker)delegate { uiAuto.PerformUIAction(uiActionName); });
            else
                uiAuto.PerformUIAction(uiActionName);
        }

        private void RemoteRequestsAuto()
        {
            if (++remReqCnt >= remReqLimit)
            {
                var lim = remReqLimit;
                switchRemRequestsAuto(0, true);
                MessageBox.Show(string.Format("{0} requests performed.", lim), "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                try
                {
                    var r_code = RC_CODES_Enum.RC_INVALID;

                    if (isAutoCode)
                        r_code = remReqAutoCodes[remReqAutoCodeIdx];
                    else
                        r_code = remReqID;

                    if (uPort.Query_RC(remReqRxChID, remReqTxChID, r_code))
                    {
                        InvokeAppendText(remReqTxb, string.Format("(Tx={0}:Rx={1}) << {2} ?...\r\n",
                            remReqTxChID, remReqRxChID, r_code));

                        remReqAutoCodeIdx = (remReqAutoCodeIdx + 1) % remReqAutoCodes.Length;
                    }
                }
                catch (Exception ex)
                {
                    ProcessException(ex, false);
                }
            }
        }

        private void InvokeRemoteRequestsAuto()
        {
            if (InvokeRequired)
                Invoke((MethodInvoker)delegate { RemoteRequestsAuto(); });
            else
                RemoteRequestsAuto();
        }

        private void InvokeAppendText(RichTextBox rtxb, string text)
        {
            if (rtxb == null) return;

            if (rtxb.InvokeRequired)
                rtxb.Invoke((MethodInvoker)delegate { rtxb.AppendText(text); });
            else
                rtxb.AppendText(text);
        }

        private void InvokeSetText(ToolStrip strip, ToolStripLabel lbl, string text, Color foreColor)
        {
            if (strip.InvokeRequired)
                strip.Invoke((MethodInvoker)delegate
                {
                    lbl.Text = text;
                    lbl.ForeColor = foreColor;
                });
            else
            {
                lbl.Text = text;
                lbl.ForeColor = foreColor;
            }
        }

        private void InvokeUpdatePortStatusLbl(ToolStrip strip, ToolStripLabel lbl, bool active, bool detected, string text)
        {
            Color foreColor = Color.FromKnownColor(KnownColor.ControlText);

            if (active)
            {                
                if (!detected)
                    foreColor = Color.Red;
                else
                    foreColor = Color.Green;
            }

            InvokeSetText(strip, lbl, text, foreColor);
        }

        #endregion

        #endregion

        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Write(uiAuto.GetPropertyStateLogString<MainForm>(this, nameof(mainTabPageIdx))); 
        }




        private void rollDegBtn_Click(object sender, EventArgs e)
        {
            lsChart.ChartAreas[5].Visible = !lsChart.ChartAreas[5].Visible;
            rollDegBtn.Checked = lsChart.ChartAreas[5].Visible;
        }

        private void pitchDegBtn_Click(object sender, EventArgs e)
        {
            lsChart.ChartAreas[4].Visible = !lsChart.ChartAreas[4].Visible;
            pitchDegBtn.Checked = lsChart.ChartAreas[4].Visible;
        }

        private void voltageVBtn_Click(object sender, EventArgs e)
        {
            lsChart.ChartAreas[3].Visible = !lsChart.ChartAreas[3].Visible;
            voltageVBtn.Checked = lsChart.ChartAreas[3].Visible;
        }

        private void depthmBtn_Click(object sender, EventArgs e)
        {
            lsChart.ChartAreas[2].Visible = !lsChart.ChartAreas[2].Visible;
            depthmBtn.Checked = lsChart.ChartAreas[2].Visible;
        }

        private void temperaturedegCBtn_Click(object sender, EventArgs e)
        {
            lsChart.ChartAreas[1].Visible = !lsChart.ChartAreas[1].Visible;
            temperaturedegCBtn.Checked = lsChart.ChartAreas[1].Visible;
        }

        private void pressuremBarBtn_Click(object sender, EventArgs e)
        {
            lsChart.ChartAreas[0].Visible = !lsChart.ChartAreas[0].Visible;
            pressuremBarBtn.Checked = lsChart.ChartAreas[0].Visible;
        }
    }
}
