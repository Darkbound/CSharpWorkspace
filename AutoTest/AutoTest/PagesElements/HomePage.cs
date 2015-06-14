namespace AutoTest.PagesElements
{
    using AutoTest;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class HomePage
    {
        public HomePage()
        {
            PageFactory.InitElements(Driver.Chrome, this);
        }

        [FindsBy(How = How.CssSelector, Using = "body > div.app > div > div.wrapper-all-lobby.ng-scope > div > div > div.wrapper-home-screen > div.wrapper-bottom > a > span")]
        public IWebElement PlayButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"body > div.app > div > div.wrapper-all-lobby.ng-scope > div > div > div.wrapper-home-screen > div.logo-signs")]
        public IWebElement BelotLogo { get; set; }
    }
}
