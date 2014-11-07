using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class PermissionTypeMap : EntityTypeConfiguration<PermissionType>
    {
        public PermissionTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.PermissionTypeID);

            // Properties
            this.Property(t => t.PermissionType1)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PermissionType", "Client");
            this.Property(t => t.PermissionTypeID).HasColumnName("PermissionTypeID");
            this.Property(t => t.PermissionType1).HasColumnName("PermissionType");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
