using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AssessmentTypeMap : EntityTypeConfiguration<AssessmentType>
    {
        public AssessmentTypeMap()
        {
            // Primary Key
            HasKey(t => t.AssessmentTypeId);

            // Properties
            Property(t => t.AssessmentTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("AssessmentType");
            Property(t => t.AssessmentTypeId).HasColumnName("AssessmentTypeID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
