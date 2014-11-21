using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class PersonRegionMap : EntityTypeConfiguration<PersonRegion>
    {
        public PersonRegionMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonRegionId);

            // Properties
            // Table & Column Mappings
            this.ToTable("PersonRegion", "Client");
            this.Property(t => t.PersonRegionId).HasColumnName("PersonRegionID");
            this.Property(t => t.PersonId).HasColumnName("PersonID");
            this.Property(t => t.RegionId).HasColumnName("RegionID");
            this.Property(t => t.PermissionTypeId).HasColumnName("PermissionTypeID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasOptional(t => t.PermissionType)
                .WithMany(t => t.PersonRegions)
                .HasForeignKey(d => d.PermissionTypeId);
            this.HasRequired(t => t.Person)
                .WithMany(t => t.PersonRegions)
                .HasForeignKey(d => d.PersonId);
            this.HasRequired(t => t.Region)
                .WithMany(t => t.PersonRegions)
                .HasForeignKey(d => d.RegionId);

        }
    }
}
