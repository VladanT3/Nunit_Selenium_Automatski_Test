using NUnit.Framework;

namespace Nunit_Selenium_Automatski_Test.Tests
{
    public class ChangePurchaseAddressTest : BaseTest
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
            //klik na add to cart pa na cart dugme
            Pages.HomePage.AddProductToCart();
            //klik na checkout dugme
            Pages.CartPage.ClickCheckoutButton();
        }

        [Test]
        public void ChangePurchaseAddress()
        {
            //klikni da se promeni adresa
            Pages.CheckoutPage.ClickEditShippingAddress();
            Pages.CheckoutPage.ClickChangeAddress();
            //popunjava se change address forma i klikce na kontinue
            Pages.CheckoutAddressShippingPage.CheckoutAddress(
                TestData.TestData.ChangePurchaseAddress.firstName,
                TestData.TestData.ChangePurchaseAddress.lastName,
                TestData.TestData.ChangePurchaseAddress.address,
                TestData.TestData.ChangePurchaseAddress.city,
                TestData.TestData.ChangePurchaseAddress.zip
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
