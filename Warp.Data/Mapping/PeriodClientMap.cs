using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class PeriodClientMap : EntityTypeConfiguration<PeriodClient>
    {
        public PeriodClientMap()
        {
            // Primary Key
            this.HasKey(t => t.PeriodClientId);

            // Properties
            this.Property(t => t.PeriodClientId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PeriodClient");
            this.Property(t => t.PeriodClientId).HasColumnName("PeriodClientID");
            this.Property(t => t.PeriodId).HasColumnName("PeriodID");
            this.Property(t => t.ClientId).HasColumnName("ClientID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.PeriodClients)
                .HasForeignKey(d => d.ClientId);
            this.HasRequired(t => t.Period)
                .WithMany(t => t.PeriodClients)
                .HasForeignKey(d => d.PeriodId);

        }
    }
}
