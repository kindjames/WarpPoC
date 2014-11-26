using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class StaffHairLengthMap : EntityTypeConfiguration<StaffHairLength>
    {
        public StaffHairLengthMap()
        {
            // Primary Key
            this.HasKey(t => t.StaffHairLengthId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("StaffHairLength");
            this.Property(t => t.StaffHairLengthId).HasColumnName("StaffHairLengthID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
