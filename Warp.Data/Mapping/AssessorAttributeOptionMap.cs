using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class AssessorAttributeOptionMap : EntityTypeConfiguration<AssessorAttributeOption>
    {
        public AssessorAttributeOptionMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessorAttributeOptionId);

            // Properties
            this.Property(t => t.AssessorAttributeOptionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AssessorAttributeOption");
            this.Property(t => t.AssessorAttributeOptionId).HasColumnName("AssessorAttributeOptionID");
            this.Property(t => t.AssessorAttributeItemId).HasColumnName("AssessorAttributeItemID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.AssessorAttributeItem)
                .WithMany(t => t.AssessorAttributeOptions)
                .HasForeignKey(d => d.AssessorAttributeItemId);

        }
    }
}
