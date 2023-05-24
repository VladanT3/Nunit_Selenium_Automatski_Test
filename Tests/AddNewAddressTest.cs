using NUnit.Framework;

namespace Nunit_Selenium_Automatski_Test.Tests
{
    public class AddNewAddressTest : BaseTest
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
        public void AddNewAddress()
        {
            //klik na manage address book dugme
            Pages.AccountPage.ClickManageAddressBookButton();
            //popunjava formu i klikce continue
            Pages.ManageAddressBookPage.CreateNewAddress(
                TestData.TestData.AddNewAddress.firstName,
                TestData.TestData.AddNewAddress.lastName,
                TestData.TestData.AddNewAddress.address,
                TestData.TestData.AddNewAddress.city,
                TestData.TestData.AddNewAddress.zip
            );

            //cuva poruku koja je izasla radi asserta
            string message = Pages.ManageAddressBookPage.GetSuccessMessage();
            //provera da li je dobra poruka prikazana
            Assert.AreEqual(AppConstants.Constants.Messages.addNewAddressSuccessMessage, message);
        }
        [TearDown]
        public void TearDown()
        {
            //brise dodatu adresu
            Pages.ManageAddressBookPage.ClickDeleteButton();
        }
    }
}
