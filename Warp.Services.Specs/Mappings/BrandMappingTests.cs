using System;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Core.Services.Dtos.Brand;
using Warp.Data.Entities;
using Warp.Services.Mappings.Brand;

namespace Warp.Services.Specs.Mappings
{
    [Subject("Brand Mapping")]
    public class BrandMappingTests
    {
        public class When_mapping_from_null_Brand : WithSubject<BrandToBrandSummaryDtoMapping>
        {
            static Exception _exception;

            Establish that = () =>
            {

            };

            Because of = () => _exception = Catch.Exception(() => Subject.Map(null));

            It should_error = () =>
            {
                _exception.ShouldNotBeNull();
                _exception.ShouldBeOfExactType<ArgumentNullException>();
                _exception.ShouldContainErrorMessage("source");
            };
        }

        public class When_mapping_from_valid_Brand : WithSubject<BrandToBrandSummaryDtoMapping>
        {
            static Brand _input;
            static BrandSummaryDto _result;

            Establish that = () =>
            {
                _input = new Brand
                {
                    Name = Guid.NewGuid().ToString(),
                    BrandId = new Random().Next(0, 999)
                };
            };

            Because of = () => _result = Subject.Map(_input);

            It should_convert = () =>
            {
                _result.BrandName.ShouldEqual(_input.Name);
                _result.BrandId.ShouldEqual(_input.BrandId);
                _result.AssessorBanDays.ShouldEqual(69);
            };
        }
    }
}