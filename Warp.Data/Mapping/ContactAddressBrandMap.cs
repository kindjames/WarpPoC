using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ContactAddressBrandMap : EntityTypeConfiguration<ContactAddressBrand>
    {
        public ContactAddressBrandMap()
        {
            // Primary Key
            this.HasKey(t => t.ContactAddressBrandId);

            // Properties
            this.Property(t => t.ContactAddressBrandId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ContactAddressBrand", "Client");
            this.Property(t => t.ContactAddressBrandId).HasColumnName("ContactAddressBrandID");
            this.Property(t => t.ContactAddressId).HasColumnName("ContactAddressID");
            this.Property(t => t.BrandId).HasColumnName("BrandID");
            this.Property(t => t.ContactAddressTypeId).HasColumnName("ContactAddressTypeID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.ContactAddressBrands)
                .HasForeignKey(d => d.BrandId);
            this.HasRequired(t => t.ContactAddress)
                .WithMany(t => t.ContactAddressBrands)
                .HasForeignKey(d => d.ContactAddressId);
            this.HasRequired(t => t.ContactAddressType)
                .WithMany(t => t.ContactAddressBrands)
                .HasForeignKey(d => d.ContactAddressTypeId);

        }
    }
}
