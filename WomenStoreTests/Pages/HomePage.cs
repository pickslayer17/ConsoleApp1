
using OpenQA.Selenium;
using System;

namespace WomenStoreTests.pages
{
    public class HomePage : AbstractWebPage
    {
        public HomePage(IWebDriver driver) : base(driver) { }

        
        private IWebElement signInButton => _driver.FindElement(By.XPath("//a[@class='login']"));


        public void clickSignInButton()
        {
            signInButton.Click();
        }
    }
}
