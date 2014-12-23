using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AuditActionMap : EntityTypeConfiguration<AuditAction>
    {
        public AuditActionMap()
        {
            // Primary Key
            HasKey(t => t.AuditActionId);

            // Properties
            Property(t => t.ActionName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("AuditAction", "Auditing");
            Property(t => t.AuditActionId).HasColumnName("AuditActionID");
            Property(t => t.ActionName).HasColumnName("ActionName");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
