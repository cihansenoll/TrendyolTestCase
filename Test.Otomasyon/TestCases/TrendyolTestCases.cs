using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using Test.Otomasyon.Helper;
using Test.Otomasyon.Helper.PageObjects;

namespace Test.Otomasyon.TestCases
{
    [TestFixture]
    public class TrendyolTestCases:BasePageTest
    {

        HomePage page;

        [SetUp]
        public void TestMethod1()
        {
            page = Pages.HomePage;

            //Anasayfayı açtığımızda her seferinde popup çıktığı için kapatıyorum.
            Thread.Sleep(4000);
            Browsers.WebDriver.FindElement(By.XPath("/html/body/div[6]/div/div/a")).Click();
            Thread.Sleep(3000);
        }

        [TearDown]
        public void TearDown()
        {
            Browsers.Close();
        }

        [Test]
        public void LoginKontrol()
        {
            var expectedResult = "Hesabım";

            Login();

            var actualResult = page.buttonAccount.Text;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("/butik/liste/kadin", ExpectedResult = "19")]
        [TestCase("/butik/liste/erkek", ExpectedResult = "19")]
        [TestCase("/butik/liste/cocuk", ExpectedResult = "19")]
        [TestCase("/butik/liste/ev--yasam", ExpectedResult = "19")]
        [TestCase("/butik/liste/supermarket", ExpectedResult = "19")]
        [TestCase("/butik/liste/kozmetik", ExpectedResult = "19")]
        [TestCase("/butik/liste/ayakkabi--canta", ExpectedResult = "19")]
        [TestCase("/butik/liste/elektronik", ExpectedResult = "19")]
        public string AnasayfaTabKontrol(string href)
        {

            var element = FindElement(href);

            element.Click();
            Thread.Sleep(2000);

            var actualHeading = Browsers.WebDriver.FindElements(By.ClassName("component-item")).Count.ToString();
            return actualHeading;
        }

        [Test]
        public void SepeteEkle()
        {
            var expectedResult = "1";

            page.randomBoutique.Click();
            Thread.Sleep(5000);

            page.randomProduct.Click();
            Thread.Sleep(5000);

            ScrollDownToSepeteEkle();
            Thread.Sleep(2000);
                
            page.buttonSepeteEkle.Click();
            Thread.Sleep(5000);
            var actualResult = page.sepetCount.Text;

            Assert.AreEqual(expectedResult, actualResult);
        }

       
        public void Login()
        {
            page.buttonAccount.Click();
            Thread.Sleep(2000);

            page.labelEMail.SendKeys("testhesap@test.com");
            page.labelPassword.SendKeys("test1234");
            Thread.Sleep(2000);

            page.buttonLogin.Click();
            Thread.Sleep(3000);
        }


        /// <summary>
        /// Verilen href değerine uygun elemanı döndüren metod.
        /// </summary>
        /// <param name="href">Elemanın href attribute'unun değerini temsil eder.</param>
        /// <returns></returns>
        public static IWebElement FindElement(string href)
        {
            var xPath = $"(//*[@class='main-nav']//a[@href='{href}'])";

            var element = Browsers.WebDriver.FindElement(By.XPath(xPath));

            return element;
        }

        /// <summary
        /// Elementlerin clickable olduğundan emin olmamız için tıklayacağımız butona kadar scroll yapan metod.
        /// </summary>
        private void ScrollDownToSepeteEkle()
        {
            var script = "document.getElementsByClassName('add-to-bs-tx')[0].scrollIntoView()";

            Browsers.JavaScriptExecutor.ExecuteScript(script);
        }

    }
}
