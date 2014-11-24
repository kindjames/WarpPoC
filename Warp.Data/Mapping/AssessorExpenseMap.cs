using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class AssessorExpenseMap : EntityTypeConfiguration<AssessorExpense>
    {
        public AssessorExpenseMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessorExpenseId);

            // Properties
            this.Property(t => t.AssessorExpenseId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AssessorExpense");
            this.Property(t => t.AssessorExpenseId).HasColumnName("AssessorExpenseID");
            this.Property(t => t.VisitId).HasColumnName("VisitID");
            this.Property(t => t.AssessorId).HasColumnName("AssessorID");
            this.Property(t => t.ExpenseTypeId).HasColumnName("ExpenseTypeID");
            this.Property(t => t.ClaimedAmount).HasColumnName("ClaimedAmount");
            this.Property(t => t.CurrencyId).HasColumnName("CurrencyID");
            this.Property(t => t.CurrencyExchangeRateId).HasColumnName("CurrencyExchangeRateID");
            this.Property(t => t.CurrentExpenseStatusId).HasColumnName("CurrentExpenseStatusID");
            this.Property(t => t.ApprovedAmount).HasColumnName("ApprovedAmount");
            this.Property(t => t.DateApproved).HasColumnName("DateApproved");
            this.Property(t => t.ApproveByAdminId).HasColumnName("ApproveByAdminID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Currency)
                .WithMany(t => t.AssessorExpenses)
                .HasForeignKey(d => d.CurrencyId);
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.AssessorExpenses)
                .HasForeignKey(d => d.AssessorId);
            this.HasRequired(t => t.ExpenseStatu)
                .WithMany(t => t.AssessorExpenses)
                .HasForeignKey(d => d.CurrentExpenseStatusId);
            this.HasRequired(t => t.ExpenseType)
                .WithMany(t => t.AssessorExpenses)
                .HasForeignKey(d => d.ExpenseTypeId);
            this.HasRequired(t => t.Visit)
                .WithMany(t => t.AssessorExpenses)
                .HasForeignKey(d => d.VisitId);

        }
    }
}
