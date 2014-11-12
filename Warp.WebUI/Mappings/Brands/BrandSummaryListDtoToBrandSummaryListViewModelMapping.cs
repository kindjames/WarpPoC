using System.Linq;
using Warp.Core.Infrastructure;
using Warp.Core.Services.Dtos.Brand;
using Warp.WebUI.Models.Brands;

namespace Warp.WebUI.Mappings.Brands
{
    public sealed class BrandSummaryListDtoToBrandSummaryListViewModelMapping : IMappingConfiguration<BrandSummaryListDto, BrandSummaryListViewModel>
    {
        public BrandSummaryListViewModel Map(BrandSummaryListDto source)
        {
            return new BrandSummaryListViewModel
            {
                ClientName = source.ClientName,
                CustomerName = source.CustomerName,
                BrandNames = source.Brands.Select(b => b.BrandName),
            };
        }
    }
}