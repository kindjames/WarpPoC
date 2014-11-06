using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ContactAddressUserRoleMap : EntityTypeConfiguration<ContactAddressUserRole>
    {
        public ContactAddressUserRoleMap()
        {
            // Primary Key
            this.HasKey(t => t.ContactAddressUserRoleID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ContactAddressUserRole");
            this.Property(t => t.ContactAddressUserRoleID).HasColumnName("ContactAddressUserRoleID");
            this.Property(t => t.ContactAddressID).HasColumnName("ContactAddressID");
            this.Property(t => t.UserRoleID).HasColumnName("UserRoleID");
            this.Property(t => t.ContactAddressTypeID).HasColumnName("ContactAddressTypeID");
            this.Property(t => t.ValidFrom).HasColumnName("ValidFrom");
            this.Property(t => t.ValidTo).HasColumnName("ValidTo");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.ContactAddress)
                .WithMany(t => t.ContactAddressUserRoles)
                .HasForeignKey(d => d.ContactAddressID);
            this.HasRequired(t => t.ContactAddressType)
                .WithMany(t => t.ContactAddressUserRoles)
                .HasForeignKey(d => d.ContactAddressTypeID);
            this.HasRequired(t => t.UserRole)
                .WithMany(t => t.ContactAddressUserRoles)
                .HasForeignKey(d => d.UserRoleID);

        }
    }
}
