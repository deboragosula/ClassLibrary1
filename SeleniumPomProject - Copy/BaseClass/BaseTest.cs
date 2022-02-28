using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace SeleniumPomProject.BaseClass
{
    class BaseTest
    {
        IWebDriver driver;
        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver(@"C:\Users\Debora_Gosula\source\repos\ClassLibrary1\SeleniumPomProject\Drivers");
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
