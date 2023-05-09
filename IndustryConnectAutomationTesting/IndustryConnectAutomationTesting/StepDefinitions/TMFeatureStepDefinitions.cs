using IndustryConnectAutomationTesting.Pages;
using IndustryConnectAutomationTesting.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace IndustryConnectAutomationTesting.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        private object tmPageObject;

        [Given(@"I logged into turn up portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            // Open chrome browser
            driver = new ChromeDriver();


            //login TurnUp portal
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            HomePage homePageObj = new HomePage();
            homePageObj.GoTOTMPage(driver);
        }

        [When(@"I create a new time and material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            TMPage tmPageObject = new TMPage();
            tmPageObject.CreateTMPage(driver);
        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            string newCode = tmPageObject.GetCode(driver);
            string newDescription = tmPageObject.GetDescription(driver);
            string newPrice = tmPageObject.GetPrice(driver);

            Assert.That(newCode == "IC2023", "Actual code and expected code do not match.");
            Assert.That(newDescription == "IC2023", "Actual description and expected description do not match.");
            Assert.That(newPrice == "$12.00", "Actual price and expected price do not match.");
        }

        [When(@"I update '([^']*)', '([^']*)' and '([^']*)' on an existing time and material record")]
        public void WhenIUpdateAndOnAnExistingTimeAndMaterialRecord(string description, string code, string price)
        {
            tmPageObject.EditTM(driver, description, code, price);

        }

        [Then(@"the record should have the updated '([^']*)', '([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdatedAnd(string description, string code, string price)
        {
            string editedDescription = tmPageObject.GetEditedDescription(driver);
            string editedCode = tmPageObject.GetEditedCode(driver);
            string editedPrice = tmPageObject.GetEditedPrice(driver);


            Assert.That(editedDescription == description, "Actual description and expected description do not match.");
            Assert.That(editedCode == code, "Actual code and expected code do not match.");
            Assert.That(editedPrice == price, "Actual price and expected price do not match.");

        }
    }
}
