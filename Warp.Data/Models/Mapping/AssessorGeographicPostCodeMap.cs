using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class AssessorGeographicPostCodeMap : EntityTypeConfiguration<AssessorGeographicPostCode>
    {
        public AssessorGeographicPostCodeMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessorGeographicPostCodeID);

            // Properties
            this.Property(t => t.AssessorGeographicPostCodeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AssessorGeographicPostCode");
            this.Property(t => t.AssessorGeographicPostCodeID).HasColumnName("AssessorGeographicPostCodeID");
            this.Property(t => t.AssessorID).HasColumnName("AssessorID");
            this.Property(t => t.GeographicPostCodeID).HasColumnName("GeographicPostCodeID");
            this.Property(t => t.Radius).HasColumnName("Radius");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.AssessorGeographicPostCodes)
                .HasForeignKey(d => d.AssessorID);
            this.HasRequired(t => t.GeographicPostCode)
                .WithMany(t => t.AssessorGeographicPostCodes)
                .HasForeignKey(d => d.GeographicPostCodeID);

        }
    }
}
