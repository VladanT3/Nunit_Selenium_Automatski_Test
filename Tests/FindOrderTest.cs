using NUnit.Framework;
using Nunit_Selenium_Automatski_Test.TestData;
using Nunit_Selenium_Automatski_Test.Tests;

namespace AutomationFramework.Tests
{
    public class FindOrderTest : BaseTest
    {
        [Test]
        public void FindOrder()
        {
            Pages.HomePage.ClickCheckOrder();
            Pages.OrderDetailsPage.CheckOrder(TestData.CheckOrder.productID, TestData.CheckOrder.email);

            //Assert

            string headingText = Pages.OrderDetailsPage.GetOrderDetailsText();
            Assert.AreEqual(Nunit_Selenium_Automatski_Test.AppConstants.Constants.Messages.orderDetailsHeadingText, headingText);
        }
    }
}
