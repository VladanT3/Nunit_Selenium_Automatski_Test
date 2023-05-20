using AutomationTestStoreDomaci.Pages;
using SeleniumExtras.PageObjects;

namespace AutomationTestStoreDomaci.Utils
{
    /// <summary>
    /// Klasa koja inicijalicuje potrebnu stranicu
    /// </summary>
    public class AllPages
    {
        public AllPages(Browsers browser)
        {
            _browser = browser;
        }

        Browsers _browser { get; }

        private T GetPages<T>() where T : new()
        {
            var page = (T)Activator.CreateInstance(typeof(T), _browser.GetDriver);
            PageFactory.InitElements(_browser.GetDriver, page);
            return page;
        }

        public HomePage HomePage => GetPages<HomePage>();
        public LoginPage LoginPage => GetPages<LoginPage>();
        public RegisterPage RegisterPage => GetPages<RegisterPage>();
        public ForgottenPasswordPage ForgottenPasswordPage => GetPages<ForgottenPasswordPage>();
        public ForgottenLoginPage ForgottenLoginPage => GetPages<ForgottenLoginPage>();
        public ContactUsPage ContactUsPage => GetPages<ContactUsPage>();
        public CartPage CartPage => GetPages<CartPage>();
        public ProductPage ProductPage => GetPages<ProductPage>();
        public AccountPage AccountPage => GetPages<AccountPage>();
        public CheckoutPage CheckoutPage => GetPages<CheckoutPage>();
    }
}
