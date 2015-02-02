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
            HasKey(t => t.PointId);

            // Properties
            Property(t => t.PointId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("Point");
            Property(t => t.PointId).HasColumnName("PointID");
            Property(t => t.AssessorId).HasColumnName("AssessorID");
            Property(t => t.PointReasonId).HasColumnName("PointReasonID");
            Property(t => t.Value).HasColumnName("Value");
            Property(t => t.EnteredByAdminId).HasColumnName("EnteredByAdminID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Assessor)
                .WithMany(t => t.Points)
                .HasForeignKey(d => d.AssessorId);
            HasRequired(t => t.PointReason)
                .WithMany(t => t.Points)
                .HasForeignKey(d => d.PointReasonId);

        }
    }
}
