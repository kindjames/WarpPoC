using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class QuestionSectionMap : EntityTypeConfiguration<QuestionSection>
    {
        public QuestionSectionMap()
        {
            // Primary Key
            this.HasKey(t => t.QuestionSectionId);

            // Properties
            this.Property(t => t.QuestionSectionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("QuestionSection");
            this.Property(t => t.QuestionSectionId).HasColumnName("QuestionSectionID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
