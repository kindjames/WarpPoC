using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PeriodClientMap : EntityTypeConfiguration<PeriodClient>
    {
        public PeriodClientMap()
        {
            // Primary Key
            HasKey(t => t.PeriodClientId);

            // Properties
            Property(t => t.PeriodClientId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("PeriodClient");
            Property(t => t.PeriodClientId).HasColumnName("PeriodClientID");
            Property(t => t.PeriodId).HasColumnName("PeriodID");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Client)
                .WithMany(t => t.PeriodClients)
                .HasForeignKey(d => d.ClientId);
            HasRequired(t => t.Period)
                .WithMany(t => t.PeriodClients)
                .HasForeignKey(d => d.PeriodId);

        }
    }
}
