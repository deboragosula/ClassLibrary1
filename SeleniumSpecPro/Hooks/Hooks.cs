using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow.Bindings;
using SelePOMProject.BaseClass;
using OpenQA.Selenium;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using Gherkin;
using TechTalk.SpecFlow;


namespace SeleniumSpecPro
{
    [Binding]
    public sealed class Hooks : BaseClass
    {
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;
        ExtentTest test = null;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {

            var htmlReporter = new AventStack.ExtentReports.Reporter.ExtentHtmlReporter(@"C:\Users\Debora_Gosula\source\repos\Debi\Master\ClassLibrary1\SeleniumSpecPro\Reports\Report.html");
           // htmlReporter.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
           

        }       
        [AfterTestRun]
        public static void TearDown()
        {
            extent.Flush();
            
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
            
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            LaunchBrowser();
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
            //test = extent.CreateTest("SearchFunctionality").Info("test started");
            //test.Log(Status.Pass, "browser launched");

        }

        [AfterStep]
        public void InsertStepsInfo()
        {
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();
            var stepError = ScenarioContext.Current.TestError;

            if (stepError == null)
            {
                if (stepType == "Given")
                {
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                    test = extent.CreateTest("SearchFunctionality");
                    test.Log(Status.Pass, "browser launched");

                }
                else if (stepType == "When")
                {
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                }
                else if (stepType == "Then")
                {
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                }
                else if (stepType == "And")
                {
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
                }
            }

            else if (stepError != null)
            {
                if (stepType == "Given")
                {
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                }
                else if (stepType == "When")
                {
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                }
                else if (stepType == "Then")
                {
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                }
                else if (stepType == "And")
                {
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                }
            }
        }
    }
}
