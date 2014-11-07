using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class VisitStatusHistoryMap : EntityTypeConfiguration<VisitStatusHistory>
    {
        public VisitStatusHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.VisitStatusHistoryID);

            // Properties
            this.Property(t => t.VisitStatusHistoryID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VisitStatusHistory");
            this.Property(t => t.VisitStatusHistoryID).HasColumnName("VisitStatusHistoryID");
            this.Property(t => t.VisitID).HasColumnName("VisitID");
            this.Property(t => t.VisitStatusID).HasColumnName("VisitStatusID");
            this.Property(t => t.AdminID).HasColumnName("AdminID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Visit)
                .WithMany(t => t.VisitStatusHistories)
                .HasForeignKey(d => d.VisitID);
            this.HasRequired(t => t.VisitStatu)
                .WithMany(t => t.VisitStatusHistories)
                .HasForeignKey(d => d.VisitStatusID);
            this.HasRequired(t => t.VisitStatu1)
                .WithMany(t => t.VisitStatusHistories1)
                .HasForeignKey(d => d.VisitStatusID);

        }
    }
}
