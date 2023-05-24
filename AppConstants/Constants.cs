namespace Nunit_Selenium_Automatski_Test.AppConstants
{
    public class Constants
    {
        public static class UrlLinks
        {
            public const string registrationSuccessLink = "https://automationteststore.com/index.php?rt=account/success",
                                loginSuccessLink = "https://automationteststore.com/index.php?rt=account/account",
                                contactUsSuccessLink = "https://automationteststore.com/index.php?rt=content/contact/success",
                                purchaseItemSuccessLink = "https://automationteststore.com/index.php?rt=checkout/success";
        }
        public static class Messages
        {
            //haos
            public const string forgottenPasswordSuccessMessage = "×\r\nSuccess: Password reset link has been sent to your e-mail address.",
                                forgottenLoginSuccessMessage = "×\r\nSuccess: Your login name reminder has been sent to your e-mail address.",
                                changePasswordSuccessMessage = "×\r\nSuccess: Your password has been successfully updated.",
                                adressBookEditSuccess = "×\r\nYour address has been successfully updated";
        }
        public static class Currencies
        {
            public const string pound = "pound",
                                euro = "eur";
        }
    }
}
