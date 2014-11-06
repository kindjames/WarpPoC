using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ActionEventMap : EntityTypeConfiguration<ActionEvent>
    {
        public ActionEventMap()
        {
            // Primary Key
            this.HasKey(t => t.ActionEventID);

            // Properties
            this.Property(t => t.Action)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ActionEvent", "Auditing");
            this.Property(t => t.ActionEventID).HasColumnName("ActionEventID");
            this.Property(t => t.ActionCategoryID).HasColumnName("ActionCategoryID");
            this.Property(t => t.SeverityID).HasColumnName("SeverityID");
            this.Property(t => t.Action).HasColumnName("Action");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.ActionCategory)
                .WithMany(t => t.ActionEvents)
                .HasForeignKey(d => d.ActionCategoryID);
            this.HasRequired(t => t.Severity)
                .WithMany(t => t.ActionEvents)
                .HasForeignKey(d => d.SeverityID);

        }
    }
}
