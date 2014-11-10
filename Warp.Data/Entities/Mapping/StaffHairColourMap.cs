using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class StaffHairColourMap : EntityTypeConfiguration<StaffHairColour>
    {
        public StaffHairColourMap()
        {
            // Primary Key
            this.HasKey(t => t.StaffHairColourID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("StaffHairColour");
            this.Property(t => t.StaffHairColourID).HasColumnName("StaffHairColourID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
