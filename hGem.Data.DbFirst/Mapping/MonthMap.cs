using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class MonthMap : EntityTypeConfiguration<Month>
    {
        public MonthMap()
        {
            // Primary Key
            HasKey(t => t.MonthId);

            // Properties
            Property(t => t.Name)
                .HasMaxLength(10);

            // Table & Column Mappings
            ToTable("Month", "Subscriptions");
            Property(t => t.MonthId).HasColumnName("MonthId");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
