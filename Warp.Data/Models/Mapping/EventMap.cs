using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class EventMap : EntityTypeConfiguration<Event>
    {
        public EventMap()
        {
            // Primary Key
            this.HasKey(t => t.LogEventID);

            // Properties
            this.Property(t => t.Description)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Event", "Auditing");
            this.Property(t => t.LogEventID).HasColumnName("LogEventID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.ActionEventID).HasColumnName("ActionEventID");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasOptional(t => t.ActionEvent)
                .WithMany(t => t.Events)
                .HasForeignKey(d => d.ActionEventID);

        }
    }
}
