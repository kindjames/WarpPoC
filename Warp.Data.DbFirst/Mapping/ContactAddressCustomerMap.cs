using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ContactAddressCustomerMap : EntityTypeConfiguration<ContactAddressCustomer>
    {
        public ContactAddressCustomerMap()
        {
            // Primary Key
            HasKey(t => t.ContactAddressCustomer1);

            // Properties
            // Table & Column Mappings
            ToTable("ContactAddressCustomer");
            Property(t => t.ContactAddressCustomer1).HasColumnName("ContactAddressCustomer");
            Property(t => t.ContactAddressId).HasColumnName("ContactAddressID");
            Property(t => t.CustomerId).HasColumnName("CustomerID");
            Property(t => t.ContactAddressTypeId).HasColumnName("ContactAddressTypeID");
            Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.ContactAddress)
                .WithMany(t => t.ContactAddressCustomers)
                .HasForeignKey(d => d.ContactAddressId);
            HasRequired(t => t.ContactAddressType)
                .WithMany(t => t.ContactAddressCustomers)
                .HasForeignKey(d => d.ContactAddressTypeId);
            HasRequired(t => t.Customer)
                .WithMany(t => t.ContactAddressCustomers)
                .HasForeignKey(d => d.CustomerId);

        }
    }
}
