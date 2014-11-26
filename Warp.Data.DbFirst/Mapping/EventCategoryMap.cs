using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class EventCategoryMap : EntityTypeConfiguration<EventCategory>
    {
        public EventCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.EventCategoryId);

            // Properties
            this.Property(t => t.Category)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("EventCategory", "Auditing");
            this.Property(t => t.EventCategoryId).HasColumnName("EventCategoryID");
            this.Property(t => t.Category).HasColumnName("Category");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
