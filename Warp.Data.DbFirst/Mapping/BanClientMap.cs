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
            this.HasKey(t => t.BanClientId);

            // Properties
            this.Property(t => t.BanClientId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BanClient");
            this.Property(t => t.BanClientId).HasColumnName("BanClientID");
            this.Property(t => t.ClientId).HasColumnName("ClientID");
            this.Property(t => t.AssessorId).HasColumnName("AssessorID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.BanClients)
                .HasForeignKey(d => d.ClientId);
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.BanClients)
                .HasForeignKey(d => d.AssessorId);

        }
    }
}
