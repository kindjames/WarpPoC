using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class CodeResourceTypeMap : EntityTypeConfiguration<CodeResourceType>
    {
        public CodeResourceTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.CodeResourceTypeId);

            // Properties
            this.Property(t => t.ResourceTypeDescription)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CodeResourceType", "Translation");
            this.Property(t => t.CodeResourceTypeId).HasColumnName("CodeResourceTypeID");
            this.Property(t => t.ResourceTypeDescription).HasColumnName("ResourceTypeDescription");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
