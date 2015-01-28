using System;
using TechTalk.SpecFlow;

namespace Warp.Testing.Integration.Services
{
    [Binding]
    public class DeveloperSavesATextResourceSteps
    {
        [Given(@"I have TextResource data to persist to the database")]
        public void GivenIHaveTextResourceDataToPersistToTheDatabase()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"the ResourceString is unique")]
        public void GivenTheResourceStringIsUnique()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"the ResourceIdentifierCode is unique")]
        public void GivenTheResourceIdentifierCodeIsUnique()
        {
            ScenarioContext.Current.Pending();
        }

        //        [Given(@"the Resource string is unique")]
        //public void GivenTheResourceStringIsUnique()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        [Given(@"the ResourceIdentifierCode is duplicated")]
        public void GivenTheResourceIdentifierCodeIsDuplicated()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"the Resource string is duplicated")]
        public void GivenTheResourceStringIsDuplicated()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"the ResourceString data has been checked for uniqueness")]
        public void WhenTheResourceStringDataHasBeenCheckedForUniqueness()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"the CheckIsResourceStringUniqueQuery returns true")]
        public void WhenTheCheckIsResourceStringUniqueQueryReturnsTrue()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"the ResourceString has been successfully checked for uniqueness")]
        public void WhenTheResourceStringHasBeenSuccessfullyCheckedForUniqueness()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"the query returns false")]
        public void WhenTheQueryReturnsFalse()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the ResourceIdentifier data is checked for uniqueness")]
        public void ThenTheResourceIdentifierDataIsCheckedForUniqueness()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the CheckIsResourceIdentifierCodeUniqueQuery returns true")]
        public void ThenTheCheckIsResourceIdentifierCodeUniqueQueryReturnsTrue()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the TextResourceService initialises a SaveTextResourceCommand from the SaveTextResourceDto")]
        public void ThenTheTextResourceServiceInitialisesASaveTextResourceCommandFromTheSaveTextResourceDto()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the TextResourceIdentifier data is persisted to the TextResourceIdentifier table")]
        public void ThenTheTextResourceIdentifierDataIsPersistedToTheTextResourceIdentifierTable()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the TextResource data is persisted to the TextResource table")]
        public void ThenTheTextResourceDataIsPersistedToTheTextResourceTable()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"SaveChanges\(\) is called on the model")]
        public void ThenSaveChangesIsCalledOnTheModel()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the CheckIsResourceIdentifierCodeUniqueQuery returns false")]
        public void ThenTheCheckIsResourceIdentifierCodeUniqueQueryReturnsFalse()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the TextResourceService creates a SaveResourceResponseDto")]
        public void ThenTheTextResourceServiceCreatesASaveResourceResponseDto()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"runs a GetResourceIdentifierCodedataQuery against the duplicated ResourceIdentifierCode string")]
        public void ThenRunsAGetResourceIdentifierCodedataQueryAgainstTheDuplicatedResourceIdentifierCodeString()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"returns the duplicate ResourceIdentifierCode data")]
        public void ThenReturnsTheDuplicateResourceIdentifierCodeData()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"runs the GetAssociatedTextResourceDataQuery using the ResourceIdentifierCodeId")]
        public void ThenRunsTheGetAssociatedTextResourceDataQueryUsingTheResourceIdentifierCodeId()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"populates the SaveResourceResponseDto with the result of the associated data dto")]
        public void ThenPopulatesTheSaveResourceResponseDtoWithTheResultOfTheAssociatedDataDto()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"maps the SaveResourceResponseDto to a SaveResourceResponseViewModel")]
        public void ThenMapsTheSaveResourceResponseDtoToASaveResourceResponseViewModel()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"returns the mapped Viewmodel")]
        public void ThenReturnsTheMappedViewmodel()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"runs a query for associated ResourceIdentifier data")]
        public void ThenRunsAQueryForAssociatedResourceIdentifierData()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"populates the SaveResourceResponseDto with the result of the associated data query")]
        public void ThenPopulatesTheSaveResourceResponseDtoWithTheResultOfTheAssociatedDataQuery()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
