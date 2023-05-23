using NUnit.Framework;

namespace Nunit_Selenium_Automatski_Test.Tests
{
    public class RemoveItemFromCartTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            //klik na add to cart pa na cart dugme
            Pages.HomePage.AddProductToCart();
        }
        [Test]
        public void RemoveItemFromCart()
        {
            //klik na remove from cart dugme
            Pages.CartPage.ClickRemoveFromCartButton();

            //cuva broj proizvoda u korpi
            string numOfItems = Pages.CartPage.GetNumberOfItemsInCart();
            //provera da li ima nula proizvoda u korpi
            Assert.AreEqual("0", numOfItems);
        }
    }
}
