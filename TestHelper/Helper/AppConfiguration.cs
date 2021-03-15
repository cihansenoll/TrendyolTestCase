using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace TestHelper.Helper
{
    public class AppConfiguration
    {
        public static string Browser => ConfigurationManager.AppSettings["Browser"];

        public static string Domain => ConfigurationManager.AppSettings["Domain"];
    }
}
