using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class ContactAddressUserRoleMap : EntityTypeConfiguration<ContactAddressUserRole>
    {
        public ContactAddressUserRoleMap()
        {
            // Primary Key
            this.HasKey(t => t.ContactAddressUserRoleID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ContactAddressUserRole", "Client");
            this.Property(t => t.ContactAddressUserRoleID).HasColumnName("ContactAddressUserRoleID");
            this.Property(t => t.ContactAddressID).HasColumnName("ContactAddressID");
            this.Property(t => t.UserRoleID).HasColumnName("UserRoleID");
            this.Property(t => t.ContactAddressTypeID).HasColumnName("ContactAddressTypeID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.ContactAddress)
                .WithMany(t => t.ContactAddressUserRoles)
                .HasForeignKey(d => d.ContactAddressID);
            this.HasRequired(t => t.ContactAddressType)
                .WithMany(t => t.ContactAddressUserRoles)
                .HasForeignKey(d => d.ContactAddressTypeID);

        }
    }
}
