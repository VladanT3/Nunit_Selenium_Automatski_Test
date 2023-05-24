using NUnit.Framework;

namespace Nunit_Selenium_Automatski_Test.Tests
{
    public class EditAdressBookTest : BaseTest
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
            Pages.AccountPage.ClickManageAddressBookButton();
        }
        
        [Test]
        public void EditAdressBook()
        {
            Pages.ManageAddressBookPage.ClickOnEditAdressBook();
            Pages.ManageAddressBookPage.FillEditAdressBook(
                TestData.TestData.EditAddress.firstName,
                TestData.TestData.EditAddress.lastName,
                TestData.TestData.EditAddress.address,
                TestData.TestData.EditAddress.city,
                TestData.TestData.EditAddress.zip);

            Assert.AreEqual(AppConstants.Constants.Messages.adressBookEditSuccess, Pages.ManageAddressBookPage.GetSuccessMessage());
        }
    }
}
