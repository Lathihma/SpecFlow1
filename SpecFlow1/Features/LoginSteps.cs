using System;
using TechTalk.SpecFlow;

namespace SpecFlow1.Features
{
    [Binding]
    public class LoginSteps
    {
        //step definiations
        [Given(@"After launching the application")]
        public void GivenAfterLaunchingTheApplication()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"Login to the profile")]
        public void GivenLoginToTheProfile()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"enter the  following details")]
        public void GivenEnterTheFollowingDetails(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"click the login button")]
        public void WhenClickTheLoginButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"it should take you to the MARS QA page")]
        public void ThenItShouldTakeYouToTheMARSQAPage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
