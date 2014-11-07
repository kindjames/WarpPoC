using Warp.Core.Infrastructure;
using Warp.Core.Services.Dtos.Brand;
using Warp.Core.Util;
using Warp.Data.Models;

namespace Warp.Services.Mappings
{
    public sealed class BrandMapping : IMappingConfiguration<Brand, BrandSummaryDto>
    {
        public BrandSummaryDto Map(Brand source)
        {
            Check.NotNull(source, "source");

            return new BrandSummaryDto
            {
                AccountManagerAdminId = 0,
                AccountManagerAdminName = "",
                AssessorBanDays = 69,
                BrandId = source.BrandID,
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