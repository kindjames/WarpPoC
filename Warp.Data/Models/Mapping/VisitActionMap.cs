using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class VisitActionMap : EntityTypeConfiguration<VisitAction>
    {
        public VisitActionMap()
        {
            // Primary Key
            this.HasKey(t => t.VisitActionID);

            // Properties
            this.Property(t => t.VisitActionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VisitAction");
            this.Property(t => t.VisitActionID).HasColumnName("VisitActionID");
            this.Property(t => t.VisitId).HasColumnName("VisitId");
            this.Property(t => t.ActionID).HasColumnName("ActionID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Action)
                .WithMany(t => t.VisitActions)
                .HasForeignKey(d => d.ActionID);
            this.HasRequired(t => t.Visit)
                .WithMany(t => t.VisitActions)
                .HasForeignKey(d => d.VisitId);

        }
    }
}
