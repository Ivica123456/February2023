using Fabruary2023.Pages;
using February2023.Pages;
using February2023.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Fabruary2023.StepDefinitions
{
    [Binding]
    public class TMFeature1StepDefinitions : CommonDriver
    {
        HomePage homePageObj = new HomePage();
        LoginPage loginPageObj = new LoginPage();
        TMPage tmPageObj = new TMPage();





        [Given(@"I logged into turnup portal successfully")]
        public void GivenILoggedIntoTurnupPortalSuccessfully()
        {
            //Open Chrome Browser

            driver = new ChromeDriver();

            // Login page object initialization and definition

            loginPageObj.LoginActions(driver);


        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {


            homePageObj.GoToTMPage(driver);

        }

        [When(@"I create a new time and material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {

            tmPageObj.CreateTM(driver);
        }

        [Then(@"Then record should be created successfully")]
        public void ThenThenRecordShouldBeCreatedSuccessfully()
        {
            string newCode = tmPageObj.GetCode(driver);
            string newDescription = tmPageObj.GetDescription(driver);
            string newPrice = tmPageObj.GetPrice(driver);

            Assert.That(newCode == "Feb2050", "Actual code and expacted code do not match");
            Assert.That(newDescription == "sun", "Actual description and expacted description do not match");
            Assert.That(newPrice == "$12.00", "Actual price and expacted price do not match");

        }

        //[When(@"I update '([^']*)' on an existing time and material record")]
        //public void WhenIUpdateOnAnExistingTimeAndMaterialRecord(string description)
        //{
        //    tmPageObj.EditTM(driver, description);
        //}
        //[Then(@"The record should have been updated '([^']*)'")]
        //public void ThenTheRecordShouldHaveBeenUpdated(string description)
        //{
            
        //}
        [When(@"I update '([^']*)','([^']*)','([^']*)', on an existing time and material record")]
        public void WhenIUpdateOnAnExistingTimeAndMaterialRecord(string description, string code, string price)
        {
            tmPageObj.EditTM(driver, description,code,price);
        }

        [Then(@"The record should have been updated '([^']*)','([^']*)','([^']*)'")]
        public void ThenTheRecordShouldHaveBeenUpdated(string description, string code, string price)
        {
            string createdDescription = tmPageObj.GetEditedDescription(driver);
            string createdCode = tmPageObj.GetEditedCode(driver);
            string createdPrice = tmPageObj.GetEditedPrice(driver);

            Assert.That(createdDescription == "description", "Actual description and expacted description do not match");
            Assert.That(createdCode == "code", "Actual code and expacted code do not match");
            Assert.That(createdPrice == "price", "Actual price and expacted price do not match");
        }





    }

}
