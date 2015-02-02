using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class VisitTypeExpenseTypeMap : EntityTypeConfiguration<VisitTypeExpenseType>
    {
        public VisitTypeExpenseTypeMap()
        {
            // Primary Key
            HasKey(t => t.VisitTypeExpenseTypeId);

            // Properties
            Property(t => t.VisitTypeExpenseTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("VisitTypeExpenseType");
            Property(t => t.VisitTypeExpenseTypeId).HasColumnName("VisitTypeExpenseTypeID");
            Property(t => t.VisitTypeId).HasColumnName("VisitTypeID");
            Property(t => t.ExpenseTypeId).HasColumnName("ExpenseTypeID");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.ExpenseType)
                .WithMany(t => t.VisitTypeExpenseTypes)
                .HasForeignKey(d => d.ExpenseTypeId);
            HasRequired(t => t.VisitType)
                .WithMany(t => t.VisitTypeExpenseTypes)
                .HasForeignKey(d => d.VisitTypeId);

        }
    }
}
