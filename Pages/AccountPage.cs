﻿using OpenQA.Selenium;

namespace Nunit_Selenium_Automatski_Test.Pages
{
    public class AccountPage : BasePage
    {
        /// <summary>
        /// Podrazumevani konstruktor
        /// </summary>
        public AccountPage()
        {
            driver = null;
        }
        /// <summary>
        /// Parametrizovani konstruktor
        /// </summary>
        /// <param name="webDriver">Driver</param>
        public AccountPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }


        //Lokatori
        By homeButton = By.XPath("//ul[@class='nav-pills categorymenu']/li/a[contains(., 'Home')]");
        By guestCheckoutRadio = By.Id("accountFrm_accountguest");
        By continueButton = By.XPath("//button[@title='Continue']");
        By wishlistButton = By.XPath("//ul[@class='side_account_list']/li[2]");
        By changePasswordButton = By.XPath("//ul[@class='side_account_list']/li[4]");
        By logoutUserButton = By.XPath("//div[contains(@class, 'myaccountbox')]//a[contains(., 'Logoff')]");
        By editAccountDetailsButton = By.XPath("//ul[@class='side_account_list']/li[3]");
        By manageAddressBookButton = By.XPath("//ul[@class='side_account_list']/li[5]");
        By successMsg = By.XPath("//div[@class='alert alert-success']");

        /// <summary>
        /// Klik na guest checkout radio button
        /// </summary>
        private void ClickGuestCheckoutRadioButton()
        {
            ClickOnElement(guestCheckoutRadio);
        }

        /// <summary>
        /// Klik na continue button
        /// </summary>
        private void ClickContinueButton()
        {
            ClickOnElement(continueButton);
        }


        /// <summary>
        /// Klik na home button
        /// </summary>
        public void ClickHomeButton()
        {
            ClickOnElement(homeButton);
        }

        /// <summary>
        /// Klik na guest checkout radio button pa na continue button
        /// </summary>
        public void CheckoutAsGuest()
        {
            ClickGuestCheckoutRadioButton();
            ClickContinueButton();
        }

        /// <summary>
        /// Klik na wishlist dugme
        /// </summary>
        public void ClickOnWishlistButton()
        {
            ClickOnElement(wishlistButton);
        }

        /// <summary>
        /// Klik na change password dugme
        /// </summary>
        public void ClickChangePasswordButton()
        {
            ClickOnElement(changePasswordButton);
        }

        /// <summary>
        /// Metoda koja klikne na Log out
        /// </summary>
        public void ClickLogout()
        {
            ClickOnElement(logoutUserButton);
        }

        /// <summary>
        /// Vraca url logout stranice
        /// </summary>
        /// <returns></returns>
        public string GetLogoutUrl(string url)
        {
            //Thread.Sleep(300);
            return GetUrlLink(url);
        }

        /// Klik na edit account dugme
        /// </summary>
        public void ClickEditAccountDetailsButton()
        {
            ClickOnElement(editAccountDetailsButton);
        }

        /// <summary>
        /// Vraca poruku koja se koristi za assert
        /// </summary>
        /// <returns></returns>
        public string GetSuccessMessage()
        {
            return ReadTextFromElement(successMsg);
        }

        /// <summary>
        /// Klik na manage address book dugme
        /// </summary>
        public void ClickManageAddressBookButton()
        {
            ClickOnElement(manageAddressBookButton);
        }
    }
}
