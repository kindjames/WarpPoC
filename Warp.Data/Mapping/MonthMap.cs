using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class MonthMap : EntityTypeConfiguration<Month>
    {
        public MonthMap()
        {
            // Primary Key
            this.HasKey(t => t.MonthId);

            // Properties
            this.Property(t => t.Name)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Month", "Subscriptions");
            this.Property(t => t.MonthId).HasColumnName("MonthId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
