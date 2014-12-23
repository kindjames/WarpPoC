using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PersonAreaMap : EntityTypeConfiguration<PersonArea>
    {
        public PersonAreaMap()
        {
            // Primary Key
            HasKey(t => t.PersonAreaId);

            // Properties
            // Table & Column Mappings
            ToTable("PersonArea", "Client");
            Property(t => t.PersonAreaId).HasColumnName("PersonAreaID");
            Property(t => t.PersonId).HasColumnName("PersonID");
            Property(t => t.AreaId).HasColumnName("AreaID");
            Property(t => t.PermissionTypeId).HasColumnName("PermissionTypeID");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            HasRequired(t => t.Area)
                .WithMany(t => t.PersonAreas)
                .HasForeignKey(d => d.AreaId);
            HasOptional(t => t.PermissionType)
                .WithMany(t => t.PersonAreas)
                .HasForeignKey(d => d.PermissionTypeId);
            HasRequired(t => t.Person)
                .WithMany(t => t.PersonAreas)
                .HasForeignKey(d => d.PersonId);

        }
    }
}
