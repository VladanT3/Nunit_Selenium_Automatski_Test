using OpenQA.Selenium;

namespace Nunit_Selenium_Automatski_Test.Pages
{
    public class CartPage : BasePage
    {
        /// <summary>
        /// Podrazumevani konstruktor
        /// </summary>
        public CartPage()
        {
            driver = null;
        }
        /// <summary>
        /// Parametrizovani konstruktor
        /// </summary>
        /// <param name="webDriver">Driver</param>
        public CartPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }


        //Lokatori
        By cartTableRows = By.XPath("//div[@class='container-fluid cart-info product-list']/table[@class='table table-striped table-bordered']/tbody/tr");
        By removeFromCartButton = By.XPath("//td[@class='align_center']/a/i");
        By numberOfItemsSpan = By.XPath("//a[@class='dropdown-toggle']/span[@class='label label-orange font14']");
        By checkoutButton = By.Id("cart_checkout1");
        //!!! quantityInput radi samo ako je u korpu stavljeno vise istih proizvoda !!!
        //Drugacija je logika ako se radi sa vise razlicitih
        By quantityInput = By.XPath("//td[@class='align_center']/div/input");
        By updateButton = By.Id("cart_update");
        By totalPriceSpan = By.XPath("//a[@class='dropdown-toggle']/span[@class='cart_total']");
        By removeFirstItemFromCartButton = By.XPath("//tr[2]/td[@class='align_center']/a/i");


        public void UpdateItemQuantity(string currentItemCount)
        {
            int itemCount = int.Parse(currentItemCount);
            if (itemCount == 0)
                return;

            ClearTextFromElement(quantityInput);
            WriteTextToElement(quantityInput, (itemCount - 1).ToString());
            ClickOnElement(updateButton);
        }

        /// <summary>
        /// Vraca vrednost iz, u ovom slucaju, druge kolone iz tabele
        /// </summary>
        /// <returns>Naziv poslednjeg proizvoda u cart tabeli</returns>
        public string GetLastProductName()
        {
            return GetValueFromLastTableRow(cartTableRows, 1);
        }

        /// <summary>
        /// Klik na remove from cart dugme od proizvoda
        /// </summary>
        public void ClickRemoveFromCartButton()
        {
            ClickOnElement(removeFromCartButton);
        }

        /// <summary>
        /// Vraca broj proizvoda u cart. Gleda broj u gornjem levom uglu kod cart dugmeta
        /// </summary>
        /// <returns>Broj proizvoda u korpi</returns>
        public string GetNumberOfItemsInCart()
        {
            return ReadTextFromElement(numberOfItemsSpan);
        }

        /// <summary>
        /// Klik na checkout dugme
        /// </summary>
        public void ClickCheckoutButton()
        {
            ClickOnElement(checkoutButton);
        }

        /// <summary>
        /// Vraca ukupnu cenu sa sajta kao realni broj
        /// </summary>
        /// <returns>Ukupna cena korpe</returns>
        public float GetActualTotalPrice()
        {
            return GetFloatFromPriceText(totalPriceSpan);
        }

        /// <summary>
        /// Sabira cene iz tabele i vraca je
        /// </summary>
        /// <returns>Zbir cena proizvoda</returns>
        public float GetExpectedTotalPrice()
        {
            return GetSumOfColumnValues(cartTableRows, 1, 6);
        }

        /// <summary>
        /// Brise iskljucivo samo prvi proizvod iz korpe
        /// </summary>
        public void RemoveFirstItemFromCart()
        {
            ClickOnElement(removeFirstItemFromCartButton);
        }
    }
}
