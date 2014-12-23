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
            HasKey(t => t.AssessorAttributeId);

            // Properties
            Property(t => t.AssessorAttributeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("AssessorAttribute");
            Property(t => t.AssessorAttributeId).HasColumnName("AssessorAttributeID");
            Property(t => t.AssessorId).HasColumnName("AssessorID");
            Property(t => t.AssessorAttributeItemId).HasColumnName("AssessorAttributeItemID");
            Property(t => t.AssessorAttributeOptionId).HasColumnName("AssessorAttributeOptionID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Assessor)
                .WithMany(t => t.AssessorAttributes)
                .HasForeignKey(d => d.AssessorId);
            HasRequired(t => t.AssessorAttributeItem)
                .WithMany(t => t.AssessorAttributes)
                .HasForeignKey(d => d.AssessorAttributeItemId);
            HasRequired(t => t.AssessorAttributeOption)
                .WithMany(t => t.AssessorAttributes)
                .HasForeignKey(d => d.AssessorAttributeOptionId);

        }
    }
}
