using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class Region1Map : EntityTypeConfiguration<Region1>
    {
        public Region1Map()
        {
            // Primary Key
            this.HasKey(t => t.RegionID);

            // Properties
            this.Property(t => t.RegionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Region");
            this.Property(t => t.RegionID).HasColumnName("RegionID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.AreaID).HasColumnName("AreaID");
            this.Property(t => t.RegionStatusID).HasColumnName("RegionStatusID");
            this.Property(t => t.ManagerID).HasColumnName("ManagerID");

            // Relationships
            this.HasRequired(t => t.Area1)
                .WithMany(t => t.Region1)
                .HasForeignKey(d => d.AreaID);
            this.HasRequired(t => t.RegionStatus1)
                .WithMany(t => t.Region1)
                .HasForeignKey(d => d.RegionStatusID);

        }
    }
}
