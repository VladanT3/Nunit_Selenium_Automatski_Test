using AutomationTestStoreDomaci.Utils;
using NUnit.Framework;
using RazorEngine.Compilation.ImpromptuInterface;

namespace AutomationTestStoreDomaci.Tests
{
    public class RegisterTest : BaseTest
    {
        //random generisan username
        string _username = CommonMethods.GenerateRandomUsername(TestData.TestData.Register.baseUsername);
        //random generisan email
        string _email = CommonMethods.GenerateRandomEmail(TestData.TestData.Register.baseEmail);

        [SetUp]
        public void Setup()
        {
            //Klik na login or register link
            Pages.HomePage.ClickLoginOrRegisterLink();
            //Klik na continue dugme kod registracije
            Pages.LoginPage.ClickOnRegisterContinueButton();
        }
        [Test]
        public void Register()
        {
            //Popunjavanje forme za registraciju i klik na continue
            //!!! BICE SPORO ZBOG OGROMNIH SELECT-A, NE ZNACI DA JE TEST PUKO !!!
            Pages.RegisterPage.RegisterUser(
                TestData.TestData.Register.firstName,
                TestData.TestData.Register.lastName,
                _email,
                TestData.TestData.Register.address,
                TestData.TestData.Register.city,
                TestData.TestData.Register.zip,
                _username,
                TestData.TestData.Register.password
            );

            //belezi se url trenutne stranice
            string url = Pages.RegisterPage.ReturnRegisterSuccessUrl();
            //proverava se zabalezeni url sa onim koji bi trebao da bude
            Assert.AreEqual(AppConstants.Constants.UrlLinks.registrationSuccessLink, url);
        }
    }
}
