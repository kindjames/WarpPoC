using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BriefClientMap : EntityTypeConfiguration<BriefClient>
    {
        public BriefClientMap()
        {
            // Primary Key
            HasKey(t => t.BriefClientId);

            // Properties
            Property(t => t.BriefClientId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("BriefClient");
            Property(t => t.BriefClientId).HasColumnName("BriefClientID");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.BriefId).HasColumnName("BriefID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Client)
                .WithMany(t => t.BriefClients)
                .HasForeignKey(d => d.ClientId);
            HasRequired(t => t.Brief)
                .WithMany(t => t.BriefClients)
                .HasForeignKey(d => d.BriefId);

        }
    }
}
