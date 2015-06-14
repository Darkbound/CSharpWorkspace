namespace AutoTest.PagesElements
{
    using AutoTest;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(Driver.Chrome, this);
        }
        
        [FindsBy(How = How.LinkText, Using = @"Продължи")]
        public IWebElement ContinueLink { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"body > div.app > div > div > div.wrapper-connect > div > div.wrapper-img.clearfix > div.fb-login-btn.clearfix > span.fb-login-btn-text.ng-binding")]
        public IWebElement FacebookLogin { get; set; }
    }
}
