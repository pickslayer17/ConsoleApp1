using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TestProject1.Tests;

namespace TestProject1.Pages
{
    public class CreateAnAccountPage : AbstractWebPage
    {
        public CreateAnAccountPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement _maleRadioButton => _driver.FindElement(By.Id("id_gender1"));
        private IWebElement _femaleRadioButton => _driver.FindElement(By.Id("id_gender2"));
        private IWebElement _customerFNameInput => _driver.FindElement(By.Id("customer_firstname"));
        private IWebElement _customerLNameInput => _driver.FindElement(By.Id("customer_lastname"));
        private IWebElement _passInput => _driver.FindElement(By.Id("passwd"));
        private IWebElement _daysSelect => _driver.FindElement(By.Id("days"));
        private IWebElement _monthsSelect => _driver.FindElement(By.Id("months"));
        private IWebElement _yearsSelect => _driver.FindElement(By.Id("years"));
        private IWebElement _company => _driver.FindElement(By.Id("company"));
        private IWebElement _address_1_input => _driver.FindElement(By.Id("address1"));
        private IWebElement _cityInput => _driver.FindElement(By.Id("city"));
        private IWebElement _stateSelect => _driver.FindElement(By.Id("id_state"));
        private IWebElement _zipInput => _driver.FindElement(By.Id("postcode"));
        private IWebElement _homePhoneInput => _driver.FindElement(By.Id("phone"));
        private IWebElement _registerButton => _driver.FindElement(By.Id("submitAccount"));

        public new void WaitPageLoaded()
        {
            new WebDriverWait(_driver, TimeSpan.FromSeconds(AbstractBaseTest.WAIT_FOR_ELEMENT_TIMEOUT))
                .Until(ExpectedConditions.ElementExists(By.Id("id_gender1")));
        }


        public void FillGender(string userGender)
        {
            if (string.Equals(userGender, "male", StringComparison.OrdinalIgnoreCase))
            {
                _maleRadioButton.Click();
            }
            else
            {
                _femaleRadioButton.Click();
            }
        }

        public void FillCustomerFirstName(string userFirstName)
        {
            _customerFNameInput.SendKeys(userFirstName);
        }

        public void FillCustomerLastName(string userLastName)
        {
            _customerLNameInput.SendKeys(userLastName);
        }

        public void FillPassword(string userPassword)
        {
            _passInput.SendKeys(userPassword);
        }

        public void FillDateOfBirth(DateTime userDateOfBirth)
        {
            FillDay(userDateOfBirth.Day);
            FillMonth(userDateOfBirth.Month);
            FillYear(userDateOfBirth.Year);

        }

        public void FillDay(int day)
        {
            FillSelectByValue(_daysSelect, day.ToString());
        }

        public void FillMonth(int month)
        {
            FillSelectByValue(_monthsSelect, month.ToString());
        }

        public void FillYear(int year)
        {
            FillSelectByValue(_yearsSelect, year.ToString());
        }


        public void FillCompany(string userCompany)
        {
            _company.SendKeys(userCompany);
        }

        public void FillAddress(string userAddress)
        {
            _address_1_input.SendKeys(userAddress);
        }

        public void FillCity(string userCity)
        {
            _cityInput.SendKeys(userCity);
        }

        public void FillState(string userState)
        {
            FillSelectByText(_stateSelect, userState);
        }

        public void FillZip(string userZip)
        {
            _zipInput.SendKeys(userZip);
        }

        public void FillHomePhone(string userHomePhone)
        {
            _homePhoneInput.SendKeys(userHomePhone);
        }

        public void Register()
        {
            _registerButton.Click();
        }

    }
}
