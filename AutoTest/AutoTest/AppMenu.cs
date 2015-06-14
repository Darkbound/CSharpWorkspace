namespace AutoTest
{
    using System;
    using System.Threading;
    using AutoTest;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    public class AppMenu
    {
        public static void Initialize()
        {
            Console.Clear();
            InitializeMenu();
        }

        public static void InitializeMenu()
        {
            int selectedTest = 0;

            Console.WriteLine("This is automated testing of Belot.BG." +
                               "\n\nPlease select a test:" +
                               "\n1. Valid registration of a new user" +
                               "\n2. Valid login test" +
                               "\n3. Invalid login test with a preset invalid details" +
                               "\n4. Change the user profile details (with valid details!)" +
                               "\n5. Exit" +
                               "\n\nWhich test do you want to initialize: ");
            selectedTest = Convert.ToInt32(Console.ReadLine());

            CheckIfValidMenuChoise(selectedTest);

            switch (selectedTest)
            {
                case 1:
                    ValidRegistration();
                    break;
                case 2:
                    ValidLogin();
                    break;
                case 3:
                    InvalidLogin();
                    break;
                case 4:
                    ChangeUserDetails();
                    break;
                case 5:
                    return;
                default:
                    break;
            }
        }

        public static void InvalidLogin()
        {
            bool closeBrowserAfterTest = CloseBrowserAfter();

            Actions.InitializeDriver();
            TestList.InvalidLogin(closeBrowserAfterTest);

            Thread.Sleep(3000);
            Initialize();
        }

        public static void ValidLogin()
        {
            Console.WriteLine("Stay logged in Y/N: ");
            string userChoise = Console.ReadLine();
            bool stayLoggedIn = false;

            if (userChoise == "Y")
            {
                stayLoggedIn = true;
            }
            else if (userChoise == "N")
            {
                stayLoggedIn = false;
            }
            else
            {
                Actions.RedConsoleMessage("Please make a valid choise! Your choise must be Y (for Yes) or N (for No)!");
                Thread.Sleep(3000);

                ValidLogin();
            }
            
            bool closeBrowserAfterTest = CloseBrowserAfter();

            Console.WriteLine("Please input the user email: ");
            string userEmail = Console.ReadLine();

            Console.WriteLine("Please input the current password: ");
            string currentPassword = Console.ReadLine();

            Actions.InitializeDriver();
            TestList.ValidLogin(stayLoggedIn, closeBrowserAfterTest, userEmail, currentPassword);

            Thread.Sleep(3000);
            Initialize();
        }

        public static void ValidRegistration()
        {
            bool closeBrowserAfterTest = CloseBrowserAfter();

            Console.WriteLine("Please input a new username: ");
            string username = Console.ReadLine();
            string email = username + "@nosuchmail.com";

            Actions.InitializeDriver();
            TestList.ValidRegistration(username, "1234567", email, closeBrowserAfterTest);

            Thread.Sleep(3000);
            Initialize();
        }

        public static void ChangeUserDetails()
        {
            Console.WriteLine("Please input the user email: ");
            string userEmail = Console.ReadLine();

            Console.WriteLine("Please input a new username: ");
            string username = Console.ReadLine();
            
            Console.WriteLine("Please input the current password: ");
            string currentPassword = Console.ReadLine();
            
            Console.WriteLine("Please input a new password: ");
            string newPassword = Console.ReadLine();
            
            Console.WriteLine("Please input a new status (up to 100 characters): ");
            string status = Console.ReadLine();
            
            Console.WriteLine("Please input a value for years: ");
            string years = Console.ReadLine();
            
            Console.WriteLine("Please input a new city: ");
            string city = Console.ReadLine();
            
            Console.WriteLine("Please input a new country: ");
            string country = Console.ReadLine();

            bool closeBrowserAfterTest = CloseBrowserAfter();
            
            Actions.InitializeDriver();

            TestList.ChangeUserDetails(userEmail, username, currentPassword, newPassword, status, years, city, country, closeBrowserAfterTest);
            
            Thread.Sleep(3000);
            Initialize();
        }

        public static void CheckIfValidMenuChoise(int selectedTest)
        {
            if (selectedTest < 1 || selectedTest > 5)
            {
                Actions.RedConsoleMessage("\nPlease select a valid index of a test [1..5]!");
                Thread.Sleep(4000);

                Initialize();
            }
        }

        public static bool CloseBrowserAfter()
        {
            Console.WriteLine("Close the browser after the test ends Y/N: ");
            string userChoise = Console.ReadLine();

            if (userChoise == "Y")
            {
                return true;
            }
            else if (userChoise == "N")
            {
                return false;
            }
            else
            {
                Actions.RedConsoleMessage("Please make a valid choise! Your choise must be Y (for Yes) or N (for No)!");
                Thread.Sleep(3000);

                return CloseBrowserAfter();
            }
        }
    }
}
