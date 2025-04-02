﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCNLDrivers;

namespace uWaveCommander.uWave
{
    #region Custom enums

    public enum AMB_PERIOD_Enum
    {
        NEVER = 0,
        TANDEM = 1,
        _1_SEC = 1000,
        _2_SEC = 2000,
        _4_SEC = 4000,
        _5_SEC = 5000,
        _6_SEC = 6000,
        _7_SEC = 7000,
        _8_SEC = 8000,
        _9_SEC = 9000,
        _10_SEC = 10000,
        _30_SEC = 30000,
        _1_MIN = 60000,
        _5_MIN = 300000
    }

    public enum DataID_Enum
    {
        DID_DPT = 0,
        DID_TMP = 1,
        DID_BAT = 2,
        DID_INVALID
    }

    public enum RC_CODES_Enum
    {
        RC_PING = 0,
        RC_PONG = 1,
        RC_DPT_GET = 2,
        RC_TMP_GET = 3,
        RC_BAT_V_GET = 4,
        RC_ERR_NSUP = 5,
        RC_ACK = 6,
        RC_USR_CMD_000 = 7,
        RC_USR_CMD_001 = 8,
        RC_USR_CMD_002 = 9,
        RC_USR_CMD_003 = 10,
        RC_USR_CMD_004 = 11,
        RC_USR_CMD_005 = 12,
        RC_USR_CMD_006 = 13,
        RC_USR_CMD_007 = 14,
        RC_USR_CMD_008 = 15,
        RC_MSG_ASYNC_IN = 16,
        RC_INVALID
    }

    public enum LOC_ERR_Enum
    {
        LOC_ERR_NO_ERROR = 0,
        LOC_ERR_INVALID_SYNTAX = 1,
        LOC_ERR_UNSUPPORTED = 2,
        LOC_ERR_TRANSMITTER_BUSY = 3,
        LOC_ERR_ARGUMENT_OUT_OF_RANGE = 4,
        LOC_ERR_INVALID_OPERATION = 5,
        LOC_ERR_UNKNOWN_FIELD_ID = 6,
        LOC_ERR_VALUE_UNAVAILABLE = 7,
        LOC_ERR_RECEIVER_BUSY = 8,
        LOC_ERR_TX_BUFFER_OVERRUN = 9,
        LOC_ERR_CHKSUM_ERROR = 10,
        LOC_ERR_TX_FINISHED = 11,
        LOC_ACK_BEFORE_STANDBY = 12,
        LOC_ACK_AFTER_WAKEUP = 13,
        LOC_ERR_SVOLTAGE_TOO_HIGH = 14,
        LOC_ERR_UNKNOWN
    }

    public enum ICs
    {
        IC_D2H_ACK,
        IC_H2D_SETTINGS_WRITE,
        IC_H2D_RC_REQUEST,
        IC_D2H_RC_RESPONSE,
        IC_D2H_RC_TIMEOUT,
        IC_D2H_RC_ASYNC_IN,
        IC_H2D_AMB_DTA_CFG,
        IC_D2H_AMB_DTA,

        IC_H2D_INC_DTA_CFG,
        IC_D2H_INC_DTA,

        IC_H2D_DINFO_GET,
        IC_D2H_DINFO,

        IC_H2D_PT_SETTINGS_READ,
        IC_D2H_PT_SETTINGS,
        IC_H2H_PT_SETTINGS_WRITE,
        IC_H2D_PT_SEND,
        IC_D2H_PT_FAILED,
        IC_D2H_PT_DLVRD,
        IC_D2H_PT_RCVD,

        IC_H2D_PT_ITG,
        IC_D2H_PT_ITG_TMO,
        IC_D2H_PT_ITG_RESP,

        IC_H2D_AQPNG_SETTINGS_READ,
        IC_HDH_AQPNG_SETTINGS,

        IC_D2H_ANY,
        IC_INVALID
    }

    public enum AQPNGModeIDs
    {
        AQPNG_DISABLED = 0,
        AQPNG_PINGER = 1,
        AQPNG_MASTER = 2,
        AQPNG_INVALID
    }

    #endregion

    public static class uWave
    {
        public static readonly double MIN_TEMPERATURE_C = -4.0;
        public static readonly double MAX_TEMPERATURE_C = 46.0;
        public static readonly double MIN_DEPTH_M = 0.0;
        public static readonly double MAX_DEPTH_M = 300.0;
        public static readonly double MIN_BAT_VOLTAGE = 0.0;
        public static readonly double MAX_BAT_VOLTAGE = 20.0;
        public static readonly double CR_DPT_OFFSET = 0;
        public static readonly double CR_DPT_CRANGE = 3000;
        public static readonly double CR_TMP_OFFSET = 3001;
        public static readonly double CR_TMP_CRANGE = 500;
        public static readonly double CR_BAT_OFFSET = 3502;
        public static readonly double CR_BAT_CRANGE = 200;
        public static readonly double CR_DPT_RANGE = (MAX_DEPTH_M - MIN_DEPTH_M);
        public static readonly double CR_DPT_SCALE = (CR_DPT_RANGE / CR_DPT_CRANGE);
        public static readonly double CR_TMP_RANGE = (MAX_TEMPERATURE_C - MIN_TEMPERATURE_C);
        public static readonly double CR_TMP_SCALE = (CR_TMP_RANGE / CR_TMP_CRANGE);
        public static readonly double CR_BAT_RANGE = (MAX_BAT_VOLTAGE - MIN_BAT_VOLTAGE);
        public static readonly double CR_BAT_SCALE = (CR_BAT_RANGE / CR_BAT_CRANGE);

