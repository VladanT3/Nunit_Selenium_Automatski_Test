using OpenQA.Selenium;

namespace Nunit_Selenium_Automatski_Test.Pages
{
    public class ForgottenPasswordPage : BasePage
    {
        /// <summary>
        /// Podrazumevani konstruktor
        /// </summary>
        public ForgottenPasswordPage()
        {
            driver = null;
        }
        /// <summary>
        /// Parametrizovani konstruktor
        /// </summary>
        /// <param name="webDriver">Driver</param>
        public ForgottenPasswordPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        //Lokatori
        By loginNameInput = By.Id("forgottenFrm_loginname");
        By emailInput = By.Id("forgottenFrm_email");
        By continueButton = By.XPath("//button[@title='Continue']");
        By successMsg = By.XPath("//div[@class='alert alert-success']");


        /// <summary>
        /// Upisuje login name u polje
        /// </summary>
        /// <param name="loginName">Login name</param>
        private void EnterLoginName(string loginName)
        {
            WriteTextToElement(loginNameInput, loginName);
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
        /// <param name="loginName">Login name</param>
        /// <param name="email">Email</param>
        public void ForgotYourPassword(string loginName, string email)
        {
            EnterLoginName(loginName);
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
