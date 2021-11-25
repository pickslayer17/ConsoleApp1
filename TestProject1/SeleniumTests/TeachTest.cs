using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace TestProject1.SeleniumTests
{
    class TeachTest : AbstractBaseTest
    {
        [Test]
        public void Teach()
        {
            IWebDriver driver = App.Flow.GetDriverForTestOnlyDeleteAfterThisAll();
            driver.Url = "https://toolsqa.com/selenium-webdriver/c-sharp/iwebdriver-browser-commands-in-c-sharp/";
            Console.Out.WriteLine(driver);
            IWebElement element = driver.FindElement(By.XPath("//form[@id='search-form']/input"));
             
            var attr = element.GetAttribute("innerText");
            element.SendKeys("huio"); //doesn't send keys - very strange and interesting
            Console.Out.WriteLine($"{element.Text}\n{element.TagName}\n{attr}");

            Thread.Sleep(2000);
            DefaultWait<IWebElement> huiWait = new DefaultWait<IWebElement>(element);
            huiWait.Timeout = TimeSpan.FromSeconds(20);
            huiWait.PollingInterval = TimeSpan.FromSeconds(1);

            huiWait.Until(ElementTextIsHui);


        }

        private Func<IWebElement, bool> ElementTextIsHui = element =>
        {
            if (element.Text == "хуй")
            {
                return true;
            }

            Console.Out.WriteLine("Inner text is: " + element.GetAttribute("innerText") );
            Console.Out.WriteLine("Element text is:" + element.Text);
            return false;
        };


    }
}
