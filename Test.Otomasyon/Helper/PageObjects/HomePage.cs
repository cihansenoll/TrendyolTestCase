using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Otomasyon.TestCases;

namespace Test.Otomasyon.Helper.PageObjects
{
    class HomePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='account-navigation-container']/div/div[1]/div[1]/p")]
        public IWebElement buttonAccount;

        [FindsBy(How = How.Id, Using = "login-email")]
        public IWebElement labelEMail;

        [FindsBy(How = How.Id, Using = "login-password-input")]
        public IWebElement labelPassword;

        [FindsBy(How = How.XPath, Using = "//*[@id='login-register']/div[3]/div[1]/form/button/span")]
        public IWebElement buttonLogin;

        [FindsBy(How = How.XPath, Using = "//*[@id='browsing-gw-homepage']/div/div[2]/div[1]/div[1]/article[1]/a/span/img")]
        public IWebElement randomBoutique;

        [FindsBy(How = How.XPath, Using = "(//*[@class='image-container'])[1]")]
        public IWebElement randomProduct;

        [FindsBy(How = How.ClassName, Using = "add-to-bs-tx")]
        public IWebElement buttonSepeteEkle;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[1]/div/div[2]/div[3]/div/div/div[2]/a/div[2]")]
        public IWebElement sepetCount;

    }

}
