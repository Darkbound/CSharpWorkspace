namespace AutoTest.PagesElements.MenuUI.UserProfile
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class ProfileMenu
    {
        public ProfileMenu()
        {
            PageFactory.InitElements(Driver.Chrome, this);
        }

        [FindsBy(How = How.CssSelector, Using = @"#owl-demo > div.owl-stage-outer > div > div:nth-child(5) > li > a")]
        public IWebElement UserProfile { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"#popup > div > div.wrapper-all.wrapper-center > div.ng-scope > div > div > div > div.edit-profile > a > span")]
        public IWebElement EditProfile { get; set; }
    }
}
