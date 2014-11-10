using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class StaffClothingColourMap : EntityTypeConfiguration<StaffClothingColour>
    {
        public StaffClothingColourMap()
        {
            // Primary Key
            this.HasKey(t => t.StaffClothingColourID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("StaffClothingColour");
            this.Property(t => t.StaffClothingColourID).HasColumnName("StaffClothingColourID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
