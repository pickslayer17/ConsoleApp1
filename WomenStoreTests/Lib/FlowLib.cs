using OpenQA.Selenium;

namespace WomenStoreTests.lib
{
    public class FlowLib
    {
        private IWebDriver _driver;

        public FlowLib(IWebDriver driver)
        {
            _driver = driver;
        }

         public void GoTo(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

         public string getCurrentUrl()
         {
             return _driver.Url;
         }
    }
}
