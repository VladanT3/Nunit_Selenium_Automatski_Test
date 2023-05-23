using NUnit.Framework;

namespace Nunit_Selenium_Automatski_Test.Tests
{
    public class ForgotPasswordTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            //klik na login or register link
            Pages.HomePage.ClickLoginOrRegisterLink();
            //klik na forgot your password link
            Pages.LoginPage.ClickForgotPasswordLink();
        }
        [Test]
        public void ForgotPassword()
        {
            //popunjava formu i klikce na continue
            Pages.ForgottenPasswordPage.ForgotYourPassword(TestData.TestData.ForgottenPassword.username, TestData.TestData.ForgottenPassword.email);

            //cuva poruku za uporedjivanje
            string message = Pages.ForgottenPasswordPage.GetTextFromSuccessMessage();
            //assert da li se poruke podudaraju
            Assert.AreEqual(AppConstants.Constants.Messages.forgottenPasswordSuccessMessage, message);
        }
    }
}
