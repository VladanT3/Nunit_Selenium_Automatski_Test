﻿using NUnit.Framework;

namespace AutomationTestStoreDomaci.Tests
{
    public class SearchProductTest : BaseTest
    {
        [Test]
        public void SearchProduct()
        {
            //izvrsava search
            Pages.HomePage.SearchForProduct(TestData.TestData.SearchProduct.productName);

            //provera da li je nadjen proizvod
            Assert.AreEqual(TestData.TestData.SearchProduct.productName, Pages.ProductPage.GetProductName());
        }
    }
}
