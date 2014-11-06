using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class BrandHistory1Map : EntityTypeConfiguration<BrandHistory1>
    {
        public BrandHistory1Map()
        {
            // Primary Key
            this.HasKey(t => t.BrandHistoryID);

            // Properties
            this.Property(t => t.BrandHistoryID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Notes)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("BrandHistory");
            this.Property(t => t.BrandHistoryID).HasColumnName("BrandHistoryID");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");
            this.Property(t => t.BrandStatusID).HasColumnName("BrandStatusID");
            this.Property(t => t.ValidTo).HasColumnName("ValidTo");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.EnteredByAdminID).HasColumnName("EnteredByAdminID");
            this.Property(t => t.Notes).HasColumnName("Notes");

            // Relationships
            this.HasRequired(t => t.Brand1)
                .WithMany(t => t.BrandHistory1)
                .HasForeignKey(d => d.BrandID);
            this.HasRequired(t => t.BrandStatus1)
                .WithMany(t => t.BrandHistory1)
                .HasForeignKey(d => d.BrandStatusID);

        }
    }
}
