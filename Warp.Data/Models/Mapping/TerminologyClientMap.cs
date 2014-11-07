using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class TerminologyClientMap : EntityTypeConfiguration<TerminologyClient>
    {
        public TerminologyClientMap()
        {
            // Primary Key
            this.HasKey(t => t.TerminiologyClientID);

            // Properties
            this.Property(t => t.TerminiologyClientID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ClientTerm)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TerminologyClient");
            this.Property(t => t.TerminiologyClientID).HasColumnName("TerminiologyClientID");
            this.Property(t => t.TerminologyID).HasColumnName("TerminologyID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.ClientTerm).HasColumnName("ClientTerm");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.TerminologyClients)
                .HasForeignKey(d => d.ClientID);
            this.HasRequired(t => t.Terminology)
                .WithMany(t => t.TerminologyClients)
                .HasForeignKey(d => d.TerminologyID);

        }
    }
}
