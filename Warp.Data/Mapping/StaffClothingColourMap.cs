using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class StaffClothingColourMap : EntityTypeConfiguration<StaffClothingColour>
    {
        public StaffClothingColourMap()
        {
            // Primary Key
            this.HasKey(t => t.StaffClothingColourId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("StaffClothingColour");
            this.Property(t => t.StaffClothingColourId).HasColumnName("StaffClothingColourID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
