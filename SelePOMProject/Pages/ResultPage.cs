using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using SeleniumPomProject.BaseClass;
using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;

namespace SeleniumPomProject.Pages
{
    public class ResultPage 
    {
        IWebDriver driver;
        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//h3[text()='Selenium C# Tutorial for Beginners - Tools QA']")]
        public IWebElement Clicklink { get; set; }        
            
        public void ClickLink()
        {
            Clicklink.Click();
        }
    }
}
