namespace Nunit_Selenium_Automatski_Test.AppConstants
{
    public class Constants
    {
        public static class UrlLinks
        {
            public const string registrationSuccessLink = "https://automationteststore.com/index.php?rt=account/success",
                                loginSuccessLink = "https://automationteststore.com/index.php?rt=account/account",
                                contactUsSuccessLink = "https://automationteststore.com/index.php?rt=content/contact/success",
                                purchaseItemSuccessLink = "https://automationteststore.com/index.php?rt=checkout/success",
                                logoutLink = "https://automationteststore.com/index.php?rt=account/logout";
        
        }
        public static class Messages
        {
            public const string forgottenPasswordSuccessMessage = "×\r\nSuccess: Password reset link has been sent to your e-mail address.",
                                forgottenLoginSuccessMessage = "×\r\nSuccess: Your login name reminder has been sent to your e-mail address.",
                                changePasswordSuccessMessage = "×\r\nSuccess: Your password has been successfully updated.",
                                orderDetailsHeadingText = "ORDER DETAILS",
                                editAccountSuccessMessage = "×\r\nSuccess: Your account has been successfully updated.",
                                addNewAddressSuccessMessage = "×\r\nYour address has been successfully inserted",
                                deleteAddressSuccessMessage = "×\r\nYour address has been successfully deleted",
                                adressBookEditSuccess = "×\r\nYour address has been successfully updated";
        }
        public static class Currencies
        {
            public const string pound = "pound",
                                euro = "eur";
        }
    }
}
