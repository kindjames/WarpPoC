using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class StaffClothingColourMap : EntityTypeConfiguration<StaffClothingColour>
    {
        public StaffClothingColourMap()
        {
            // Primary Key
            HasKey(t => t.StaffClothingColourId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("StaffClothingColour");
            Property(t => t.StaffClothingColourId).HasColumnName("StaffClothingColourID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
