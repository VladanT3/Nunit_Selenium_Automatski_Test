using NUnit.Framework;

namespace Nunit_Selenium_Automatski_Test.Tests
{
    public class LogoutTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            //klik na login or register link
            Pages.HomePage.ClickLoginOrRegisterLink();
            //popunjavanje forme i klik na submit
            Pages.LoginPage.LoginUser(TestData.TestData.Login.username, TestData.TestData.Login.password);
        }

        [Test]
        public void Logout()
        {
            //klik na logoff
            Pages.AccountPage.ClickLogout();
            //cuva url trenutne stranice
            string url = Pages.CheckoutPage.GetSuccessUrl(AppConstants.Constants.UrlLinks.logoutLink);
            //assert test
            Assert.AreEqual(AppConstants.Constants.UrlLinks.logoutLink, url);
        }
    }
}
