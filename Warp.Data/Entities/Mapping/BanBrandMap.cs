using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class BanBrandMap : EntityTypeConfiguration<BanBrand>
    {
        public BanBrandMap()
        {
            // Primary Key
            this.HasKey(t => t.BanBrandID);

            // Properties
            this.Property(t => t.BanBrandID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BanBrand");
            this.Property(t => t.BanBrandID).HasColumnName("BanBrandID");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.AssessorID).HasColumnName("AssessorID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.BanBrands)
                .HasForeignKey(d => d.BrandID);
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.BanBrands)
                .HasForeignKey(d => d.AssessorID);

        }
    }
}
