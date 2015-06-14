namespace AutoTest.PagesElements.MenuUI.MenuElements
{
    using AutoTest;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class LeftMenu
    {
        public LeftMenu()
        {
            PageFactory.InitElements(Driver.Chrome, this);
        }

        [FindsBy(How = How.CssSelector, Using = @"body > div.app > div > div.wrapper-header-navigation.ng-scope > ul > li.menu-icon > div:nth-child(1)")]
        public IWebElement OpenMenu { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"body > div.app > div > div:nth-child(4) > ul > li:nth-child(1) > span.header-hover.close-btn-navigation.menu-icon > img")]
        public IWebElement CloseMenu { get; set; }

        [FindsBy(How = How.LinkText, Using = @"Начало")]
        public IWebElement HomeButton { get; set; }

        [FindsBy(How = How.LinkText, Using = @"Приятели")]
        public IWebElement FriendsButton { get; set; }

        [FindsBy(How = How.LinkText, Using = @"Класации")]
        public IWebElement RatingsButton { get; set; }

        [FindsBy(How = How.LinkText, Using = @"Известия")]
        public IWebElement NotificationsButton { get; set; }

        [FindsBy(How = How.LinkText, Using = @"Магазин")]
        public IWebElement ShopButton { get; set; }

        [FindsBy(How = How.LinkText, Using = @"Помощ")]
        public IWebElement HelpButton { get; set; }

        [FindsBy(How = How.LinkText, Using = @"Излез")]
        public IWebElement LogOutButton { get; set; }
    }
}
