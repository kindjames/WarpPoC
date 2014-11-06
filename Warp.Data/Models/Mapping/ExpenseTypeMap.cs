using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ExpenseTypeMap : EntityTypeConfiguration<ExpenseType>
    {
        public ExpenseTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ExpenseTypeID);

            // Properties
            this.Property(t => t.ExpenseTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ExpenseType");
            this.Property(t => t.ExpenseTypeID).HasColumnName("ExpenseTypeID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
