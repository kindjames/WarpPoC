using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class PersonClientMap : EntityTypeConfiguration<PersonClient>
    {
        public PersonClientMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonClientID);

            // Properties
            // Table & Column Mappings
            this.ToTable("PersonClient");
            this.Property(t => t.PersonClientID).HasColumnName("PersonClientID");
            this.Property(t => t.PersonID).HasColumnName("PersonID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.PersonClients)
                .HasForeignKey(d => d.ClientID);

        }
    }
}
