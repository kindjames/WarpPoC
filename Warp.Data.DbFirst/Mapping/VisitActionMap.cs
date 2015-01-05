using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class VisitActionMap : EntityTypeConfiguration<VisitAction>
    {
        public VisitActionMap()
        {
            // Primary Key
            HasKey(t => t.VisitActionId);

            // Properties
            Property(t => t.VisitActionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("VisitAction");
            Property(t => t.VisitActionId).HasColumnName("VisitActionID");
            Property(t => t.VisitId).HasColumnName("VisitId");
            Property(t => t.ActionId).HasColumnName("ActionID");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Action)
                .WithMany(t => t.VisitActions)
                .HasForeignKey(d => d.ActionId);
            HasRequired(t => t.Visit)
                .WithMany(t => t.VisitActions)
                .HasForeignKey(d => d.VisitId);

        }
    }
}
