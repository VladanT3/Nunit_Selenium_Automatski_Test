using OpenQA.Selenium;

namespace AutomationTestStoreDomaci.Pages
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
    }
}
