using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class EventMap : EntityTypeConfiguration<Event>
    {
        public EventMap()
        {
            // Primary Key
            this.HasKey(t => t.EventLogID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Event", "Auditing");
            this.Property(t => t.EventLogID).HasColumnName("EventLogID");
            this.Property(t => t.UserRoleID).HasColumnName("UserRoleID");
            this.Property(t => t.SeverityID).HasColumnName("SeverityID");
            this.Property(t => t.EventCategoryID).HasColumnName("EventCategoryID");
            this.Property(t => t.CodeResourceID).HasColumnName("CodeResourceID");
            this.Property(t => t.Message).HasColumnName("Message");
            this.Property(t => t.Exception).HasColumnName("Exception");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasOptional(t => t.User)
                .WithMany(t => t.Events)
                .HasForeignKey(d => d.UserRoleID);
            this.HasRequired(t => t.EventCategory)
                .WithMany(t => t.Events)
                .HasForeignKey(d => d.EventCategoryID);
            this.HasRequired(t => t.Severity)
                .WithMany(t => t.Events)
                .HasForeignKey(d => d.SeverityID);

        }
    }
}
