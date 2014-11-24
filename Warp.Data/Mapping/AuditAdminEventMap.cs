using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class AuditAdminEventMap : EntityTypeConfiguration<AuditAdminEvent>
    {
        public AuditAdminEventMap()
        {
            // Primary Key
            this.HasKey(t => t.AuditAdminiEventId);

            // Properties
            this.Property(t => t.AuditAdminiEventId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Id)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Note)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("AuditAdminEvent");
            this.Property(t => t.AuditAdminiEventId).HasColumnName("AuditAdminiEventID");
            this.Property(t => t.AdminId).HasColumnName("AdminID");
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
                .WithMany(t => t.AuditAdminEvents)
                .HasForeignKey(d => d.AuditActionId);
            this.HasRequired(t => t.AuditTable)
                .WithMany(t => t.AuditAdminEvents)
                .HasForeignKey(d => d.AuditTableId);

        }
    }
}
