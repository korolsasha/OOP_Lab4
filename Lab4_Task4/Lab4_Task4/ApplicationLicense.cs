using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Task4
{
    class ApplicationLicense
    {
        public enum LicenseTypes
        {
            Common = 0,
            Trial,
            Pro
        }

        private string TrialKey = "ALDS5-3OLJN-S2KJN-SDF8V-DXKJC";
        private string ProKey = "2XDK4-SJF89-LCVKJ-HGJK3-AZCVN";

        public LicenseTypes License
        {
            get;
            set;
        }

        public LicenseTypes DefineLicense(string key)
        {
            if (key == TrialKey)
            {
                AllowTrial();
            }
            else if (key == ProKey)
            {
                AllowPro();
            }
            else
            {
                AllowCommon();
            }

            return License;
        }

        public void AllowCommon()
        {
            License = LicenseTypes.Common;
        }

        public void AllowTrial()
        {
            License = LicenseTypes.Trial;
        }
        public void AllowPro()
        {
            License = LicenseTypes.Pro;
        }
    }
}
