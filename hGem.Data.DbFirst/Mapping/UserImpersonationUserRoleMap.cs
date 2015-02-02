using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class UserImpersonationUserRoleMap : EntityTypeConfiguration<UserImpersonationUserRole>
    {
        public UserImpersonationUserRoleMap()
        {
            // Primary Key
            HasKey(t => t.UserImpersonationUserRoleId);

            // Properties
            // Table & Column Mappings
            ToTable("UserImpersonationUserRole", "Account");
            Property(t => t.UserImpersonationUserRoleId).HasColumnName("UserImpersonationUserRoleID");
            Property(t => t.DateStart).HasColumnName("DateStart");
            Property(t => t.DateEnd).HasColumnName("DateEnd");
            Property(t => t.UserId).HasColumnName("UserID");
            Property(t => t.UserRoleId).HasColumnName("UserRoleID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
