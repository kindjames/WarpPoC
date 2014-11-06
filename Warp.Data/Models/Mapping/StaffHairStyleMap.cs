using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class StaffHairStyleMap : EntityTypeConfiguration<StaffHairStyle>
    {
        public StaffHairStyleMap()
        {
            // Primary Key
            this.HasKey(t => t.StaffHairStyleID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("StaffHairStyle");
            this.Property(t => t.StaffHairStyleID).HasColumnName("StaffHairStyleID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
