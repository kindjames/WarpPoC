using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class AssessorGeographicPostCodeMap : EntityTypeConfiguration<AssessorGeographicPostCode>
    {
        public AssessorGeographicPostCodeMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessorGeographicPostCodeId);

            // Properties
            this.Property(t => t.AssessorGeographicPostCodeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AssessorGeographicPostCode");
            this.Property(t => t.AssessorGeographicPostCodeId).HasColumnName("AssessorGeographicPostCodeID");
            this.Property(t => t.AssessorId).HasColumnName("AssessorID");
            this.Property(t => t.GeographicPostCodeId).HasColumnName("GeographicPostCodeID");
            this.Property(t => t.Radius).HasColumnName("Radius");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.AssessorGeographicPostCodes)
                .HasForeignKey(d => d.AssessorId);
            this.HasRequired(t => t.GeographicPostCode)
                .WithMany(t => t.AssessorGeographicPostCodes)
                .HasForeignKey(d => d.GeographicPostCodeId);

        }
    }
}
