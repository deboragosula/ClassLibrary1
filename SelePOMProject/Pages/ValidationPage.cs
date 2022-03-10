using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SelePOMProject.BaseClass;
using System;
using System.Collections.Generic;
using SelePOMProject.GenericMethods;
using System.Text;
using System.Threading;
using SelePOMProject;

namespace SelePOMProject.Pages
{
    public class ValidationPage : BaseClass.BaseClass
    {
        #region Lazy Instance
        IWebDriver driver;
        private static ValidationPage instance = null;
        public static ValidationPage GetInstance(IWebDriver driver)
        {
            if (instance == null)
            {
                instance = new ValidationPage(driver);
            }
            return instance;
        }
        public ValidationPage(IWebDriver webDriver)
        {
            this.driver = webDriver;
        }
        public IWebDriver SetDriver(IWebDriver webDriver)
        {
            webDriver = driver;
            return driver;
        }
        #endregion     
        public void ValidateTitleofPage(string ActualTitle)
        {
            IWebElement element = ValidationPage.GetInstance(driver).SetDriver(driver).FindElement(By.XPath(Elements.Instance.PageTitle));
            bool Title = Keywords.Instance.ElementisDisplayed(element);

            if (Title.Equals(true) && ActualTitle.Equals(element.Text))
            {
                Console.WriteLine("Validation of title is completed");
            }
        }
    }
}
