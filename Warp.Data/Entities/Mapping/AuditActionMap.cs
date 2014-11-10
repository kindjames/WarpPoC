using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class AuditActionMap : EntityTypeConfiguration<AuditAction>
    {
        public AuditActionMap()
        {
            // Primary Key
            this.HasKey(t => t.AuditActionID);

            // Properties
            this.Property(t => t.ActionName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AuditAction", "Auditing");
            this.Property(t => t.AuditActionID).HasColumnName("AuditActionID");
            this.Property(t => t.ActionName).HasColumnName("ActionName");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
