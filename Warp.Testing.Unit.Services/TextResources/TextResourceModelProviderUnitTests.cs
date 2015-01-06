namespace Warp.Testing.Unit.Services.TextResources
{
    public static class TextResourceModelProviderUnitTests
    {
        //public class When_calling__Build__on_a_model : WithSubject<TextResourceModelProvider>
        //{
        //    Establish context = () =>
        //    {
        //        var dto = new TextResourceDto
        //        {
        //            ClientId = 0,
        //            ClientOverride = false,
        //            LanguageId = 1,
        //            ResourceString = "merdetext",
        //            TextResourceCodeId = 182,
        //            ResourceCode = "Merde!",
        //            TextResourceId = 34567
        //        };
        //        // Mock the GetResource call to return MERDE!
        //        The<ITextResourceService>()
        //            .WhenToldTo(s => s.GetTextResourceString(182))
        //            .Return("Merde!");
        //    };


        //    Because of = () =>
        //        _translatedModelResult = Subject.Build<TestModelFake>();

        //    It should = () =>
        //        _translatedModelResult.RememberMeResourceToBeTranslated.ShouldEqual("Merde!");

        //    static TestModelFake _translatedModelResult;
        //}

        //public class When_calling__Build__on_a_model_and_textresource_is_not_found : WithSubject<TextResourceModelProvider>
        //{
        //    Establish context = () =>
        //    {
        //        var dto = new TextResourceDto
        //        {
        //            ClientId = 0,
        //            ClientOverride = false,
        //            LanguageId = 1,
        //            ResourceString = "merde",
        //            TextResourceCodeId = 182,
        //            ResourceCode = "Merde!",
        //            TextResourceId = 34567
        //        };

        //        // Mock the GetResource call to return MERDE!
        //        The<ITextResourceService>()
        //            .WhenToldTo(s => s.GetTextResource(182))
        //            .Return((string)null);
        //    };

        //    Because of = () =>
        //        _exception = Catch.Exception(() => Subject.Build<TestModelFake>());

        //    It should_throw_a__TextResourceNotFoundException__ = () =>
        //    {
        //        _exception.ShouldNotBeNull();
        //        _exception.ShouldBeOfExactType<TextResourceNotFoundException>();
        //        _exception.ShouldContainErrorMessage("182");
        //    };

        //    static Exception _exception;
        //}

        //public class When_calling__Build__on_a_model_that_doesnt_have_setter_property : WithSubject<TextResourceModelProvider>
        //{
        //    Establish context = () =>
        //    {
        //        var dto = new TextResourceDto
        //        {
        //            ClientId = 0,
        //            ClientOverride = false,
        //            LanguageId = 1,
        //            ResourceString = "merde",
        //            TextResourceCodeId = 182,
        //            ResourceCode = "Merde!",
        //            TextResourceId = 34567
        //        };

        //        // Mock the GetResource call to return MERDE!
        //        The<ITextResourceService>()
        //            .WhenToldTo(s => s.GetTextResource(182))
        //            .Return(dto);
        //    };

        //    Because of = () => _exception = Catch.Exception(() => Subject.Build<TestModelWithoutSetterFake>());

        //    It should_throw_a__SetterNotFoundOnModelException__ = () =>
        //    {
        //        _exception.ShouldNotBeNull();
        //        _exception.ShouldBeOfExactType<SetterNotFoundOnModelException>();
        //        _exception.ShouldContainErrorMessage("ResourceToBeTranslated");
        //    };

        //    static Exception _exception;
        //}
    }
}
