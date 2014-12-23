using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class DelayTypeMap : EntityTypeConfiguration<DelayType>
    {
        public DelayTypeMap()
        {
            // Primary Key
            HasKey(t => t.DelayTypeId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            ToTable("DelayType", "Subscriptions");
            Property(t => t.DelayTypeId).HasColumnName("DelayTypeId");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
