using OpenQA.Selenium;

namespace AutomationTestStoreDomaci.Pages
{
    public class ForgottenLoginPage : BasePage
    {
        /// <summary>
        /// Podrazumevani konstruktor
        /// </summary>
        public ForgottenLoginPage()
        {
            driver = null;
        }
        /// <summary>
        /// Parametrizovani konstruktor
        /// </summary>
        /// <param name="webDriver">Driver</param>
        public ForgottenLoginPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        //Lokatori
        By lastNameInput = By.Id("forgottenFrm_lastname");
        By emailInput = By.Id("forgottenFrm_email");
        By continueButton = By.XPath("//button[@title='Continue']");
        By successMsg = By.XPath("//div[@class='alert alert-success']");


        /// <summary>
        /// Upisuje last name u polje
        /// </summary>
        /// <param name="lastName">Last name</param>
        private void EnterLastName(string lastName)
        {
            WriteTextToElement(lastNameInput, lastName);
        }

        /// <summary>
        /// Upisuje email u polje
        /// </summary>
        /// <param name="email">Email</param>
        private void EnterEmail(string email)
        {
            WriteTextToElement(emailInput, email);
        }

        /// <summary>
        /// Klik na continue button
        /// </summary>
        private void ClickContinueButton()
        {
            ClickOnElement(continueButton);
        }


        /// <summary>
        /// Popunjava formu i klikce na continue
        /// </summary>
        /// <param name="lastName">Last name</param>
        /// <param name="email">Email</param>
        public void ForgotYourLogin(string lastName, string email)
        {
            EnterLastName(lastName);
            EnterEmail(email);
            ClickContinueButton();
        }

        /// <summary>
        /// Izvalci tekst is poruke da bi se assertovala
        /// </summary>
        /// <returns>Tekst iz success poruke</returns>
        public string GetTextFromSuccessMessage()
        {
            return ReadTextFromElement(successMsg);
        }
    }
}
