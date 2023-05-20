using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestStoreDomaci.Pages
{
    public class ContactUsPage : BasePage
    {
        /// <summary>
        /// Podrazumevani konstruktor
        /// </summary>
        public ContactUsPage()
        {
            driver = null;
        }
        /// <summary>
        /// Parametrizovani konstruktor
        /// </summary>
        /// <param name="webDriver">Driver</param>
        public ContactUsPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        //Lokatori
        By firstNameInput = By.Id("ContactUsFrm_first_name");
        By emailInput = By.Id("ContactUsFrm_email");
        By enquiryInput = By.Id("ContactUsFrm_enquiry");
        By submitButton = By.XPath("//button[@title='Submit']");


        /// <summary>
        /// Unosi first name u polje
        /// </summary>
        /// <param name="firstName">First name</param>
        private void EnterFirstName(string firstName)
        {
            WriteTextToElement(firstNameInput, firstName);
        }

        /// <summary>
        /// Unosi email u polje
        /// </summary>
        /// <param name="email">Email</param>
        private void EnterEmail(string email)
        {
            WriteTextToElement(emailInput, email);
        }

        /// <summary>
        /// Unosi poruku u polje
        /// </summary>
        /// <param name="enquiry">Poruka</param>
        private void EnterEnquiry(string enquiry)
        {
            WriteTextToElement(enquiryInput, enquiry);
        }

        /// <summary>
        /// Klik na submit dugme
        /// </summary>
        private void ClickSubmitButton()
        {
            ClickOnElement(submitButton);
        }


        /// <summary>
        /// Popunjava formu i klikce na submit
        /// </summary>
        /// <param name="firstName">First name</param>
        /// <param name="email">Email</param>
        /// <param name="enquiry">Poruka</param>
        public void SendMessage(string firstName, string email, string enquiry)
        {
            EnterFirstName(firstName);
            EnterEmail(email);
            EnterEnquiry(enquiry);
            ClickSubmitButton();
        }

        public string GetSuccessUrlLink()
        {
            return GetUrlLink();
        }
    }
}
