using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Test.Otomasyon.Helper;

namespace Test.Otomasyon.TestCases
{
    [TestFixture]
    public class BasePageTest
    {
        [SetUp]
        public void StartUpTest()
        {
            string baseUrl = Utility.Url;
            Browsers.Init(baseUrl);
        }

        [TearDown]
        public void EndTest()
        {
            Browsers.Close();
        }

    }
}
