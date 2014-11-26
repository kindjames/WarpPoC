using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AuditActionMap : EntityTypeConfiguration<AuditAction>
    {
        public AuditActionMap()
        {
            // Primary Key
            this.HasKey(t => t.AuditActionId);

            // Properties
            this.Property(t => t.ActionName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AuditAction", "Auditing");
            this.Property(t => t.AuditActionId).HasColumnName("AuditActionID");
            this.Property(t => t.ActionName).HasColumnName("ActionName");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}