using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PeriodBrandMap : EntityTypeConfiguration<PeriodBrand>
    {
        public PeriodBrandMap()
        {
            // Primary Key
            HasKey(t => t.PeriodBrandId);

            // Properties
            Property(t => t.PeriodBrandId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("PeriodBrand");
            Property(t => t.PeriodBrandId).HasColumnName("PeriodBrandID");
            Property(t => t.PeriodId).HasColumnName("PeriodID");
            Property(t => t.BrandId).HasColumnName("BrandID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Brand)
                .WithMany(t => t.PeriodBrands)
                .HasForeignKey(d => d.BrandId);
            HasRequired(t => t.Period)
                .WithMany(t => t.PeriodBrands)
                .HasForeignKey(d => d.PeriodId);

        }
    }
}
