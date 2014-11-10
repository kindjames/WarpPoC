using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class PointMap : EntityTypeConfiguration<Point>
    {
        public PointMap()
        {
            // Primary Key
            this.HasKey(t => t.PointID);

            // Properties
            this.Property(t => t.PointID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Point");
            this.Property(t => t.PointID).HasColumnName("PointID");
            this.Property(t => t.AssessorID).HasColumnName("AssessorID");
            this.Property(t => t.PointReasonID).HasColumnName("PointReasonID");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.EnteredByAdminID).HasColumnName("EnteredByAdminID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.Points)
                .HasForeignKey(d => d.AssessorID);
            this.HasRequired(t => t.PointReason)
                .WithMany(t => t.Points)
                .HasForeignKey(d => d.PointReasonID);

        }
    }
}
