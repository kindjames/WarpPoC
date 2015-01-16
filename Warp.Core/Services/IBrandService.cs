using System;
using Warp.Core.Services.Dtos.Brand;

namespace Warp.Core.Services
{
    public interface IBrandService
    {
        BrandSummaryListDto GetBrandSummaryListForClient(Guid clientId);
    }
}