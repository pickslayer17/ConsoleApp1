using OpenQA.Selenium;

namespace TestProject1.Pages
{
    public class MyAccountPage : AbstractWebPage
    {
        public const string URL = "http://automationpractice.com/index.php?controller=my-account";
        public MyAccountPage(IWebDriver driver) : base(driver)
        {
        }
        private IWebElement _signOutButton => _driver.FindElement(By.XPath("//a[@class='logout']"));

        public void clickSignOutButton()
        {
            _signOutButton.Click();
        }
    }
}
