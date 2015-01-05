using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class CodeResourceMap : EntityTypeConfiguration<CodeResource>
    {
        public CodeResourceMap()
        {
            // Primary Key
            HasKey(t => t.CodeResourceId);

            // Properties
            // Table & Column Mappings
            ToTable("CodeResource", "Translation");
            Property(t => t.CodeResourceId).HasColumnName("CodeResourceID");
            Property(t => t.CodeResourceTypeId).HasColumnName("CodeResourceTypeID");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            HasRequired(t => t.CodeResourceType)
                .WithMany(t => t.CodeResources)
                .HasForeignKey(d => d.CodeResourceTypeId);

        }
    }
}
