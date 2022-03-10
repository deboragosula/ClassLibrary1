// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using AventStack.ExtentReports;
using NUnit.Framework;
using SelePOMProject.BaseClass;
using SelePOMProject.Pages;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SeleniumTestProject.Tests1
{
    [TestFixture]
    public class TestClass : BaseClass
    {
        ExtentReports extent = null;
        ExtentTest test = null;
        [OneTimeSetUp]
        public void ExtentStart()
        {
            var htmlReporter = new AventStack.ExtentReports.Reporter.ExtentHtmlReporter(@"C:\Users\Debora_Gosula\source\repos\Debi\Master\ClassLibrary1\SeleniumSpecPro\Reports\Report.html");
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }
        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
        }
        [Test]
        public void TestMethod()
        {
            try
            {
                test = extent.CreateTest("Tests1").Info("Execution started");
                LaunchBrowser();
                test.Log(Status.Pass, "Browser is launched");
                SearchPage.GetInstance(driver).EnterSearchText("Selenium with C# tutorial");
                test.Log(Status.Pass, "Search Criteria is entered");
                SearchPage.GetInstance(driver).ClickSearchButton();
                test.Log(Status.Pass, "Search button is clicked succesfully");
                ResultPage.GetInstance(driver).ClickLink();
                test.Log(Status.Pass, "Succesfully Clicked the required link");
                test.Log(Status.Info, "Succesfully Clicked the link");
                ValidationPage.GetInstance(driver).ValidateTitleofPage("Selenium C# Tutorial for Beginners - Tools QA");
                test.Log(Status.Pass, "Validation of tile page is completed successfully");
            }
            catch(Exception e)
            {
                throw;
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }
        }
    }
}
