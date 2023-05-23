using NUnit.Framework;

namespace Nunit_Selenium_Automatski_Test.Tests
{
    public class ValidateCartPriceTest : BaseTest
    {
        [Test]
        public void ValidateCartPrice()
        {
            //dodavanje dva proizvoda u korpu
            Pages.HomePage.AddTwoItemsToCart();
            //ulazi u cart
            Pages.HomePage.ClickCartButton();

            //cena koja pise na sajtu i cena koja je dobijena sabiranjem cena proizvoda
            float actualTotalPrice = Pages.CartPage.GetActualTotalPrice();
            float expectedTotalPrice = Pages.CartPage.GetExpectedTotalPrice();
            //provera da li su iste
            Assert.AreEqual(expectedTotalPrice, actualTotalPrice);

            //brise se prvi proizvod iz korpe
            Pages.CartPage.RemoveFirstItemFromCart();
            //cena koja pise na sajtu i cena koja je dobijena sabiranjem cena proizvoda
            float newActualTotalPrice = Pages.CartPage.GetActualTotalPrice();
            float newExpectedTotalPrice = Pages.CartPage.GetExpectedTotalPrice();
            //provera da li su iste
            Assert.AreEqual(newExpectedTotalPrice, newActualTotalPrice);
        }
    }
}
