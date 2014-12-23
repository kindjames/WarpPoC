using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PersonClientMap : EntityTypeConfiguration<PersonClient>
    {
        public PersonClientMap()
        {
            // Primary Key
            HasKey(t => t.PersonClientId);

            // Properties
            // Table & Column Mappings
            ToTable("PersonClient", "Client");
            Property(t => t.PersonClientId).HasColumnName("PersonClientID");
            Property(t => t.PersonId).HasColumnName("PersonID");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.PermissionTypeId).HasColumnName("PermissionTypeID");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            HasRequired(t => t.Client)
                .WithMany(t => t.PersonClients)
                .HasForeignKey(d => d.ClientId);
            HasOptional(t => t.PermissionType)
                .WithMany(t => t.PersonClients)
                .HasForeignKey(d => d.PermissionTypeId);
            HasRequired(t => t.Person)
                .WithMany(t => t.PersonClients)
                .HasForeignKey(d => d.PersonId);

        }
    }
}
