using OpenQA.Selenium;

namespace Nunit_Selenium_Automatski_Test.Pages
{
    public class CheckoutPage : BasePage
    {
        /// <summary>
        /// Podrazumevani konstruktor
        /// </summary>
        public CheckoutPage()
        {
            driver = null;
        }
        /// <summary>
        /// Parametrizovani konstruktor
        /// </summary>
        /// <param name="webDriver">Driver</param>
        public CheckoutPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }


        //Lokatori
        By confirmOrderButton = By.Id("checkout_btn");
        By firstNameInput = By.Id("guestFrm_firstname");
        By lastNameInput = By.Id("guestFrm_lastname");
        By emailInput = By.Id("guestFrm_email");
        By addressInput = By.Id("guestFrm_address_1");
        By cityInput = By.Id("guestFrm_city");
        By regionStateSelect = By.Id("guestFrm_zone_id");
        By regionStateSelectOptions = By.XPath("//select[@id='guestFrm_zone_id']/option");
        By zipInput = By.Id("guestFrm_postcode");
        By countrySelect = By.Id("guestFrm_country_id");
        By countrySelectOptions = By.XPath("//select[@id='guestFrm_country_id']/option");
        By continueButton = By.XPath("//button[@title='Continue']");
        By editShippingAddressButton = By.XPath("//table[contains(@class, 'table confirm_shippment_options')]//a");
        By changeAddressButton = By.XPath("//div[contains(@class, 'input-group')]/a");



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
        /// Klik na continue dugme
        /// </summary>
        private void ClickContinueButton()
        {
            ClickOnElement(continueButton);
        }


        /// <summary>
        /// Popunjava formu i klikce na continue
        /// </summary>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="email">E-mail</param>
        /// <param name="address">Address</param>
        /// <param name="city">City</param>
        /// <param name="zip">Zip</param>
        public void FillCheckoutForm(string firstName, string lastName, string email, string address, string city, string zip)
        {
            EnterFirstName(firstName);
            EnterLastName(lastName);
            EnterEmail(email);
            EnterAddress(address);
            EnterCity(city);
            ChooseRandomCountry();
            ChooseRandomRegion();
            EnterZipCode(zip);
            ClickContinueButton();
        }


        /// <summary>
        /// Klik na confirm order dugme
        /// </summary>
        public void ClickConfirmOrderButton()
        {
            ClickOnElement(confirmOrderButton);
        }

        /// <summary>
        /// Vraca url trenutne stranice
        /// </summary>
        /// <returns>Url stranice</returns>
        public string GetSuccessUrl(string url)
        {
            //thread sleep jer uhvati link od prosle stranice
            //Thread.Sleep(1000);
            return GetUrlLink(url);
        }

        /// <summary>
        /// Klik na edit shipping dugme
        /// </summary>
        public void ClickEditShippingAddress()
        {
            ClickOnElement(editShippingAddressButton);
        }

        /// <summary>
        /// Klik na change address dugme
        /// </summary>
        public void ClickChangeAddress()
        {
            ClickOnElement(changeAddressButton);
        }

    }
}
