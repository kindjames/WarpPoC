using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class BriefConfigurationBrandMap : EntityTypeConfiguration<BriefConfigurationBrand>
    {
        public BriefConfigurationBrandMap()
        {
            // Primary Key
            this.HasKey(t => t.BriefConfigurationBrand1);

            // Properties
            this.Property(t => t.BriefConfigurationBrand1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BriefConfigurationBrand");
            this.Property(t => t.BriefConfigurationBrand1).HasColumnName("BriefConfigurationBrand");
            this.Property(t => t.BriefConfigurationId).HasColumnName("BriefConfigurationID");
            this.Property(t => t.BrandId).HasColumnName("BrandID");
            this.Property(t => t.Permission).HasColumnName("Permission");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.BriefConfiguration)
                .WithMany(t => t.BriefConfigurationBrands)
                .HasForeignKey(d => d.BriefConfigurationId);

        }
    }
}
