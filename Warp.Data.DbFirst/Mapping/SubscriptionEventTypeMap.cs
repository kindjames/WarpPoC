using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class SubscriptionEventTypeMap : EntityTypeConfiguration<SubscriptionEventType>
    {
        public SubscriptionEventTypeMap()
        {
            // Primary Key
            HasKey(t => t.SubscriptionEventTypeId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            ToTable("SubscriptionEventType", "Subscriptions");
            Property(t => t.SubscriptionEventTypeId).HasColumnName("SubscriptionEventTypeId");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
