using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace TestProject1.Pages
{

    public abstract class AbstractWebPage
    {

        protected IWebDriver _driver;

        public AbstractWebPage(IWebDriver driver)
        {
            _driver = driver;

        }

        public virtual void WaitPageLoaded()
        {

        }

        protected void FillSelectByValue(IWebElement select, string value)
        {
            new SelectElement(select).SelectByValue(value);
        }
        public void FillSelectByText(IWebElement select, string value)
        {
            new SelectElement(select).SelectByText(value);
        }
        public void WaitPageUrlEqualsToCurrent()
        {
            new WebDriverWait(_driver, TimeSpan.FromSeconds(TestSettings.Timeout))
                .Until(ExpectedConditions
                    .ElementExists(By.ClassName("icon-home")));
        }
    }
}
