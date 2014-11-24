using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class PermissionGroupUserMap : EntityTypeConfiguration<PermissionGroupUser>
    {
        public PermissionGroupUserMap()
        {
            // Primary Key
            this.HasKey(t => t.PermissionGroupUserId);

            // Properties
            // Table & Column Mappings
            this.ToTable("PermissionGroupUser", "Account");
            this.Property(t => t.PermissionGroupUserId).HasColumnName("PermissionGroupUserID");
            this.Property(t => t.PermissionGroupId).HasColumnName("PermissionGroupID");
            this.Property(t => t.UserRoleId).HasColumnName("UserRoleID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            this.Property(t => t.DateDeactivated).HasColumnName("DateDeactivated");
            this.Property(t => t.DeactivatedByAdminId).HasColumnName("DeactivatedByAdminID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.PermissionGroup)
                .WithMany(t => t.PermissionGroupUsers)
                .HasForeignKey(d => d.PermissionGroupId);
            this.HasRequired(t => t.UserRole)
                .WithMany(t => t.PermissionGroupUsers)
                .HasForeignKey(d => d.UserRoleId);

        }
    }
}
