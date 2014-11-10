using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class QuestionTagMap : EntityTypeConfiguration<QuestionTag>
    {
        public QuestionTagMap()
        {
            // Primary Key
            this.HasKey(t => t.QuestionTagID);

            // Properties
            this.Property(t => t.QuestionTagID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("QuestionTag");
            this.Property(t => t.QuestionTagID).HasColumnName("QuestionTagID");
            this.Property(t => t.QuestionID).HasColumnName("QuestionID");
            this.Property(t => t.TagID).HasColumnName("TagID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Question)
                .WithMany(t => t.QuestionTags)
                .HasForeignKey(d => d.QuestionID);
            this.HasRequired(t => t.Tag)
                .WithMany(t => t.QuestionTags)
                .HasForeignKey(d => d.TagID);

        }
    }
}
