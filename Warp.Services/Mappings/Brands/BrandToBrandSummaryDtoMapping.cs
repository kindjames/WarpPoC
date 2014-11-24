using Warp.Core.Infrastructure;
using Warp.Core.Infrastructure.Mapping;
using Warp.Core.Services.Dtos.Brand;
using Warp.Core.Util;
using Warp.Data.Entities;

namespace Warp.Services.Mappings.Brands
{
    public sealed class BrandToBrandSummaryDtoMapping : IMappingConfiguration<Brand, BrandSummaryDto>
    {
        public BrandSummaryDto Map(Brand source)
        {
            CheckArgument.NotNull(source, "source");

            return new BrandSummaryDto
            {
                AccountManagerAdminId = 0,
                AccountManagerAdminName = "",
                AssessorBanDays = 69,
                BrandId = source.BrandId,
                BrandName = source.Name,
                BrandStatusName = "",
                IndustrySectorName = "",
                ManagerId = 0,
                ManagerName = "",
                NoOfBranches = 0
            };
        }
    }
}