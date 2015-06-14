namespace AutoTest.PagesElements.MenuUI
{
    using AutoTest;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class HeaderMenu
    {
        public HeaderMenu()
        {
            PageFactory.InitElements(Driver.Chrome, this);
        }

        [FindsBy(How = How.CssSelector, Using = @"body > div.app > div > div.wrapper-header-navigation.ng-scope > ul > li:nth-child(2) > a > img")]
        public IWebElement OpenProfile { get; set; }
    }
}
