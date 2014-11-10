using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class QuestionResultActionMap : EntityTypeConfiguration<QuestionResultAction>
    {
        public QuestionResultActionMap()
        {
            // Primary Key
            this.HasKey(t => t.QuestionResultActionID);

            // Properties
            this.Property(t => t.QuestionResultActionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("QuestionResultAction");
            this.Property(t => t.QuestionResultActionID).HasColumnName("QuestionResultActionID");
            this.Property(t => t.QuestionResultID).HasColumnName("QuestionResultID");
            this.Property(t => t.ActionID).HasColumnName("ActionID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Action)
                .WithMany(t => t.QuestionResultActions)
                .HasForeignKey(d => d.ActionID);
            this.HasRequired(t => t.QuestionResult)
                .WithMany(t => t.QuestionResultActions)
                .HasForeignKey(d => d.QuestionResultID);

        }
    }
}
