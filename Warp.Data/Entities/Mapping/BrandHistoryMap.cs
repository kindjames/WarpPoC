using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
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
            this.Property(t => t.EnteredByUserRoleID).HasColumnName("EnteredByUserRoleID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
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
