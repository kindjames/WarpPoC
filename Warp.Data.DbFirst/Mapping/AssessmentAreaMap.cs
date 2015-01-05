using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AssessmentAreaMap : EntityTypeConfiguration<AssessmentArea>
    {
        public AssessmentAreaMap()
        {
            // Primary Key
            HasKey(t => t.AssessmentAreaId);

            // Properties
            Property(t => t.AssessmentAreaId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("AssessmentArea");
            Property(t => t.AssessmentAreaId).HasColumnName("AssessmentAreaID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.AssessmentTypeId).HasColumnName("AssessmentTypeID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.AssessmentType)
                .WithMany(t => t.AssessmentAreas)
                .HasForeignKey(d => d.AssessmentTypeId);

        }
    }
}
