using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class AssessorAttributeOptionMap : EntityTypeConfiguration<AssessorAttributeOption>
    {
        public AssessorAttributeOptionMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessorAttributeOptionID);

            // Properties
            this.Property(t => t.AssessorAttributeOptionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AssessorAttributeOption");
            this.Property(t => t.AssessorAttributeOptionID).HasColumnName("AssessorAttributeOptionID");
            this.Property(t => t.AssessorAttributeItemID).HasColumnName("AssessorAttributeItemID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.AssessorAttributeItem)
                .WithMany(t => t.AssessorAttributeOptions)
                .HasForeignKey(d => d.AssessorAttributeItemID);

        }
    }
}
