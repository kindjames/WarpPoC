using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class AssessorExpenseHistoryMap : EntityTypeConfiguration<AssessorExpenseHistory>
    {
        public AssessorExpenseHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessorExpenseHistoryID);

            // Properties
            this.Property(t => t.AssessorExpenseHistoryID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AssessorExpenseHistory");
            this.Property(t => t.AssessorExpenseHistoryID).HasColumnName("AssessorExpenseHistoryID");
            this.Property(t => t.AssessorExpenseID).HasColumnName("AssessorExpenseID");
            this.Property(t => t.AdminID).HasColumnName("AdminID");
            this.Property(t => t.TimeStamp).HasColumnName("TimeStamp");
            this.Property(t => t.ExpenseStatusID).HasColumnName("ExpenseStatusID");
            this.Property(t => t.ApprovedAmount).HasColumnName("ApprovedAmount");

            // Relationships
            this.HasRequired(t => t.AssessorExpense)
                .WithMany(t => t.AssessorExpenseHistories)
                .HasForeignKey(d => d.AssessorExpenseID);
            this.HasRequired(t => t.ExpenseStatu)
                .WithMany(t => t.AssessorExpenseHistories)
                .HasForeignKey(d => d.ExpenseStatusID);

        }
    }
}
