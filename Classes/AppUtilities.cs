using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
 using System.Diagnostics;

namespace Asso.Launcher.Classes
{
    public static class AppUtilities
    {
        public static string GetCurrentAppVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            return fileVersionInfo.ProductVersion;
        }
    }
}
