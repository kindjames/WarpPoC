using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class RegionHistory1Map : EntityTypeConfiguration<RegionHistory1>
    {
        public RegionHistory1Map()
        {
            // Primary Key
            this.HasKey(t => t.RegionHistoryID);

            // Properties
            this.Property(t => t.RegionHistoryID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Notes)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("RegionHistory");
            this.Property(t => t.RegionHistoryID).HasColumnName("RegionHistoryID");
            this.Property(t => t.RegionID).HasColumnName("RegionID");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");
            this.Property(t => t.RegionStatusID).HasColumnName("RegionStatusID");
            this.Property(t => t.ValidTo).HasColumnName("ValidTo");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.EnteredByAdminID).HasColumnName("EnteredByAdminID");
            this.Property(t => t.Notes).HasColumnName("Notes");

            // Relationships
            this.HasRequired(t => t.Region1)
                .WithMany(t => t.RegionHistory1)
                .HasForeignKey(d => d.RegionID);
            this.HasRequired(t => t.RegionStatus1)
                .WithMany(t => t.RegionHistory1)
                .HasForeignKey(d => d.RegionStatusID);

        }
    }
}
