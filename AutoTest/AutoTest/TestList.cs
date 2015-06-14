namespace AutoTest
{
    using System;
    using System.Threading;
    using AutoTest.PagesElements;
    using AutoTest.PagesElements.MenuUI.EditProfileMenu;
    using AutoTest.PagesElements.MenuUI.MenuElements;
    using AutoTest.PagesElements.LoginForms;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Support.UI;

    public static class TestList
    {
        public static void ValidLogin(bool stayLoggedIn, bool closeBrowserWhenFinished, string email, string password)
        {
            LoginForm loginForm = new LoginForm();
            HomePage homePage = new HomePage();
            
            Actions.NavToLoginForm();
            Actions.FillLoginForm(email, password);
            Thread.Sleep(300);

            try
            {
                homePage.BelotLogo.Click();
                Actions.GreenConsoleMessage("Login with valid details passed!");
            }
            catch (System.Reflection.TargetInvocationException) 
            {
                Actions.RedConsoleMessage("Login with valid details did NOT pass!");
            }

            if (stayLoggedIn == false)
            {
                Actions.LogOut();
            }

            if (closeBrowserWhenFinished == true)
            {
                Actions.CloseBrowser();
            }
        }

        public static void InvalidLogin(bool closeBrowserWhenFinished)
        {
            LoginForm loginForm = new LoginForm();
            HomePage homePage = new HomePage();
            
            Actions.NavToLoginForm();
            Actions.FillLoginForm("invalidmail@nosuchmailprovider.com", "invalidpass");
            Thread.Sleep(300); // needs to wait for the animation to end and the play button to become visible IF the test logged in successfuly

            try
            {
                homePage.BelotLogo.Click();
                Actions.RedConsoleMessage("Login with invalid details passed! This is very bad!");
            }
            catch (System.Reflection.TargetInvocationException) // element is not clickable exception
            {
                Actions.GreenConsoleMessage("Login with invalid details did NOT pass!");
            }

            if (closeBrowserWhenFinished == true)
            {
                Actions.CloseBrowser();
            }
        }
        
        public static void ValidRegistration(string username, string password, string email, bool closeBrowserWhenFinished)
        {
            Actions.NavToRegistrationForm();
            Actions.FillRegisterForm(username, password, email);
            Actions.GreenConsoleMessage("New user was successfuly registered.");

            if (closeBrowserWhenFinished == true)
            {
                Actions.CloseBrowser();
            }
        }

        public static void ChangeUserDetails(string userEmail, string newUsername, string currentPassword, string newPassword, string status, string years, string city, string country, bool closeBrowserWhenFinished)
        {
            Actions.RedConsoleMessage("Warning! Currently there is no check if the test was really successful!");

            ValidLogin(true, false, userEmail, currentPassword);
            Thread.Sleep(300);

            Actions.NavToUserProfile();
            Thread.Sleep(500);

            Actions.NavToEditUserProfile();
            Thread.Sleep(500);

            Actions.FillEditProfileInfoForm(newUsername, currentPassword, newPassword, status, years, city, country, closeBrowserWhenFinished);

            // Add a check if they really were successfuly changed!
            Actions.GreenConsoleMessage("User profile details were successfuly changed!");

            if (closeBrowserWhenFinished == true)
            {
                Actions.CloseBrowser();
            }
        }
    }
}
