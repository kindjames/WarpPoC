using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class UserImpersonationUserRoleMap : EntityTypeConfiguration<UserImpersonationUserRole>
    {
        public UserImpersonationUserRoleMap()
        {
            // Primary Key
            this.HasKey(t => t.UserImpersonationUserRoleID);

            // Properties
            // Table & Column Mappings
            this.ToTable("UserImpersonationUserRole");
            this.Property(t => t.UserImpersonationUserRoleID).HasColumnName("UserImpersonationUserRoleID");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.UserRoleID).HasColumnName("UserRoleID");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.UserImpersonationUserRoles)
                .HasForeignKey(d => d.UserID);
            this.HasRequired(t => t.UserRole)
                .WithMany(t => t.UserImpersonationUserRoles)
                .HasForeignKey(d => d.UserRoleID);

        }
    }
}
