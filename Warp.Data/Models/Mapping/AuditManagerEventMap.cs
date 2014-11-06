using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class AuditManagerEventMap : EntityTypeConfiguration<AuditManagerEvent>
    {
        public AuditManagerEventMap()
        {
            // Primary Key
            this.HasKey(t => t.AuditManagerEventID);

            // Properties
            this.Property(t => t.AuditManagerEventID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Note)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("AuditManagerEvent");
            this.Property(t => t.AuditManagerEventID).HasColumnName("AuditManagerEventID");
            this.Property(t => t.Timestamp).HasColumnName("Timestamp");
            this.Property(t => t.ManagerID).HasColumnName("ManagerID");
            this.Property(t => t.AuditTableID).HasColumnName("AuditTableID");
            this.Property(t => t.AuditActionID).HasColumnName("AuditActionID");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Hidden).HasColumnName("Hidden");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.AuditAction)
                .WithMany(t => t.AuditManagerEvents)
                .HasForeignKey(d => d.AuditActionID);
            this.HasRequired(t => t.AuditTable)
                .WithMany(t => t.AuditManagerEvents)
                .HasForeignKey(d => d.AuditTableID);

        }
    }
}
