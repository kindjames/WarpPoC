using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class QuestionTypeMap : EntityTypeConfiguration<QuestionType>
    {
        public QuestionTypeMap()
        {
            // Primary Key
            HasKey(t => t.QuestionTypeId);

            // Properties
            Property(t => t.QuestionTypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Value)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("QuestionType");
            Property(t => t.QuestionTypeId).HasColumnName("QuestionTypeID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Value).HasColumnName("Value");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
