using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AssessorAttributeOptionMap : EntityTypeConfiguration<AssessorAttributeOption>
    {
        public AssessorAttributeOptionMap()
        {
            // Primary Key
            HasKey(t => t.AssessorAttributeOptionId);

            // Properties
            Property(t => t.AssessorAttributeOptionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("AssessorAttributeOption");
            Property(t => t.AssessorAttributeOptionId).HasColumnName("AssessorAttributeOptionID");
            Property(t => t.AssessorAttributeItemId).HasColumnName("AssessorAttributeItemID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            HasRequired(t => t.AssessorAttributeItem)
                .WithMany(t => t.AssessorAttributeOptions)
                .HasForeignKey(d => d.AssessorAttributeItemId);

        }
    }
}
