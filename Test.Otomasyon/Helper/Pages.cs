using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Otomasyon.Helper.PageObjects;

namespace Test.Otomasyon.Helper
{
    class Pages
    {
        public static HomePage HomePage => GetPages<HomePage>();

        private static T GetPages<T>() where T : new()
        {
            var page = new T();
#pragma warning disable CS0618 // Type or member is obsolete
            PageFactory.InitElements(Browsers.WebDriver, page);
#pragma warning restore CS0618 // Type or member is obsolete
            return page;
        }
    }
}
