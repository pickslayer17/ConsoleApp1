using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;
using WomenStoreTests.lib;

namespace WomenStoreTests
{

    public abstract class AbstractBaseTest : IDisposable
    {
        public const int WAIT_FOR_ELEMENT_TIMEOUT = 30;
        private IWebDriver _driver;
        private WebDriverWait _webDriverWait;
        private AppLib _app;
        public AppLib App()
        {
            return _app;
        }

        [SetUp]
        public void Setup()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            _driver = new ChromeDriver();
            _webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(WAIT_FOR_ELEMENT_TIMEOUT));
            _app = new AppLib(_driver);

        }
        [TearDown]
        public void TearDown()
        {
            _driver.Close();
        }
        public void Dispose()
        {
            _driver.Quit();
        }
    }
}
