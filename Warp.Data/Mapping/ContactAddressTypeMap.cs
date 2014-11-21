using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ContactAddressTypeMap : EntityTypeConfiguration<ContactAddressType>
    {
        public ContactAddressTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ContactAddressTypeId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ContactAddressType", "Geographic");
            this.Property(t => t.ContactAddressTypeId).HasColumnName("ContactAddressTypeID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
