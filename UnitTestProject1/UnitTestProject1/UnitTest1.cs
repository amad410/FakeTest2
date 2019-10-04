using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public IWebDriver _driver = null;
        [TestMethod]
        public void TestMethod1()
        {
            _driver.Navigate().GoToUrl("http://www.espn.com");
        }

        [TestInitialize]
        public void Setup()
        {
            _driver = new ChromeDriver();

        }
        [TestCleanup]
        public void Teardown()
        {

        }
    }
}
