using System;
using UCNLDrivers;
using UCNLNav;
using UCNLNMEA;

namespace uWaveCommander.uWave
{
    #region Miscelaneous EventArgs

    public class ACKReceivedEventArgs : EventArgs
    {
        #region Properties

        public ICs SentenceID { get; private set; }
        public LOC_ERR_Enum ErrorID { get; private set; }

        #endregion

        #region Constructor

        public ACKReceivedEventArgs(ICs sntID, LOC_ERR_Enum errID)
        {
            SentenceID = sntID;
            ErrorID = errID;
        }

        #endregion
    }

    public class RCTimeoutReceivedEventArgs : EventArgs
    {
        #region Properties

        public int TxChID { get; private set; }
        public int RxChID { get; private set; }
        public RC_CODES_Enum RCCmdID { get; private set; }

        #endregion

        #region Constructor

        public RCTimeoutReceivedEventArgs(int txChID, int rxChID, RC_CODES_Enum rcCmdID)
        {
            TxChID = txChID;
            RxChID = rxChID;
            RCCmdID = rcCmdID;
        }

        #endregion
    }

    public class RCResponseReceivedEventArgs : EventArgs
    {
        #region Properties

        public int TxChID { get; private set; }
        public int RxChID { get; private set; }
        public RC_CODES_Enum RCCmdID { get; private set; }
        public double PropTime_sec { get; private set; }
        public double MSR_db { get; private set; }
        public double Value { get; private set; }
        public double Azimuth { get; private set; }

        public bool IsValuePresent
        {
            get
            {
                return !double.IsNaN(Value);
            }
        }

        public bool IsAzimuthPresent
        {
            get
            {
                return !double.IsNaN(Azimuth);
            }
        }

        #endregion

        #region Constructor

        public RCResponseReceivedEventArgs(int txChID, int rxChID, RC_CODES_Enum rcCmdID, double pTime_sec, double snr_db)
            : this(txChID, rxChID, rcCmdID, pTime_sec, snr_db, double.NaN, double.NaN)
        {
        }

        public RCResponseReceivedEventArgs(int txChID, int rxChID, RC_CODES_Enum rcCmdID, double pTime_sec, double snr_db, double value)
            : this(txChID, rxChID, rcCmdID, pTime_sec, snr_db, value, double.NaN)
        {
        }

        public RCResponseReceivedEventArgs(int txChID, int rxChID, RC_CODES_Enum rcCmdID, double pTime_sec, double snr_db, double value, double azimuth)
        {
            TxChID = txChID;
            RxChID = rxChID;
            RCCmdID = rcCmdID;
            PropTime_sec = pTime_sec;
            MSR_db = snr_db;
            Value = value;
            Azimuth = azimuth;
        }

        #endregion
    }

    public class RCAsyncInReceivedEventArgs : EventArgs
    {
        #region Properties

        public double MSR_dB { get; private set; }
        public RC_CODES_Enum RCCmdID { get; private set; }

        public double Azimuth_deg { get; private set; }

        public bool IsAzimuthPresent
        {
            get => !double.IsNaN(Azimuth_deg);
        }

        #endregion

        #region Constructor

        public RCAsyncInReceivedEventArgs(RC_CODES_Enum rcCmdID, double msr_dB, double azimuth_deg)
        {
            RCCmdID = rcCmdID;
            MSR_dB = msr_dB;
            Azimuth_deg = azimuth_deg;
        }

        #endregion
    }

    public class PacketEventArgs : EventArgs
    {
        #region Properties

        public byte Target_ptAddress { get; private set; }
        public byte TriesTaken { get; private set; }
        public double Azimuth { get; private set; }
        public byte[] DataPacket { get; private set; }

        #endregion

        #region Constructor

        public PacketEventArgs(byte target_ptAddress, byte triesTaken, double azimuth, byte[] dataPacket)
        {
            Target_ptAddress = target_ptAddress;
            TriesTaken = triesTaken;
            Azimuth = azimuth;
            DataPacket = dataPacket;
        }

        #endregion
    }

    public class PacketReceivedEventArgs : EventArgs
    {
        #region Properties

        public byte Target_ptAddress { get; private set; }
        public double Azimuth { get; private set; }
        public byte[] DataPacket { get; private set; }

        #endregion

        #region Constructor

        public PacketReceivedEventArgs(byte target_ptAddress, double azimuth, byte[] dataPacket)
        {
            Target_ptAddress = target_ptAddress;
            Azimuth = azimuth;
            DataPacket = dataPacket;
        }

        #endregion
    }

