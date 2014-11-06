using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class PermissionGroupPermissionMap : EntityTypeConfiguration<PermissionGroupPermission>
    {
        public PermissionGroupPermissionMap()
        {
            // Primary Key
            this.HasKey(t => t.PermissionGroupPermissionID);

            // Properties
            // Table & Column Mappings
            this.ToTable("PermissionGroupPermission");
            this.Property(t => t.PermissionGroupPermissionID).HasColumnName("PermissionGroupPermissionID");
            this.Property(t => t.PermissionGroupID).HasColumnName("PermissionGroupID");
            this.Property(t => t.PermissionID).HasColumnName("PermissionID");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");
            this.Property(t => t.AddedByAdminID).HasColumnName("AddedByAdminID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DeactivateDate).HasColumnName("DeactivateDate");
            this.Property(t => t.DeactivatedByAdminID).HasColumnName("DeactivatedByAdminID");

            // Relationships
            this.HasRequired(t => t.Permission)
                .WithMany(t => t.PermissionGroupPermissions)
                .HasForeignKey(d => d.PermissionID);
            this.HasRequired(t => t.PermissionGroup)
                .WithMany(t => t.PermissionGroupPermissions)
                .HasForeignKey(d => d.PermissionGroupID);

        }
    }
}
