using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using SeleniumSpecPro.Steps;

namespace SeleniumSpecPro.Steps
{
    [Binding]
    public class SearchSteps 
    {
        [Given(@"user navigates to google application")]
        public void GivenUserNavigatesToGoogleApplication()
        {
            //Open();
        }

        [Given(@"user enters the search criteria")]
        public void GivenUserEntersTheSearchCriteria()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"user clicks on search button")]
        public void WhenUserClicksOnSearchButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"search results should be displayed")]
        public void ThenSearchResultsShouldBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
