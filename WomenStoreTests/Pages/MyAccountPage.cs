using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using WomenStoreTests.pages;

namespace WomenStoreTests.Pages
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
