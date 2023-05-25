using NUnit.Framework;

namespace Nunit_Selenium_Automatski_Test.Tests
{
    public class ContactUsTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            //klik na contact us link u footeru
            Pages.HomePage.ClickContactUsLink();
        }
        [Test]
        public void ContactUs()
        {
            //popunjava formu i klikce na submit
            Pages.ContactUsPage.SendMessage(
                TestData.TestData.ContactUs.firstName,
                TestData.TestData.ContactUs.email,
                TestData.TestData.ContactUs.message
            );
            
            //cuva trenutni link za assert
            string url = Pages.ContactUsPage.GetSuccessUrlLink(AppConstants.Constants.UrlLinks.contactUsSuccessLink);
            //uporedjivanje da li smo na dobroj stranici
            Assert.AreEqual(AppConstants.Constants.UrlLinks.contactUsSuccessLink, url);
        }
    }
}
