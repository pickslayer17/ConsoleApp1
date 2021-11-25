using OpenQA.Selenium;

namespace TestProject1.Lib
{
    public class FlowLib
    {
        private readonly IWebDriver _driver;

        public IWebDriver GetDriverForTestOnlyDeleteAfterThisAll()
        {
            return _driver;
        }

        public FlowLib(IWebDriver driver)
        {
            _driver = driver;
        }

        public void GoTo(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public string GetCurrentUrl()
        {
            return _driver.Url;
        }
    }
}