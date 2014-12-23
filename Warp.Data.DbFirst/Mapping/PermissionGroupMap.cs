using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PermissionGroupMap : EntityTypeConfiguration<PermissionGroup>
    {
        public PermissionGroupMap()
        {
            // Primary Key
            HasKey(t => t.PermissionGroupId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(300);

            // Table & Column Mappings
            ToTable("PermissionGroup", "Account");
            Property(t => t.PermissionGroupId).HasColumnName("PermissionGroupID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
