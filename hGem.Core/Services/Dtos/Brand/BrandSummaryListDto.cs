using System.Collections.Generic;

namespace hGem.Core.Services.Dtos.Brand
{
    public class BrandSummaryListDto
    {
        public IEnumerable<BrandSummaryDto> Brands { get; set; }
        public string CustomerName { get; set; }
        public string ClientName { get; set; }
    }
}