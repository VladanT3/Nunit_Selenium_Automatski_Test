using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit_Selenium_Automatski_Test.Pages
{
    public class EditAccountDetailsPage:BasePage
    {
        public EditAccountDetailsPage()
        {
            driver = null;
        }

        public EditAccountDetailsPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        //Locators
        By firstNameField = By.Id("AccountFrm_firstname");
        By lastNameField = By.Id("AccountFrm_lastname");
        By emailField = By.Id("AccountFrm_email");
        By telephoneNumberField = By.Id("AccountFrm_telephone");
        By faxNumberField = By.Id("AccountFrm_fax");
        By continueButton = By.XPath("//button[@class='btn btn-orange pull-right lock-on-click']");


        /// <summary>
        /// Unosi ime
        /// </summary>
        /// <param name="name">ime</param>
        private void EnterFirstName(string firstName)
        {
            ClearTextFromElement(firstNameField);
            WriteTextToElement(firstNameField, firstName);
        }

        
        /// <summary>
        /// Unosi prezime
        /// </summary>
        /// <param name="lastName">prezime</param>
        private void EnterLastName(string lastName)
        {
            ClearTextFromElement(lastNameField);
            WriteTextToElement(lastNameField, lastName);
        }

        /// <summary>
        /// Unosi email adresu
        /// </summary>
        /// <param name="email">email</param>
        private void EnterEmail(string email)
        {
            ClearTextFromElement(emailField);
            WriteTextToElement(emailField, email);
        }

        /// <summary>
        /// Unosi broj telefona
        /// </summary>
        /// <param name="phoneNumber">broj telefona</param>
        private void EnterPhoneNumber(string phoneNumber)
        {
            ClearTextFromElement(telephoneNumberField);
            WriteTextToElement(telephoneNumberField, phoneNumber);
        }


        /// <summary>
        /// Unosi fax
        /// </summary>
        /// <param name="fax">fax</param>
        private void EnterFax(string fax)
        {
            ClearTextFromElement(faxNumberField);
            WriteTextToElement(faxNumberField, fax);
        }

        /// <summary>
        /// Klik na dugme continue
        /// </summary>
        private void ClickOnContinueButton()
        {
            ClickOnElement(continueButton);
        }

        public void EnterEditAccount(string firstName, string lastName, string email, string phoneNumber, string fax)
        {
            EnterFirstName(firstName);
            EnterLastName(lastName);
            EnterEmail(email);
            EnterPhoneNumber(phoneNumber);
            EnterFax(fax);
            ClickOnContinueButton();
        }

        


    }
}
