using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class PersonBrandMap : EntityTypeConfiguration<PersonBrand>
    {
        public PersonBrandMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonBrandId);

            // Properties
            // Table & Column Mappings
            this.ToTable("PersonBrand", "Client");
            this.Property(t => t.PersonBrandId).HasColumnName("PersonBrandID");
            this.Property(t => t.PersonId).HasColumnName("PersonID");
            this.Property(t => t.PermissionTypeId).HasColumnName("PermissionTypeID");
            this.Property(t => t.BrandId).HasColumnName("BrandID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.PersonBrands)
                .HasForeignKey(d => d.BrandId);
            this.HasRequired(t => t.Person)
                .WithMany(t => t.PersonBrands)
                .HasForeignKey(d => d.PersonId);
            this.HasRequired(t => t.PersonBrand2)
                .WithOptional(t => t.PersonBrand1);

        }
    }
}
