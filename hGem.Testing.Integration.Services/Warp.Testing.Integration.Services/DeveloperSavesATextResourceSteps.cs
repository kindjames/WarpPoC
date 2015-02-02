using TechTalk.SpecFlow;

namespace hGem.Testing.Integration.Services
{
    [Binding]
    public class DeveloperSavesATextResourceSteps
    {
        [Given(@"the Resource string is unique")]
public void GivenTheResourceStringIsUnique()
{
    ScenarioContext.Current.Pending();
}

        [When(@"the CheckIsResourceIdentifierCodeUniqueQuery returns false")]
public void WhenTheCheckIsResourceIdentifierCodeUniqueQueryReturnsFalse()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"run a GetResourceIdentifierCodeDataQuery against the duplicated ResourceIdentifierCode string")]
public void ThenRunAGetResourceIdentifierCodeDataQueryAgainstTheDuplicatedResourceIdentifierCodeString()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"runs the GetAssociatedTextResourceDataQuery using the duplicate ResourceIdentifierCodeId")]
public void ThenRunsTheGetAssociatedTextResourceDataQueryUsingTheDuplicateResourceIdentifierCodeId()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"returns associated TextResource data")]
public void ThenReturnsAssociatedTextResourceData()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"the TextResourceService initialises a SaveTextResourceResponseDto with both associated data query results")]
public void ThenTheTextResourceServiceInitialisesASaveTextResourceResponseDtoWithBothAssociatedDataQueryResults()
{
    ScenarioContext.Current.Pending();
}

        [Then(@"returns the mapped Viewmodel to the TextResourceController SaveTextResource method")]
public void ThenReturnsTheMappedViewmodelToTheTextResourceControllerSaveTextResourceMethod(string multilineText)
{
    ScenarioContext.Current.Pending();
}
    }
}
