using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class AssessmentTypeMap : EntityTypeConfiguration<AssessmentType>
    {
        public AssessmentTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessmentTypeID);

            // Properties
            this.Property(t => t.AssessmentTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AssessmentType");
            this.Property(t => t.AssessmentTypeID).HasColumnName("AssessmentTypeID");
            this.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
