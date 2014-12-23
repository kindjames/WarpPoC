using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BrandHistoryMap : EntityTypeConfiguration<BrandHistory>
    {
        public BrandHistoryMap()
        {
            // Primary Key
            HasKey(t => t.BrandHistoryId);

            // Properties
            Property(t => t.Notes)
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("BrandHistory", "Client");
            Property(t => t.BrandHistoryId).HasColumnName("BrandHistoryID");
            Property(t => t.BrandId).HasColumnName("BrandID");
            Property(t => t.BrandStatusId).HasColumnName("BrandStatusID");
            Property(t => t.EnteredByUserRoleId).HasColumnName("EnteredByUserRoleID");
            Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.Notes).HasColumnName("Notes");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Brand)
                .WithMany(t => t.BrandHistories)
                .HasForeignKey(d => d.BrandId);
            HasRequired(t => t.BrandStatus)
                .WithMany(t => t.BrandHistories)
                .HasForeignKey(d => d.BrandStatusId);

        }
    }
}
