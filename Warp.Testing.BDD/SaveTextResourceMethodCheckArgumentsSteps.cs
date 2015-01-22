using System;
using TechTalk.SpecFlow;

namespace Warp.Testing.BDD
{
    [Binding]
    public class SaveTextResourceMethodCheckArgumentsSteps
    {
        [Given(@"I have a populated SaveTextResourceDto")]
public void GivenIHaveAPopulatedSaveTextResourceDto()
{
    ScenarioContext.Current.Pending();
}

        [When(@"Passing the saveTextResourceDto to the SaveTextResource method")]
public void WhenPassingTheSaveTextResourceDtoToTheSaveTextResourceMethod()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"I check that the SaveTextResourceDto is not null")]
public void ThenICheckThatTheSaveTextResourceDtoIsNotNull()
{
    ScenarioContext.Current.Pending();
}
    }
}
