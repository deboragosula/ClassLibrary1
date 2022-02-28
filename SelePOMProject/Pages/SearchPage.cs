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
   public class SearchPage 
    {
        IWebDriver driver;
        public SearchPage(IWebDriver driver)
        { 
           this.driver=driver;
            PageFactory.InitElements(driver, this);
         }
        [FindsBy(How=How.XPath,Using =".//*[@title='Search']")]
        public IWebElement SearchTextBox { get; set; }

        [FindsBy(How = How.XPath, Using = "(.//input[@aria-label='Google Search'])[2]")]
        public IWebElement SearchButton { get; set; }

        public void SearchText()
        {
            SearchTextBox.SendKeys("Selenium C# tutorial");
            SearchButton.Click();
        }
        public void ClickSearchButton()
        {
            SearchButton.Click();
        }

    }
}
