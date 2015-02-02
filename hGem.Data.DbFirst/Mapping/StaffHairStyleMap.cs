using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class StaffHairStyleMap : EntityTypeConfiguration<StaffHairStyle>
    {
        public StaffHairStyleMap()
        {
            // Primary Key
            HasKey(t => t.StaffHairStyleId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("StaffHairStyle");
            Property(t => t.StaffHairStyleId).HasColumnName("StaffHairStyleID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
