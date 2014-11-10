using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class AuditPersonEventMap : EntityTypeConfiguration<AuditPersonEvent>
    {
        public AuditPersonEventMap()
        {
            // Primary Key
            this.HasKey(t => t.AuditPersonEventID);

            // Properties
            this.Property(t => t.AuditPersonEventID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Note)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("AuditPersonEvent");
            this.Property(t => t.AuditPersonEventID).HasColumnName("AuditPersonEventID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.AuditTableID).HasColumnName("AuditTableID");
            this.Property(t => t.AuditActionID).HasColumnName("AuditActionID");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Hidden).HasColumnName("Hidden");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.AuditAction)
                .WithMany(t => t.AuditPersonEvents)
                .HasForeignKey(d => d.AuditActionID);
            this.HasRequired(t => t.AuditTable)
                .WithMany(t => t.AuditPersonEvents)
                .HasForeignKey(d => d.AuditTableID);

        }
    }
}
