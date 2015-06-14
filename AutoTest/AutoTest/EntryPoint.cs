using System;
using AutoTest;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

///<summary>
/// You can use this application in two ways.
/// 1. You can uncomment the rows that contain the individual tests (and fill the required info in the constructor!). You must also uncomment Actions.InitializeDriver()
/// 2. You can uncomment the row that initializes the Menu and then you can start tests from the console
///</summary>

public class EntryPoint
{
    public static string BaseURL = "http://belot.bg/#/login";

    static void Main()
    {
        //This is so cool!
        AppMenu.Initialize(); 
       
        // Actions.InitializeDriver();

        // TestList.InvalidLogin();

        // TestList.ValidLogin();
        
        // TestList.ValidRegistration();
        
        // TestList.ChangeUserDetails();
    }
}