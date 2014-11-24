using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class AssessorAttributeItemMap : EntityTypeConfiguration<AssessorAttributeItem>
    {
        public AssessorAttributeItemMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessorAttributeItemId);

            // Properties
            this.Property(t => t.AssessorAttributeItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AssessorAttributeItem");
            this.Property(t => t.AssessorAttributeItemId).HasColumnName("AssessorAttributeItemID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.MultipleSelection).HasColumnName("MultipleSelection");
            this.Property(t => t.ForecRequirement).HasColumnName("ForecRequirement");
            this.Property(t => t.Display).HasColumnName("Display");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
