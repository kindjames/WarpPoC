using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class StaffHeightMap : EntityTypeConfiguration<StaffHeight>
    {
        public StaffHeightMap()
        {
            // Primary Key
            this.HasKey(t => t.StaffHeightID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("StaffHeight");
            this.Property(t => t.StaffHeightID).HasColumnName("StaffHeightID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
