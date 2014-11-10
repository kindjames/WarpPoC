using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class PersonAreaMap : EntityTypeConfiguration<PersonArea>
    {
        public PersonAreaMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonAreaID);

            // Properties
            // Table & Column Mappings
            this.ToTable("PersonArea", "Client");
            this.Property(t => t.PersonAreaID).HasColumnName("PersonAreaID");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.AreaID).HasColumnName("AreaID");
            this.Property(t => t.PermissionTypeID).HasColumnName("PermissionTypeID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.Area)
                .WithMany(t => t.PersonAreas)
                .HasForeignKey(d => d.AreaID);
            this.HasOptional(t => t.PermissionType)
                .WithMany(t => t.PersonAreas)
                .HasForeignKey(d => d.PermissionTypeID);
            this.HasRequired(t => t.Person)
                .WithMany(t => t.PersonAreas)
                .HasForeignKey(d => d.PersonID);

        }
    }
}
