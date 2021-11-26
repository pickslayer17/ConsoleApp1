using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using TestProject1.Lib;
using TestProject1.Steps.Utils;
using WebDriverManager;
using WebDriverManager.DriverConfigs;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

[assembly: Parallelizable(ParallelScope.All)]

namespace TestProject1.SeleniumTests
{
    public abstract class AbstractBaseTest : IDisposable
    {
        private IWebDriver _driver;
        private IDriverConfig _driverConfig;
        private WebDriverWait _webDriverWait;

        public void Dispose()
        {
            _driver.Quit();
        }

        protected AppLib App { get; private set; }

        private void SetupDriver(DriverName browserName)
        {
            switch (browserName) 
            {
                case DriverName.CHROME:
                    _driverConfig = new ChromeConfig();
                    new DriverManager().SetUpDriver(_driverConfig, VersionResolveStrategy.MatchingBrowser);
                    _driver = new ChromeDriver();
                    break;
                case DriverName.FIREFOX:
                    _driverConfig = new FirefoxConfig();
                    new DriverManager().SetUpDriver(_driverConfig);
                    _driver = new FirefoxDriver();
                    break;
                default:
                    throw new Exception("You add browser name to enum, but forget to describe behaviour for it");
            }
        }

        [SetUp]
        public void Setup()
        {
            SetupDriver(DriverName.CHROME);
            _webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(TestSettings.Timeout));
            App = new AppLib(_driver);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
        }
    }
}