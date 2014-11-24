using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class UserImpersonationUserRoleMap : EntityTypeConfiguration<UserImpersonationUserRole>
    {
        public UserImpersonationUserRoleMap()
        {
            // Primary Key
            this.HasKey(t => t.UserImpersonationUserRoleId);

            // Properties
            // Table & Column Mappings
            this.ToTable("UserImpersonationUserRole", "Account");
            this.Property(t => t.UserImpersonationUserRoleId).HasColumnName("UserImpersonationUserRoleID");
            this.Property(t => t.DateStart).HasColumnName("DateStart");
            this.Property(t => t.DateEnd).HasColumnName("DateEnd");
            this.Property(t => t.UserId).HasColumnName("UserID");
            this.Property(t => t.UserRoleId).HasColumnName("UserRoleID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
