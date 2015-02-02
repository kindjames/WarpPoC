using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AssessorExpenseHistoryMap : EntityTypeConfiguration<AssessorExpenseHistory>
    {
        public AssessorExpenseHistoryMap()
        {
            // Primary Key
            HasKey(t => t.AssessorExpenseHistoryId);

            // Properties
            Property(t => t.AssessorExpenseHistoryId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("AssessorExpenseHistory");
            Property(t => t.AssessorExpenseHistoryId).HasColumnName("AssessorExpenseHistoryID");
            Property(t => t.AssessorExpenseId).HasColumnName("AssessorExpenseID");
            Property(t => t.AdminId).HasColumnName("AdminID");
            Property(t => t.ExpenseStatusId).HasColumnName("ExpenseStatusID");
            Property(t => t.ApprovedAmount).HasColumnName("ApprovedAmount");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.AssessorExpense)
                .WithMany(t => t.AssessorExpenseHistories)
                .HasForeignKey(d => d.AssessorExpenseId);
            HasRequired(t => t.ExpenseStatus)
                .WithMany(t => t.AssessorExpenseHistories)
                .HasForeignKey(d => d.ExpenseStatusId);

        }
    }
}
