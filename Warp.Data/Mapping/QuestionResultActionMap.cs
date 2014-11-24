using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class QuestionResultActionMap : EntityTypeConfiguration<QuestionResultAction>
    {
        public QuestionResultActionMap()
        {
            // Primary Key
            this.HasKey(t => t.QuestionResultActionId);

            // Properties
            this.Property(t => t.QuestionResultActionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("QuestionResultAction");
            this.Property(t => t.QuestionResultActionId).HasColumnName("QuestionResultActionID");
            this.Property(t => t.QuestionResultId).HasColumnName("QuestionResultID");
            this.Property(t => t.ActionId).HasColumnName("ActionID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Action)
                .WithMany(t => t.QuestionResultActions)
                .HasForeignKey(d => d.ActionId);
            this.HasRequired(t => t.QuestionResult)
                .WithMany(t => t.QuestionResultActions)
                .HasForeignKey(d => d.QuestionResultId);

        }
    }
}
