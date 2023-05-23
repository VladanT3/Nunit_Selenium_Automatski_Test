using OpenQA.Selenium;

namespace Nunit_Selenium_Automatski_Test.Pages
{
    public class ChangePasswordPage : BasePage
    {
        /// <summary>
        /// Podrazumevani konstruktor
        /// </summary>
        public ChangePasswordPage()
        {
            driver = null;
        }
        /// <summary>
        /// Parametrizovani konstruktor
        /// </summary>
        /// <param name="webDriver">Driver</param>
        public ChangePasswordPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }


        //Lokatori
        By currentPasswordInput = By.Id("PasswordFrm_current_password");
        By newPasswordInput = By.Id("PasswordFrm_password");
        By newPasswordConfirmInput = By.Id("PasswordFrm_confirm");
        By continueButton = By.XPath("//button[@title='Continue']");
        By successMsg = By.XPath("//div[@class='alert alert-success']");


        /// <summary>
        /// Popunjava current password polje
        /// </summary>
        /// <param name="currentPassword">Trenutna sifra</param>
        private void EnterCurrentPassword(string currentPassword)
        {
            WriteTextToElement(currentPasswordInput, currentPassword);
        }

        /// <summary>
        /// Popunjava new password polje
        /// </summary>
        /// <param name="newPassword">Nova sifra</param>
        private void EnterNewPassword(string newPassword)
        {
            WriteTextToElement(newPasswordInput, newPassword);
        }

        /// <summary>
        /// Popunjava new password confirm polje
        /// </summary>
        /// <param name="newPasswordConfirm">Nova sifra</param>
        private void EnterNewConfirmPassword(string newPasswordConfirm)
        {
            WriteTextToElement(newPasswordConfirmInput, newPasswordConfirm);
        }

        /// <summary>
        /// Klik na continue dugme
        /// </summary>
        private void ClickContinueButton()
        {
            ClickOnElement(continueButton);
        }


        /// <summary>
        /// Popunjava change password formu i klikce na continue dugme
        /// </summary>
        /// <param name="currentPassword">Trenutna sifra</param>
        /// <param name="newPassword">Nova sifra</param>
        public void FillChangePasswordForm(string currentPassword, string newPassword)
        {
            EnterCurrentPassword(currentPassword);
            EnterNewPassword(newPassword);
            EnterNewConfirmPassword(newPassword);
            ClickContinueButton();
        }

        /// <summary>
        /// Vraca poruku koja izlazi nakon sto je promenjena sifra
        /// </summary>
        /// <returns>Poruka</returns>
        public string GetSuccessMessage()
        {
            return ReadTextFromElement(successMsg);
        }
    }
}
