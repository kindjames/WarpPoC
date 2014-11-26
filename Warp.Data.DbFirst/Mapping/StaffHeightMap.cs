using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class StaffHeightMap : EntityTypeConfiguration<StaffHeight>
    {
        public StaffHeightMap()
        {
            // Primary Key
            this.HasKey(t => t.StaffHeightId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("StaffHeight");
            this.Property(t => t.StaffHeightId).HasColumnName("StaffHeightID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
