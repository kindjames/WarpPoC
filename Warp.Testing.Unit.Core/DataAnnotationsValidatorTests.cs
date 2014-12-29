using System;
using System.ComponentModel.DataAnnotations;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Core.Infrastructure.Validation;

namespace Warp.Testing.Unit.Core
{
    [Subject("DataAnnotationsValidator tests")]
    public class DataAnnotationsValidatorTests
    {
        public class ModelToValidateFake
        {
            [Required]
            public string PropertyToValidate { get; set; }
        }

        public class When_calling__Validate__with_a_model_that_does_not_follow_validation_rules : WithSubject<DataAnnotationsValidator>
        {
            Establish context = () =>
            {
                _model = new ModelToValidateFake { PropertyToValidate = null };
            };

            Because of = () => _exception = Catch.Exception(() => Subject.Validate(_model));

            It should_throw_an_exception = () =>
            {
                _exception.ShouldNotBeNull();
                _exception.ShouldBeOfExactType<ValidationException>();
            };

            static Exception _exception;
            static ModelToValidateFake _model;
        }

        public class When_calling__Validate__with_a_model_that_follows_validation_rules : WithSubject<DataAnnotationsValidator>
        {
            Establish context = () =>
            {
                _model = new ModelToValidateFake { PropertyToValidate = Guid.NewGuid().ToString() };
            };

            Because of = () => _exception = Catch.Exception(() => Subject.Validate(_model));

            It should_throw_an_exception = () =>
                _exception.ShouldBeNull();

            static Exception _exception;
            static ModelToValidateFake _model;
        }
    }
}