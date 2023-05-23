using NUnit.Framework;

namespace Nunit_Selenium_Automatski_Test.Tests
{
    public class ChangePasswordTest : BaseTest
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
        public void ChangePassword()
        {
            //klik na change password dugme
            Pages.AccountPage.ClickChangePasswordButton();
            //popunjava formu za promenu sifre i klikce na continue
            Pages.ChangePasswordPage.FillChangePasswordForm(TestData.TestData.ChangePassword.currentPassword, TestData.TestData.ChangePassword.newPassword);

            //cuva poruku za proveru
            string message = Pages.ChangePasswordPage.GetSuccessMessage();
            //provera da li se poruke podudaraju
            Assert.AreEqual(AppConstants.Constants.Messages.changePasswordSuccessMessage, message);
        }
        [TearDown]
        public void TearDown()
        {
            //klik na change password dugme
            Pages.AccountPage.ClickChangePasswordButton();
            //vraca sifru na staru da ne bi pukli ostali testovi
            Pages.ChangePasswordPage.FillChangePasswordForm(TestData.TestData.ChangePassword.newPassword, TestData.TestData.ChangePassword.currentPassword);
        }
    }
}
