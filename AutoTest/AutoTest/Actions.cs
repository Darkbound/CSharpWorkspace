namespace AutoTest
{
    using System;
    using System.Threading;
    using AutoTest.PagesElements;
    using AutoTest.PagesElements.LoginForms;
    using AutoTest.PagesElements.MenuUI;
    using AutoTest.PagesElements.MenuUI.EditProfileMenu;
    using AutoTest.PagesElements.MenuUI.MenuElements;
    using AutoTest.PagesElements.MenuUI.UserProfile;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Support.UI;

    public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.Chrome = new ChromeDriver();
            Driver.Chrome.Navigate().GoToUrl(EntryPoint.BaseURL);
            Driver.WaitForElementUpTo(5000);
        }

        public static void NavToLoginForm()
        {
            LoginPage loginPage = new LoginPage();
            LoginForm loginForm = new LoginForm();
            
            if (Driver.Chrome.Url != EntryPoint.BaseURL)
            {
                Driver.Chrome.Navigate().GoToUrl(EntryPoint.BaseURL);
            }
            
            loginPage.ContinueLink.Click();
            ClickDailyBonusPopUp();
            Driver.Chrome.Navigate().GoToUrl("https://belot.bg/#/login/fb"); // clicks on "Влез"
            loginForm.UserPasswordLogin.Click();
        }

        public static void FillLoginForm(string email, string password)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.EmailField.SendKeys(email);
            loginForm.PasswordField.SendKeys(password);
            loginForm.LoginButton.Click();

            // Try to take daily bonus if this is the first login for this account for today.
            Driver.WaitForElementUpTo(150);
            try
            {
                ClickDailyBonusPopUp();
            }
            catch (NoSuchElementException) { }

            Driver.WaitForElementUpTo(5000);
        }

        public static void NavToRegistrationForm()
        {
            LoginPage loginPage = new LoginPage();
            RegisterForm regForm = new RegisterForm();
            
            if (Driver.Chrome.Url != EntryPoint.BaseURL)
            {
                Driver.Chrome.Navigate().GoToUrl(EntryPoint.BaseURL);
            }

            loginPage.ContinueLink.Click();
            ClickDailyBonusPopUp();
            Driver.Chrome.Navigate().GoToUrl("https://belot.bg/#/login/fb"); // clicks on "Влез", add it to headerNavMenu elements!!
            regForm.OpenRegMenu.Click();
        }
        
        public static void FillRegisterForm(string username, string password, string email)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.EmailField.SendKeys(email);
            regForm.UsernameField.SendKeys(username);
            regForm.PasswordField.SendKeys(password);
            regForm.RepeatPasswordField.SendKeys(password);
            regForm.CreateAccountButton.Click();
            regForm.YouMustConfirmYourEmailButton.Click();
        }

        public static void NavToUserProfile()
        {
            HeaderMenu headerMenu = new HeaderMenu();
            ProfileMenu profileMenu = new ProfileMenu();
            headerMenu.OpenProfile.Click();
            profileMenu.UserProfile.Click();
        } 

        public static void NavToEditUserProfile()
        {
            ProfileMenu profileMenu = new ProfileMenu();
            
            if (!profileMenu.EditProfile.Displayed)
            {
                NavToUserProfile();
            }

            profileMenu.EditProfile.Click();
        }

        public static void FillEditProfileInfoForm(string newUsername, string currentPassword, string newPassword, string status, string years, string city, string country, bool closeBrowserWhenFinished)
        {
            EditProfileMenu editProfile = new EditProfileMenu();
            editProfile.UsernameField.Clear();
            editProfile.UsernameField.SendKeys(newUsername);
            editProfile.StatusField.Clear();
            editProfile.StatusField.SendKeys(status);
            editProfile.AgeField.Clear();
            editProfile.AgeField.SendKeys(years);
            editProfile.CityField.Clear();
            editProfile.CityField.SendKeys(city);
            editProfile.CountryField.Clear();
            editProfile.CountryField.SendKeys(country);
            editProfile.ChangePasswordButton.Click();
            editProfile.CurrentPassword.SendKeys(currentPassword);
            editProfile.NewPassword.SendKeys(newPassword);
            editProfile.NewPasswordRepeat.SendKeys(newPassword);
            editProfile.SaveProfileChangesButton.Click();
        }
        
        public static void ClickDailyBonusPopUp()
        {
            IWebElement takeBonus = Driver.Chrome.FindElement(By.CssSelector(".collect"));
            takeBonus.Click();
        }
        
        public static void RedConsoleMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void GreenConsoleMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void CloseBrowser()
        {
            Driver.Chrome.Close();
        }

        public static void LogOut()
        {
            LeftMenu leftMenu = new LeftMenu();

            Thread.Sleep(500);     // driver does not wait for this element, because it's already there but not clickable, there is another element on top of it, without sleep exception is thrown
            try
            {
                leftMenu.OpenMenu.Click();
                leftMenu.LogOutButton.Click();
                GreenConsoleMessage("Loging out was successful!");
            }
            catch (System.Reflection.TargetInvocationException)
            {
                RedConsoleMessage("Loging out was not successful!");
            }
        }
    }
}
