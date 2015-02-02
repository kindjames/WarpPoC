using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BriefConfigurationBrandMap : EntityTypeConfiguration<BriefConfigurationBrand>
    {
        public BriefConfigurationBrandMap()
        {
            // Primary Key
            HasKey(t => t.BriefConfigurationBrand1);

            // Properties
            Property(t => t.BriefConfigurationBrand1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("BriefConfigurationBrand");
            Property(t => t.BriefConfigurationBrand1).HasColumnName("BriefConfigurationBrand");
            Property(t => t.BriefConfigurationId).HasColumnName("BriefConfigurationID");
            Property(t => t.BrandId).HasColumnName("BrandID");
            Property(t => t.Permission).HasColumnName("Permission");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            HasRequired(t => t.BriefConfiguration)
                .WithMany(t => t.BriefConfigurationBrands)
                .HasForeignKey(d => d.BriefConfigurationId);

        }
    }
}
