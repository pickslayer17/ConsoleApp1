using System;
using System.Threading;
using NUnit.Framework;
using TestProject1.Pages;

[assembly:Parallelizable(ParallelScope.All)]

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

            App().Pages().MyAccountPage.waitPageUrlEqualsToCurrent();
            string currentUrl = App().Flow().getCurrentUrl();
            string expectedUrl = MyAccountPage.PAGE_URL;

            Assert.That(currentUrl, Is.EqualTo(expectedUrl));

            Thread.Sleep(1000);
            Assert.Pass();

        }

    }
}
