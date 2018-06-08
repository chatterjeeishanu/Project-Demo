using System;
using TechTalk.SpecFlow;
using Property_Community.Global;

namespace Property_Community.Specflow
{
    [Binding]
    public class SearchAndSortSteps
    {
        [Given(@"I have logged into the homepage")]
        public void GivenIHaveLoggedIntoTheHomepage()
        {
            CommonFeatures.Initialize();
            CommonFeatures.test = CommonFeatures.extent.StartTest("Test - Search, Sort by Name and Edit");
            Pages.Login.LoginSteps();
        }
        
        [When(@"I search property and sort by name")]
        public void WhenISearchPropertyAndSortByName()
        {
            Pages.SearchSort.SearchAndSort();
        }
        
        [Then(@"Property is sorted by name")]
        public void ThenPropertyIsSortedByName()
        {
            CommonFeatures.Teardown();
        }
    }
}
