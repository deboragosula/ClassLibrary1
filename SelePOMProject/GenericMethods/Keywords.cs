using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SelePOMProject.BaseClass;

namespace SelePOMProject.GenericMethods
{
    public class Keywords : BaseClass.BaseClass
    {
        #region Lazy Instance
        private static readonly ThreadLocal<Keywords> instance = new ThreadLocal<Keywords>(() => new Keywords());

        public static new Keywords Instance
        {
            get => instance.Value;
            protected internal set => instance.Value = value;
        }
        public void SetDriver(IWebDriver driver)
        {
            this.driver = driver;
        }

        #endregion 
        public void ClickWebElement(IWebDriver driver,IWebElement element)
        {
            try
            {
                //Driverwait(driver, element);
                element.Click();
            }
            catch(WebDriverException e)
            {
                IJavaScriptExecutor javaScriptExecutor = (IJavaScriptExecutor)driver;
                javaScriptExecutor.ExecuteScript("arguments[0].click();", element);
            }
        }      

        public void ClearandSendtext(IWebElement element,String value)
        {
            //Driverwait(driver, element);
            element.Clear();
            element.SendKeys(value);           
        }
        public string getElementText(IWebDriver driver,IWebElement element,string value)
        {
            Driverwait(driver, element);
            value =element.Text;
            return value;
        }

        public void SelectDropdownvalue(IWebDriver driver,IWebElement element, string value)
        {
            Driverwait(driver,element);
            SelectElement selectdropdown = new SelectElement(element);
            selectdropdown.SelectByValue(value);

        }
        public void Driverwait(IWebDriver driver, IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromMilliseconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible((By)element));
        }
        public Boolean ElementisDisplayed(IWebElement element)
        {
            bool value=element.Displayed;
            return value;
        }
        public void ClickLink(IWebDriver driver, IWebElement element)
        {
            //Driverwait(driver, element);
            element.Click();
        }
    }
}
