using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using SeleniumSpecPro.Steps;
using SelePOMProject.Pages;
using SelePOMProject.BaseClass;
using SelePOMProject;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using SelePOMProject.GenericMethods;
using AventStack.ExtentReports;


namespace SeleniumSpecPro.Steps
{
    [Binding]
    public class SearchSteps : BaseClass
    {      

        [Given(@"user navigates to google application")]
        public void GivenUserNavigatesToGoogleApplication()
        {
           
        }        

        [Given(@"user enters the search criteria")]
        public void GivenUserEntersTheSearchCriteria()
        {
            SearchPage.GetInstance(driver).EnterSearchText("Selenium with C# tutorial");
        }

        [When(@"user clicks on search button")]
        public void WhenUserClicksOnSearchButton()
        {
            SearchPage.GetInstance(driver).ClickSearchButton();
        }

        [Then(@"search results should be displayed")]
        public void ThenSearchResultsShouldBeDisplayed()
        {
            ResultPage.GetInstance(driver).ClickLink();
        }
        [Then(@"verify the pagetitle of the site")]
        public void ThenVerifyThePagetitleOfTheSite()
        {
            ValidationPage.GetInstance(driver).ValidateTitleofPage("Selenium C# Tutorial for Beginners - Tools QA");

        }
    }
}
