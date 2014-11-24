using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class VisitPointMap : EntityTypeConfiguration<VisitPoint>
    {
        public VisitPointMap()
        {
            // Primary Key
            this.HasKey(t => t.VisitPointId);

            // Properties
            this.Property(t => t.VisitPointId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VisitPoint");
            this.Property(t => t.VisitPointId).HasColumnName("VisitPointID");
            this.Property(t => t.VisitId).HasColumnName("VisitID");
            this.Property(t => t.PointId).HasColumnName("PointID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Point)
                .WithMany(t => t.VisitPoints)
                .HasForeignKey(d => d.PointId);
            this.HasRequired(t => t.Visit)
                .WithMany(t => t.VisitPoints)
                .HasForeignKey(d => d.VisitId);

        }
    }
}
