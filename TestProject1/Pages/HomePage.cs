using OpenQA.Selenium;

namespace TestProject1.Pages
{
    public class HomePage : AbstractWebPage
    {
        public HomePage(IWebDriver driver) : base(driver) { }

        
        private IWebElement _signInButton => _driver.FindElement(By.XPath("//a[@class='login']"));


        public void clickSignInButton()
        {
            _signInButton.Click();
        }
    }
}
