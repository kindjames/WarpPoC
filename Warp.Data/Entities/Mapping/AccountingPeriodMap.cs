using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class AccountingPeriodMap : EntityTypeConfiguration<AccountingPeriod>
    {
        public AccountingPeriodMap()
        {
            // Primary Key
            this.HasKey(t => t.AccountingPeriodID);

            // Properties
            this.Property(t => t.AccountingPeriodID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PeriodName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AccountingPeriod");
            this.Property(t => t.AccountingPeriodID).HasColumnName("AccountingPeriodID");
            this.Property(t => t.PeriodName).HasColumnName("PeriodName");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.CreatedByAdminID).HasColumnName("CreatedByAdminID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.AccountingPeriods)
                .HasForeignKey(d => d.ClientID);

        }
    }
}
