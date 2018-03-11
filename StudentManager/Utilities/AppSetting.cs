using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Utilities
{
    public class AppSetting
    {
        public static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
        }
    }
}
