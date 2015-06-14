namespace AutoTest.PagesElements.LoginForms
{
    using AutoTest;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class RegisterForm
    {
        public RegisterForm()
        {
            PageFactory.InitElements(Driver.Chrome, this);
        }

        [FindsBy(How = How.CssSelector, Using = @"#owl-demo > div.owl-stage-outer > div > div:nth-child(5) > li > a")]
        public IWebElement OpenRegMenu { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"#popup > div > div > div.bounceInRight.ng-scope > div > div > form > div:nth-child(2) > input")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"#popup > div > div > div.bounceInRight.ng-scope > div > div > form > div:nth-child(3) > input")]
        public IWebElement UsernameField { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"#popup > div > div > div.bounceInRight.ng-scope > div > div > form > div:nth-child(4) > input")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"#popup > div > div > div.bounceInRight.ng-scope > div > div > form > div:nth-child(5) > input")]
        public IWebElement RepeatPasswordField { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"#popup > div > div > div.bounceInRight.ng-scope > div > div > form > div:nth-child(6) > input")]
        public IWebElement CreateAccountButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"body > alert-popup > div > div > div.confirm-alert-content > span")]
        public IWebElement YouMustConfirmYourEmailButton { get; set; }
    }
}
