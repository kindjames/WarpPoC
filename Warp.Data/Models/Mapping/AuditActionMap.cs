using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
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
            this.ToTable("AuditAction");
            this.Property(t => t.AuditActionID).HasColumnName("AuditActionID");
            this.Property(t => t.ActionName).HasColumnName("ActionName");
        }
    }
}
