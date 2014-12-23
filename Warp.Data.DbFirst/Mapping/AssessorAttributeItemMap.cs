using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AssessorAttributeItemMap : EntityTypeConfiguration<AssessorAttributeItem>
    {
        public AssessorAttributeItemMap()
        {
            // Primary Key
            HasKey(t => t.AssessorAttributeItemId);

            // Properties
            Property(t => t.AssessorAttributeItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("AssessorAttributeItem");
            Property(t => t.AssessorAttributeItemId).HasColumnName("AssessorAttributeItemID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.MultipleSelection).HasColumnName("MultipleSelection");
            Property(t => t.ForecRequirement).HasColumnName("ForecRequirement");
            Property(t => t.Display).HasColumnName("Display");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
