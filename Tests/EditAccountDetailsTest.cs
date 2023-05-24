using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit_Selenium_Automatski_Test.Tests
{
    public class EditAccountDetailsTest:BaseTest
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
        public void EditAccount()
        {
            Pages.AccountPage.ClickEditAccountDetailsButton();
            Pages.AccountDetailsPage.EnterEditAccount(TestData.TestData.EditAccount.firstName, TestData.TestData.EditAccount.lastName,
                TestData.TestData.EditAccount.email, TestData.TestData.EditAccount.phoneNumber, TestData.TestData.EditAccount.fax);

            //cuva poruku za proveru
            string message = Pages.AccountPage.GetSuccessMessage();
            //provera da li se poruke podudaraju
            Assert.AreEqual(AppConstants.Constants.Messages.editAccountSuccessMessage, message);
        }

    }
}
