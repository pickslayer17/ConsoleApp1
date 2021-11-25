using System;
using System.Threading;
using NUnit.Framework;
using TestProject1.Pages;



namespace TestProject1.Tests
{
    public class SignInTest : AbstractBaseTest
    {
        [Test]
        public void run()
        {
            App().Flow().GoTo("http://automationpractice.com/");
            App().Pages().HomePage.clickSignInButton();


            string eMail = "qwerty10@test.ru";
            string password = "qscwdvefb43215432";


            App().Pages().AuthenticationPage.fillEmailAddress(eMail);
            App().Pages().AuthenticationPage.fillPassword(password);
            App().Pages().AuthenticationPage.clickSignInButton();

            App().Pages().MyAccountPage.WaitPageUrlEqualsToCurrent();
            string currentUrl = App().Flow().GetCurrentUrl();
            string expectedUrl = MyAccountPage.URL;

            Assert.That(currentUrl, Is.EqualTo(expectedUrl));

            Thread.Sleep(1000);
            Assert.Pass();

        }

    }
}
