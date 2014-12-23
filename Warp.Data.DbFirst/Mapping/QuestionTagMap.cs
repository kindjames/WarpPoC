using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class QuestionTagMap : EntityTypeConfiguration<QuestionTag>
    {
        public QuestionTagMap()
        {
            // Primary Key
            HasKey(t => t.QuestionTagId);

            // Properties
            Property(t => t.QuestionTagId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("QuestionTag");
            Property(t => t.QuestionTagId).HasColumnName("QuestionTagID");
            Property(t => t.QuestionId).HasColumnName("QuestionID");
            Property(t => t.TagId).HasColumnName("TagID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Question)
                .WithMany(t => t.QuestionTags)
                .HasForeignKey(d => d.QuestionId);
            HasRequired(t => t.Tag)
                .WithMany(t => t.QuestionTags)
                .HasForeignKey(d => d.TagId);

        }
    }
}
