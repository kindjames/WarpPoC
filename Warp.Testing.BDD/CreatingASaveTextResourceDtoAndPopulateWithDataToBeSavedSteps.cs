using System;
using TechTalk.SpecFlow;

namespace Warp.Testing.BDD
{
    [Binding]
    public class CreatingASaveTextResourceDtoAndPopulateWithDataToBeSavedSteps
    {
        [Given(@"There is new unsaved TextResource and TextResourceIdentifier data")]
public void GivenThereIsNewUnsavedTextResourceAndTextResourceIdentifierData()
{
    ScenarioContext.Current.Pending();
}

        [When(@"I click the Save button")]
public void WhenIClickTheSaveButton()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"Create a new SaveTextResourceDto with the data to be saved")]
public void ThenCreateANewSaveTextResourceDtoWithTheDataToBeSaved()
{
    ScenarioContext.Current.Pending();
}
    }
}
