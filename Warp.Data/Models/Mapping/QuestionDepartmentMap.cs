using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class QuestionDepartmentMap : EntityTypeConfiguration<QuestionDepartment>
    {
        public QuestionDepartmentMap()
        {
            // Primary Key
            this.HasKey(t => t.QuestionDepartmentID);

            // Properties
            this.Property(t => t.QuestionDepartmentID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("QuestionDepartment");
            this.Property(t => t.QuestionDepartmentID).HasColumnName("QuestionDepartmentID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
