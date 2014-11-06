using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class RegionStatus1Map : EntityTypeConfiguration<RegionStatus1>
    {
        public RegionStatus1Map()
        {
            // Primary Key
            this.HasKey(t => t.RegionStatusID);

            // Properties
            this.Property(t => t.RegionStatusID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("RegionStatus");
            this.Property(t => t.RegionStatusID).HasColumnName("RegionStatusID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
