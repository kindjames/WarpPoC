using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class AuditAdminEventMap : EntityTypeConfiguration<AuditAdminEvent>
    {
        public AuditAdminEventMap()
        {
            // Primary Key
            this.HasKey(t => t.AuditAdminiEventID);

            // Properties
            this.Property(t => t.AuditAdminiEventID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Note)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("AuditAdminEvent");
            this.Property(t => t.AuditAdminiEventID).HasColumnName("AuditAdminiEventID");
            this.Property(t => t.Timestamp).HasColumnName("Timestamp");
            this.Property(t => t.AdminID).HasColumnName("AdminID");
            this.Property(t => t.AuditTableID).HasColumnName("AuditTableID");
            this.Property(t => t.AuditActionID).HasColumnName("AuditActionID");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Hidden).HasColumnName("Hidden");
            this.Property(t => t.Note).HasColumnName("Note");

            // Relationships
            this.HasRequired(t => t.AuditAction)
                .WithMany(t => t.AuditAdminEvents)
                .HasForeignKey(d => d.AuditActionID);
            this.HasRequired(t => t.AuditTable)
                .WithMany(t => t.AuditAdminEvents)
                .HasForeignKey(d => d.AuditTableID);

        }
    }
}
