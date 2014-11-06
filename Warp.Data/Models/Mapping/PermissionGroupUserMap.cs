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
            this.ToTable("PermissionGroupUser");
            this.Property(t => t.PermissionGroupUserID).HasColumnName("PermissionGroupUserID");
            this.Property(t => t.PermissionGroupID).HasColumnName("PermissionGroupID");
            this.Property(t => t.UserRoleID).HasColumnName("UserRoleID");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");
            this.Property(t => t.AddedByAdminID).HasColumnName("AddedByAdminID");
            this.Property(t => t.DeactivateDate).HasColumnName("DeactivateDate");
            this.Property(t => t.DeactivatedByAdminID).HasColumnName("DeactivatedByAdminID");
            this.Property(t => t.Active).HasColumnName("Active");

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
