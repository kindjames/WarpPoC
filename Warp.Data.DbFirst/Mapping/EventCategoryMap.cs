using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class EventCategoryMap : EntityTypeConfiguration<EventCategory>
    {
        public EventCategoryMap()
        {
            // Primary Key
            HasKey(t => t.EventCategoryId);

            // Properties
            Property(t => t.Category)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("EventCategory", "Auditing");
            Property(t => t.EventCategoryId).HasColumnName("EventCategoryID");
            Property(t => t.Category).HasColumnName("Category");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
