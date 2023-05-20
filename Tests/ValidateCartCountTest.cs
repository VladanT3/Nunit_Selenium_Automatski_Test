﻿using NUnit.Framework;

namespace AutomationTestStoreDomaci.Tests
{
    public class ValidateCartCountTest : BaseTest
    {
        [Test]
        public void ValidateCartCount()
        {
            //dodavanje u cart i assert da li se broj proizvoda povecava
            int i = 1;
            while(i <= 3)
            {
                Pages.HomePage.ClickOnAddToCartButton();
                Assert.AreEqual(i.ToString(), Pages.CartPage.GetNumberOfItemsInCart());
                i++;
            }

            //ulazi u cart
            Pages.HomePage.ClickCartButton();

            //zbog petlje iznad je na 4 pa treba da se spusti samo nazad na 3
            i--;
            //brisanje iz korpe i assert da li se broj smanjuje
            while(i > 0)
            {
                i--;
                Pages.CartPage.UpdateItemQuantity(Pages.CartPage.GetNumberOfItemsInCart());
                Assert.AreEqual(i.ToString(), Pages.CartPage.GetNumberOfItemsInCart());
            }
        }
    }
}
