using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class StaffHairLengthMap : EntityTypeConfiguration<StaffHairLength>
    {
        public StaffHairLengthMap()
        {
            // Primary Key
            HasKey(t => t.StaffHairLengthId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("StaffHairLength");
            Property(t => t.StaffHairLengthId).HasColumnName("StaffHairLengthID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
