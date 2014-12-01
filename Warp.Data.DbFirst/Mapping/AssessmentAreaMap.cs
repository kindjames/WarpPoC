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
            this.HasKey(t => t.AssessmentAreaId);

            // Properties
            this.Property(t => t.AssessmentAreaId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AssessmentArea");
            this.Property(t => t.AssessmentAreaId).HasColumnName("AssessmentAreaID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.AssessmentTypeId).HasColumnName("AssessmentTypeID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.AssessmentType)
                .WithMany(t => t.AssessmentAreas)
                .HasForeignKey(d => d.AssessmentTypeId);

        }
    }
}
