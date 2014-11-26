using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AuditAssessorEventMap : EntityTypeConfiguration<AuditAssessorEvent>
    {
        public AuditAssessorEventMap()
        {
            // Primary Key
            this.HasKey(t => t.AuditAssessorEventId);

            // Properties
            this.Property(t => t.AuditAssessorEventId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Id)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Note)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("AuditAssessorEvent");
            this.Property(t => t.AuditAssessorEventId).HasColumnName("AuditAssessorEventID");
            this.Property(t => t.DateTimeStamp).HasColumnName("DateTimeStamp");
            this.Property(t => t.AssessorId).HasColumnName("AssessorID");
            this.Property(t => t.AuditTableId).HasColumnName("AuditTableID");
            this.Property(t => t.AuditActionId).HasColumnName("AuditActionID");
            this.Property(t => t.Id).HasColumnName("ID");
            this.Property(t => t.Hidden).HasColumnName("Hidden");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.AuditAction)
                .WithMany(t => t.AuditAssessorEvents)
                .HasForeignKey(d => d.AuditActionId);
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.AuditAssessorEvents)
                .HasForeignKey(d => d.AssessorId);
            this.HasRequired(t => t.AuditTable)
                .WithMany(t => t.AuditAssessorEvents)
                .HasForeignKey(d => d.AuditTableId);

        }
    }
}
