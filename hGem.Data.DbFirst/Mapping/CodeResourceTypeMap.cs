using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class CodeResourceTypeMap : EntityTypeConfiguration<CodeResourceType>
    {
        public CodeResourceTypeMap()
        {
            // Primary Key
            HasKey(t => t.CodeResourceTypeId);

            // Properties
            Property(t => t.ResourceTypeDescription)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("CodeResourceType", "Translation");
            Property(t => t.CodeResourceTypeId).HasColumnName("CodeResourceTypeID");
            Property(t => t.ResourceTypeDescription).HasColumnName("ResourceTypeDescription");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
