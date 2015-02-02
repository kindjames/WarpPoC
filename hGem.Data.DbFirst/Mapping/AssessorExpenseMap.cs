using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AssessorExpenseMap : EntityTypeConfiguration<AssessorExpense>
    {
        public AssessorExpenseMap()
        {
            // Primary Key
            HasKey(t => t.AssessorExpenseId);

            // Properties
            Property(t => t.AssessorExpenseId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("AssessorExpense");
            Property(t => t.AssessorExpenseId).HasColumnName("AssessorExpenseID");
            Property(t => t.VisitId).HasColumnName("VisitID");
            Property(t => t.AssessorId).HasColumnName("AssessorID");
            Property(t => t.ExpenseTypeId).HasColumnName("ExpenseTypeID");
            Property(t => t.ClaimedAmount).HasColumnName("ClaimedAmount");
            Property(t => t.CurrencyId).HasColumnName("CurrencyID");
            Property(t => t.CurrencyExchangeRateId).HasColumnName("CurrencyExchangeRateID");
            Property(t => t.CurrentExpenseStatusId).HasColumnName("CurrentExpenseStatusID");
            Property(t => t.ApprovedAmount).HasColumnName("ApprovedAmount");
            Property(t => t.DateApproved).HasColumnName("DateApproved");
            Property(t => t.ApproveByAdminId).HasColumnName("ApproveByAdminID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Currency)
                .WithMany(t => t.AssessorExpenses)
                .HasForeignKey(d => d.CurrencyId);
            HasRequired(t => t.Assessor)
                .WithMany(t => t.AssessorExpenses)
                .HasForeignKey(d => d.AssessorId);
            HasRequired(t => t.ExpenseStatus)
                .WithMany(t => t.AssessorExpenses)
                .HasForeignKey(d => d.CurrentExpenseStatusId);
            HasRequired(t => t.ExpenseType)
                .WithMany(t => t.AssessorExpenses)
                .HasForeignKey(d => d.ExpenseTypeId);
            HasRequired(t => t.Visit)
                .WithMany(t => t.AssessorExpenses)
                .HasForeignKey(d => d.VisitId);

        }
    }
}
