using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class CodeResourceMap : EntityTypeConfiguration<CodeResource>
    {
        public CodeResourceMap()
        {
            // Primary Key
            this.HasKey(t => t.CodeResourceId);

            // Properties
            // Table & Column Mappings
            this.ToTable("CodeResource", "Translation");
            this.Property(t => t.CodeResourceId).HasColumnName("CodeResourceID");
            this.Property(t => t.CodeResourceTypeId).HasColumnName("CodeResourceTypeID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.CodeResourceType)
                .WithMany(t => t.CodeResources)
                .HasForeignKey(d => d.CodeResourceTypeId);

        }
    }
}
