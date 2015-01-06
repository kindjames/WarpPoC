using System;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Query;
using Warp.Core.Services.Dtos.TextResources;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Queries.TextResources;
using Warp.Services;
using MoqIt = Moq.It;
using ThenIt = Machine.Specifications.It;

namespace Warp.Testing.Integration.TextResources
{
    [Subject("TextResource Service Integration Tests")]
    public class TextResourceServiceIntegrationTests
    {

        //#region GetTextResource Tests

        //public class When_Calling_GetTextResource_For_A_TextResource_With_An_Invalid_Id : WithSubject<TextResourceService>
        //{
        //    static Exception _exception;

        //    Because of = () => _exception = Catch.Exception(() => Subject.GetTextResource(0));

        //    ThenIt should_throw_an_exception = () =>
        //    {
        //        _exception.ShouldNotBeNull();
        //        _exception.ShouldBeOfExactType<ArgumentException>();
        //    };
        //}

        //public class When_Calling_GetTextResource_For_A_Null_TextResource : WithSubject<TextResourceService>
        //{
        //    static Exception _exception;

        //    Because of = () => _exception = Catch.Exception(() => Subject.GetTextResource(0));

        //    It should_throw_an_exception = () =>
        //    {
        //        _exception.ShouldNotBeNull();
        //        _exception.ShouldBeOfExactType<ArgumentException>();
        //    };
        //}

        //public class When_Calling_GetTextResource_For_An_Existing_TextResource : WithSubject<TextResourceService>
        //{
        //    private const int _textResourceIdentifierId = 1;
        //    static string _result;

        //    Establish _context = () =>
        //    {
        //    };

        //    Because of = () => _result = Subject.GetTextResource(_textResourceIdentifierId);

        //    It should_return_a_string = () =>
        //    {
        //        The<IQueryDispatcher>()
        //            .WasToldTo(d => d.Execute(Param.IsAny<GetTextResourceQuery>()));
        //    };
        //}

        //#endregion GetTextResource Tests

        //#region GetTextResourceString Tests

        //public class When_Calling_GetTextResourceString_With_Invalid_Id : WithSubject<TextResourceService>
        //{
        //    static Exception _exception;
        //    static int _textResourceIdentifierId = 0;

        //    private Because of = () => _exception = Catch.Exception(() => Subject.GetTextResourceString(_textResourceIdentifierId));

        //    private It should_throw_an_exception = () =>
        //    {
        //        _exception.ShouldNotBeNull();
        //        _exception.ShouldBeOfExactType<ArgumentException>();
        //    };
        //}

        //public class When_calling_GetTextResourceString_For_A_Nonexistent_TextResource : WithSubject<TextResourceService>
        //{
        //    static int _textResourceIdentifierId = 0;

        //    private Because _of = () => _exception = Catch.Exception(() => Subject.GetTextResourceString(_textResourceIdentifierId));

        //    private It should_throw_an_exception = () =>
        //    {
        //        _exception.ShouldNotBeNull();
        //        _exception.ShouldBeOfExactType<ArgumentException>();
        //    };

        //    static Exception _exception;
        //}

        //public class When_Calling_GetTextResourceString_Return_A_ResourceStringDto : WithSubject<TextResourceService>
        //{
        //    private const int _textResourceIdentifierId = 1;
        //    static ResourceStringDto _result;

        //    Establish _context = () =>
        //    {
        //        The<IQueryDispatcher>()
        //            .WhenToldTo(d => d.Execute(Param.IsAny<GetTextResourceStringQuery>()))
        //            .Return("BEEP");
        //    };

        //    Because of = () => _result = Subject.GetTextResourceString(_textResourceIdentifierId);

        //    It should_return_a_dto = () =>
        //    {
        //        The<IQueryDispatcher>()
        //            .WasToldTo(d => d.Execute(Param.IsAny<GetTextResourceStringQuery>()));

        //        _result.TextResourceString.ShouldEqual("BEEP");
        //    };
        //}

        //public class When_Calling_GetTextResourceString_Return_Null : WithSubject<TextResourceService>
        //{
        //    private const int _textResourceIdentifierId = 1;
        //    static ResourceStringDto _result;

        //    Establish _context = () =>
        //    {
        //    };

        //    Because of = () => _result = Subject.GetTextResourceString(_textResourceIdentifierId);

        //    It should_return_null = () =>
        //    {
        //        The<IQueryDispatcher>()
        //            .WasToldTo(d => d.Execute(Param.IsAny<GetTextResourceStringQuery>()));

        //        _result.ShouldBeNull();
        //    };
        //}


        ////public class : WithSubject<TextResourceService>
        ////{
        ////    Establish _context = () => { };
        ////    Because _of = () =>{};
        ////    It _should = () => { };
        ////}
        //#endregion GetTextResourceString Tests

        //#region GetTextResourceCode Tests

        //public class GetTextResourceCode_With_Invalid_Id : WithSubject<TextResourceService>
        //{

        //}

        //public class GetTextResourceCode_That_Does_Not_Exist : WithSubject<TextResourceService>
        //{

        //}

        //public class GetTextResourceCode_That_Exists : WithSubject<TextResourceService>
        //{

        //}

        //#endregion GetTextResourceCode Tests

        ////public class When_calling_GetTextResource_with_textResourceCodeId_of_zero : WithSubject<TextResourceService>
        ////{
        ////    static Exception _exception;

