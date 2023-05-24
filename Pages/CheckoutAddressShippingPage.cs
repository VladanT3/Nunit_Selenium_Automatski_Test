using OpenQA.Selenium;

namespace Nunit_Selenium_Automatski_Test.Pages
{
    public class CheckoutAddressShippingPage : BasePage
    {
        /// <summary>
        /// Podrazumevani konstruktor
        /// </summary>
        public CheckoutAddressShippingPage()
        {
            driver = null;
        }

        /// <summary>
        /// Parametrizovani konstruktor
        /// </summary>
        /// <param name="webDriver">Driver</param>
        public CheckoutAddressShippingPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        //Lokatori
        By firstNameInput = By.Id("Address2Frm_firstname");
        By lastNameInput = By.Id("Address2Frm_lastname");
        By addressInput = By.Id("Address2Frm_address_1");
        By cityInput = By.Id("Address2Frm_city");
        By regionStateSelect = By.Id("Address2Frm_zone_id");
        By regionStateSelectOptions = By.XPath("//select[@id='Address2Frm_zone_id']/option");
        By zipInput = By.Id("Address2Frm_postcode");
        By countrySelect = By.Id("Address2Frm_country_id");
        By countrySelectOptions = By.XPath("//select[@id='Address2Frm_country_id']/option");
        By checkoutContinueButton = By.XPath("//button[contains(@class, 'btn btn-orange pull-right lock-on-click')]");


        /// <summary>
        /// Upisuje First name u odgovarajuce polje
        /// </summary>
        /// <param name="First name"></param>
        public void EnterFirstName(string firstName)
        {
            WriteTextToElement(firstNameInput, firstName);
        }

        /// <summary>
        /// Upisuje Last name u odgovarajuce polje
        /// </summary>
        /// <param name="Last name"></param>
        public void EnterLastName(string lastName)
        {
            WriteTextToElement(lastNameInput, lastName);
        }

        /// <summary>
        /// Upisuje Address u odgovarajuce polje
        /// </summary>
        /// <param name="Address"></param>
        public void EnterAddress(string address)
        {
            WriteTextToElement(addressInput, address);
        }

        /// <summary>
        /// Upisuje City u odgovarajuce polje
        /// </summary>
        /// <param name="City"></param>
        public void EnterCity(string city)
        {
            WriteTextToElement(cityInput, city);
        }

        /// <summary>
        /// Bira random region option iz selecta
        /// </summary>
        public void ChooseRandomRegion()
        {
            ClickRandomOptionFromSelect(regionStateSelect, regionStateSelectOptions, 1);
        }

        /// <summary>
        /// Upisuje zip u odgovarajuce polje
        /// </summary>
        /// <param name="zip">zip</param>
        public void EnterZip(string zip)
        {
            WriteTextToElement(zipInput, zip);
        }

        /// <summary>
        /// Bira random country option iz selecta
        /// </summary>
        public void ChooseRandomCountry()
        {
            ClickRandomOptionFromSelect(countrySelect, countrySelectOptions, 1);
        }

        /// <summary>
        /// Klik na continue dugme
        /// </summary>
        public void ClickContinueButton()
        {
            ClickOnElement(checkoutContinueButton);
        }

        /// <summary>
        /// Popunjava formu i klikce na continue
        /// </summary>
        public void CheckoutAddress(string firstName, string lastName, string address,
                                    string city, string zip)
        {
            EnterFirstName(firstName);
            EnterLastName(lastName);
            EnterAddress(address);
            EnterCity(city);
            ChooseRandomCountry();
            Thread.Sleep(300);
            ChooseRandomRegion();
            Thread.Sleep(300);
            EnterZip(zip);
            ClickContinueButton();
        }

    }
}
