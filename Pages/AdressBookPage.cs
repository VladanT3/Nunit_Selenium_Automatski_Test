using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V111.Network;

namespace Nunit_Selenium_Automatski_Test.Pages
{
    public class AdressBookPage : BasePage
    {
        /// <summary>
        /// Podrazumevani konstruktor
        /// </summary>
        public AdressBookPage()
        {
            driver = null;
        }
        /// <summary>
        /// Parametrizovani konstruktor
        /// </summary>
        /// <param name="webDriver">Driver</param>
        public AdressBookPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        // Lokatori
        By EditButton = By.XPath("//button[@title='Edit']");
        By ManageBookAdress = By.XPath("//ul[@class='side_account_list']/li[5]");
        By FirstNameInput = By.Id("AddressFrm_firstname");
        By LastNameInput = By.Id("AddressFrm_lastname");
        By AddressInput = By.Id("AddressFrm_address_1");
        By CityInput = By.Id("AddressFrm_city");
        By RegionStateSelect = By.Id("AddressFrm_zone_id");
        By RegionStateSelectOptions = By.XPath("//select[@id='AddressFrm_zone_id']/option");
        By ZipInput = By.Id("AddressFrm_postcode");
        By CountrySelect = By.Id("AddressFrm_country_id");
        By CountrySelectOptions = By.XPath("//select[@id='AddressFrm_country_id']/option");
        By ContinueButton = By.XPath("//button[@title='Continue']");
        By successMsg = By.XPath("//div[@class='alert alert-success']");

        /// <summary>
        /// Klik na Edit dugme
        /// </summary>
        public void ClickOnEditAdressBook()
        {
            ClickOnElement(EditButton);
        }

        public void ClickOnManageBookAdress() 
        {
            ClickOnElement(ManageBookAdress);
        }

        public string GetSuccessText()
        {
            return ReadTextFromElement(successMsg);
        }

        /// <summary>
        /// Upisuje first name u odgovarajuce polje
        /// </summary>
        /// <param name="firstName">First name</param>
        private void EnterFirstName(string firstName)
        {
            ClearTextFromElement(FirstNameInput);
            WriteTextToElement(FirstNameInput, firstName);
        }

        /// <summary>
        /// Upisuje last name u odgovarajuce polje
        /// </summary>
        /// <param name="lastName">Last name</param>
        private void EnterLastName(string lastName)
        {
            ClearTextFromElement(LastNameInput);
            WriteTextToElement(LastNameInput, lastName);
        }

        /// <summary>
        /// Upisuje address u odgovarajuce polje
        /// </summary>
        /// <param name="address">Address</param>
        private void EnterAddress(string address)
        {
            ClearTextFromElement(AddressInput);
            WriteTextToElement(AddressInput, address);
        }

        /// <summary>
        /// Upisuje city u odgovarajuce polje
        /// </summary>
        /// <param name="city">City</param>
        private void EnterCity(string city)
        {
            ClearTextFromElement(CityInput);
            WriteTextToElement(CityInput, city);
        }

        /// <summary>
        /// Bira random region option iz selecta
        /// </summary>
        private void ChooseRandomRegion()
        {
            ClickRandomOptionFromSelect(RegionStateSelect, RegionStateSelectOptions, 1);
        }

        /// <summary>
        /// Upisuje zip u odgovarajuce polje
        /// </summary>
        /// <param name="zipCode">Zip</param>
        private void EnterZipCode(string zipCode)
        {
            ClearTextFromElement(ZipInput);
            WriteTextToElement(ZipInput, zipCode);
        }

        /// <summary>
        /// Bira random country option iz selecta
        /// </summary>
        private void ChooseRandomCountry()
        {
            ClickRandomOptionFromSelect(CountrySelect, CountrySelectOptions, 1);
        }

        /// <summary>
        /// Klik na continue dugme
        /// </summary>
        private void ClickContinueButton()
        {
            ClickOnElement(ContinueButton);
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
            //Potreban thread sleep jer program crkne dok izvuce 241 drzavu pa jednu random od njih
            //zato se moze videti ona dosta duza pauza od pola sekunde kad dodje do ovog dela
            Thread.Sleep(1000);
            ChooseRandomRegion();
            //Ovde mozda ne mora al nisam gledao da li mozda neka drzava ima preveliki broj regiona pa za svaki slucaj
            Thread.Sleep(1000);
            EnterZipCode(zip);
            ClickContinueButton();
        }
    }
}
