using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class AssessorExpenseMap : EntityTypeConfiguration<AssessorExpense>
    {
        public AssessorExpenseMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessorExpenseID);

            // Properties
            this.Property(t => t.AssessorExpenseID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AssessorExpense");
            this.Property(t => t.AssessorExpenseID).HasColumnName("AssessorExpenseID");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");
            this.Property(t => t.VisitID).HasColumnName("VisitID");
            this.Property(t => t.AssessorID).HasColumnName("AssessorID");
            this.Property(t => t.ExpenseTypeID).HasColumnName("ExpenseTypeID");
            this.Property(t => t.ClaimedAmount).HasColumnName("ClaimedAmount");
            this.Property(t => t.CurrencyID).HasColumnName("CurrencyID");
            this.Property(t => t.CurrencyExchangeRateID).HasColumnName("CurrencyExchangeRateID");
            this.Property(t => t.CurrentExpenseStatusID).HasColumnName("CurrentExpenseStatusID");
            this.Property(t => t.ApprovedAmount).HasColumnName("ApprovedAmount");
            this.Property(t => t.ApprovedDate).HasColumnName("ApprovedDate");
            this.Property(t => t.ApproveByAdminID).HasColumnName("ApproveByAdminID");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.AssessorExpenses)
                .HasForeignKey(d => d.AssessorID);
            this.HasRequired(t => t.Currency)
                .WithMany(t => t.AssessorExpenses)
                .HasForeignKey(d => d.CurrencyID);
            this.HasRequired(t => t.ExpenseStatu)
                .WithMany(t => t.AssessorExpenses)
                .HasForeignKey(d => d.CurrentExpenseStatusID);
            this.HasRequired(t => t.ExpenseType)
                .WithMany(t => t.AssessorExpenses)
                .HasForeignKey(d => d.ExpenseTypeID);
            this.HasRequired(t => t.Visit)
                .WithMany(t => t.AssessorExpenses)
                .HasForeignKey(d => d.VisitID);

        }
    }
}
