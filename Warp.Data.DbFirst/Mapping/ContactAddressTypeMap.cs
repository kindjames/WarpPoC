using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ContactAddressTypeMap : EntityTypeConfiguration<ContactAddressType>
    {
        public ContactAddressTypeMap()
        {
            // Primary Key
            HasKey(t => t.ContactAddressTypeId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("ContactAddressType", "Geographic");
            Property(t => t.ContactAddressTypeId).HasColumnName("ContactAddressTypeID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
