﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using TestProject1.Lib;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;


[assembly: Parallelizable(ParallelScope.All)]
namespace TestProject1.Tests
{
    public abstract class AbstractBaseTest : IDisposable
    {
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
            _webDriverWait = new WebDriverWait(_driver,
                TimeSpan.FromSeconds(TestSettings.Timeout)

                );
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
