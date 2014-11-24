using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class VisitStatusHistoryMap : EntityTypeConfiguration<VisitStatusHistory>
    {
        public VisitStatusHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.VisitStatusHistoryId);

            // Properties
            this.Property(t => t.VisitStatusHistoryId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VisitStatusHistory");
            this.Property(t => t.VisitStatusHistoryId).HasColumnName("VisitStatusHistoryID");
            this.Property(t => t.VisitId).HasColumnName("VisitID");
            this.Property(t => t.VisitStatusId).HasColumnName("VisitStatusID");
            this.Property(t => t.AdminId).HasColumnName("AdminID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Visit)
                .WithMany(t => t.VisitStatusHistories)
                .HasForeignKey(d => d.VisitId);
            this.HasRequired(t => t.VisitStatus)
                .WithMany(t => t.VisitStatusHistories)
                .HasForeignKey(d => d.VisitStatusId);
            this.HasRequired(t => t.VisitStatus1)
                .WithMany(t => t.VisitStatusHistories1)
                .HasForeignKey(d => d.VisitStatusId);

        }
    }
}
