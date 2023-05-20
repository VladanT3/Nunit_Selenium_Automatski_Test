using NUnit.Framework;

namespace AutomationTestStoreDomaci.Tests
{
    public class PurchaseItemTest : BaseTest
    {
        [Test]
        public void PurchaseItemWithUSD()
        {
            //klik na login or register link
            Pages.HomePage.ClickLoginOrRegisterLink();
            //popunjavanje forme i klik na submit
            Pages.LoginPage.LoginUser(TestData.TestData.Login.username, TestData.TestData.Login.password);
            //klik na home button
            Pages.AccountPage.ClickHomeButton();
            //klik na add to cart pa na cart dugme
            Pages.HomePage.AddProductToCart();
            //klik na checkout dugme
            Pages.CartPage.ClickCheckoutButton();
            //klik na confirm order dugme
            Pages.CheckoutPage.ClickConfirmOrderButton();

            //cuva url trenutne stranice
            string url = Pages.CheckoutPage.GetSuccessUrl();
            //provera da li smo na dobroj stranici
            Assert.AreEqual(AppConstants.Constants.UrlLinks.purchaseItemSuccessLink, url);
        }
        [Test]
        public void PurchaseItemWithEUR()
        {
            //menja se valuta u EUR
            Pages.HomePage.SetCurrencyToEuro();
            //klik na login or register link
            Pages.HomePage.ClickLoginOrRegisterLink();
            //popunjavanje forme i klik na submit
            Pages.LoginPage.LoginUser(TestData.TestData.Login.username, TestData.TestData.Login.password);
            //klik na home button
            Pages.AccountPage.ClickHomeButton();
            //klik na add to cart pa na cart dugme
            Pages.HomePage.AddProductToCart();
            //klik na checkout dugme
            Pages.CartPage.ClickCheckoutButton();
            //klik na confirm order dugme
            Pages.CheckoutPage.ClickConfirmOrderButton();

            //cuva url trenutne stranice
            string url = Pages.CheckoutPage.GetSuccessUrl();
            //provera da li smo na dobroj stranici
            Assert.AreEqual(AppConstants.Constants.UrlLinks.purchaseItemSuccessLink, url);
        }
        [Test]
        public void GuestPurchaseItemWithGBP()
        {
            //menja se valuta u GBP
            Pages.HomePage.SetCurrencyToPound();
            //klik na home button
            Pages.HomePage.AddProductToCart();
            //klik na checkout dugme
            Pages.CartPage.ClickCheckoutButton();
            //bira opciju guest checkout i ide dalje
            Pages.AccountPage.CheckoutAsGuest();
            //popunjava se checkout forma i klikce na continue
            //!!! BICE SPORO ZBOG OGROMNIH SELECT-A, NE ZNACI DA JE TEST PUKO !!!
            Pages.CheckoutPage.FillCheckoutForm(
                TestData.TestData.Checkout.firstName,
                TestData.TestData.Checkout.lastName,
                TestData.TestData.Checkout.email,
                TestData.TestData.Checkout.address,
                TestData.TestData.Checkout.city,
                TestData.TestData.Checkout.zip
            );
            //klik na confirm order dugme
            Pages.CheckoutPage.ClickConfirmOrderButton();

            //cuva url trenutne stranice
            string url = Pages.CheckoutPage.GetSuccessUrl();
            //provera da li smo na dobroj stranici
            Assert.AreEqual(AppConstants.Constants.UrlLinks.purchaseItemSuccessLink, url);
        }
    }
}
