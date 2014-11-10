using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class PersonClientMap : EntityTypeConfiguration<PersonClient>
    {
        public PersonClientMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonClientID);

            // Properties
            // Table & Column Mappings
            this.ToTable("PersonClient", "Client");
            this.Property(t => t.PersonClientID).HasColumnName("PersonClientID");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.PermissionTypeID).HasColumnName("PermissionTypeID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.PersonClients)
                .HasForeignKey(d => d.ClientID);
            this.HasOptional(t => t.PermissionType)
                .WithMany(t => t.PersonClients)
                .HasForeignKey(d => d.PermissionTypeID);
            this.HasRequired(t => t.Person)
                .WithMany(t => t.PersonClients)
                .HasForeignKey(d => d.PersonID);

        }
    }
}