    public class PacketRequestTimeoutEventArgs : EventArgs
    {
        #region Properties

        public byte Target_ptAddress { get; private set; }
        public DataID_Enum DataId { get; private set; }

        #endregion

        #region Constructor

        public PacketRequestTimeoutEventArgs(byte target_ptAddress, DataID_Enum dataID)
        {
            Target_ptAddress = target_ptAddress;
            DataId = dataID;
        }

        #endregion
    }

    public class PacketResponseEventArgs : EventArgs
    {
        #region Properties

        public byte Target_ptAddress { get; private set; }
        public DataID_Enum DataId { get; private set; }
        public double DataValue { get; private set; }
        public double PropagationTime_s { get; private set; }
        public double Azimuth { get; private set; }

        #endregion

        #region Constructor

        public PacketResponseEventArgs(byte target_ptAddress, DataID_Enum dataID, double dataValue, double pTime, double azimuth)
        {
            Target_ptAddress = target_ptAddress;
            DataId = dataID;
            DataValue = dataValue;
            PropagationTime_s = pTime;
            Azimuth = azimuth;
        }

        #endregion

    }


    public class AQPNGSettingsReceivedEventArgs : EventArgs
    {
        #region Properties

        public AQPNGModeIDs AQPNG_Mode { get; private set; }
        public int PeriodMs { get; private set; }
        public int DataId { get; private set; }
        public int TxID { get; private set; }
        public int RxID { get; private set; }
        public bool IsPT { get; private set; }
        public int PtTargetAddr { get; private set; }

        #endregion

        #region Constructor

        public AQPNGSettingsReceivedEventArgs(AQPNGModeIDs mode, int periodMs, int dataID, int txID, int rxID, bool isPT, int ptAddr)
        {
            AQPNG_Mode = mode;
            PeriodMs = periodMs;
            DataId = dataID;
            TxID = txID;
            RxID = rxID;
            IsPT = isPT;
            PtTargetAddr = ptAddr;
        }

        #endregion
    }


    #endregion

    public class uWaveSerialPort : uSerialPort
    {
        #region Properties

        static bool nmeaSingleton = false;

        ICs lastQueryID = ICs.IC_INVALID;
        int rc_query_rxChID = -1;


        bool isWaitingLocal = false;
        public bool IsWaitingLocal
        {
            get { return isWaitingLocal; }
            private set
            {
                isWaitingLocal = value;
                IsWaitingLocalChanged.Rise(this, new EventArgs());
            }
        }

        bool isWaitingRemote = false;
        public bool IsWaitingRemote
        {
            get { return isWaitingRemote; }
            private set
            {
                isWaitingRemote = value;
                IsWaitingRemoteChanged.Rise(this, new EventArgs());
            }
        }

        bool deviceInfoValid = false;
        public bool IsDeviceInfoValid
        {
            get { return deviceInfoValid; }
            private set
            {
                deviceInfoValid = value;
                DeviceInfoValidChanged.Rise(this, new EventArgs());
            }
        }

        public string SerialNumber { get; private set; }
        public string SystemMoniker { get; private set; }
        public string SystemVersion { get; private set; }
        public string CoreMoniker { get; private set; }
        public string CoreVersion { get; private set; }
        public double AcousticBaudrate { get; private set; }
        public int RxChID { get; private set; }
        public int TxChID { get; private set; }
        public int TotalCodeChannels { get; private set; }
        public double SalinityPSU { get; private set; }
        public bool IsPTS { get; private set; }
        public bool IsCommandModeByDefault { get; private set; }

        public bool IsACKOnTxFinished { get; private set; }

        public int PTAddress { get; private set; }

        public AgingValue<double> Pitch_deg { get; private set; }
        public AgingValue<double> Roll_deg { get; private set; }
        public AgingValue<double> Pressure_mBar { get; private set; }
        public AgingValue<double> Temperature_C { get; private set; }
        public AgingValue<double> Depth_m { get; private set; }
        public AgingValue<double> Voltage_V { get; private set; }

        #endregion

        #region Constructor

        public uWaveSerialPort(BaudRate baudRate)
            : base(baudRate)
        {
            base.PortDescription = "UWV";
            base.IsLogIncoming = true;
            base.IsTryAlways = true;

            NMEAInit();

            #region System state values

            Pitch_deg = new AgingValue<double>(3, 10, uWave.degrees1dec_fmtr);
            Roll_deg = new AgingValue<double>(3, 10, uWave.degrees1dec_fmtr);

            Pressure_mBar = new AgingValue<double>(3, 10, uWave.mBar_fmtr);
            Temperature_C = new AgingValue<double>(3, 10, uWave.degC_fmtr);
            Depth_m = new AgingValue<double>(3, 10, uWave.meters1dec_fmtr);
            Voltage_V = new AgingValue<double>(3, 10, uWave.v1dec_fmt);

            #endregion
        }

