using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PermissionGroupUserMap : EntityTypeConfiguration<PermissionGroupUser>
    {
        public PermissionGroupUserMap()
        {
            // Primary Key
            HasKey(t => t.PermissionGroupUserId);

            // Properties
            // Table & Column Mappings
            ToTable("PermissionGroupUser", "Account");
            Property(t => t.PermissionGroupUserId).HasColumnName("PermissionGroupUserID");
            Property(t => t.PermissionGroupId).HasColumnName("PermissionGroupID");
            Property(t => t.UserRoleId).HasColumnName("UserRoleID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            Property(t => t.DateDeactivated).HasColumnName("DateDeactivated");
            Property(t => t.DeactivatedByAdminId).HasColumnName("DeactivatedByAdminID");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            HasRequired(t => t.PermissionGroup)
                .WithMany(t => t.PermissionGroupUsers)
                .HasForeignKey(d => d.PermissionGroupId);
            HasRequired(t => t.UserRole)
                .WithMany(t => t.PermissionGroupUsers)
                .HasForeignKey(d => d.UserRoleId);

        }
    }
}
