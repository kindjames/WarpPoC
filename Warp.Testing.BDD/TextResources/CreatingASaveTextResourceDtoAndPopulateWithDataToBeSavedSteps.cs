using System;
using TechTalk.SpecFlow;

namespace Warp.Testing.BDD.TextResources
{
    [Binding]
    public class CreatingASaveTextResourceDtoAndPopulateWithDataToBeSavedSteps
    {
        [Given(@"/\^There is new unsaved TextResource and TextResourceIdentifier data\$/ do")]
        public void GivenThereIsNewUnsavedTextResourceAndTextResourceIdentifierDataDo()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"/\^I click the Save button\$/ do")]
        public void WhenIClickTheSaveButtonDo()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"/\^Create a new SaveTextResourceDto with the data to be saved\$/ do")]
        public void ThenCreateANewSaveTextResourceDtoWithTheDataToBeSavedDo()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
