using NUnit.Framework;

namespace Nunit_Selenium_Automatski_Test.Tests
{
    public class FindOrderTest : BaseTest
    {
        [Test]
        public void FindOrder()
        {
            Pages.HomePage.ClickCheckOrder();
            Pages.OrderDetailsPage.CheckOrder(TestData.TestData.CheckOrder.productID, TestData.TestData.CheckOrder.email);

            //Assert
            string headingText = Pages.OrderDetailsPage.GetOrderDetailsText();
            Assert.AreEqual(Nunit_Selenium_Automatski_Test.AppConstants.Constants.Messages.orderDetailsHeadingText, headingText);
        }
    }
}
