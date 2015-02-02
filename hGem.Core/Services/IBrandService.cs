using System;
using hGem.Core.Services.Dtos.Brand;

namespace hGem.Core.Services
{
    public interface IBrandService
    {
        BrandSummaryListDto GetBrandSummaryListForClient(Guid clientId);
    }
}