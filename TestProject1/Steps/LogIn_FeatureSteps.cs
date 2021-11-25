using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using TestProject1.Lib;
using TestProject1.Pages;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace TestProject1.Features
{
    [Binding]
    public class LogIn_FeatureSteps : IDisposable
    {
        private AppLib _app;
        private IWebDriver _driver;
        private WebDriverWait _webDriverWait;

        public void Dispose()
        {
            _driver.Quit();
        }

        public AppLib App
        {
            get { return _app; }
        }

        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
            _driver = new ChromeDriver();
            _webDriverWait = new WebDriverWait(_driver,
                TimeSpan.FromSeconds(TestSettings.Timeout)
            );
            _app = new AppLib(_driver);
        }

        [Given(@"User is at the Home Page")]
        public void GivenUserIsAtTheHomePage()
        {
            Setup();
            App.Flow.GoTo("http://automationpractice.com/");
        }

        [Given(@"Navigate to LogIn Page")]
        public void GivenNavigateToLogInPage()
        {
            App.Pages.HomePage.clickSignInButton();
        }

        [When(@"User enter UserName and Password")]
        public void WhenUserEnterUserNameAndPassword(Table table)
        {
            var dictionary = TableExtensions.ToDictionary(table);
            var name = dictionary["Username"];
            var pass = dictionary["Password"];
            Console.Out.WriteLine($"'{name}'-'{pass}'");

            App.Pages.AuthenticationPage.fillEmailAddress(name);
            App.Pages.AuthenticationPage.fillPassword(pass);
        }

        [When(@"Click on the LogIn button")]
        public void WhenClickOnTheLogInButton()
        {
            App.Pages.AuthenticationPage.clickSignInButton();
        }

        [Then(@"Successful LogIn message should display")]
        public void ThenSuccessfulLogInMessageShouldDisplay()
        {
            var currentUrl = App.Flow.GetCurrentUrl();
            var expectedUrl = MyAccountPage.URL;
            Assert.That(currentUrl, Is.EqualTo(expectedUrl));
        }

        [When(@"User LogOut from the Application")]
        public void WhenUserLogOutFromTheApplication()
        {
            App.Pages.MyAccountPage.clickSignOutButton();
        }

        [Then(@"Successful LogOut message should display")]
        public void ThenSuccessfulLogOutMessageShouldDisplay()
        {
            var currentUrl = App.Flow.GetCurrentUrl();
            var expectedUrl = AuthenticationPage.URL;
            Assert.That(currentUrl, Is.EqualTo(expectedUrl));
        }

        [AfterScenario("Logout")]
        public void TearDown()
        {
            _driver.Close();
        }
    }
}