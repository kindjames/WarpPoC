using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class QuestionDepartmentMap : EntityTypeConfiguration<QuestionDepartment>
    {
        public QuestionDepartmentMap()
        {
            // Primary Key
            HasKey(t => t.QuestionDepartmentId);

            // Properties
            Property(t => t.QuestionDepartmentId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("QuestionDepartment");
            Property(t => t.QuestionDepartmentId).HasColumnName("QuestionDepartmentID");
            Property(t => t.Title).HasColumnName("Title");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
