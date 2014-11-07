using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class CodeResourceMap : EntityTypeConfiguration<CodeResource>
    {
        public CodeResourceMap()
        {
            // Primary Key
            this.HasKey(t => t.CodeResourceID);

            // Properties
            // Table & Column Mappings
            this.ToTable("CodeResource", "Translation");
            this.Property(t => t.CodeResourceID).HasColumnName("CodeResourceID");
            this.Property(t => t.CodeResourceTypeID).HasColumnName("CodeResourceTypeID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.CodeResourceType)
                .WithMany(t => t.CodeResources)
                .HasForeignKey(d => d.CodeResourceTypeID);

        }
    }
}
