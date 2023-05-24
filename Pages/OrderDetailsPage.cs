using OpenQA.Selenium;

namespace Nunit_Selenium_Automatski_Test.Pages
{
    public class OrderDetailsPage : BasePage
    {
        /// <summary>
        /// Konstuktor bez parametara
        /// </summary>
        public OrderDetailsPage()
        {
            driver = null;
        }

        /// <summary>
        /// Konstruktor sa parametrima
        /// </summary>
        /// <param name="webDriver">web driver</param>
        public OrderDetailsPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        //Locators
        By orderIdField = By.Id("CheckOrderFrm_order_id");
        By emailField = By.Id("CheckOrderFrm_email");
        By continueButton = By.XPath("//button[@title='Continue']");
        By orderDetailsText = By.XPath("//span[@class='maintext']");

        /// <summary>
        /// Metoda koja unosi vrednost u id polje
        /// </summary>
        /// <param name="id">id</param>
        private void EnterID(string id)
        {
            WriteTextToElement(orderIdField, id);
        }

        /// <summary>
        /// MEtoda koja unosi vrednost u email
        /// </summary>
        /// <param name="email">email</param>
        private void EnterEmail(string email)
        {
            WriteTextToElement(emailField, email);
        }

        /// <summary>
        /// Metoda koja vraca orde details text
        /// </summary>
        /// <returns>Vraca order deatails text</returns>
        public string GetOrderDetailsText()
        {
            Thread.Sleep(500);
            return ReadTextFromElement(orderDetailsText);
        }

        /// <summary>
        /// Metoda koja klikna na dugme continue
        /// </summary>
        private void ClickOnContinueButton()
        {
            ClickOnElement(continueButton);
        }

        /// <summary>
        /// Metoda koja vrsi proveru order-a
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="email">email</param>
        public void CheckOrder(string id, string email)
        {
            EnterID(id);
            EnterEmail(email);
            ClickOnContinueButton();
        }
        
    }
}
