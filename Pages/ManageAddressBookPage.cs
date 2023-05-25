using OpenQA.Selenium;

namespace Nunit_Selenium_Automatski_Test.Pages
{
    public class ManageAddressBookPage : BasePage
    {
        /// <summary>
        /// Podrazumevani konstruktor
        /// </summary>
        public ManageAddressBookPage()
        {
            driver = null;
        }
        /// <summary>
        /// Parametrizovani konstruktor
        /// </summary>
        /// <param name="webDriver">Driver</param>
        public ManageAddressBookPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }


        //Lokatori
        By newAddressButton = By.XPath("//a[@title='New Address']");
        By firstNameInput = By.Id("AddressFrm_firstname");
        By lastNameInput = By.Id("AddressFrm_lastname");
        By addressInput = By.Id("AddressFrm_address_1");
        By cityInput = By.Id("AddressFrm_city");
        By regionStateSelect = By.Id("AddressFrm_zone_id");
        By regionStateSelectOptions = By.XPath("//select[@id='AddressFrm_zone_id']/option");
        By zipInput = By.Id("AddressFrm_postcode");
        By countrySelect = By.Id("AddressFrm_country_id");
        By countrySelectOptions = By.XPath("//select[@id='AddressFrm_country_id']/option");
        By continueButton = By.XPath("//button[@title='Continue']");
        By successMsg = By.XPath("//div[@class='alert alert-success']");
        By deleteButton = By.XPath("//button[@title='Delete']");
        By EditButton = By.XPath("//button[@title='Edit']");


        /// <summary>
        /// Klik na new address dugme
        /// </summary>
        private void ClickNewAddressButton()
        {
            ClickOnElement(newAddressButton);
        }

        /// <summary>
        /// Upisuje first name u odgovarajuce polje
        /// </summary>
        /// <param name="firstName">First name</param>
        private void EnterFirstName(string firstName)
        {
            ClearTextFromElement(firstNameInput);
            WriteTextToElement(firstNameInput, firstName);
        }

        /// <summary>
        /// Upisuje last name u odgovarajuce polje
        /// </summary>
        /// <param name="lastName">Last name</param>
        private void EnterLastName(string lastName)
        {
            ClearTextFromElement(lastNameInput);
            WriteTextToElement(lastNameInput, lastName);
        }

        /// <summary>
        /// Upisuje address u odgovarajuce polje
        /// </summary>
        /// <param name="address">Address</param>
        private void EnterAddress(string address)
        {
            ClearTextFromElement(addressInput);
            WriteTextToElement(addressInput, address);
        }

        /// <summary>
        /// Upisuje city u odgovarajuce polje
        /// </summary>
        /// <param name="city">City</param>
        private void EnterCity(string city)
        {
            ClearTextFromElement(cityInput);
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
            ClearTextFromElement(zipInput);
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
        /// <param name="address">Address</param>
        /// <param name="city">City</param>
        /// <param name="zip">Zip</param>
        public void CreateNewAddress(string firstName, string lastName, string address, string city, string zip)
        {
            ClickNewAddressButton();
            EnterFirstName(firstName);
            EnterLastName(lastName);
            EnterAddress(address);
            EnterCity(city);
            ChooseRandomCountry();
            ChooseRandomRegion();
            EnterZipCode(zip);
            ClickContinueButton();
        }

        /// <summary>
        /// Vraca poruku nakon pravljenja nove adrese
        /// </summary>
        /// <returns>Poruka</returns>
        public string GetSuccessMessage()
        {
            return ReadTextFromElement(successMsg);
        }

        /// <summary>
        /// Klik na delete dugme
        /// </summary>
        public void ClickDeleteButton()
        {
            ClickOnElement(deleteButton);
        }

        /// <summary>
        /// Klik na Edit dugme
        /// </summary>
        public void ClickOnEditAdressBook()
        {
            ClickOnElement(EditButton);
        }

        /// <summary>
        /// Popunjava formu i klikce na continue
        /// </summary>
        /// <param name="firstName">First name</param>
        /// <param name="lastName">Last name</param>
        /// <param name="address">Address</param>
        /// <param name="city">City</param>
        /// <param name="zip">Zip</param>
        public void FillEditAdressBook(string firstName, string lastName, string address, string city, string zip)
        {
            EnterFirstName(firstName);
            EnterLastName(lastName);
            EnterAddress(address);
            EnterCity(city);
            ChooseRandomCountry();
            ChooseRandomRegion();
            EnterZipCode(zip);
            ClickContinueButton();
        }
    }
}
