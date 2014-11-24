using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class BrandHistoryMap : EntityTypeConfiguration<BrandHistory>
    {
        public BrandHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.BrandHistoryId);

            // Properties
            this.Property(t => t.Notes)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("BrandHistory", "Client");
            this.Property(t => t.BrandHistoryId).HasColumnName("BrandHistoryID");
            this.Property(t => t.BrandId).HasColumnName("BrandID");
            this.Property(t => t.BrandStatusId).HasColumnName("BrandStatusID");
            this.Property(t => t.EnteredByUserRoleId).HasColumnName("EnteredByUserRoleID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.BrandHistories)
                .HasForeignKey(d => d.BrandId);
            this.HasRequired(t => t.BrandStatus)
                .WithMany(t => t.BrandHistories)
                .HasForeignKey(d => d.BrandStatusId);

        }
    }
}
