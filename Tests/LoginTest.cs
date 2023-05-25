using NUnit.Framework;

namespace Nunit_Selenium_Automatski_Test.Tests
{
    public class LoginTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            //klik na login or register link
            Pages.HomePage.ClickLoginOrRegisterLink();
        }
        [Test]
        public void Login()
        {
            //popunjavanje forme i klik na submit
            Pages.LoginPage.LoginUser(TestData.TestData.Login.username, TestData.TestData.Login.password);

            //pamti trenutni url link
            string url = Pages.LoginPage.ReturnLoginSuccessLink(AppConstants.Constants.UrlLinks.loginSuccessLink);
            //provera da li nas je prosledio na dobru stranicu
            Assert.AreEqual(AppConstants.Constants.UrlLinks.loginSuccessLink, url);
        }
    }
}
