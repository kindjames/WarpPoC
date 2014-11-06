using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class UserRoleMap : EntityTypeConfiguration<UserRole>
    {
        public UserRoleMap()
        {
            // Primary Key
            this.HasKey(t => t.UserRoleID);

            // Properties
            // Table & Column Mappings
            this.ToTable("UserRole");
            this.Property(t => t.UserRoleID).HasColumnName("UserRoleID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.RoleID).HasColumnName("RoleID");
            this.Property(t => t.LegacyUserID).HasColumnName("LegacyUserID");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Customer)
                .WithMany(t => t.UserRoles)
                .HasForeignKey(d => d.CustomerID);
            this.HasRequired(t => t.Role)
                .WithMany(t => t.UserRoles)
                .HasForeignKey(d => d.RoleID);
            this.HasRequired(t => t.User)
                .WithMany(t => t.UserRoles)
                .HasForeignKey(d => d.UserID);

        }
    }
}
