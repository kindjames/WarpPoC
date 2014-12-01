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
            this.HasKey(t => t.BanBrandId);

            // Properties
            this.Property(t => t.BanBrandId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BanBrand");
            this.Property(t => t.BanBrandId).HasColumnName("BanBrandID");
            this.Property(t => t.BrandId).HasColumnName("BrandID");
            this.Property(t => t.AssessorId).HasColumnName("AssessorID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.BanBrands)
                .HasForeignKey(d => d.BrandId);
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.BanBrands)
                .HasForeignKey(d => d.AssessorId);

        }
    }
}
