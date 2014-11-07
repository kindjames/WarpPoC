using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class PermissionGroupUserMap : EntityTypeConfiguration<PermissionGroupUser>
    {
        public PermissionGroupUserMap()
        {
            // Primary Key
            this.HasKey(t => t.PermissionGroupUserID);

            // Properties
            // Table & Column Mappings
            this.ToTable("PermissionGroupUser", "Account");
            this.Property(t => t.PermissionGroupUserID).HasColumnName("PermissionGroupUserID");
            this.Property(t => t.PermissionGroupID).HasColumnName("PermissionGroupID");
            this.Property(t => t.UserRoleID).HasColumnName("UserRoleID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.AddedByAdminID).HasColumnName("AddedByAdminID");
            this.Property(t => t.DateDeactivated).HasColumnName("DateDeactivated");
            this.Property(t => t.DeactivatedByAdminID).HasColumnName("DeactivatedByAdminID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.PermissionGroup)
                .WithMany(t => t.PermissionGroupUsers)
                .HasForeignKey(d => d.PermissionGroupID);
            this.HasRequired(t => t.UserRole)
                .WithMany(t => t.PermissionGroupUsers)
                .HasForeignKey(d => d.UserRoleID);

        }
    }
}
