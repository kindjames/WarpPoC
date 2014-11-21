using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class AssessorExpenseHistoryMap : EntityTypeConfiguration<AssessorExpenseHistory>
    {
        public AssessorExpenseHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessorExpenseHistoryId);

            // Properties
            this.Property(t => t.AssessorExpenseHistoryId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AssessorExpenseHistory");
            this.Property(t => t.AssessorExpenseHistoryId).HasColumnName("AssessorExpenseHistoryID");
            this.Property(t => t.AssessorExpenseId).HasColumnName("AssessorExpenseID");
            this.Property(t => t.AdminId).HasColumnName("AdminID");
            this.Property(t => t.ExpenseStatusId).HasColumnName("ExpenseStatusID");
            this.Property(t => t.ApprovedAmount).HasColumnName("ApprovedAmount");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.AssessorExpense)
                .WithMany(t => t.AssessorExpenseHistories)
                .HasForeignKey(d => d.AssessorExpenseId);
            this.HasRequired(t => t.ExpenseStatu)
                .WithMany(t => t.AssessorExpenseHistories)
                .HasForeignKey(d => d.ExpenseStatusId);

        }
    }
}
