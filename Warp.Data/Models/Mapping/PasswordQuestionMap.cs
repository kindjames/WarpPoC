using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class PasswordQuestionMap : EntityTypeConfiguration<PasswordQuestion>
    {
        public PasswordQuestionMap()
        {
            // Primary Key
            this.HasKey(t => t.PasswordQuestionID);

            // Properties
            this.Property(t => t.Question)
                .IsRequired()
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("PasswordQuestion");
            this.Property(t => t.PasswordQuestionID).HasColumnName("PasswordQuestionID");
            this.Property(t => t.Question).HasColumnName("Question");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
