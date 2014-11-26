namespace Warp.Data.Entities
{
    public class Customer : EntityBase
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string UrlName { get; set; }
        public string DisplayName { get; set; }
        public string CustomerCode { get; set; }
        public int DefaultLanguageId { get; set; }
    }
}