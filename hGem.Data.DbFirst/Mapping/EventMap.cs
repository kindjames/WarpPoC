using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class EventMap : EntityTypeConfiguration<Event>
    {
        public EventMap()
        {
            // Primary Key
            HasKey(t => t.EventLogId);

            // Properties
            // Table & Column Mappings
            ToTable("Event", "Auditing");
            Property(t => t.EventLogId).HasColumnName("EventLogID");
            Property(t => t.UserRoleId).HasColumnName("UserRoleID");
            Property(t => t.SeverityId).HasColumnName("SeverityID");
            Property(t => t.EventCategoryId).HasColumnName("EventCategoryID");
            Property(t => t.CodeResourceId).HasColumnName("CodeResourceID");
            Property(t => t.Message).HasColumnName("Message");
            Property(t => t.Exception).HasColumnName("Exception");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasOptional(t => t.User)
                .WithMany(t => t.Events)
                .HasForeignKey(d => d.UserRoleId);
            HasRequired(t => t.EventCategory)
                .WithMany(t => t.Events)
                .HasForeignKey(d => d.EventCategoryId);
            HasRequired(t => t.Severity)
                .WithMany(t => t.Events)
                .HasForeignKey(d => d.SeverityId);

        }
    }
}
