using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class PersonRegionMap : EntityTypeConfiguration<PersonRegion>
    {
        public PersonRegionMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonRegionID);

            // Properties
            // Table & Column Mappings
            this.ToTable("PersonRegion", "Client");
            this.Property(t => t.PersonRegionID).HasColumnName("PersonRegionID");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.RegionID).HasColumnName("RegionID");
            this.Property(t => t.PermissionTypeID).HasColumnName("PermissionTypeID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasOptional(t => t.PermissionType)
                .WithMany(t => t.PersonRegions)
                .HasForeignKey(d => d.PermissionTypeID);
            this.HasRequired(t => t.Person)
                .WithMany(t => t.PersonRegions)
                .HasForeignKey(d => d.PersonID);
            this.HasRequired(t => t.Region)
                .WithMany(t => t.PersonRegions)
                .HasForeignKey(d => d.RegionID);

        }
    }
}
