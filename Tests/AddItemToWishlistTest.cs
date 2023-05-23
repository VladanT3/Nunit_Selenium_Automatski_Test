using NUnit.Framework;

namespace Nunit_Selenium_Automatski_Test.Tests
{
    public class AddItemToWishlistTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            //klik na login or register link
            Pages.HomePage.ClickLoginOrRegisterLink();
            //popunjavanje forme i klik na submit
            Pages.LoginPage.LoginUser(TestData.TestData.Login.username, TestData.TestData.Login.password);
            //klik na home button
            Pages.AccountPage.ClickHomeButton();
            //klik na naziv proizvoda
            Pages.HomePage.ClickOnProductLink();
        }
        [Test]
        public void AddItemToWishlist()
        {
            //klik na wishlist dugme
            Pages.ProductPage.ClickOnWishlistButton();
            //klik na account dugme
            Pages.HomePage.ClickOnAccountButton();
            //klik na wishlist dugme
            Pages.AccountPage.ClickOnWishlistButton();

            //pamti naziv proizvoda koji je dodat u wishlist
            string productName = Pages.WishlistPage.GetAddedProductName();
            //provera da li je dodat dobar proizvod
            Assert.AreEqual(TestData.TestData.AddItemToWishlist.productName, productName);
        }
        [TearDown]
        public void TearDown()
        {
            //brise dodati proizvod iz wishlista
            Pages.WishlistPage.RemoveItemFromWishlist();

            //broj redova u tabeli
            int numOfRows = Pages.WishlistPage.GetNumberOfWishlistTableRows();
            //provera da li je tabela prazna
            //proverava se sa jedan jer ostaje table header samo nakon brisanja svih proizvoda
            Assert.AreEqual(1, numOfRows);
        }
    }
}
