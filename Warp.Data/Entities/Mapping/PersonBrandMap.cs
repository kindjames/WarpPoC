using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class PersonBrandMap : EntityTypeConfiguration<PersonBrand>
    {
        public PersonBrandMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonBrandID);

            // Properties
            // Table & Column Mappings
            this.ToTable("PersonBrand", "Client");
            this.Property(t => t.PersonBrandID).HasColumnName("PersonBrandID");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.PermissionTypeID).HasColumnName("PermissionTypeID");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.PersonBrands)
                .HasForeignKey(d => d.BrandID);
            this.HasRequired(t => t.Person)
                .WithMany(t => t.PersonBrands)
                .HasForeignKey(d => d.PersonID);
            this.HasRequired(t => t.PersonBrand2)
                .WithOptional(t => t.PersonBrand1);

        }
    }
}
