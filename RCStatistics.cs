﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCNLDrivers;
using UCNLNav;

namespace uWaveCommander
{
    public class StatValue
    {
        #region Properties

        public int TotalSamples { get; private set; }

        public double LastValue { get; private set; }
        public double MinValue { get; private set; }
        public double MaxValue { get; private set; }

        public double MeanValue { get; private set; }

        public double Sigma { get; private set; }

        public string FmtString { get; private set; }

        public List<double> vals { get; private set; }

        #endregion

        #region Constructor

        public StatValue(string fmtString)
        {
            FmtString = fmtString;
            vals = new List<double>();
            Clear();
        }

        #endregion

        #region Methods

        public void Clear()
        {
            TotalSamples = 0;
            LastValue = double.NaN;
            MinValue = double.MaxValue;
            MaxValue = double.MinValue;
            MeanValue = double.NaN;
            Sigma = double.NaN;
            vals.Clear();
        }

        public void Add(double nextValue)
        {
            LastValue = nextValue;
            if (nextValue > MaxValue)
                MaxValue = nextValue;
            if (nextValue < MinValue)
                MinValue = nextValue;

            vals.Add(nextValue);
            double sum = 0.0;
            double sigma = 0.0;

            foreach (var item in vals)
            {
                sum += item;
            }

            MeanValue = sum / vals.Count;

            foreach (var item in vals)
            {
                sigma += Math.Pow(item - MeanValue, 2);
            }

            Sigma = sigma / vals.Count;

            TotalSamples++;
        }

        public string GetValuesToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var val in vals)
            {
                sb.Append(val.ToString(FmtString, CultureInfo.InvariantCulture));
                sb.Append(", ");
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            if (TotalSamples > 0)
            {
                return string.Format("{0} .. {1} .. {2}, {3}, {4} ({5} smps)",
                    MinValue.ToString(FmtString, CultureInfo.InvariantCulture),
                    MeanValue.ToString(FmtString, CultureInfo.InvariantCulture),
                    MaxValue.ToString(FmtString, CultureInfo.InvariantCulture),
                    Sigma.ToString(FmtString, CultureInfo.InvariantCulture),
                    LastValue.ToString(FmtString, CultureInfo.InvariantCulture),
                    TotalSamples);
            }
            else
                return "- - -";
        }

        #endregion
    }

    public class RCStatistics
    {
        #region Properties

        public int RequestsSucceeded { get; private set; }
        public int RequestsFailed { get; private set; }

        Dictionary<string, StatValue> statValues;

        #endregion

        #region Constructor

        public RCStatistics()
        {
            statValues = new Dictionary<string, StatValue>();
        }

        #endregion

        #region Methods

        public StatValue GetStatValue(string id)
        {
            return statValues[id];
        }

        public void InitStatValue(string key, string fmtString)
        {
            statValues.Add(key, new StatValue(fmtString));
        }

        public void Clear()
        {
            RequestsSucceeded = 0;
            RequestsFailed = 0;
            foreach (var item in statValues)
                item.Value.Clear();

            StatisticsUpdated.Rise(this, new EventArgs());
        }

        public void AddMeasurement(string key, double value)
        {
            if (statValues.ContainsKey(key))
            {
                statValues[key].Add(value);                
            }
            else
                throw new KeyNotFoundException();
        }

        public void AddSuccess()
        {
            RequestsSucceeded++;
            StatisticsUpdated.Rise(this, new EventArgs());
        }

        public void AddFail()
        {
            RequestsFailed++;
            StatisticsUpdated.Rise(this, new EventArgs());
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            int total = RequestsSucceeded + RequestsFailed;

            sb.AppendFormat("Total requests performed: {0}\r\n", total);

            if (total > 0)
            {
                double succeededPercent = 100.0 * RequestsSucceeded / (double)total;
                double failedPercent = 100.0 * RequestsFailed / (double)total;

                sb.AppendFormat("Request succeeded: {0} ({1:F01}%)\r\n", RequestsSucceeded, succeededPercent);
                sb.AppendFormat("Request failed: {0} ({1:F01}%)\r\n", RequestsFailed, failedPercent);
                sb.AppendLine();
            }

            foreach (var item in statValues)
            {
                if (item.Value.TotalSamples > 0)
                    sb.AppendFormat("{0}: {1}\r\n", item.Key, item.Value.ToString());
            }

            return sb.ToString();
        }

        #endregion

        #region Events

        public EventHandler StatisticsUpdated;

        #endregion
    }
}
