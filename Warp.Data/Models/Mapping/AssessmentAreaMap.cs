using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class AssessmentAreaMap : EntityTypeConfiguration<AssessmentArea>
    {
        public AssessmentAreaMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessmentAreaID);

            // Properties
            this.Property(t => t.AssessmentAreaID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AssessmentArea");
            this.Property(t => t.AssessmentAreaID).HasColumnName("AssessmentAreaID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.AssessmentTypeID).HasColumnName("AssessmentTypeID");

            // Relationships
            this.HasRequired(t => t.AssessmentType)
                .WithMany(t => t.AssessmentAreas)
                .HasForeignKey(d => d.AssessmentTypeID);

        }
    }
}
