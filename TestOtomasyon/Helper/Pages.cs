using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOtomasyon.Helper
{
    class Pages
    {
        public static HomePage HomePage => GetPages<HomePage>();

        private static T GetPages<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browsers.WebDriver, page);
            return page;
        }
    }
}
