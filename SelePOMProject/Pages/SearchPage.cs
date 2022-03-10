using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using SelePOMProject.BaseClass;
using SelePOMProject.GenericMethods;
using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using SelePOMProject;
using System.Threading;

namespace SelePOMProject.Pages
{
    public class SearchPage : BaseClass.BaseClass
    {        
        IWebDriver driver;
        private static SearchPage instance = null;
        public static SearchPage GetInstance(IWebDriver driver)
        {
            if (instance == null)
            {
                instance = new SearchPage(driver);
            }
            return instance;
        }
        public SearchPage(IWebDriver webDriver)
        {
            this.driver = webDriver;
        }
        public IWebDriver SetDriver(IWebDriver webDriver)
        {
            webDriver = driver;
            return driver;
        }
        public void EnterSearchText(String value)
        {           
            IWebElement element =SearchPage.GetInstance(driver).SetDriver(driver).FindElement(By.XPath(Elements.Instance.SearchTextbox));
            Keywords.Instance.ClearandSendtext(element, value);           
        }
        public void ClickSearchButton()
        {
            IWebElement element = SearchPage.GetInstance(driver).SetDriver(driver).FindElement(By.XPath(Elements.Instance.SearchButton));
            Keywords.Instance.ClickWebElement(SearchPage.GetInstance(driver).SetDriver(driver), element);
        }
        public void ApplicationLaunched()
        {
            if (driver != null)
            {
                Console.WriteLine("Application launched successfully");
            }
        }

    }
}
