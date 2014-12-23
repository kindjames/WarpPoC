using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ContactAddressUserRoleMap : EntityTypeConfiguration<ContactAddressUserRole>
    {
        public ContactAddressUserRoleMap()
        {
            // Primary Key
            HasKey(t => t.ContactAddressUserRoleId);

            // Properties
            // Table & Column Mappings
            ToTable("ContactAddressUserRole", "Client");
            Property(t => t.ContactAddressUserRoleId).HasColumnName("ContactAddressUserRoleID");
            Property(t => t.ContactAddressId).HasColumnName("ContactAddressID");
            Property(t => t.UserRoleId).HasColumnName("UserRoleID");
            Property(t => t.ContactAddressTypeId).HasColumnName("ContactAddressTypeID");
            Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.ContactAddress)
                .WithMany(t => t.ContactAddressUserRoles)
                .HasForeignKey(d => d.ContactAddressId);
            HasRequired(t => t.ContactAddressType)
                .WithMany(t => t.ContactAddressUserRoles)
                .HasForeignKey(d => d.ContactAddressTypeId);

        }
    }
}
