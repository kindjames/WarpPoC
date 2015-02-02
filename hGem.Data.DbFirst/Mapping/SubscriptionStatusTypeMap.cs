using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class SubscriptionStatusTypeMap : EntityTypeConfiguration<SubscriptionStatusType>
    {
        public SubscriptionStatusTypeMap()
        {
            // Primary Key
            HasKey(t => t.SubscriptionStatusTypeId);

            // Properties
            Property(t => t.Name)
                .HasMaxLength(250);

            Property(t => t.Description)
                .HasMaxLength(250);

            // Table & Column Mappings
            ToTable("SubscriptionStatusType", "Subscriptions");
            Property(t => t.SubscriptionStatusTypeId).HasColumnName("SubscriptionStatusTypeId");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
