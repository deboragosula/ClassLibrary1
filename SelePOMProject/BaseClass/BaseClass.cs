using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using SelePOMProject;
using SelePOMProject.GenericMethods;
using SelePOMProject.Pages;
//using AventStack.ExtentReports;

namespace SelePOMProject.BaseClass
{
    
    public class BaseClass
    {   
        public IWebDriver driver;
        //private static ExtentTest test = null;
        public IWebDriver LaunchBrowser()
        {            
            driver = new ChromeDriver(@"C:\Debi\Master\ClassLibrary1\SeleniumSpecPro\Drivers");
            driver.Manage().Window.Maximize();
            initializepages();
            driver.Navigate().GoToUrl(Elements.Instance.Appurl);
             return driver;            
            Console.WriteLine(driver.Url);           
        }
        public void initializepages()
        {
            SearchPage.GetInstance(driver).SetDriver(driver);
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
