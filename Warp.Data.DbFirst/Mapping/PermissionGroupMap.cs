using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PermissionGroupMap : EntityTypeConfiguration<PermissionGroup>
    {
        public PermissionGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.PermissionGroupId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("PermissionGroup", "Account");
            this.Property(t => t.PermissionGroupId).HasColumnName("PermissionGroupID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
