using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class AssessmentTypeMap : EntityTypeConfiguration<AssessmentType>
    {
        public AssessmentTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessmentTypeId);

            // Properties
            this.Property(t => t.AssessmentTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AssessmentType");
            this.Property(t => t.AssessmentTypeId).HasColumnName("AssessmentTypeID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
