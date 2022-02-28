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


namespace SeleniumPomProject.BaseClass
{
    public class BaseTest
    {
        IWebDriver driver;
        public void LaunchBrowser(IWebDriver driver)
        {
            this.driver = driver;
            driver = new ChromeDriver(@"C:\Users\Debora_Gosula\source\repos\ClassLibrary1\SeleniumPOMTestProject\Drivers");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://google.com");
            
        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
