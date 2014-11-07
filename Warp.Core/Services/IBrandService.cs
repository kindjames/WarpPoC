using Warp.Core.Services.Dtos.Brand;

namespace Warp.Core.Services
{
    public interface IBrandService
    {
        BrandSummaryListDto GetBrandSummaryListForClient(int clientId);
    }
}