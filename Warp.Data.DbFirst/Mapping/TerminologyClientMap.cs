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
            this.HasKey(t => t.TerminiologyClientId);

            // Properties
            this.Property(t => t.TerminiologyClientId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ClientTerm)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TerminologyClient");
            this.Property(t => t.TerminiologyClientId).HasColumnName("TerminiologyClientID");
            this.Property(t => t.TerminologyId).HasColumnName("TerminologyID");
            this.Property(t => t.ClientId).HasColumnName("ClientID");
            this.Property(t => t.ClientTerm).HasColumnName("ClientTerm");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.TerminologyClients)
                .HasForeignKey(d => d.ClientId);
            this.HasRequired(t => t.Terminology)
                .WithMany(t => t.TerminologyClients)
                .HasForeignKey(d => d.TerminologyId);

        }
    }
}
