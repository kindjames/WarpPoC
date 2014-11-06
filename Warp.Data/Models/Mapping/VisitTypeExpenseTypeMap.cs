using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class VisitTypeExpenseTypeMap : EntityTypeConfiguration<VisitTypeExpenseType>
    {
        public VisitTypeExpenseTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.VisitTypeExpenseTypeID);

            // Properties
            this.Property(t => t.VisitTypeExpenseTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VisitTypeExpenseType");
            this.Property(t => t.VisitTypeExpenseTypeID).HasColumnName("VisitTypeExpenseTypeID");
            this.Property(t => t.VisitTypeID).HasColumnName("VisitTypeID");
            this.Property(t => t.ExpenseTypeID).HasColumnName("ExpenseTypeID");

            // Relationships
            this.HasRequired(t => t.ExpenseType)
                .WithMany(t => t.VisitTypeExpenseTypes)
                .HasForeignKey(d => d.ExpenseTypeID);
            this.HasRequired(t => t.VisitType)
                .WithMany(t => t.VisitTypeExpenseTypes)
                .HasForeignKey(d => d.VisitTypeID);

        }
    }
}
