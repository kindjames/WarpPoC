using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PermissionTypeMap : EntityTypeConfiguration<PermissionType>
    {
        public PermissionTypeMap()
        {
            // Primary Key
            HasKey(t => t.PermissionTypeId);

            // Properties
            Property(t => t.PermissionType1)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("PermissionType", "Client");
            Property(t => t.PermissionTypeId).HasColumnName("PermissionTypeID");
            Property(t => t.PermissionType1).HasColumnName("PermissionType");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
