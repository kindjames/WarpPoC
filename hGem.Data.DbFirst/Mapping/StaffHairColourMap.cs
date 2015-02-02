using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class StaffHairColourMap : EntityTypeConfiguration<StaffHairColour>
    {
        public StaffHairColourMap()
        {
            // Primary Key
            HasKey(t => t.StaffHairColourId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("StaffHairColour");
            Property(t => t.StaffHairColourId).HasColumnName("StaffHairColourID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
