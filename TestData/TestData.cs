namespace Nunit_Selenium_Automatski_Test.TestData
{
    public class TestData
    {
        public static class Register
        {
            public const string firstName = "Vladan",
                                lastName = "Tesic",
                                baseEmail = "vladan",
                                address = "Spanskih boraca 34",
                                city = "Beograd",
                                zip = "11070",
                                baseUsername = "Vladan",
                                password = "test";
        }
        public static class Login
        {
            public const string username = "Vladan2001",
                                password = "test";
        }
        public static class ForgottenPassword
        {
            public const string username = "Vladan2001",
                                email = "vladanTest@test.com";
        }
        public static class ForgottenLogin
        {
            public const string lastName = "Tesic",
                                email = "vladanTest@test.com";
        }
        public static class ContactUs
        {
            public const string firstName = "Vladan",
                                email = "vladanTest@test.com",
                                message = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.";
        }
        public static class AddToCart
        {
            public const string productName = "Total Moisture Facial Cream";
        }
        public static class Checkout
        {
            public const string firstName = "Vladan",
                                lastName = "Tesic",
                                email = "vladanTest@test.com",
                                address = "Spanskih boraca 34",
                                city = "Beograd",
                                zip = "11070";
        }
        public static class SearchProduct
        {
            public const string productName = "Total Moisture Facial Cream";
        }
        public static class AddItemToWishlist
        {
            public const string productName = "Total Moisture Facial Cream";
        }
        public static class ChangePassword
        {
            public const string currentPassword = "test",
                                newPassword = "test1";
        }
        public static class CheckOrder
        {
            public const string productID = "19565",
                                email = "vladanTest@test.com";
        }
        public static class ChangePurchaseAddress
        {
            public const string firstName = "ime narucioca",
                                lastName = "prezime narucioca",
                                address = "ulica narucioca bb",
                                city = "grad narucioca",
                                zip = "12005";
        }
        public static class EditAccount
        {
            public const string firstName = "Test",
                                lastName = "Tesic",
                                email = "testtestic@test.com",
                                phoneNumber = "060555996",
                                fax = "123123",
                                emailTeardown = "vladanTest@test.com";
        }
        public static class AddNewAddress
        {
            public const string firstName = "test",
                                lastName = "test",
                                address = "test 123",
                                city = "test",
                                zip = "54321";
        }
        public static class EditAddress
        {
            public const string firstName = "Test123",
                                lastName = "Test321",
                                address = "Test 312",
                                city = "Test 456",
                                zip = "54321";
        }
    }
}
