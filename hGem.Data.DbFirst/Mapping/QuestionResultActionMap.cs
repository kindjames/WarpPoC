using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class QuestionResultActionMap : EntityTypeConfiguration<QuestionResultAction>
    {
        public QuestionResultActionMap()
        {
            // Primary Key
            HasKey(t => t.QuestionResultActionId);

            // Properties
            Property(t => t.QuestionResultActionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("QuestionResultAction");
            Property(t => t.QuestionResultActionId).HasColumnName("QuestionResultActionID");
            Property(t => t.QuestionResultId).HasColumnName("QuestionResultID");
            Property(t => t.ActionId).HasColumnName("ActionID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Action)
                .WithMany(t => t.QuestionResultActions)
                .HasForeignKey(d => d.ActionId);
            HasRequired(t => t.QuestionResult)
                .WithMany(t => t.QuestionResultActions)
                .HasForeignKey(d => d.QuestionResultId);

        }
    }
}
