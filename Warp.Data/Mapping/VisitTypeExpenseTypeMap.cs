using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class VisitTypeExpenseTypeMap : EntityTypeConfiguration<VisitTypeExpenseType>
    {
        public VisitTypeExpenseTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.VisitTypeExpenseTypeId);

            // Properties
            this.Property(t => t.VisitTypeExpenseTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VisitTypeExpenseType");
            this.Property(t => t.VisitTypeExpenseTypeId).HasColumnName("VisitTypeExpenseTypeID");
            this.Property(t => t.VisitTypeId).HasColumnName("VisitTypeID");
            this.Property(t => t.ExpenseTypeId).HasColumnName("ExpenseTypeID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.ExpenseType)
                .WithMany(t => t.VisitTypeExpenseTypes)
                .HasForeignKey(d => d.ExpenseTypeId);
            this.HasRequired(t => t.VisitType)
                .WithMany(t => t.VisitTypeExpenseTypes)
                .HasForeignKey(d => d.VisitTypeId);

        }
    }
}
