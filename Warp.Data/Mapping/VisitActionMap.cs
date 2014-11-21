using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class VisitActionMap : EntityTypeConfiguration<VisitAction>
    {
        public VisitActionMap()
        {
            // Primary Key
            this.HasKey(t => t.VisitActionId);

            // Properties
            this.Property(t => t.VisitActionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VisitAction");
            this.Property(t => t.VisitActionId).HasColumnName("VisitActionID");
            this.Property(t => t.VisitId).HasColumnName("VisitId");
            this.Property(t => t.ActionId).HasColumnName("ActionID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Action)
                .WithMany(t => t.VisitActions)
                .HasForeignKey(d => d.ActionId);
            this.HasRequired(t => t.Visit)
                .WithMany(t => t.VisitActions)
                .HasForeignKey(d => d.VisitId);

        }
    }
}
