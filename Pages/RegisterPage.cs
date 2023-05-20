using AutomationTestStoreDomaci.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationTestStoreDomaci.Pages
{
    public class RegisterPage : BasePage
    {
        /// <summary>
        /// Podrazumevani konstruktor
        /// </summary>
        public RegisterPage()
        {
            driver = null;
        }
        /// <summary>
        /// Parametrizovani konstruktor
        /// </summary>
        /// <param name="webDriver">Driver</param>
        public RegisterPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }


        //Lokatori
        By firstNameInput = By.Id("AccountFrm_firstname");
        By lastNameInput = By.Id("AccountFrm_lastname");
        By emailInput = By.Id("AccountFrm_email");
        By addressInput = By.Id("AccountFrm_address_1");
        By cityInput = By.Id("AccountFrm_city");
        By regionStateSelect = By.Id("AccountFrm_zone_id");
        By regionStateSelectOptions = By.XPath("//select[@id='AccountFrm_zone_id']/option");
        By zipInput = By.Id("AccountFrm_postcode");
        By countrySelect = By.Id("AccountFrm_country_id");
        By countrySelectOptions = By.XPath("//select[@id='AccountFrm_country_id']/option");
        By loginNameInput = By.Id("AccountFrm_loginname");
        By passwordInput = By.Id("AccountFrm_password");
        By confirmPasswordInput = By.Id("AccountFrm_confirm");
        By privacyPolicyCheckBox = By.Id("AccountFrm_agree");
        By registerContinueButton = By.XPath("//button[@title='Continue']");

        
        /// <summary>
        /// Upisuje first name u odgovarajuce polje
        /// </summary>
        /// <param name="firstName">First name</param>
        private void EnterFirstName(string firstName)
        {
            WriteTextToElement(firstNameInput, firstName);
        }

        /// <summary>
        /// Upisuje last name u odgovarajuce polje
        /// </summary>
        /// <param name="lastName">Last name</param>
        private void EnterLastName(string lastName)
        {
            WriteTextToElement(lastNameInput, lastName);
        }

        /// <summary>
        /// Upisuje email u odgovarajuce polje
        /// </summary>
        /// <param name="email">E-mail</param>
        private void EnterEmail(string email)
        {
            WriteTextToElement(emailInput, email);
        }

        /// <summary>
        /// Upisuje address u odgovarajuce polje
        /// </summary>
        /// <param name="address">Address</param>
        private void EnterAddress(string address)
        {
            WriteTextToElement(addressInput, address);
        }

        /// <summary>
        /// Upisuje city u odgovarajuce polje
        /// </summary>
        /// <param name="city">City</param>
        private void EnterCity(string city)
        {
            WriteTextToElement(cityInput, city);
        }

        /// <summary>
        /// Bira random region option iz selecta
        /// </summary>
        private void ChooseRandomRegion()
        {
            ClickRandomOptionFromSelect(regionStateSelect, regionStateSelectOptions, 1);
        }

        /// <summary>
        /// Upisuje zip u odgovarajuce polje
        /// </summary>
        /// <param name="zipCode">Zip</param>
        private void EnterZipCode(string zipCode)
        {
            WriteTextToElement(zipInput, zipCode);
        }

        /// <summary>
        /// Bira random country option iz selecta
        /// </summary>
        private void ChooseRandomCountry()
        {
            ClickRandomOptionFromSelect(countrySelect, countrySelectOptions, 1);
        }

        /// <summary>
        /// Upisuje login name u odgovarajuce polje
        /// </summary>
        /// <param name="loginName">Login name</param>
        private void EnterLoginName(string loginName)
        {
            WriteTextToElement(loginNameInput, loginName);
        }

        /// <summary>
        /// Upisuje password u odgovarajuce polje
        /// </summary>
        /// <param name="password">Password</param>
        private void EnterPassword(string password)
        {
            WriteTextToElement(passwordInput, password);
        }

        /// <summary>
        /// Upisuje confirmed password u odgovarajuce polje
        /// </summary>
        /// <param name="confirmPassword">Confirmed password</param>
        private void EnterConfirmedPassword(string confirmPassword)
        {
            WriteTextToElement(confirmPasswordInput, confirmPassword);
        }

        /// <summary>
        /// Klik na privacy policy check box
        /// </summary>
        private void ClickPrivacyPolicyCheckBox()
        {
            ClickOnElement(privacyPolicyCheckBox);
        }

        /// <summary>
        /// Klik na continue dugme
        /// </summary>
        private void ClickContinueButton()
        {
            ClickOnElement(registerContinueButton);
        }


        /// <summary>
        /// Popunjava formu, klikce na privacy policy check box i klikce na continue
        /// </summary>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="email">E-mail</param>
        /// <param name="address">Address</param>
        /// <param name="city">City</param>
        /// <param name="zip">Zip</param>
        /// <param name="loginName">Login name</param>
        /// <param name="password">Password</param>
        public void RegisterUser(string firstName, string lastName, string email, string address, string city, string zip, string loginName, string password)
        {
            EnterFirstName(firstName);
            EnterLastName(lastName);
            EnterEmail(email);
            EnterAddress(address);
            EnterCity(city);
            ChooseRandomCountry();
            //Potreban thread sleep jer program crkne dok izvuce 241 drzavu pa jednu random od njih
            //zato se moze videti ona dosta duza pauza od pola sekunde kad dodje do ovog dela
            Thread.Sleep(1000);
            ChooseRandomRegion();
            //Ovde mozda ne mora al nisam gledao da li mozda neka drzava ima preveliki broj regiona pa za svaki slucaj
            Thread.Sleep(1000);
            EnterZipCode(zip);
            EnterLoginName(loginName);
            EnterPassword(password);
            EnterConfirmedPassword(password);
            ClickPrivacyPolicyCheckBox();
            ClickContinueButton();
        }

        public string ReturnRegisterSuccessUrl()
        {
            return GetUrlLink();
        }
    }
}
