using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class PersonClientMap : EntityTypeConfiguration<PersonClient>
    {
        public PersonClientMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonClientId);

            // Properties
            // Table & Column Mappings
            this.ToTable("PersonClient", "Client");
            this.Property(t => t.PersonClientId).HasColumnName("PersonClientID");
            this.Property(t => t.PersonId).HasColumnName("PersonID");
            this.Property(t => t.ClientId).HasColumnName("ClientID");
            this.Property(t => t.PermissionTypeId).HasColumnName("PermissionTypeID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.PersonClients)
                .HasForeignKey(d => d.ClientId);
            this.HasOptional(t => t.PermissionType)
                .WithMany(t => t.PersonClients)
                .HasForeignKey(d => d.PermissionTypeId);
            this.HasRequired(t => t.Person)
                .WithMany(t => t.PersonClients)
                .HasForeignKey(d => d.PersonId);

        }
    }
}
