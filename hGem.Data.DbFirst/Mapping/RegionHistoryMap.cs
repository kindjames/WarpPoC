using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class RegionHistoryMap : EntityTypeConfiguration<RegionHistory>
    {
        public RegionHistoryMap()
        {
            // Primary Key
            HasKey(t => t.RegionHistoryId);

            // Properties
            Property(t => t.RegionName)
                .HasMaxLength(150);

            Property(t => t.Notes)
                .IsRequired()
                .HasMaxLength(200);

            Property(t => t.Code)
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("RegionHistory", "Client");
            Property(t => t.RegionHistoryId).HasColumnName("RegionHistoryID");
            Property(t => t.RegionId).HasColumnName("RegionID");
            Property(t => t.RegionName).HasColumnName("RegionName");
            Property(t => t.RegionStatusId).HasColumnName("RegionStatusID");
            Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.EnteredByUserRoleId).HasColumnName("EnteredByUserRoleID");
            Property(t => t.Notes).HasColumnName("Notes");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.Code).HasColumnName("Code");

            // Relationships
            HasRequired(t => t.Region)
                .WithMany(t => t.RegionHistories)
                .HasForeignKey(d => d.RegionId);
            HasRequired(t => t.RegionStatus)
                .WithMany(t => t.RegionHistories)
                .HasForeignKey(d => d.RegionStatusId);

        }
    }
}