        #endregion

        #region Methods

        #region private

        private bool TrySend(string message, ICs queryID)
        {
            bool result = detected && !IsWaitingLocal && !IsWaitingRemote;

            if (result)
            {
                try
                {
                    Send(message);

                    if ((queryID == ICs.IC_H2D_SETTINGS_WRITE) ||
                        (queryID == ICs.IC_H2H_PT_SETTINGS_WRITE) ||
                        (queryID == ICs.IC_H2D_AMB_DTA_CFG) ||
                        (queryID == ICs.IC_H2D_INC_DTA_CFG))
                        StartTimer(3000);
                    else
                        StartTimer(1000);

                    IsWaitingLocal = true;

                    lastQueryID = queryID;
                    result = true;
                }
                catch (Exception ex)
                {
                    LogEventHandler.Rise(this, new LogEventArgs(LogLineType.ERROR, ex));
                }
            }

            return result;
        }

        private void NMEAInit()
        {
            if (!nmeaSingleton)
            {
                nmeaSingleton = true;
                NMEAParser.AddManufacturerToProprietarySentencesBase(ManufacturerCodes.UWV);

                #region Common sentences

                // IC_D2H_ACK             $PUWV0,cmdID,errCode
                NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "0", "c--c,x");

                // IC_H2D_SETTINGS_WRITE  $PUWV1,rxChID,txChID,styPSU,isCmdMode,isACKOnTXFinished,gravityAcc
                NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "1", "x,x,x.x,x,x,x.x");

                #endregion

                #region Short code messages management sentences

                // IC_H2D_RC_REQUEST      $PUWV2,txChID,rxChID,rcCmdID
                NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "2", "x,x,x");

