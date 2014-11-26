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
            this.HasKey(t => t.CriteriaAssessorAttributeId);

            // Properties
            this.Property(t => t.CriteriaAssessorAttributeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AssessorAttributeOptionIDs)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SQL)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("CriteriaAssessorAttribute");
            this.Property(t => t.CriteriaAssessorAttributeId).HasColumnName("CriteriaAssessorAttributeID");
            this.Property(t => t.CriteriaSetId).HasColumnName("CriteriaSetID");
            this.Property(t => t.AssessorAttributeItemId).HasColumnName("AssessorAttributeItemID");
            this.Property(t => t.AssessorAttributeOptionIDs).HasColumnName("AssessorAttributeOptionIDs");
            this.Property(t => t.SQL).HasColumnName("SQL");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.AssessorAttributeItem)
                .WithMany(t => t.CriteriaAssessorAttributes)
                .HasForeignKey(d => d.AssessorAttributeItemId);
            this.HasRequired(t => t.CriteriaSet)
                .WithMany(t => t.CriteriaAssessorAttributes)
                .HasForeignKey(d => d.CriteriaSetId);

        }
    }
}
