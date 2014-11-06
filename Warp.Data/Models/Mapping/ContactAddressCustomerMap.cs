using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
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
            this.Property(t => t.ContactAddressID).HasColumnName("ContactAddressID");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.ContactAddressTypeID).HasColumnName("ContactAddressTypeID");
            this.Property(t => t.ValidFrom).HasColumnName("ValidFrom");
            this.Property(t => t.ValidTo).HasColumnName("ValidTo");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.ContactAddress)
                .WithMany(t => t.ContactAddressCustomers)
                .HasForeignKey(d => d.ContactAddressID);
            this.HasRequired(t => t.ContactAddressType)
                .WithMany(t => t.ContactAddressCustomers)
                .HasForeignKey(d => d.ContactAddressTypeID);
            this.HasRequired(t => t.Customer)
                .WithMany(t => t.ContactAddressCustomers)
                .HasForeignKey(d => d.CustomerID);

        }
    }
}
