using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class BriefClientMap : EntityTypeConfiguration<BriefClient>
    {
        public BriefClientMap()
        {
            // Primary Key
            this.HasKey(t => t.BriefClientID);

            // Properties
            this.Property(t => t.BriefClientID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BriefClient");
            this.Property(t => t.BriefClientID).HasColumnName("BriefClientID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.BriefID).HasColumnName("BriefID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.BriefClients)
                .HasForeignKey(d => d.ClientID);
            this.HasRequired(t => t.Brief)
                .WithMany(t => t.BriefClients)
                .HasForeignKey(d => d.BriefID);

        }
    }
}
