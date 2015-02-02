using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class CriteriaAssessorAttributeMap : EntityTypeConfiguration<CriteriaAssessorAttribute>
    {
        public CriteriaAssessorAttributeMap()
        {
            // Primary Key
            HasKey(t => t.CriteriaAssessorAttributeId);

            // Properties
            Property(t => t.CriteriaAssessorAttributeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.AssessorAttributeOptionIDs)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.SQL)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            ToTable("CriteriaAssessorAttribute");
            Property(t => t.CriteriaAssessorAttributeId).HasColumnName("CriteriaAssessorAttributeID");
            Property(t => t.CriteriaSetId).HasColumnName("CriteriaSetID");
            Property(t => t.AssessorAttributeItemId).HasColumnName("AssessorAttributeItemID");
            Property(t => t.AssessorAttributeOptionIDs).HasColumnName("AssessorAttributeOptionIDs");
            Property(t => t.SQL).HasColumnName("SQL");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.AssessorAttributeItem)
                .WithMany(t => t.CriteriaAssessorAttributes)
                .HasForeignKey(d => d.AssessorAttributeItemId);
            HasRequired(t => t.CriteriaSet)
                .WithMany(t => t.CriteriaAssessorAttributes)
                .HasForeignKey(d => d.CriteriaSetId);

        }
    }
}
