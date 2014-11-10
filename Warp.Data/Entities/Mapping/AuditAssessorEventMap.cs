using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class AuditAssessorEventMap : EntityTypeConfiguration<AuditAssessorEvent>
    {
        public AuditAssessorEventMap()
        {
            // Primary Key
            this.HasKey(t => t.AuditAssessorEventID);

            // Properties
            this.Property(t => t.AuditAssessorEventID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Note)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("AuditAssessorEvent");
            this.Property(t => t.AuditAssessorEventID).HasColumnName("AuditAssessorEventID");
            this.Property(t => t.DateTimeStamp).HasColumnName("DateTimeStamp");
            this.Property(t => t.AssessorID).HasColumnName("AssessorID");
            this.Property(t => t.AuditTableID).HasColumnName("AuditTableID");
            this.Property(t => t.AuditActionID).HasColumnName("AuditActionID");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Hidden).HasColumnName("Hidden");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.AuditAction)
                .WithMany(t => t.AuditAssessorEvents)
                .HasForeignKey(d => d.AuditActionID);
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.AuditAssessorEvents)
                .HasForeignKey(d => d.AssessorID);
            this.HasRequired(t => t.AuditTable)
                .WithMany(t => t.AuditAssessorEvents)
                .HasForeignKey(d => d.AuditTableID);

        }
    }
}
