using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FroneriATS.Module.Core
{
    public class PathHelper
    {
        public static string GetApplicationFolder()
        {
            return AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
        }
        public static string GetTempFolder()
        {
            return AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "temp\\";
        }

    }
}
