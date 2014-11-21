using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class StaffHairColourMap : EntityTypeConfiguration<StaffHairColour>
    {
        public StaffHairColourMap()
        {
            // Primary Key
            this.HasKey(t => t.StaffHairColourId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("StaffHairColour");
            this.Property(t => t.StaffHairColourId).HasColumnName("StaffHairColourID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
