using Machine.Fakes;
using Machine.Specifications;
using System.Linq;
using System.Web.Mvc;
using Machine.Specifications.Mvc;
using Warp.Core.Services;
using Warp.Core.Services.Dtos.Brand;
using Warp.WebUI.Controllers;
using Warp.WebUI.ViewModels;
using Param = Moq.It;

namespace Warp.WebUI.Specs
{
    [Subject("Home Controller")]
    public class HomeControllerTests
    {
        public class When_viewing_Index : WithSubject<HomeController>
        {
            static ActionResult _result;
            static BrandSummaryListDto _dto;

            Establish that = () =>
            {
                _dto = new BrandSummaryListDto
                {
                    ClientName = "TestClient",
                    CustomerName = "TestCustomer",
                    Brands = new[]
                    {
                        new BrandSummaryDto {BrandName = "TestBrandOne"},
                        new BrandSummaryDto {BrandName = "TestBrandTwo"}
                    }
                };

                The<IBrandService>()
                    .WhenToldTo(d => d.GetBrandSummaryListForClient(Param.IsAny<int>()))
                    .Return(_dto);
            };

            Because of = () => _result = Subject.Index(Param.IsAny<int>());

            It should_return_a_valid__BrandSummaryListViewModel__ = () =>
            {
                //_result.ShouldNotBeNull();;
                //var viewModel = _result.Model<BrandSummaryListViewModel>();

                //viewModel.ShouldNotBeNull();
                //viewModel.ClientName.ShouldEqual(_dto.ClientName);
                //viewModel.CustomerName.ShouldEqual(_dto.CustomerName);

                //viewModel.BrandNames.ShouldContain(_dto.Brands.Select(b => b.BrandName));
            };
        }
    }
}
