using NUnit.Framework;

namespace Nunit_Selenium_Automatski_Test.Tests
{
    public class DeleteAddressTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            //klik na login or register link
            Pages.HomePage.ClickLoginOrRegisterLink();
            //popunjavanje forme i klik na submit
            Pages.LoginPage.LoginUser(TestData.TestData.Login.username, TestData.TestData.Login.password);
            //klik na account dugme
            Pages.HomePage.ClickOnAccountButton();
            //klik na manage address book dugme
            Pages.AccountPage.ClickManageAddressBookButton();
            //pravi novu adresu
            Pages.ManageAddressBookPage.FillAddNewAddressForm(
                TestData.TestData.AddNewAddress.firstName,
                TestData.TestData.AddNewAddress.lastName,
                TestData.TestData.AddNewAddress.address,
                TestData.TestData.AddNewAddress.city,
                TestData.TestData.AddNewAddress.zip
            );
        }
        [Test]
        public void DeleteAddress()
        {
            //klik na delete dugme
            Pages.ManageAddressBookPage.ClickDeleteButton();

            //poruka za assert
            string message = Pages.ManageAddressBookPage.GetSuccessMessage();
            //provera da li je dobra poruka
            Assert.AreEqual(AppConstants.Constants.Messages.deleteAddressSuccessMessage, message);
        }
    }
}
