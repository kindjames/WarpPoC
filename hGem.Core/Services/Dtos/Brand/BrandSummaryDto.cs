namespace hGem.Core.Services.Dtos.Brand
{
    public class BrandSummaryDto
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string BrandStatusName { get; set; }
        public string IndustrySectorName { get; set; }
        public int AccountManagerAdminId { get; set; }
        public string AccountManagerAdminName { get; set; }
        public int AssessorBanDays { get; set; }
        public int ManagerId { get; set; }
        public string ManagerName { get; set; }
        public int NoOfBranches { get; set; }
    }
}