        public static readonly int CR_STRONG_MAX_CODE_CHANNELS = 28;

        public static readonly int PT_MAX_PACKET_SIZE = 64;

        public static readonly BaudRate CR_DEFAULT_BAUDRATE = BaudRate.baudRate9600;

        static Dictionary<string, ICs> ICsIdxArray = new Dictionary<string, ICs>()
        {
            { "0", ICs.IC_D2H_ACK },
            { "1", ICs.IC_H2D_SETTINGS_WRITE },
            { "2", ICs.IC_H2D_RC_REQUEST },
            { "3", ICs.IC_D2H_RC_RESPONSE },
            { "4", ICs.IC_D2H_RC_TIMEOUT },
            { "5", ICs.IC_D2H_RC_ASYNC_IN },
            { "6", ICs.IC_H2D_AMB_DTA_CFG },
            { "7", ICs.IC_D2H_AMB_DTA },

            { "8", ICs.IC_H2D_INC_DTA_CFG },
            { "9", ICs.IC_D2H_INC_DTA },

            { "?", ICs.IC_H2D_DINFO_GET },
            { "!", ICs.IC_D2H_DINFO },

            { "D", ICs.IC_H2D_PT_SETTINGS_READ },
            { "E", ICs.IC_D2H_PT_SETTINGS },
            { "F", ICs.IC_H2H_PT_SETTINGS_WRITE },
            { "G", ICs.IC_H2D_PT_SEND },
            { "H", ICs.IC_D2H_PT_FAILED },
            { "I", ICs.IC_D2H_PT_DLVRD },
            { "J", ICs.IC_D2H_PT_RCVD },

            {"K", ICs.IC_H2D_PT_ITG },
            {"L", ICs.IC_D2H_PT_ITG_TMO },
            {"M", ICs.IC_D2H_PT_ITG_RESP },

            {"N", ICs.IC_H2D_AQPNG_SETTINGS_READ },
            {"O", ICs.IC_HDH_AQPNG_SETTINGS },

            { "-", ICs.IC_D2H_ANY }
        };

        public static readonly Func<object, AQPNGModeIDs> O2_AQPNG_MODE = o => o == null ? AQPNGModeIDs.AQPNG_INVALID : (AQPNGModeIDs)(int)o;
        public static readonly Func<object, DataID_Enum> O2_DATA_ID = o => o == null ? DataID_Enum.DID_INVALID : (DataID_Enum)(int)o;
        public static readonly Func<object, RC_CODES_Enum> O2_RC_CODES = o => o == null ? RC_CODES_Enum.RC_INVALID : (RC_CODES_Enum)(int)o;
        public static readonly Func<object, LOC_ERR_Enum> O2_LOC_ERR = o => o == null ? LOC_ERR_Enum.LOC_ERR_UNKNOWN : (LOC_ERR_Enum)(int)o;
        public static readonly Func<object, string> O2S = o => o == null ? string.Empty : (string)o;
        public static readonly Func<object, double> O2D = o => o == null ? double.NaN : (double)o;
        public static readonly Func<object, int> O2I = o => o == null ? -1 : (int)o;


        public static readonly Func<double, string> meters1dec_fmtr = o => string.Format("{0:F01} m", o, CultureInfo.InvariantCulture);
        public static readonly Func<double, string> degrees1dec_fmtr = o => string.Format("{0:F01} °", o, CultureInfo.InvariantCulture);
        public static readonly Func<double, string> latlon_fmtr = o => string.Format("{0:F06} °", o, CultureInfo.InvariantCulture);
        public static readonly Func<double, string> db_fmtr = o => string.Format("{0:F01} dB", o, CultureInfo.InvariantCulture);
        public static readonly Func<double, string> degC_fmtr = o => string.Format("{0:F01} °C", o, CultureInfo.InvariantCulture);
        public static readonly Func<double, string> mBar_fmtr = o => string.Format("{0:F01} mBar", o, CultureInfo.InvariantCulture);
        public static readonly Func<double, string> v1dec_fmt = o => string.Format("{0:F01} V", o, CultureInfo.InvariantCulture);

        public static ICs ICsByMessageID(string msgID)
        {
            if (ICsIdxArray.ContainsKey(msgID))
                return ICsIdxArray[msgID];
            else
                return ICs.IC_INVALID;
        }

        public static string BCDVersionToStr(int versionData)
        {
            return string.Format("{0}.{1}", (versionData >> 0x08).ToString(), (versionData & 0xff).ToString("X2"));
        }
    }
}
