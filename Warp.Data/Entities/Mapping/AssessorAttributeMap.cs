using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class AssessorAttributeMap : EntityTypeConfiguration<AssessorAttribute>
    {
        public AssessorAttributeMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessorAttributeID);

            // Properties
            this.Property(t => t.AssessorAttributeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AssessorAttribute");
            this.Property(t => t.AssessorAttributeID).HasColumnName("AssessorAttributeID");
            this.Property(t => t.AssessorID).HasColumnName("AssessorID");
            this.Property(t => t.AssessorAttributeItemID).HasColumnName("AssessorAttributeItemID");
            this.Property(t => t.AssessorAttributeOptionID).HasColumnName("AssessorAttributeOptionID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.AssessorAttributes)
                .HasForeignKey(d => d.AssessorID);
            this.HasRequired(t => t.AssessorAttributeItem)
                .WithMany(t => t.AssessorAttributes)
                .HasForeignKey(d => d.AssessorAttributeItemID);
            this.HasRequired(t => t.AssessorAttributeOption)
                .WithMany(t => t.AssessorAttributes)
                .HasForeignKey(d => d.AssessorAttributeOptionID);

        }
    }
}
