using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class EventMap : EntityTypeConfiguration<Event>
    {
        public EventMap()
        {
            // Primary Key
            this.HasKey(t => t.EventLogId);

            // Properties
            // Table & Column Mappings
            this.ToTable("Event", "Auditing");
            this.Property(t => t.EventLogId).HasColumnName("EventLogID");
            this.Property(t => t.UserRoleId).HasColumnName("UserRoleID");
            this.Property(t => t.SeverityId).HasColumnName("SeverityID");
            this.Property(t => t.EventCategoryId).HasColumnName("EventCategoryID");
            this.Property(t => t.CodeResourceId).HasColumnName("CodeResourceID");
            this.Property(t => t.Message).HasColumnName("Message");
            this.Property(t => t.Exception).HasColumnName("Exception");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasOptional(t => t.User)
                .WithMany(t => t.Events)
                .HasForeignKey(d => d.UserRoleId);
            this.HasRequired(t => t.EventCategory)
                .WithMany(t => t.Events)
                .HasForeignKey(d => d.EventCategoryId);
            this.HasRequired(t => t.Severity)
                .WithMany(t => t.Events)
                .HasForeignKey(d => d.SeverityId);

        }
    }
}
