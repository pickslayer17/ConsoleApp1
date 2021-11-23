using NUnit.Framework;
using System;
using System.Threading;
using WomenStoreTests.Data;
using WomenStoreTests.Pages;

namespace WomenStoreTests.Tests
{
    class RegisterUserTest : AbstractBaseTest
    {
        [Test]
        public void Register()
        {
            App().Flow().GoTo("http://automationpractice.com/");
            App().Pages().HomePage.WaitPageLoaded();
            App().Pages().HomePage.clickSignInButton();

            App().Pages().AuthenticationPage.WaitPageLoaded();
            App().Pages().AuthenticationPage.fillEmailCreateAddress(GenerateRadomValidEmail());
            App().Pages().AuthenticationPage.clickCreateAnAccountButton();
            App().Pages().CreateAnAccountPage.WaitPageLoaded();

            var user = UserDataProvider.GetUserData("json_user.txt", new JsonUserParser());
            App().Pages().CreateAnAccountPage.FillGender(user.Gender);
            App().Pages().CreateAnAccountPage.FillCustomerFirstName(user.FirstName);
            App().Pages().CreateAnAccountPage.FillCustomerLastName(user.LastName);
            App().Pages().CreateAnAccountPage.FillPassword(user.Password);
            App().Pages().CreateAnAccountPage.FillDateOfBirth(user.DateOfBirth);
            App().Pages().CreateAnAccountPage.FillCompany(user.Company);
            App().Pages().CreateAnAccountPage.FillAddress(user.Address);
            App().Pages().CreateAnAccountPage.FillCity(user.City);
            App().Pages().CreateAnAccountPage.FillState(user.State);
            App().Pages().CreateAnAccountPage.FillZip(user.Zip);
            App().Pages().CreateAnAccountPage.FillHomePhone(user.HomePhone);
            App().Pages().CreateAnAccountPage.Register();
            App().Pages().MyAccountPage.WaitPageLoaded();

            Assert.That(App().Flow().getCurrentUrl(), Is.EqualTo(MyAccountPage.PAGE_URL));
            Thread.Sleep(2000);
            Assert.Pass();

        }

        private string GenerateRadomValidEmail()
        {
            var prefix = "qwerty";
            var postfix = "@test.ru";
            string randString = DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString();
            return prefix + randString + postfix;
        }
    }
}