                // IC_D2H_RC_RESPONSE     $PUWV3,txChID,rcCmdID,propTime_seс,snr,[value],[azimuth]
                NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "3", "x,x,x.x,x.x,x.x,x.x");

                // IC_D2H_RC_TIMEOUT      $PUWV4,txChID,rcCmdID
                NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "4", "x,x");

                // IC_D2H_RC_ASYNC_IN     $PUWV5,rcCmdID,snr,[azimuth]
                NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "5", "x,x.x,x.x");

                #endregion

                #region Ambient data management sentences

                // IC_H2D_AMB_DTA_CFG     $PUWV6,isWriteInFlash,periodMs,isPrs,isTemp,isDpt,isBatV
                NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "6", "x,x,x,x,x,x");

                // IC_D2H_AMB_DTA         $PUWV7,prs_mBar,temp_C,dpt_m,batVoltage_V
                NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "7", "x.x,x.x,x.x,x.x");

                //
                NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "8", "x,x");
                NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "9", "x.x,x.x,x.x");

                #endregion

                #region Device info

                // IC_H2D_DINFO_GET       $PUWV?,reserved
                NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "?", "x");

                // IC_D2H_DINFO $PUWV!,serial_number,sys_moniker,sys_version,core_moniker [release],core_version,acBaudrate,rxChID,txChID,totalCh,styPSU,isPTS,isCmdModeDefault                
                NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "!", "c--c,c--c,x,c--c,x,x.x,x,x,x,x.x,x,x");

                #endregion

                #region Packet mode

                // IC_H2D_PT_SETTINGS_READ   $PUWVD,reserved
                NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "D", "x");

                // IC_D2H_PT_SETTINGS        $PUWVE,isPTMode,ptAddress
                NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "E", "x,x");

                // IC_H2H_PT_SETTINGS_WRITE  $PUWVF,isSaveInFlash,isPTMode,ptAddress
                NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "F", "x,x,x");

                // IC_H2D_PT_SEND            $PUWVG,tareget_ptAddress,[maxTries],data
                NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "G", "x,x,h--h");

                // IC_D2H_PT_FAILED          $PUWVH,tareget_ptAddress,triesTaken,data
                NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "H", "x,x,h--h");

                // IC_D2H_PT_DLVRD           $PUWVI,tareget_ptAddress,[azimuth],triesTaken,data
                NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "I", "x,x,x.x,h--h");

                // IC_D2H_PT_RCVD            $PUWVJ,sender_ptAddress,[azimuth],data
                NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "J", "x,x.x,h--h");

                // IC_H2D_PT_ITG             $PUWVK,target_ptAddress,pt_itg_dataID
                NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "K", "x,x");

                // IC_D2H_PT_TMO             $PUWVL,target_ptAddress,pt_itg_dataID
                NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "L", "x,x");

                // IC_D2H_PT_ITG_RESP
                NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "M", "x,x,x.x,x.x,x.x");

                #endregion

                #region AQ-PNG Automatic query / pinger mode management

                // IC_H2D_AQPNG_SETTINGS_READ 'N'   // $PUWVN,reserved
                NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "N", "x");

                // IC_HDH_AQPNG_SETTINGS      'O'   // $PUWVO,[isSaveInFlash],AQPN_ModeID,[periodMs],[rcCmdID],[rcTxID],[rcRxID],[isPT],[pt_targetAddr]
                NMEAParser.AddProprietarySentenceDescription(ManufacturerCodes.UWV, "O", "x,x,x,x,x,x,x,x");

                #endregion
            }
        }

        #region Parsers

        private void Parse_ACK(object[] parameters)
        {
            try
            {
                ICs sntID = uWave.ICsByMessageID((string)parameters[0]);
                LOC_ERR_Enum errID = uWave.O2_LOC_ERR(parameters[1]);

                StopTimer();
                IsWaitingLocal = false;

                if ((sntID == ICs.IC_H2D_RC_REQUEST) ||
                    (sntID == ICs.IC_H2D_PT_ITG))
                {
                    IsWaitingRemote = true;
                    StartTimer(6000);
                }

                ACKReceived.Rise(this, new ACKReceivedEventArgs(sntID, errID));
            }
            catch (Exception ex)
            {
                LogEventHandler.Rise(this, new LogEventArgs(LogLineType.ERROR, ex));
            }
        }

        private void Parse_REM_RESPONSE(object[] parameters)
        {
            try
            {
                // IC_D2H_RC_RESPONSE     $PUWV3,txChID,rcCmdID,propTime_seс,snr,[value],[azimuth]
                int txChID = uWave.O2I(parameters[0]);
                RC_CODES_Enum rcCmdID = uWave.O2_RC_CODES(parameters[1]);
                double pTime = uWave.O2D(parameters[2]);
                double msr = uWave.O2D(parameters[3]);
                double value = uWave.O2D(parameters[4]);

                /// TODO: WARNING!!!!
                double azimuth = uWave.O2D(parameters[5]);

                StopTimer();

                RCResponseReceived.Rise(this, new RCResponseReceivedEventArgs(txChID, rc_query_rxChID, rcCmdID, pTime, msr, value, azimuth));

                IsWaitingRemote = false;
            }
            catch (Exception ex)
            {
                LogEventHandler.Rise(this, new LogEventArgs(LogLineType.ERROR, ex));
            }
        }

        private void Parse_REM_TIMEOUT(object[] parameters)
        {
            try
            {
                // IC_D2H_RC_TIMEOUT      $PUWV4,txChID,rcCmdID
                int txChID = uWave.O2I(parameters[0]);
                RC_CODES_Enum rcCmdID = uWave.O2_RC_CODES(parameters[1]);

                StopTimer();
                IsWaitingRemote = false;

                RCTimeoutReceived.Rise(this, new RCTimeoutReceivedEventArgs(txChID, rc_query_rxChID, rcCmdID));
            }
            catch (Exception ex)
            {
                LogEventHandler.Rise(this, new LogEventArgs(LogLineType.ERROR, ex));
            }
        }

        private void Parse_REM_ASYNC_IN(object[] parameters)
        {
            try
            {
                // IC_D2H_RC_ASYNC_IN     $PUWV5,rcCmdID,snr,[azimuth]
                RC_CODES_Enum rcCmdID = uWave.O2_RC_CODES(parameters[0]);
                double msr = uWave.O2D(parameters[1]);                
                double azimuth = uWave.O2D(parameters[2]);

                StopTimer();
                IsWaitingRemote = false;

                RCAsyncInReceived.Rise(this, new RCAsyncInReceivedEventArgs(rcCmdID, msr, azimuth));
            }
            catch (Exception ex)
            {
                LogEventHandler.Rise(this, new LogEventArgs(LogLineType.ERROR, ex));
            }
        }

        private void Parse_AMB_DTA(object[] parameters)
        {
            try
            {
                // IC_D2H_AMB_DTA         $PUWV7,prs_mBar,temp_C,dpt_m,batVoltage_V
                double prs = uWave.O2D(parameters[0]);
                double temp = uWave.O2D(parameters[1]);
                double dpt = uWave.O2D(parameters[2]);
                double vcc = uWave.O2D(parameters[3]);

                if (!double.IsNaN(prs))
                    Pressure_mBar.Value = prs;

                if (!double.IsNaN(temp))
                    Temperature_C.Value = temp;

                if (!double.IsNaN(dpt))
                    Depth_m.Value = dpt;

                if (!double.IsNaN(vcc))
                    Voltage_V.Value = vcc;

                AMBDataUpdated.Rise(this, new EventArgs());
            }
            catch (Exception ex)
            {
                LogEventHandler.Rise(this, new LogEventArgs(LogLineType.ERROR, ex));
            }
        }

        private void Parse_INC_DTA(object[] parameters)
        {
            try
            {
                // $PUWV9,[reserved empty field],pitch,roll
                double pitch = uWave.O2D(parameters[1]);
                double roll = uWave.O2D(parameters[2]);

                if (!double.IsNaN(pitch))
                    Pitch_deg.Value = pitch;

                if (!double.IsNaN(roll))
                    Roll_deg.Value = roll;

                PTCROLDataUpdated.Rise(this, new EventArgs());
            }
            catch (Exception ex)
            {
                LogEventHandler.Rise(this, new LogEventArgs(LogLineType.ERROR, ex));
            }
        }

        private void Parse_DINFO(object[] parameters)
        {
            try
            {
                // $PUWV!,serial,sys_moniker,sys_version,core_moniker [release],core_version,acBaudrate,rxChID,txChID,maxChannels,styPSU,isPTS,isCmdMode                
                var sn = uWave.O2S(parameters[0]);
                var sysMoniker = uWave.O2S(parameters[1]);
                var sysVersion = uWave.BCDVersionToStr(uWave.O2I(parameters[2]));
                var creMoniker = uWave.O2S(parameters[3]);
                var creVersion = uWave.BCDVersionToStr(uWave.O2I(parameters[4]));
                var acBaudrate = uWave.O2D(parameters[5]);
                var rxChID = uWave.O2I(parameters[6]);
                var txChID = uWave.O2I(parameters[7]);
                var totalCh = uWave.O2I(parameters[8]);
                var styPSU = uWave.O2D(parameters[9]);
                int isPTSFlag = uWave.O2I(parameters[10]);

                bool isPTS = true;
                if (isPTSFlag == 0)
                    isPTS = false;

                var isCmdMode = Convert.ToBoolean(uWave.O2I(parameters[11]));

                StopTimer();
                IsWaitingLocal = false;

                SerialNumber = sn;
                SystemMoniker = sysMoniker;
                SystemVersion = sysVersion;
                CoreMoniker = creMoniker;
                CoreVersion = creVersion;
                AcousticBaudrate = acBaudrate;
                RxChID = rxChID;
                TxChID = txChID;
                TotalCodeChannels = totalCh;
                SalinityPSU = styPSU;
                IsPTS = isPTS;
                IsCommandModeByDefault = isCmdMode;

                IsDeviceInfoValid = true;
            }
            catch (Exception ex)
            {
                LogEventHandler.Rise(this, new LogEventArgs(LogLineType.ERROR, ex));
            }
        }

        private void Parse_PT_SETTINGS(object[] parameters)
        {
            try
            {
                bool isPTMode = Convert.ToBoolean(uWave.O2I(parameters[0]));
                byte ptAddress = Convert.ToByte(uWave.O2I(parameters[1]));

                //IsPacketMode = isPTMode;
                PTAddress = ptAddress;

                StopTimer();
                IsWaitingLocal = false;

                PacketModeSettingsReceived.Rise(this, new EventArgs());
            }
            catch (Exception ex)
            {
                LogEventHandler.Rise(this, new LogEventArgs(LogLineType.ERROR, ex));
            }
        }

        private void Parse_PT_FAILED(object[] parameters)
        {
            try
            {
                byte target_ptAddress = Convert.ToByte(uWave.O2I(parameters[0]));
                byte triesTaken = Convert.ToByte(uWave.O2I(parameters[1]));
                byte[] dataPacket = (byte[])(parameters[2]);

                PacketTransferFailed.Rise(this, new PacketEventArgs(target_ptAddress, triesTaken, double.NaN, dataPacket));
            }
            catch (Exception ex)
            {
                LogEventHandler.Rise(this, new LogEventArgs(LogLineType.ERROR, ex));
            }
        }

        private void Parse_PT_DLVRD(object[] parameters)
        {
            // $PUWVI,tareget_ptAddress,triesTaken,azimuth,dataPacket
            try
            {
                byte target_ptAddress = Convert.ToByte(uWave.O2I(parameters[0]));
                byte triesTaken = Convert.ToByte(uWave.O2I(parameters[1]));
                double azimuth = uWave.O2D(parameters[2]);                               
                byte[] dataPacket = (byte[])parameters[3];

                PacketTransferred.Rise(this, new PacketEventArgs(target_ptAddress, triesTaken, azimuth, dataPacket));
            }
            catch (Exception ex)
            {
                LogEventHandler.Rise(this, new LogEventArgs(LogLineType.ERROR, ex));
            }
        }

        private void Parse_PT_RCVD(object[] parameters)
        {
            // $PUWVJ,sender_ptAddress,azimuth,dataPacket
            try
            {
                byte sender_ptAddress = Convert.ToByte(uWave.O2I(parameters[0]));
                double azimuth = uWave.O2D(parameters[1]);
                byte[] dataPacket = (byte[])parameters[2];

                PacketReceived.Rise(this, new PacketReceivedEventArgs(sender_ptAddress, azimuth, dataPacket));
            }
            catch (Exception ex)
            {
                LogEventHandler.Rise(this, new LogEventArgs(LogLineType.ERROR, ex));
            }
        }


        private void Parse_PT_ITG_TMO(object[] parameters)
        {
            try
            {
                byte target_ptAddress = Convert.ToByte(uWave.O2I(parameters[0]));
                DataID_Enum dataID = uWave.O2_DATA_ID(parameters[1]);

                StopTimer();
                IsWaitingRemote = false;

                PacketRequestTimeout.Rise(this, new PacketRequestTimeoutEventArgs(target_ptAddress, dataID));
            }
            catch (Exception ex)
            {
                LogEventHandler.Rise(this, new LogEventArgs(LogLineType.ERROR, ex));
            }
        }

        private void Parse_PT_ITG_RESP(object[] parameters)
        {
            // $PUWVM,target_ptAddress,pt_itg_dataID,[dataValue],pTime,[azimuth]

            try
            {
                byte target_ptAddress = Convert.ToByte(uWave.O2I(parameters[0]));
                DataID_Enum dataID = uWave.O2_DATA_ID(parameters[1]);
                double dataValue = uWave.O2D(parameters[2]);
                double pTime = uWave.O2D(parameters[3]);
                double azimuth = uWave.O2D(parameters[4]);

                StopTimer();
                IsWaitingRemote = false;

                PacketResponse.Rise(this, new PacketResponseEventArgs(target_ptAddress, dataID, dataValue, pTime, azimuth));
            }
            catch (Exception ex)
            {
                LogEventHandler.Rise(this, new LogEventArgs(LogLineType.ERROR, ex));
            }
        }


        private void Parse_AQPNG_SETTINGS(object[] parameters)
        {
            // $PUWVO,[isSaveInFlash],AQPN_ModeID,[periodMs],[rcCmdID],[rcTxID],[rcRxID],[isPT],[pt_targetAddr]
            try
            {
                //
                AQPNGModeIDs modeID = uWave.O2_AQPNG_MODE(parameters[1]);
                int periodMs = uWave.O2I(parameters[2]);
                int dataID = uWave.O2I(parameters[3]);
                int txID = uWave.O2I(parameters[4]);
                int rxID = uWave.O2I(parameters[5]);
                bool isPT = Convert.ToBoolean(uWave.O2I(parameters[6]));
                int ptTargetAddr = uWave.O2I(parameters[7]);

                StopTimer();
                IsWaitingLocal = false;

                AQPNGSettingsReceived.Rise(this, new AQPNGSettingsReceivedEventArgs(modeID, periodMs, dataID, txID, rxID, isPT, ptTargetAddr));
            }
            catch (Exception ex)
            {
                LogEventHandler.Rise(this, new LogEventArgs(LogLineType.ERROR, ex));
            }
        }


        #endregion

        #endregion

        #region public

        public bool Query_DINFO()
        {
            var msg = NMEAParser.BuildProprietarySentence(ManufacturerCodes.UWV, "?", new object[] { 0 });
            return TrySend(msg, ICs.IC_H2D_DINFO_GET);
        }

        public bool Query_SETTINGS_WRITE(int txChID, int rxChID, double salinityPSU, bool isCmdMode, bool isACKOnTXFinished, double gravityAcc)
        {
            var msg = NMEAParser.BuildProprietarySentence(ManufacturerCodes.UWV, "1", new object[]
            {
                txChID,
                rxChID,
                salinityPSU,
                Convert.ToInt32(isCmdMode),
                Convert.ToInt32(isACKOnTXFinished),
                gravityAcc
            });

            return TrySend(msg, ICs.IC_H2D_SETTINGS_WRITE);
        }

        public bool Query_AMB_CFG_WRITE(bool isSaveToFlash, int periodMs, bool isPressure, bool isTemperature, bool isDepth, bool isVCC)
        {
            var msg = NMEAParser.BuildProprietarySentence(ManufacturerCodes.UWV, "6", new object[]
            {
                Convert.ToInt32(isSaveToFlash),
                periodMs,
                Convert.ToInt32(isPressure),
                Convert.ToInt32(isTemperature),
                Convert.ToInt32(isDepth),
                Convert.ToInt32(isVCC)
            });

            return TrySend(msg, ICs.IC_H2D_AMB_DTA_CFG);
        }

        public bool Query_PTCROL_CFG_WRITE(bool isSaveToFlash, int periodMs)
        {
            var msg = NMEAParser.BuildProprietarySentence(ManufacturerCodes.UWV, "8", new object[]
            {
                Convert.ToInt32(isSaveToFlash),
                periodMs
            });

            return TrySend(msg, ICs.IC_H2D_INC_DTA_CFG);
        }

        public bool Query_RC(int txChID, int rxChID, RC_CODES_Enum cmdID)
        {
            if (!IsWaitingRemote)
            {
                var msg = NMEAParser.BuildProprietarySentence(ManufacturerCodes.UWV, "2", new object[]
                {
                    txChID,
                    rxChID,
                    (int)cmdID
                });

                rc_query_rxChID = rxChID;

                return TrySend(msg, ICs.IC_H2D_RC_REQUEST);
            }
            else
            {
                LogEventHandler.Rise(this, new LogEventArgs(LogLineType.ERROR, "Unable to perform a remote request due to waiting for previous"));
                return false;
            }
        }

        public bool Query_PT_SETTINGS()
        {
            var msg = NMEAParser.BuildProprietarySentence(ManufacturerCodes.UWV, "D", new object[] { 0 });
            return TrySend(msg, ICs.IC_H2D_PT_SETTINGS_READ);
        }

        public bool Query_PT_SETTINGS_WRITE(bool isSaveInFlash, bool isPTMode, byte ptAddress)
        {
            var msg = NMEAParser.BuildProprietarySentence(ManufacturerCodes.UWV, "F", new object[] 
            { 
                Convert.ToInt32(isSaveInFlash), 
                Convert.ToInt32(isPTMode), 
                (int)ptAddress 
            });
            return TrySend(msg, ICs.IC_H2H_PT_SETTINGS_WRITE);
        }


        public bool Query_PT_ABORT_SEND()
        {
            var msg = NMEAParser.BuildProprietarySentence(ManufacturerCodes.UWV, "G", new object[] 
            { 
                null, 
                null, 
                null 
            });
            return TrySend(msg, ICs.IC_H2D_PT_SEND);
        }

        public bool Query_PT_SEND(byte target_ptAddress, byte[] data)
        {
            if (data.Length <= uWave.PT_MAX_PACKET_SIZE)
            {
                var msg = NMEAParser.BuildProprietarySentence(ManufacturerCodes.UWV, "G", new object[] 
                { 
                    (int)target_ptAddress, 
                    null, 
                    data 
                });
                return TrySend(msg, ICs.IC_H2D_PT_SEND);
            }
            return false;
        }

        public bool Query_PT_SEND(byte target_ptAddress, byte maxTries, byte[] data)
        {
            if (data.Length <= uWave.PT_MAX_PACKET_SIZE)
            {
                var msg = NMEAParser.BuildProprietarySentence(ManufacturerCodes.UWV, "G", new object[] 
                { 
                    (int)target_ptAddress, 
                    (int)maxTries, 
                    data 
                });
                return TrySend(msg, ICs.IC_H2D_PT_SEND);
            }
            return false;
        }


        public bool Query_PT_ITG(byte target_ptAddress, DataID_Enum dataID)
        {
            var msg = NMEAParser.BuildProprietarySentence(ManufacturerCodes.UWV, "K", new object[] 
            { 
                (int)target_ptAddress, 
                (int)dataID 
            });
            return TrySend(msg, ICs.IC_H2D_PT_ITG);
        }



        public bool Query_AQPNG_SETTINGS()
        {
            var msg = NMEAParser.BuildProprietarySentence(ManufacturerCodes.UWV, "N", new object[] { 0 });
            return TrySend(msg, ICs.IC_H2D_AQPNG_SETTINGS_READ);
        }

        public bool Query_AQPNG_SETTINGS_WRITE(bool isSaveToFlash, AQPNGModeIDs modeID, int periodMs, int dataID, int rcTxChID, int rcRxChID, bool isPT, int pt_targetAddr)
        {
            var msg = NMEAParser.BuildProprietarySentence(ManufacturerCodes.UWV, "O", new object[]
            {
                Convert.ToInt32(isSaveToFlash),
                Convert.ToInt32(modeID),
                periodMs,
                dataID,
                rcTxChID,
                rcRxChID,
                Convert.ToInt32(isPT),
                pt_targetAddr
            });

            return TrySend(msg, ICs.IC_HDH_AQPNG_SETTINGS);
        }

        #endregion

        #endregion

        #region uSerialPort

        public override void InitQuerySend()
        {
            var msg = NMEAParser.BuildProprietarySentence(ManufacturerCodes.UWV, "?", new object[] { 0 });
            Send(msg);
        }

        public override void OnClosed()
        {
            StopTimer();
            IsDeviceInfoValid = false;
            isWaitingLocal = false;
            isWaitingRemote = false;
        }

        public override void ProcessIncoming(NMEASentence sentence)
        {
            if (sentence is NMEAProprietarySentence)
            {
                NMEAProprietarySentence pSentence = (sentence as NMEAProprietarySentence);

                if (pSentence.Manufacturer == ManufacturerCodes.UWV)
                {
                    if (!detected)
                    {
                        detected = true;
                        StopTimer();
                    }

                    if (pSentence.SentenceIDString == "0")
                        Parse_ACK(pSentence.parameters);
                    else if (pSentence.SentenceIDString == "3")
                        Parse_REM_RESPONSE(pSentence.parameters);
                    else if (pSentence.SentenceIDString == "4")
                        Parse_REM_TIMEOUT(pSentence.parameters);
                    else if (pSentence.SentenceIDString == "5")
                        Parse_REM_ASYNC_IN(pSentence.parameters);
                    else if (pSentence.SentenceIDString == "7")
                        Parse_AMB_DTA(pSentence.parameters);
                    else if (pSentence.SentenceIDString == "9")
                        Parse_INC_DTA(pSentence.parameters);
                    else if (pSentence.SentenceIDString == "E")
                        Parse_PT_SETTINGS(pSentence.parameters);
                    else if (pSentence.SentenceIDString == "H")
                        Parse_PT_FAILED(pSentence.parameters);
                    else if (pSentence.SentenceIDString == "I")
                        Parse_PT_DLVRD(pSentence.parameters);
                    else if (pSentence.SentenceIDString == "J")
                        Parse_PT_RCVD(pSentence.parameters);
                    else if (pSentence.SentenceIDString == "L")
                        Parse_PT_ITG_TMO(pSentence.parameters);
                    else if (pSentence.SentenceIDString == "M")
                        Parse_PT_ITG_RESP(pSentence.parameters);
                    else if (pSentence.SentenceIDString == "O")
                        Parse_AQPNG_SETTINGS(pSentence.parameters);                        
                    else if (pSentence.SentenceIDString == "!")
                        Parse_DINFO(pSentence.parameters);
                }
            }
        }

        #endregion

        #region Events

        public EventHandler IsWaitingLocalChanged;
        public EventHandler IsWaitingRemoteChanged;

        public EventHandler<ACKReceivedEventArgs> ACKReceived;
        public EventHandler<RCResponseReceivedEventArgs> RCResponseReceived;
        public EventHandler<RCTimeoutReceivedEventArgs> RCTimeoutReceived;
        public EventHandler<RCAsyncInReceivedEventArgs> RCAsyncInReceived;

        public EventHandler PacketModeSettingsReceived;
        public EventHandler<PacketEventArgs> PacketTransferFailed;
        public EventHandler<PacketEventArgs> PacketTransferred;
        public EventHandler<PacketReceivedEventArgs> PacketReceived;

        public EventHandler<PacketRequestTimeoutEventArgs> PacketRequestTimeout;
        public EventHandler<PacketResponseEventArgs> PacketResponse;

        public EventHandler<AQPNGSettingsReceivedEventArgs> AQPNGSettingsReceived;

        public EventHandler AMBDataUpdated;
        public EventHandler PTCROLDataUpdated;
        public EventHandler DeviceInfoValidChanged;

        #endregion
    }
}
