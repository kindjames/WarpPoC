using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class QuestionDepartmentMap : EntityTypeConfiguration<QuestionDepartment>
    {
        public QuestionDepartmentMap()
        {
            // Primary Key
            this.HasKey(t => t.QuestionDepartmentId);

            // Properties
            this.Property(t => t.QuestionDepartmentId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("QuestionDepartment");
            this.Property(t => t.QuestionDepartmentId).HasColumnName("QuestionDepartmentID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
