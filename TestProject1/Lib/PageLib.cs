using OpenQA.Selenium;
using TestProject1.Pages;

namespace TestProject1.Lib
{
    public class PageLib
    {
        private IWebDriver _driver;

        public HomePage HomePage { get; }
        public AuthenticationPage AuthenticationPage { get; }
        public MyAccountPage MyAccountPage { get; }
        public CreateAnAccountPage CreateAnAccountPage { get; }

        public PageLib(IWebDriver driver)
        {
            _driver = driver;
            HomePage = new HomePage(_driver);
            AuthenticationPage = new AuthenticationPage(_driver);
            MyAccountPage = new MyAccountPage(_driver);
            CreateAnAccountPage = new CreateAnAccountPage(_driver);
        }

    }
}
