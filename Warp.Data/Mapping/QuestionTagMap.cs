using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class QuestionTagMap : EntityTypeConfiguration<QuestionTag>
    {
        public QuestionTagMap()
        {
            // Primary Key
            this.HasKey(t => t.QuestionTagId);

            // Properties
            this.Property(t => t.QuestionTagId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("QuestionTag");
            this.Property(t => t.QuestionTagId).HasColumnName("QuestionTagID");
            this.Property(t => t.QuestionId).HasColumnName("QuestionID");
            this.Property(t => t.TagId).HasColumnName("TagID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Question)
                .WithMany(t => t.QuestionTags)
                .HasForeignKey(d => d.QuestionId);
            this.HasRequired(t => t.Tag)
                .WithMany(t => t.QuestionTags)
                .HasForeignKey(d => d.TagId);

        }
    }
}
