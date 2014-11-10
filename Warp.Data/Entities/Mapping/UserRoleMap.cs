using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class UserRoleMap : EntityTypeConfiguration<UserRole>
    {
        public UserRoleMap()
        {
            // Primary Key
            this.HasKey(t => t.UserRoleID);

            // Properties
            // Table & Column Mappings
            this.ToTable("UserRole", "Account");
            this.Property(t => t.UserRoleID).HasColumnName("UserRoleID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
            this.Property(t => t.LegacyUserID).HasColumnName("LegacyUserID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Role)
                .WithMany(t => t.UserRoles)
                .HasForeignKey(d => d.RoleID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.UserRoles)
                .HasForeignKey(d => d.UserID);

        }
    }
}
