using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ContactAddressTypeMap : EntityTypeConfiguration<ContactAddressType>
    {
        public ContactAddressTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ContactAddressTypeID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ContactAddressType", "Geographic");
            this.Property(t => t.ContactAddressTypeID).HasColumnName("ContactAddressTypeID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
