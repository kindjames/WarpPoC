using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class VisitPointMap : EntityTypeConfiguration<VisitPoint>
    {
        public VisitPointMap()
        {
            // Primary Key
            this.HasKey(t => t.VisitPointID);

            // Properties
            this.Property(t => t.VisitPointID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VisitPoint");
            this.Property(t => t.VisitPointID).HasColumnName("VisitPointID");
            this.Property(t => t.VisitID).HasColumnName("VisitID");
            this.Property(t => t.PointID).HasColumnName("PointID");

            // Relationships
            this.HasRequired(t => t.Point)
                .WithMany(t => t.VisitPoints)
                .HasForeignKey(d => d.PointID);
            this.HasRequired(t => t.Visit)
                .WithMany(t => t.VisitPoints)
                .HasForeignKey(d => d.VisitID);

        }
    }
}
