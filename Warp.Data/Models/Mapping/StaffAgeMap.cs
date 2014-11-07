using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class StaffAgeMap : EntityTypeConfiguration<StaffAge>
    {
        public StaffAgeMap()
        {
            // Primary Key
            this.HasKey(t => t.StaffAgeID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("StaffAge");
            this.Property(t => t.StaffAgeID).HasColumnName("StaffAgeID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
