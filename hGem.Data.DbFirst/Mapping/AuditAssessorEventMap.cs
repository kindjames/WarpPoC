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
            HasKey(t => t.AuditAssessorEventId);

            // Properties
            Property(t => t.AuditAssessorEventId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Id)
                .IsRequired()
                .HasMaxLength(10);

            Property(t => t.Note)
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("AuditAssessorEvent");
            Property(t => t.AuditAssessorEventId).HasColumnName("AuditAssessorEventID");
            Property(t => t.DateTimeStamp).HasColumnName("DateTimeStamp");
            Property(t => t.AssessorId).HasColumnName("AssessorID");
            Property(t => t.AuditTableId).HasColumnName("AuditTableID");
            Property(t => t.AuditActionId).HasColumnName("AuditActionID");
            Property(t => t.Id).HasColumnName("ID");
            Property(t => t.Hidden).HasColumnName("Hidden");
            Property(t => t.Note).HasColumnName("Note");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.AuditAction)
                .WithMany(t => t.AuditAssessorEvents)
                .HasForeignKey(d => d.AuditActionId);
            HasRequired(t => t.Assessor)
                .WithMany(t => t.AuditAssessorEvents)
                .HasForeignKey(d => d.AssessorId);
            HasRequired(t => t.AuditTable)
                .WithMany(t => t.AuditAssessorEvents)
                .HasForeignKey(d => d.AuditTableId);

        }
    }
}
