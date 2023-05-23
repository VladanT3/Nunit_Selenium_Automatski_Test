using OpenQA.Selenium;

namespace Nunit_Selenium_Automatski_Test.Pages
{
    public class WishlistPage : BasePage
    {
        /// <summary>
        /// Podrazumevani konstruktor
        /// </summary>
        public WishlistPage()
        {
            driver = null;
        }
        /// <summary>
        /// Parametrizovani konstruktor
        /// </summary>
        /// <param name="webDriver">Driver</param>
        public WishlistPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }


        //Lokatori
        By wishlistTableRows = By.XPath("//table[@class='table table-striped table-bordered']/tbody/tr");
        By removeWishlistItem = By.XPath("//i[@class='fa fa-trash-o fa-fw']");


        /// <summary>
        /// Vraca naziv poslednjeg proizvoda koji je dodat u wishlist
        /// </summary>
        /// <returns>Naziv proizvoda iz tabele</returns>
        public string GetAddedProductName()
        {
            return GetValueFromLastTableRow(wishlistTableRows, 1);
        }

        /// <summary>
        /// Brise proizvod iz wishlista
        /// </summary>
        public void RemoveItemFromWishlist()
        {
            ClickOnElement(removeWishlistItem);
        }

        /// <summary>
        /// Vraca broj redova u wishlist tabeli
        /// </summary>
        /// <returns></returns>
        public int GetNumberOfWishlistTableRows()
        {
            Thread.Sleep(500);
            return GetNumberOfRowsFromTable(wishlistTableRows);
        }
    }
}
