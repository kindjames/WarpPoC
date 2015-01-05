using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class StaffHeightMap : EntityTypeConfiguration<StaffHeight>
    {
        public StaffHeightMap()
        {
            // Primary Key
            HasKey(t => t.StaffHeightId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("StaffHeight");
            Property(t => t.StaffHeightId).HasColumnName("StaffHeightID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
