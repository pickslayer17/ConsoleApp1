using OpenQA.Selenium;

namespace TestProject1.Pages
{
    public class MyAccountPage : AbstractWebPage
    {
        public const string PAGE_URL = "http://automationpractice.com/index.php?controller=my-account";
        public MyAccountPage(IWebDriver driver) : base(driver)
        {
        }




    }
}
