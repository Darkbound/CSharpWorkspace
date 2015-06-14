namespace AutoTest
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Support.UI;

    public class Driver
    {
        public static IWebDriver Chrome { get; set; }

        public static void WaitForElementUpTo(int milliSeconds = 5000)
        {
            Driver.Chrome.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(milliSeconds));  // makes the driver wait up to 5 seconds for elements to appear
        }
    }
}
