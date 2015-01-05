using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AuditPersonEventMap : EntityTypeConfiguration<AuditPersonEvent>
    {
        public AuditPersonEventMap()
        {
            // Primary Key
            HasKey(t => t.AuditPersonEventId);

            // Properties
            Property(t => t.AuditPersonEventId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Id)
                .IsRequired()
                .HasMaxLength(10);

            Property(t => t.Note)
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("AuditPersonEvent");
            Property(t => t.AuditPersonEventId).HasColumnName("AuditPersonEventID");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.PersonId).HasColumnName("PersonID");
            Property(t => t.AuditTableId).HasColumnName("AuditTableID");
            Property(t => t.AuditActionId).HasColumnName("AuditActionID");
            Property(t => t.Id).HasColumnName("ID");
            Property(t => t.Hidden).HasColumnName("Hidden");
            Property(t => t.Note).HasColumnName("Note");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.AuditAction)
                .WithMany(t => t.AuditPersonEvents)
                .HasForeignKey(d => d.AuditActionId);
            HasRequired(t => t.AuditTable)
                .WithMany(t => t.AuditPersonEvents)
                .HasForeignKey(d => d.AuditTableId);

        }
    }
}
