using System;

namespace hGem.Core.Services.Dtos.Customer
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Uri Uri { get; set; }
        public string DisplayName { get; set; }
        public string CustomerCode { get; set; }
    }
}