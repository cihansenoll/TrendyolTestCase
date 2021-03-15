using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOtomasyon.Helper
{
    class Browsers
    {
        public static string Title => WebDriver.Title;

        public static IWebDriver WebDriver { get; private set; }

        public static IJavaScriptExecutor JavaScriptExecutor => WebDriver as IJavaScriptExecutor;

        public static void Init(string baseUrl)
        {
            switch (AppConfiguration.Browser)
            {

            }
        }
    }
}
