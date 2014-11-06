using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class PeriodClientMap : EntityTypeConfiguration<PeriodClient>
    {
        public PeriodClientMap()
        {
            // Primary Key
            this.HasKey(t => t.PeriodClientID);

            // Properties
            this.Property(t => t.PeriodClientID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PeriodClient");
            this.Property(t => t.PeriodClientID).HasColumnName("PeriodClientID");
            this.Property(t => t.PeriodID).HasColumnName("PeriodID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.PeriodClients)
                .HasForeignKey(d => d.ClientID);
            this.HasRequired(t => t.Period)
                .WithMany(t => t.PeriodClients)
                .HasForeignKey(d => d.PeriodID);

        }
    }
}
