using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using SeleniumSpecPro.Steps;
using SeleniumPomProject.Pages;
using SeleniumPomProject.BaseClass;
using SeleniumPomProject.TestScripts;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
//using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;


namespace SeleniumSpecPro.Steps 
{
    [Binding]
    public class SearchSteps 
    {
         IWebDriver driver = null;      

        [Given(@"user navigates to google application")]
        public void GivenUserNavigatesToGoogleApplication()
        {
            driver = new ChromeDriver(@"C:\Users\Debora_Gosula\source\repos\ClassLibrary1\SeleniumPOMTestProject\Drivers");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://google.com");            
                     
        }
               
        [Given(@"user enters the search criteria")]
        public void GivenUserEntersTheSearchCriteria()
        {            
            SearchPage Searchpage = new SearchPage(driver);
            Searchpage.SearchTextBox.SendKeys("Selenium C# tutorial");
        }

        [When(@"user clicks on search button")]
        public void WhenUserClicksOnSearchButton()
        {
            SearchPage ClickSearch = new SearchPage(driver);
            ClickSearch.ClickSearchButton();
        }

        [Then(@"search results should be displayed")]
        public void ThenSearchResultsShouldBeDisplayed()
        {
            ResultPage Resultpage = new ResultPage(driver);
            Resultpage.ClickLink();

            
        }
        [Then(@"verify the pagetitle of the site")]
        public void ThenVerifyThePagetitleOfTheSite()
        {
            ValidationPage Validationpage = new ValidationPage(driver);
            Validationpage.ValidateTitleofPage();
        }


    }
}
