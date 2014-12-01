using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AssessorAttributeMap : EntityTypeConfiguration<AssessorAttribute>
    {
        public AssessorAttributeMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessorAttributeId);

            // Properties
            this.Property(t => t.AssessorAttributeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AssessorAttribute");
            this.Property(t => t.AssessorAttributeId).HasColumnName("AssessorAttributeID");
            this.Property(t => t.AssessorId).HasColumnName("AssessorID");
            this.Property(t => t.AssessorAttributeItemId).HasColumnName("AssessorAttributeItemID");
            this.Property(t => t.AssessorAttributeOptionId).HasColumnName("AssessorAttributeOptionID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.AssessorAttributes)
                .HasForeignKey(d => d.AssessorId);
            this.HasRequired(t => t.AssessorAttributeItem)
                .WithMany(t => t.AssessorAttributes)
                .HasForeignKey(d => d.AssessorAttributeItemId);
            this.HasRequired(t => t.AssessorAttributeOption)
                .WithMany(t => t.AssessorAttributes)
                .HasForeignKey(d => d.AssessorAttributeOptionId);

        }
    }
}
