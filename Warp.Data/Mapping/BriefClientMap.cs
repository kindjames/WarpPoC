using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class BriefClientMap : EntityTypeConfiguration<BriefClient>
    {
        public BriefClientMap()
        {
            // Primary Key
            this.HasKey(t => t.BriefClientId);

            // Properties
            this.Property(t => t.BriefClientId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BriefClient");
            this.Property(t => t.BriefClientId).HasColumnName("BriefClientID");
            this.Property(t => t.ClientId).HasColumnName("ClientID");
            this.Property(t => t.BriefId).HasColumnName("BriefID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.BriefClients)
                .HasForeignKey(d => d.ClientId);
            this.HasRequired(t => t.Brief)
                .WithMany(t => t.BriefClients)
                .HasForeignKey(d => d.BriefId);

        }
    }
}
