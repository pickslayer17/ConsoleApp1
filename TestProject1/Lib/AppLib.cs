using OpenQA.Selenium;

namespace TestProject1.Lib
{
    public class AppLib
    {
        private readonly IWebDriver _driver;
        private readonly FlowLib _flow;
        private readonly PageLib _pages;

        public AppLib(IWebDriver driver)
        {
            _driver = driver;
            _pages = new PageLib(_driver);
            _flow = new FlowLib(_driver);
        }

        public PageLib Pages {
            get { return _pages; }
        }

        public FlowLib Flow
        {
            get { return _flow; }
        }
    }
}