using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class TerminologyClientMap : EntityTypeConfiguration<TerminologyClient>
    {
        public TerminologyClientMap()
        {
            // Primary Key
            HasKey(t => t.TerminiologyClientId);

            // Properties
            Property(t => t.TerminiologyClientId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.ClientTerm)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("TerminologyClient");
            Property(t => t.TerminiologyClientId).HasColumnName("TerminiologyClientID");
            Property(t => t.TerminologyId).HasColumnName("TerminologyID");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.ClientTerm).HasColumnName("ClientTerm");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Client)
                .WithMany(t => t.TerminologyClients)
                .HasForeignKey(d => d.ClientId);
            HasRequired(t => t.Terminology)
                .WithMany(t => t.TerminologyClients)
                .HasForeignKey(d => d.TerminologyId);

        }
    }
}
