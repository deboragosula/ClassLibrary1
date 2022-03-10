using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SelePOMProject.BaseClass;

namespace SelePOMProject
{
    public class Elements : BaseClass.BaseClass
    {
        #region Lazy Instance
        private static readonly ThreadLocal<Elements> instance = new ThreadLocal<Elements>(() => new Elements());

        public static new Elements Instance
        {
            get => instance.Value;
            protected internal set => instance.Value = value;
        }
        public IWebDriver SetDriver(IWebDriver webDriver)
        {
            webDriver = driver;
            return driver;
        }
        #endregion 

        public string SearchTextbox = "//*[@title='Search']";
        public string SearchButton = "(.//input[@aria-label='Google Search'])[2]";
        public string PageTitle = "//h1[text()='Selenium with C# Tutorial']";
        public string ClickLink = "//h3[text()='Selenium with C# Tutorial - javatpoint']";
        public string Appurl = "https://google.com";
    }
}
