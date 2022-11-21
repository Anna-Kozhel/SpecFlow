using PageObjectLab2;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class AddToCardStepDefinitions : BaseSteps
    {
        private GooglePage googlePage;

        [Given(@"open search page")]
        public void GivenOpenSearchPage()
        {
            driver.Url = "https://www.saucedemo.com/";
            googlePage = new GooglePage(driver);
        }

        [Given(@"fill username")]
        public void GivenFillUsername()
        {
            googlePage.FillName("standard_user");
        }

        [Given(@"fill password and click enter")]
        public void GivenFillPasswordAndClickEnter()
        {
            googlePage.FillPassword("secret_sauce");
        }

        [When(@"click ADD TO CARD")]
        public void WhenClickADDTOCARD()
        {
            googlePage.AddToCardClick();
        }

        [Then(@"the text changed on REMOVE")]
        public void ThenTheTextChangedOnREMOVE()
        {
            googlePage.CheckThatAlertMessageContainsText("REMOVE");
        }
    }
}
