using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class QuestionOverwriteMap : EntityTypeConfiguration<QuestionOverwrite>
    {
        public QuestionOverwriteMap()
        {
            // Primary Key
            HasKey(t => t.QuestionOverwiteId);

            // Properties
            Property(t => t.QuestionOverwiteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Text)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("QuestionOverwrite");
            Property(t => t.QuestionOverwiteId).HasColumnName("QuestionOverwiteID");
            Property(t => t.QuestionId).HasColumnName("QuestionID");
            Property(t => t.Text).HasColumnName("Text");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
