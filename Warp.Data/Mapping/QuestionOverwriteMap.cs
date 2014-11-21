using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class QuestionOverwriteMap : EntityTypeConfiguration<QuestionOverwrite>
    {
        public QuestionOverwriteMap()
        {
            // Primary Key
            this.HasKey(t => t.QuestionOverwiteId);

            // Properties
            this.Property(t => t.QuestionOverwiteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Text)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("QuestionOverwrite");
            this.Property(t => t.QuestionOverwiteId).HasColumnName("QuestionOverwiteID");
            this.Property(t => t.QuestionId).HasColumnName("QuestionID");
            this.Property(t => t.Text).HasColumnName("Text");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
