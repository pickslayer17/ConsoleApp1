

using OpenQA.Selenium;

namespace TestProject1.Lib
{
    public class AppLib
    {
        private IWebDriver _driver;
        private PageLib _pages;
        private FlowLib _flow;
        public AppLib(IWebDriver driver)
        {
            _driver = driver;
            _pages = new PageLib(_driver);
            _flow = new FlowLib(_driver);
        }

        public PageLib Pages() { return _pages; }
        public FlowLib Flow() { return _flow; }
    }
}
