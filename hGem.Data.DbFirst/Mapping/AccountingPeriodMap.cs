using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AccountingPeriodMap : EntityTypeConfiguration<AccountingPeriod>
    {
        public AccountingPeriodMap()
        {
            // Primary Key
            HasKey(t => t.AccountingPeriodId);

            // Properties
            Property(t => t.AccountingPeriodId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.PeriodName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("AccountingPeriod");
            Property(t => t.AccountingPeriodId).HasColumnName("AccountingPeriodID");
            Property(t => t.PeriodName).HasColumnName("PeriodName");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.CreatedByAdminId).HasColumnName("CreatedByAdminID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            HasRequired(t => t.Client)
                .WithMany(t => t.AccountingPeriods)
                .HasForeignKey(d => d.ClientId);

        }
    }
}
