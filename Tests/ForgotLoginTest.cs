using NUnit.Framework;

namespace Nunit_Selenium_Automatski_Test.Tests
{
    public class ForgotLoginTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            //klik na login or register link
            Pages.HomePage.ClickLoginOrRegisterLink();
            //klik na forgot your login link
            Pages.LoginPage.ClickForgotLoginLink();
        }
        [Test]
        public void ForgotLogin()
        {
            //popunjava formu i klikce na continue
            Pages.ForgottenLoginPage.ForgotYourLogin(TestData.TestData.ForgottenLogin.lastName, TestData.TestData.ForgottenLogin.email);

            //cuva poruku za uporedjivanje
            string message = Pages.ForgottenLoginPage.GetTextFromSuccessMessage();
            //assert da li se poruke podudaraju
            Assert.AreEqual(AppConstants.Constants.Messages.forgottenLoginSuccessMessage, message);
        }
    }
}
