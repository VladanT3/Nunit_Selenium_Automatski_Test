using Microsoft.VisualBasic;
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
            Pages.AdressBookPage.ClickOnManageBookAdress();
        }
        
        [Test]
        public void EditAdressBook()
        {
            Pages.AdressBookPage.ClickOnEditAdressBook();
            Pages.AdressBookPage.FillEditAdressBook(
                TestData.TestData.Checkout.firstName,
                TestData.TestData.Checkout.lastName,
                TestData.TestData.Checkout.address,
                TestData.TestData.Checkout.city,
                TestData.TestData.Checkout.zip);

            Assert.AreEqual(AppConstants.Constants.Messages.adressBookEditSuccess, Pages.AdressBookPage.GetSuccessText());
        }
    }
}
