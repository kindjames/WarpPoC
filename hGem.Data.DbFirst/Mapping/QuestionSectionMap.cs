using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class QuestionSectionMap : EntityTypeConfiguration<QuestionSection>
    {
        public QuestionSectionMap()
        {
            // Primary Key
            HasKey(t => t.QuestionSectionId);

            // Properties
            Property(t => t.QuestionSectionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("QuestionSection");
            Property(t => t.QuestionSectionId).HasColumnName("QuestionSectionID");
            Property(t => t.Title).HasColumnName("Title");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
