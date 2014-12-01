using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PersonAreaMap : EntityTypeConfiguration<PersonArea>
    {
        public PersonAreaMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonAreaId);

            // Properties
            // Table & Column Mappings
            this.ToTable("PersonArea", "Client");
            this.Property(t => t.PersonAreaId).HasColumnName("PersonAreaID");
            this.Property(t => t.PersonId).HasColumnName("PersonID");
            this.Property(t => t.AreaId).HasColumnName("AreaID");
            this.Property(t => t.PermissionTypeId).HasColumnName("PermissionTypeID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.Area)
                .WithMany(t => t.PersonAreas)
                .HasForeignKey(d => d.AreaId);
            this.HasOptional(t => t.PermissionType)
                .WithMany(t => t.PersonAreas)
                .HasForeignKey(d => d.PermissionTypeId);
            this.HasRequired(t => t.Person)
                .WithMany(t => t.PersonAreas)
                .HasForeignKey(d => d.PersonId);

        }
    }
}
