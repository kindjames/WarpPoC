using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PermissionGroupPermissionMap : EntityTypeConfiguration<PermissionGroupPermission>
    {
        public PermissionGroupPermissionMap()
        {
            // Primary Key
            HasKey(t => t.PermissionGroupPermissionId);

            // Properties
            // Table & Column Mappings
            ToTable("PermissionGroupPermission", "Account");
            Property(t => t.PermissionGroupPermissionId).HasColumnName("PermissionGroupPermissionID");
            Property(t => t.PermissionGroupId).HasColumnName("PermissionGroupID");
            Property(t => t.PermissionId).HasColumnName("PermissionID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateDeactivated).HasColumnName("DateDeactivated");
            Property(t => t.DeactivatedByAdminId).HasColumnName("DeactivatedByAdminID");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            HasRequired(t => t.Permission)
                .WithMany(t => t.PermissionGroupPermissions)
                .HasForeignKey(d => d.PermissionId);
            HasRequired(t => t.PermissionGroup)
                .WithMany(t => t.PermissionGroupPermissions)
                .HasForeignKey(d => d.PermissionGroupId);

        }
    }
}
