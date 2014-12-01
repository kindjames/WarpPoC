using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PermissionGroupPermissionMap : EntityTypeConfiguration<PermissionGroupPermission>
    {
        public PermissionGroupPermissionMap()
        {
            // Primary Key
            this.HasKey(t => t.PermissionGroupPermissionId);

            // Properties
            // Table & Column Mappings
            this.ToTable("PermissionGroupPermission", "Account");
            this.Property(t => t.PermissionGroupPermissionId).HasColumnName("PermissionGroupPermissionID");
            this.Property(t => t.PermissionGroupId).HasColumnName("PermissionGroupID");
            this.Property(t => t.PermissionId).HasColumnName("PermissionID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateDeactivated).HasColumnName("DateDeactivated");
            this.Property(t => t.DeactivatedByAdminId).HasColumnName("DeactivatedByAdminID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.Permission)
                .WithMany(t => t.PermissionGroupPermissions)
                .HasForeignKey(d => d.PermissionId);
            this.HasRequired(t => t.PermissionGroup)
                .WithMany(t => t.PermissionGroupPermissions)
                .HasForeignKey(d => d.PermissionGroupId);

        }
    }
}
