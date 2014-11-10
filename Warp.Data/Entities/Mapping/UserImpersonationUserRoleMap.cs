using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class UserImpersonationUserRoleMap : EntityTypeConfiguration<UserImpersonationUserRole>
    {
        public UserImpersonationUserRoleMap()
        {
            // Primary Key
            this.HasKey(t => t.UserImpersonationUserRoleID);

            // Properties
            // Table & Column Mappings
            this.ToTable("UserImpersonationUserRole", "Account");
            this.Property(t => t.UserImpersonationUserRoleID).HasColumnName("UserImpersonationUserRoleID");
            this.Property(t => t.DateStart).HasColumnName("DateStart");
            this.Property(t => t.DateEnd).HasColumnName("DateEnd");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.UserRoleID).HasColumnName("UserRoleID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
