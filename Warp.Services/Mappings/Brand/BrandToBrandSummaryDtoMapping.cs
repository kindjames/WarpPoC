using Warp.Core.Infrastructure.Mapping;
using Warp.Core.Services.Dtos.Brand;
using Warp.Core.Util;

namespace Warp.Services.Mappings.Brand
{
    public sealed class BrandToBrandSummaryDtoMapping : IMappingConfiguration<Data.Entities.Brand, BrandSummaryDto>
    {
        public BrandSummaryDto Map(Data.Entities.Brand source)
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