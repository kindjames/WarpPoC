using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ContactAddressUserRoleMap : EntityTypeConfiguration<ContactAddressUserRole>
    {
        public ContactAddressUserRoleMap()
        {
            // Primary Key
            this.HasKey(t => t.ContactAddressUserRoleId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ContactAddressUserRole", "Client");
            this.Property(t => t.ContactAddressUserRoleId).HasColumnName("ContactAddressUserRoleID");
            this.Property(t => t.ContactAddressId).HasColumnName("ContactAddressID");
            this.Property(t => t.UserRoleId).HasColumnName("UserRoleID");
            this.Property(t => t.ContactAddressTypeId).HasColumnName("ContactAddressTypeID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.ContactAddress)
                .WithMany(t => t.ContactAddressUserRoles)
                .HasForeignKey(d => d.ContactAddressId);
            this.HasRequired(t => t.ContactAddressType)
                .WithMany(t => t.ContactAddressUserRoles)
                .HasForeignKey(d => d.ContactAddressTypeId);

        }
    }
}
