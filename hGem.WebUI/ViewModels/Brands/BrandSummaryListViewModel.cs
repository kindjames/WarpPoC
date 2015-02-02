using System.Collections.Generic;

namespace hGem.WebUI.ViewModels.Brands
{
    public class BrandSummaryListViewModel
    {
        public string ClientName { get; set; }
        public string CustomerName { get; set; }
        public IEnumerable<string> BrandNames { get; set; }
    }
}