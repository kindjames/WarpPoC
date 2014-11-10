namespace Warp.Data.Entities
{
    public partial class MaintenanceCustomer
    {
        public int MaintenanceCustomerID { get; set; }
        public int CustomerID { get; set; }
        public int MaintenanceID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Maintenance Maintenance { get; set; }
    }
}
