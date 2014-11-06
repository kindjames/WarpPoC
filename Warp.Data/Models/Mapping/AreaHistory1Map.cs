using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class AreaHistory1Map : EntityTypeConfiguration<AreaHistory1>
    {
        public AreaHistory1Map()
        {
            // Primary Key
            this.HasKey(t => t.AreaHistoryID);

            // Properties
            this.Property(t => t.AreaHistoryID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Notes)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("AreaHistory");
            this.Property(t => t.AreaHistoryID).HasColumnName("AreaHistoryID");
            this.Property(t => t.AreaID).HasColumnName("AreaID");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");
            this.Property(t => t.AreaStatusID).HasColumnName("AreaStatusID");
            this.Property(t => t.ValidTo).HasColumnName("ValidTo");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.EnteredByAdminID).HasColumnName("EnteredByAdminID");
            this.Property(t => t.Notes).HasColumnName("Notes");

            // Relationships
            this.HasRequired(t => t.Area1)
                .WithMany(t => t.AreaHistory1)
                .HasForeignKey(d => d.AreaID);
            this.HasRequired(t => t.AreaStatus1)
                .WithMany(t => t.AreaHistory1)
                .HasForeignKey(d => d.AreaStatusID);

        }
    }
}
