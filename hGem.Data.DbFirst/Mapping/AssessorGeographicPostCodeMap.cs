using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AssessorGeographicPostCodeMap : EntityTypeConfiguration<AssessorGeographicPostCode>
    {
        public AssessorGeographicPostCodeMap()
        {
            // Primary Key
            HasKey(t => t.AssessorGeographicPostCodeId);

            // Properties
            Property(t => t.AssessorGeographicPostCodeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("AssessorGeographicPostCode");
            Property(t => t.AssessorGeographicPostCodeId).HasColumnName("AssessorGeographicPostCodeID");
            Property(t => t.AssessorId).HasColumnName("AssessorID");
            Property(t => t.GeographicPostCodeId).HasColumnName("GeographicPostCodeID");
            Property(t => t.Radius).HasColumnName("Radius");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Assessor)
                .WithMany(t => t.AssessorGeographicPostCodes)
                .HasForeignKey(d => d.AssessorId);
            HasRequired(t => t.GeographicPostCode)
                .WithMany(t => t.AssessorGeographicPostCodes)
                .HasForeignKey(d => d.GeographicPostCodeId);

        }
    }
}
