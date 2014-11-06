using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class PermissionGroupMap : EntityTypeConfiguration<PermissionGroup>
    {
        public PermissionGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.PermissionGroupID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("PermissionGroup");
            this.Property(t => t.PermissionGroupID).HasColumnName("PermissionGroupID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
