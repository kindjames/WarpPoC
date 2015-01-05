using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BanClientMap : EntityTypeConfiguration<BanClient>
    {
        public BanClientMap()
        {
            // Primary Key
            HasKey(t => t.BanClientId);

            // Properties
            Property(t => t.BanClientId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("BanClient");
            Property(t => t.BanClientId).HasColumnName("BanClientID");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.AssessorId).HasColumnName("AssessorID");
            Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Client)
                .WithMany(t => t.BanClients)
                .HasForeignKey(d => d.ClientId);
            HasRequired(t => t.Assessor)
                .WithMany(t => t.BanClients)
                .HasForeignKey(d => d.AssessorId);

        }
    }
}
