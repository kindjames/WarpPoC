using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class PersonRegionMap : EntityTypeConfiguration<PersonRegion>
    {
        public PersonRegionMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonRegionID);

            // Properties
            this.Property(t => t.PersonRegionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PersonRegion");
            this.Property(t => t.PersonRegionID).HasColumnName("PersonRegionID");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.RegionID).HasColumnName("RegionID");

            // Relationships
            this.HasRequired(t => t.Region)
                .WithMany(t => t.PersonRegions)
                .HasForeignKey(d => d.RegionID);

        }
    }
}
