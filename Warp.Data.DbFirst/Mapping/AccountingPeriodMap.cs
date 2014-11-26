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
            this.HasKey(t => t.AccountingPeriodId);

            // Properties
            this.Property(t => t.AccountingPeriodId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PeriodName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AccountingPeriod");
            this.Property(t => t.AccountingPeriodId).HasColumnName("AccountingPeriodID");
            this.Property(t => t.PeriodName).HasColumnName("PeriodName");
            this.Property(t => t.ClientId).HasColumnName("ClientID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.CreatedByAdminId).HasColumnName("CreatedByAdminID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.AccountingPeriods)
                .HasForeignKey(d => d.ClientId);

        }
    }
}
