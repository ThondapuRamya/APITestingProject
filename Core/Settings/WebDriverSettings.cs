using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Settings
{
    public class WebDriverSettings
    {
        public static readonly string DOWNLOADSLOCATION = Path.Combine(Environment.GetEnvironmentVariable("USERPROFILE") + @"\" + "Downloads\\");
    }
}
