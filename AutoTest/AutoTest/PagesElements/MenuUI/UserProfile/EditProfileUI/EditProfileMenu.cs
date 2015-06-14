namespace AutoTest.PagesElements.MenuUI.EditProfileMenu
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class EditProfileMenu
    {
        public EditProfileMenu()
        {
            PageFactory.InitElements(Driver.Chrome, this);
        }

        [FindsBy(How = How.Id, Using = @"username")]
        public IWebElement UsernameField { get; set; }

        [FindsBy(How = How.Id, Using = @"status")]
        public IWebElement StatusField { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"#sex > select")]
        public IWebElement GenderDropDownMenu { get; set; }

        [FindsBy(How = How.Id, Using = @"age")]
        public IWebElement AgeField { get; set; }

        [FindsBy(How = How.Id, Using = @"city")]
        public IWebElement CityField { get; set; }

        [FindsBy(How = How.Id, Using = @"country")]
        public IWebElement CountryField { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"#popup > div > div.wrapper-all.wrapper-center > div.ng-scope > div > div > div > div > div.wrapper-change-pass > button > span")]
        public IWebElement ChangePasswordButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"#popup > div > div.wrapper-all.wrapper-center > div.ng-scope > div > div > div > div > div.wrapper-popup-relative > div:nth-child(1) > input")]
        public IWebElement CurrentPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"#popup > div > div.wrapper-all.wrapper-center > div.ng-scope > div > div > div > div > div.wrapper-popup-relative > div:nth-child(2) > input")]
        public IWebElement NewPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"#popup > div > div.wrapper-all.wrapper-center > div.ng-scope > div > div > div > div > div.wrapper-popup-relative > div:nth-child(3) > input")]
        public IWebElement NewPasswordRepeat { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"#popup > div > div.wrapper-all.wrapper-center > div.ng-scope > div > div > div > div > div.wrapper-save-btn > button")]
        public IWebElement SaveProfileChangesButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = @"#popup > div > div.wrapper-all.wrapper-center > div.ng-scope > div > div > div > div > a > input")]
        public IWebElement CancelProfileChangesButton { get; set; }
    }
}