        ////    //Establish that = () =>
        ////    //{
        ////    //    The<ITextResourceDbContext>()
        ////    //        .WhenToldTo(tr => tr.TextResources)
        ////    //        .Return(new InMemoryDbSet<TextResource>(true)
        ////    //        {
        ////    //            new TextResource { TextResourceId = 2, ResourceCodeId = 0 }
        ////    //        });
        ////    //};

        ////    Because of = () => _exception = Catch.Exception(() => Subject.GetTextResource(0));

        ////    It should_throw_ArgumentException = () =>
        ////    {
        ////        _exception.ShouldNotBeNull();
        ////        _exception.ShouldBeOfExactType<ArgumentException>();
        ////        _exception.ShouldContainErrorMessage("textResourceId");
        ////    };


        ////}

        ////[Subject("TextResource Validation")]
        ////public class When_Validating_duplicate_TextResource_Strings : WithSubject<DuplicateTextResourceStringsQueryHandler>
        ////{
        ////    private const string _textResourceString = "Welcome!";
        ////    private const string _textResourceCode = "Welcome";

        ////    private Establish that = () => 
        ////        The<ITextResourceDbContext>()
        ////            .WhenToldTo(tr => tr.TextResources)
        ////            .Return(new InMemoryDbSet<Warp.Data.Entities.TextResource>(true)
        ////        {
        ////            new TextResource { TextResourceId =  1, ResourceCodeId = 1, ApplicationLanguageId = 1, ResourceString = "Welcome!", Active = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
        ////        new TextResource() { TextResourceId =  2, ResourceCodeId = 2, ApplicationLanguageId = 1, ResourceString = "Username", Active = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
        ////        new TextResource() { TextResourceId =  3, ResourceCodeId = 3, ApplicationLanguageId = 1, ResourceString = "Password", Active = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
        ////        new TextResource() { TextResourceId =  4, ResourceCodeId = 4, ApplicationLanguageId = 1, ResourceString = "Login", Active = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
        ////        new TextResource() { TextResourceId =  5, ResourceCodeId = 1, ApplicationLanguageId = 2, ResourceString = "Bienvenue!", Active = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
        ////        new TextResource() { TextResourceId =  6, ResourceCodeId = 2, ApplicationLanguageId = 2, ResourceString = "Nom d'utilisateur", Active = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
        ////        new TextResource() { TextResourceId =  7, ResourceCodeId = 3, ApplicationLanguageId = 2, ResourceString = "Mot de passe", Active = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
        ////        new TextResource() { TextResourceId =  8, ResourceCodeId = 4, ApplicationLanguageId = 2, ResourceString = "Login", Active = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
        ////        new TextResource() { TextResourceId =  9, ResourceCodeId = 5, ApplicationLanguageId = 1, ResourceString = "Help!", Active = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now },
        ////        new TextResource() { TextResourceId =  10, ResourceCodeId = 5, ApplicationLanguageId = 2, ResourceString = "M'aidez!", Active = true, DateCreated = DateTime.Now, DateUpdated = DateTime.Now }

        ////        });

        ////    private Because of = () => ;
        ////    private It should = () => ;

        ////}

        ////[Subject("TextResourceValidation")]
        ////public class When_Validating_duplicate_TextResource_Codes : WithSubject<TextResourceService>
        ////{
        ////    private Establish that = () => ;
        ////    private Because of = () => ;
        ////    private It should = () => ;

        ////}
        ////public class When_calling_GetTextResource_with_ : WithSubject<TextResourceService>
        ////{
        ////    Establish that = () =>
        ////    {
        ////        // Mock the HttpContextRequest header
        ////        var moqLanguages = new string[] {"en-GB", "en-US" };
        ////    };

        ////    Because of = () => _result = Subject.GetTextResource(textResourceId: 123);

        ////    It should = () =>
        ////    {

        ////    };

        ////    static string _result;
        ////}

        ////public class When_getting_calling_GetTextResource_with_languageId_of_zero : WithSubject<TextResourceService>
        ////{
        ////    private static Exception _exception;

        ////    Because of = () => _exception = Catch.Exception(() => Subject.GetResource(123));

        ////    ThenIt should_throw_ArgumentException = () =>
        ////    {
        ////        _exception.ShouldNotBeNull();
        ////        _exception.ShouldBeOfExactType<ArgumentException>();
        ////        _exception.ShouldContainErrorMessage("languageId");
        ////    };
        ////}

        ////public class When_getting_calling_GetTextResource_with_clientId_of_zero : WithSubject<TextResourceService>
        ////{
        ////    private static Exception _exception;

        ////    Because of = () => _exception = Catch.Exception(() => Subject.GetResource(123));

        ////    ThenIt should_throw_ArgumentException = () =>
        ////    {
        ////        _exception.ShouldNotBeNull();
        ////        _exception.ShouldBeOfExactType<ArgumentException>();
        ////        _exception.ShouldContainErrorMessage("clientId");
        ////    };
        ////}

        //#region Templates

        ////public class When_getting_calling_GetTextResource : WithSubject<TextResourceService>
        ////{
        ////    Establish that = () =>
        ////    {
        ////    };

        ////    Because of = () => result = Subject.GetTextResource(textResourceId: 123, languageId: 123);

        ////    ThenIt should = () =>
        ////    {
        ////    };

        ////    static string result;
        ////}


        //// Establish _context = () => { };
        //// Because _of = () => { };
        //// It _of = () => { };

        //#endregion Templates
    }
}
