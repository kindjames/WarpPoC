//using System.Data.Entity.ModelConfiguration;
//using Warp.Data.DbFirst.Entities;

//namespace Warp.Data.Mapping
//{
//    public class UserRoleMap : EntityTypeConfiguration<UserRole>
//    {
//        public UserRoleMap()
//        {
//            // Primary Key
//            this.HasKey(t => t.UserRoleId);

//            // Properties
//            // Table & Column Mappings
//            this.ToTable("UserRole", "Account");
//            this.Property(t => t.UserRoleId).HasColumnName("UserRoleID");
//            this.Property(t => t.UserId).HasColumnName("UserID");
//            this.Property(t => t.CustomerId).HasColumnName("CustomerID");
//            this.Property(t => t.RoleId).HasColumnName("RoleID");
//            this.Property(t => t.LegacyUserId).HasColumnName("LegacyUserID");
//            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
//            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
//            this.Property(t => t.Active).HasColumnName("Active");

//            // Relationships
//            this.HasRequired(t => t.Role)
//                .WithMany(t => t.UserRoles)
//                .HasForeignKey(d => d.RoleId);
//            this.HasRequired(t => t.User)
//                .WithMany(t => t.UserRoles)
//                .HasForeignKey(d => d.UserId);

//        }
//    }
//}
