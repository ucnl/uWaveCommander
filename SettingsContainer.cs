using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCNLDrivers;

namespace uWaveCommander
{
    public class SettingsContainer : SimpleSettingsContainer
    {
        #region Properties

        public string CultureOverride;

        #endregion

        #region Methods

        public override void SetDefaults()
        {
            CultureOverride = string.Empty;
        }

        #endregion
    }
}
