using OpenQA.Selenium;

namespace AutomationTestStoreDomaci.Pages
{
    public class LoginPage : BasePage
    {
        /// <summary>
        /// Podrazumevani konstruktor
        /// </summary>
        public LoginPage()
        {
            driver = null;
        }
        /// <summary>
        /// Parametrizovani konstruktor
        /// </summary>
        /// <param name="webDriver">Driver</param>
        public LoginPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        //Lokatori
        By registerContinueButton = By.XPath("//button[@title='Continue']");
        By loginNameInput = By.Id("loginFrm_loginname");
        By passwordInput = By.Id("loginFrm_password");
        By loginButton = By.XPath("//button[@title='Login']");
        By forgotYourPasswordLink = By.LinkText("Forgot your password?");
        By forgotYourLoginLink = By.LinkText("Forgot your login?");


        /// <summary>
        /// Popunjava login name polje
        /// </summary>
        /// <param name="loginName">Login name</param>
        private void EnterLoginName(string loginName)
        {
            WriteTextToElement(loginNameInput, loginName);
        }

        /// <summary>
        /// Popunjava password polje
        /// </summary>
        /// <param name="password">Password</param>
        private void EnterPassword(string password)
        {
            WriteTextToElement(passwordInput, password);
        }

        /// <summary>
        /// Klik na Login button
        /// </summary>
        private void ClickLoginButton()
        {
            ClickOnElement(loginButton);
        }


        /// <summary>
        /// Popunjava formu i klikce na login button
        /// </summary>
        /// <param name="username">Username/Login name</param>
        /// <param name="password">Password</param>
        public void LoginUser(string username, string password)
        {
            EnterLoginName(username);
            EnterPassword(password);
            ClickLoginButton();
        }

        /// <summary>
        /// Metoda koja vrsi klik na continue dugme u da bi se doslo do stranice za pravljenje naloga
        /// </summary>
        public void ClickOnRegisterContinueButton()
        {
            ClickOnElement(registerContinueButton);
        }

        /// <summary>
        /// Vraca url da bi proverili da li je otisao na dobru stranicu
        /// </summary>
        /// <returns>Url trenutne stranice</returns>
        public string ReturnLoginSuccessLink()
        {
            return GetUrlLink();
        }

        /// <summary>
        /// Klik na forgot your password link
        /// </summary>
        public void ClickForgotPasswordLink()
        {
            ClickOnElement(forgotYourPasswordLink);
        }

        /// <summary>
        /// Klik na forgot your login link
        /// </summary>
        public void ClickForgotLoginLink()
        {
            ClickOnElement(forgotYourLoginLink);
        }
    }
}
