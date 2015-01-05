using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class StaffAgeMap : EntityTypeConfiguration<StaffAge>
    {
        public StaffAgeMap()
        {
            // Primary Key
            HasKey(t => t.StaffAgeId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("StaffAge");
            Property(t => t.StaffAgeId).HasColumnName("StaffAgeID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
