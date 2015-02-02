using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AuditAdminEventMap : EntityTypeConfiguration<AuditAdminEvent>
    {
        public AuditAdminEventMap()
        {
            // Primary Key
            HasKey(t => t.AuditAdminiEventId);

            // Properties
            Property(t => t.AuditAdminiEventId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Id)
                .IsRequired()
                .HasMaxLength(10);

            Property(t => t.Note)
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("AuditAdminEvent");
            Property(t => t.AuditAdminiEventId).HasColumnName("AuditAdminiEventID");
            Property(t => t.AdminId).HasColumnName("AdminID");
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
                .WithMany(t => t.AuditAdminEvents)
                .HasForeignKey(d => d.AuditActionId);
            HasRequired(t => t.AuditTable)
                .WithMany(t => t.AuditAdminEvents)
                .HasForeignKey(d => d.AuditTableId);

        }
    }
}
