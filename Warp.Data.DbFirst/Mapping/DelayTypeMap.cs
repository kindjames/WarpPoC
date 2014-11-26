using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class DelayTypeMap : EntityTypeConfiguration<DelayType>
    {
        public DelayTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.DelayTypeId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("DelayType", "Subscriptions");
            this.Property(t => t.DelayTypeId).HasColumnName("DelayTypeId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}