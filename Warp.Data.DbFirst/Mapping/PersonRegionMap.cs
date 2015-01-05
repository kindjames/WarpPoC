using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PersonRegionMap : EntityTypeConfiguration<PersonRegion>
    {
        public PersonRegionMap()
        {
            // Primary Key
            HasKey(t => t.PersonRegionId);

            // Properties
            // Table & Column Mappings
            ToTable("PersonRegion", "Client");
            Property(t => t.PersonRegionId).HasColumnName("PersonRegionID");
            Property(t => t.PersonId).HasColumnName("PersonID");
            Property(t => t.RegionId).HasColumnName("RegionID");
            Property(t => t.PermissionTypeId).HasColumnName("PermissionTypeID");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            HasOptional(t => t.PermissionType)
                .WithMany(t => t.PersonRegions)
                .HasForeignKey(d => d.PermissionTypeId);
            HasRequired(t => t.Person)
                .WithMany(t => t.PersonRegions)
                .HasForeignKey(d => d.PersonId);
            HasRequired(t => t.Region)
                .WithMany(t => t.PersonRegions)
                .HasForeignKey(d => d.RegionId);

        }
    }
}
