using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class SubscriptionEventTypeMap : EntityTypeConfiguration<SubscriptionEventType>
    {
        public SubscriptionEventTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.SubscriptionEventTypeId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("SubscriptionEventType", "Subscriptions");
            this.Property(t => t.SubscriptionEventTypeId).HasColumnName("SubscriptionEventTypeId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
