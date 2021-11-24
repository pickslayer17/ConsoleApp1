using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace TestProject1.Pages
{
    public class MyAccountPage : AbstractWebPage
    {
        public const string PAGE_URL = "http://automationpractice.com/index.php?controller=my-account";
        public MyAccountPage(IWebDriver driver) : base(driver)
        {
        }

        public void waitPageUrlEqualsToCurrent()
        {
            new WebDriverWait(_driver, TimeSpan.FromSeconds(30))
                .Until(ExpectedConditions
                    .ElementExists(By.ClassName("icon-home")));
        }


    }
}
