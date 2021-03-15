using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestHelper.Helper;

namespace Test.Otomasyon.Helper
{
    class Utility
    {
        public static string Url => Environment.GetEnvironmentVariable("URL") ?? AppConfiguration.Domain;

        public static ChromeOptions ChromeOptions
        {
            get
            {
                var options = new ChromeOptions();
                options.AddArgument("no-sandbox");
                options.AddArgument("start-maximized");

                return options;
            }
        }

        public static void NavigateTo(string uri)
        {
            Browsers.WebDriver.Navigate().GoToUrl(uri);
        }
    }
}
