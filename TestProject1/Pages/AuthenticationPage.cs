using OpenQA.Selenium;
using System;

namespace TestProject1.Pages
{
    public class AuthenticationPage : AbstractWebPage
    {
        public AuthenticationPage(IWebDriver driver) : base(driver) { }

        private IWebElement _emailCreateAddressInput => _driver.FindElement(By.Id("email_create"));
        private IWebElement _createAnAccountButton => _driver.FindElement(By.Id("SubmitCreate"));
        private IWebElement _emailInput => _driver.FindElement(By.Id("email"));
        private IWebElement _passInput => _driver.FindElement(By.Id("passwd"));
        private IWebElement _signInButton => _driver.FindElement(By.Id("SubmitLogin"));


        public void fillEmailCreateAddress(string text)
        {
            _emailCreateAddressInput.SendKeys(text);
        }

        public void clickCreateAnAccountButton()
        {
            _createAnAccountButton.Click();
        }

        public void fillEmailAddress(String text)
        {
            _emailInput.SendKeys(text);
        }

        public void fillPassword(String text)
        {
            _passInput.SendKeys(text);
        }

        public void clickSignInButton()
        {
            _signInButton.Click();
        }


    }
}
