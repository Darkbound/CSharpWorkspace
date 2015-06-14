namespace AutoTest.PagesElements.LoginForms
{
    using AutoTest;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class LoginForm
    {
        public LoginForm()
        {
            PageFactory.InitElements(Driver.Chrome, this);
        }

        [FindsBy(How = How.LinkText, Using = @"Belot.BG")]
        public IWebElement UserPasswordLogin { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"#popup > div > div > div.bounceInRight.ng-scope > div > div.wrapper-popup-relative > form > div.position-relative.wrapper-bgbelot-login-name > input")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"#popup > div > div > div.bounceInRight.ng-scope > div > div.wrapper-popup-relative > form > div.position-relative.wrapper-bgbelot-login-password > input")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"input.bgbelot-login-btn.font-weight-700")]
        public IWebElement LoginButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"#popup > div > div > div.bounceInRight.ng-scope > div > div.wrapper-popup-relative > form > div.position-relative.wrapper-bgbelot-login-password > div")]
        public IWebElement InvalidLoginIcon { get; set; }
    }
}
