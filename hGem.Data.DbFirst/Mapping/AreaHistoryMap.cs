using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AreaHistoryMap : EntityTypeConfiguration<AreaHistory>
    {
        public AreaHistoryMap()
        {
            // Primary Key
            HasKey(t => t.AreaHistoryId);

            // Properties
            Property(t => t.AreaName)
                .HasMaxLength(200);

            Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Notes)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("AreaHistory", "Client");
            Property(t => t.AreaHistoryId).HasColumnName("AreaHistoryID");
            Property(t => t.AreaId).HasColumnName("AreaID");
            Property(t => t.AreaName).HasColumnName("AreaName");
            Property(t => t.AreaStatusId).HasColumnName("AreaStatusID");
            Property(t => t.RegionId).HasColumnName("RegionID");
            Property(t => t.Code).HasColumnName("Code");
            Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.EnteredByUserRoleId).HasColumnName("EnteredByUserRoleID");
            Property(t => t.Notes).HasColumnName("Notes");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Area)
                .WithMany(t => t.AreaHistories)
                .HasForeignKey(d => d.AreaId);
            HasRequired(t => t.Region)
                .WithMany(t => t.AreaHistories)
                .HasForeignKey(d => d.RegionId);
            HasRequired(t => t.AreaStatus)
                .WithMany(t => t.AreaHistories)
                .HasForeignKey(d => d.AreaStatusId);

        }
    }
}
