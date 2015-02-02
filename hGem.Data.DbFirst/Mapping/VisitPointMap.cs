using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class VisitPointMap : EntityTypeConfiguration<VisitPoint>
    {
        public VisitPointMap()
        {
            // Primary Key
            HasKey(t => t.VisitPointId);

            // Properties
            Property(t => t.VisitPointId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("VisitPoint");
            Property(t => t.VisitPointId).HasColumnName("VisitPointID");
            Property(t => t.VisitId).HasColumnName("VisitID");
            Property(t => t.PointId).HasColumnName("PointID");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Point)
                .WithMany(t => t.VisitPoints)
                .HasForeignKey(d => d.PointId);
            HasRequired(t => t.Visit)
                .WithMany(t => t.VisitPoints)
                .HasForeignKey(d => d.VisitId);

        }
    }
}
