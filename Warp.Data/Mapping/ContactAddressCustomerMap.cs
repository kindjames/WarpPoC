using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ContactAddressCustomerMap : EntityTypeConfiguration<ContactAddressCustomer>
    {
        public ContactAddressCustomerMap()
        {
            // Primary Key
            this.HasKey(t => t.ContactAddressCustomer1);

            // Properties
            // Table & Column Mappings
            this.ToTable("ContactAddressCustomer");
            this.Property(t => t.ContactAddressCustomer1).HasColumnName("ContactAddressCustomer");
            this.Property(t => t.ContactAddressId).HasColumnName("ContactAddressID");
            this.Property(t => t.CustomerId).HasColumnName("CustomerID");
            this.Property(t => t.ContactAddressTypeId).HasColumnName("ContactAddressTypeID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.ContactAddress)
                .WithMany(t => t.ContactAddressCustomers)
                .HasForeignKey(d => d.ContactAddressId);
            this.HasRequired(t => t.ContactAddressType)
                .WithMany(t => t.ContactAddressCustomers)
                .HasForeignKey(d => d.ContactAddressTypeId);
            this.HasRequired(t => t.Customer)
                .WithMany(t => t.ContactAddressCustomers)
                .HasForeignKey(d => d.CustomerId);

        }
    }
}
