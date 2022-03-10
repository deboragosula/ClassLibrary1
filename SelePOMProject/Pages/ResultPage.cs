using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using SelePOMProject.BaseClass;
using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using System.Threading;
using SelePOMProject.GenericMethods;
using SelePOMProject;

namespace SelePOMProject.Pages
{
    public class ResultPage : BaseClass.BaseClass
    {
        #region Lazy Instance
        IWebDriver driver;
        private static ResultPage instance = null;
        public static ResultPage GetInstance(IWebDriver driver)
        {
            if (instance == null)
            {
                instance = new ResultPage(driver);
            }
            return instance;
        }
        public ResultPage(IWebDriver webDriver)
        {
            this.driver = webDriver;
        }
        public IWebDriver SetDriver(IWebDriver webDriver)
        {
            webDriver = driver;
            return driver;
        }
        #endregion

        public void ClickLink()
        {
            IWebElement element = SearchPage.GetInstance(driver).SetDriver(driver).FindElement(By.XPath(Elements.Instance.ClickLink));
            Keywords.Instance.ClickLink(SearchPage.GetInstance(driver).SetDriver(driver), element);
        }
    }
}
