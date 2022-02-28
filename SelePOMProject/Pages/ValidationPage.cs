using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumPomProject.BaseClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumPomProject.Pages
{
    public class ValidationPage 
    {
        IWebDriver driver;
        public ValidationPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//h1[text()='Selenium C Sharp Tutorial']")]
        public IWebElement ValidateTitle { get; set; }        

        public void ValidateTitleofPage()
        {
           bool Title= ValidateTitle.Displayed;
            if (Title.Equals(true) && ValidateTitle.Text.Equals("Selenium C Sharp Tutorial"))
            {
                Console.WriteLine("Validation od title is completed");
            }
        }
    }
}
