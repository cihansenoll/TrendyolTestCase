using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestHelper.Helper;

namespace Test.Otomasyon.Helper
{
    public class Browsers
    {
        public static string Title => WebDriver.Title;

        public static IWebDriver WebDriver { get; private set; }

        public static IJavaScriptExecutor JavaScriptExecutor => WebDriver as IJavaScriptExecutor;

        public static void Init(string baseUrl)
        {
            switch (AppConfiguration.Browser)
            {
                case "Chrome":
                    WebDriver = new ChromeDriver(Utility.ChromeOptions);
                    break;
                case "IE":
                    WebDriver = new InternetExplorerDriver();
                    break;
                case "Firefox":
                    WebDriver = new FirefoxDriver();
                    break;
                default:
                    WebDriver = new ChromeDriver();
                    break;
            }

            Goto(baseUrl);
        }

        public static void Goto(string uri)
        {
            WebDriver.Url = uri;
        }

        public static void Close()
        {
            WebDriver.Quit();
        }
    }
}
