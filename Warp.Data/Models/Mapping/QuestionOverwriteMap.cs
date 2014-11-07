using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class QuestionOverwriteMap : EntityTypeConfiguration<QuestionOverwrite>
    {
        public QuestionOverwriteMap()
        {
            // Primary Key
            this.HasKey(t => t.QuestionOverwiteID);

            // Properties
            this.Property(t => t.QuestionOverwiteID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Text)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("QuestionOverwrite");
            this.Property(t => t.QuestionOverwiteID).HasColumnName("QuestionOverwiteID");
            this.Property(t => t.QuestionID).HasColumnName("QuestionID");
            this.Property(t => t.Text).HasColumnName("Text");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
