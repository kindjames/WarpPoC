using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class BrandHistoryMap : EntityTypeConfiguration<BrandHistory>
    {
        public BrandHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.BrandHistoryID);

            // Properties
            this.Property(t => t.Notes)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("BrandHistory", "Client");
            this.Property(t => t.BrandHistoryID).HasColumnName("BrandHistoryID");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.BrandStatusID).HasColumnName("BrandStatusID");
            this.Property(t => t.EnteredByAdminID).HasColumnName("EnteredByAdminID");
            this.Property(t => t.ValidFrom).HasColumnName("ValidFrom");
            this.Property(t => t.ValidTo).HasColumnName("ValidTo");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.BrandHistories)
                .HasForeignKey(d => d.BrandID);
            this.HasRequired(t => t.BrandStatu)
                .WithMany(t => t.BrandHistories)
                .HasForeignKey(d => d.BrandStatusID);

        }
    }
}
