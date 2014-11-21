using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class StaffHairStyleMap : EntityTypeConfiguration<StaffHairStyle>
    {
        public StaffHairStyleMap()
        {
            // Primary Key
            this.HasKey(t => t.StaffHairStyleId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("StaffHairStyle");
            this.Property(t => t.StaffHairStyleId).HasColumnName("StaffHairStyleID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
