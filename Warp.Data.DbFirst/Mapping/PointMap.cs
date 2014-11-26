using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PointMap : EntityTypeConfiguration<Point>
    {
        public PointMap()
        {
            // Primary Key
            this.HasKey(t => t.PointId);

            // Properties
            this.Property(t => t.PointId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Point");
            this.Property(t => t.PointId).HasColumnName("PointID");
            this.Property(t => t.AssessorId).HasColumnName("AssessorID");
            this.Property(t => t.PointReasonId).HasColumnName("PointReasonID");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.EnteredByAdminId).HasColumnName("EnteredByAdminID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.Points)
                .HasForeignKey(d => d.AssessorId);
            this.HasRequired(t => t.PointReason)
                .WithMany(t => t.Points)
                .HasForeignKey(d => d.PointReasonId);

        }
    }
}
