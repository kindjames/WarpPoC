using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AreaHistoryMap : EntityTypeConfiguration<AreaHistory>
    {
        public AreaHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.AreaHistoryId);

            // Properties
            this.Property(t => t.AreaName)
                .HasMaxLength(200);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Notes)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("AreaHistory", "Client");
            this.Property(t => t.AreaHistoryId).HasColumnName("AreaHistoryID");
            this.Property(t => t.AreaId).HasColumnName("AreaID");
            this.Property(t => t.AreaName).HasColumnName("AreaName");
            this.Property(t => t.AreaStatusId).HasColumnName("AreaStatusID");
            this.Property(t => t.RegionId).HasColumnName("RegionID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.EnteredByUserRoleId).HasColumnName("EnteredByUserRoleID");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Area)
                .WithMany(t => t.AreaHistories)
                .HasForeignKey(d => d.AreaId);
            this.HasRequired(t => t.Region)
                .WithMany(t => t.AreaHistories)
                .HasForeignKey(d => d.RegionId);
            this.HasRequired(t => t.AreaStatus)
                .WithMany(t => t.AreaHistories)
                .HasForeignKey(d => d.AreaStatusId);

        }
    }
}
