using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BanBrandMap : EntityTypeConfiguration<BanBrand>
    {
        public BanBrandMap()
        {
            // Primary Key
            HasKey(t => t.BanBrandId);

            // Properties
            Property(t => t.BanBrandId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("BanBrand");
            Property(t => t.BanBrandId).HasColumnName("BanBrandID");
            Property(t => t.BrandId).HasColumnName("BrandID");
            Property(t => t.AssessorId).HasColumnName("AssessorID");
            Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Brand)
                .WithMany(t => t.BanBrands)
                .HasForeignKey(d => d.BrandId);
            HasRequired(t => t.Assessor)
                .WithMany(t => t.BanBrands)
                .HasForeignKey(d => d.AssessorId);

        }
    }
}
