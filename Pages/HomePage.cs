using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Nunit_Selenium_Automatski_Test.Pages
{
    public class HomePage : BasePage
    {
        /// <summary>
        /// Podrazumevani konstruktor
        /// </summary>
        public HomePage()
        {
            driver = null;
        }
        /// <summary>
        /// Parametrizovani konstruktor
        /// </summary>
        /// <param name="webDriver">Driver</param>
        public HomePage(IWebDriver webDriver)
        {
            driver= webDriver;
        }


        //Lokatori
        By loginOrRegisterLink = By.LinkText("Login or register");
        By contactUsLink = By.LinkText("Contact Us");
        //neki add to cart buttoni proslede na product page tako da ne moze za svaki proizvod da se uradi
        By addToCartButton = By.XPath("//a[@data-id='88']");
        By addToCartButton1 = By.XPath("//a[@data-id='66']");
        By cartButton = By.XPath("//ul[@class='nav topcart pull-left']/li[@class='dropdown hover']/a");
        By productLink = By.XPath("//a[@title='ck one Summer 3.4 oz']");
        By currencyDropdown = By.XPath("//ul[@class='nav language pull-left']/li[@class='dropdown hover']");
        By currencyEuro = By.XPath("//li/a[contains(., '€ Euro')]");
        By currencyPound = By.XPath("//li/a[contains(., '£ Pound Sterling')]");
        By searchInput = By.Id("filter_keyword");
        By searchButton = By.XPath("//i[@class='fa fa-search']");
        By accountButton = By.XPath("//li[@class='dropdown']/a[@class='top menu_account']");


        /// <summary>
        /// Klik na currency dropdown menu
        /// </summary>
        private void ClickCurrencyDropdownMenu()
        {
            ClickOnElement(currencyDropdown);
        }

        /// <summary>
        /// Klik na euro
        /// </summary>
        private void ClickCurrencyEuro()
        {
            ClickOnElement(currencyEuro);
        }

        /// <summary>
        /// Klik na pound sterling
        /// </summary>
        private void ClickCurrencyPound()
        {
            ClickOnElement(currencyPound);
        }

        /// <summary>
        /// Upisuje naziv proizvoda u search box
        /// </summary>
        /// <param name="searchText">Naziv proizvoda</param>
        private void TypeInSearchBox(string searchText)
        {
            WriteTextToElement(searchInput, searchText);
        }

        /// <summary>
        /// Klik na search dugme
        /// </summary>
        private void ClickSearchButton()
        {
            ClickOnElement(searchButton);
        }


        /// <summary>
        /// Klik na add to cart dugme odredjenog proizvoda
        /// </summary>
        public void ClickOnAddToCartButton()
        {
            ClickOnElement(addToCartButton);
        }

        /// <summary>
        /// Klik na cart dugme da nas odvede na cart stranicu
        /// </summary>
        public void ClickCartButton()
        {
            ClickOnElement(cartButton);
        }

        /// <summary>
        /// Proces kliktanja na add to cart dugme proizvoda pa potom ulazenje u cart
        /// </summary>
        public void AddProductToCart()
        {
            ClickOnAddToCartButton();
            ClickCartButton();
        }

        /// <summary>
        /// Metoda koja vrsi klik na login or register link
        /// </summary>
        public void ClickLoginOrRegisterLink()
        {
            ClickOnElement(loginOrRegisterLink);
        }

        /// <summary>
        /// Klik na contact us link u footeru
        /// </summary>
        public void ClickContactUsLink()
        {
            ClickOnElement(contactUsLink);
        }

        /// <summary>
        /// Klik na naziv proizvoda
        /// </summary>
        public void ClickOnProductLink()
        {
            ClickOnElement(productLink);
        }


        /// <summary>
        /// Menja valutu u odredjenu vrednost koja je prosledjena pri pozivu
        /// </summary>
        /// <param name="currency">Valuta</param>
        public void ChangeCurrency(string currency)
        {
            IWebElement mainMenu = driver.FindElement(currencyDropdown);

            //Instantiating Actions class
            Actions actions = new Actions(driver);

            //Hovering on main menu
            actions.MoveToElement(mainMenu);

            IWebElement subMenu;
            switch (currency)
            {
                case "eur":
                    subMenu = driver.FindElement(currencyEuro);
                    break;
                case "pound":
                    subMenu = driver.FindElement(currencyPound);
                    break;
                default:
                    subMenu = null;
                    break;
            }

            //To mouseover on sub menu
            actions.MoveToElement(subMenu).Click();


            //build()- used to compile all the actions into a single step
            actions.Click().Build().Perform();
        }

        /*/// <summary>
        /// Postavlja valutu na evro
        /// </summary>
        public void SetCurrencyToEuro()
        {
            ClickCurrencyDropdownMenu();
            ClickCurrencyEuro();
        }

        /// <summary>
        /// Postavlja valutu na pound
        /// </summary>
        public void SetCurrencyToPound()
        {
            ClickCurrencyDropdownMenu();
            ClickCurrencyPound();
        }*/

        /// <summary>
        /// Dodaje dva proizvoda u korpu
        /// </summary>
        public void AddTwoItemsToCart()
        {
            ClickOnAddToCartButton();
            ClickOnElement(addToCartButton1);
        }

        /// <summary>
        /// Kuca naziv proizvoda u search boxu i klikce search button
        /// </summary>
        /// <param name="productName">Naziv proizvoda</param>
        public void SearchForProduct(string productName)
        {
            TypeInSearchBox(productName);
            ClickSearchButton();
        }

        /// <summary>
        /// Klik na account dugme
        /// </summary>
        public void ClickOnAccountButton()
        {
            ClickOnElement(accountButton);
        }
    }
}
