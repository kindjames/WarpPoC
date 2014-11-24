using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class AreaQuestionnaireMap : EntityTypeConfiguration<AreaQuestionnaire>
    {
        public AreaQuestionnaireMap()
        {
            // Primary Key
            this.HasKey(t => t.AreaQuestionnaireId);

            // Properties
            this.Property(t => t.AreaQuestionnaireId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AreaQuestionnaire");
            this.Property(t => t.AreaQuestionnaireId).HasColumnName("AreaQuestionnaireID");
            this.Property(t => t.AreaId).HasColumnName("AreaID");
            this.Property(t => t.QuestionnaireId).HasColumnName("QuestionnaireID");
            this.Property(t => t.Permission).HasColumnName("Permission");
            this.Property(t => t.SubQuestionnaireId).HasColumnName("SubQuestionnaireID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Questionnaire)
                .WithMany(t => t.AreaQuestionnaires)
                .HasForeignKey(d => d.QuestionnaireId);
            this.HasRequired(t => t.SubQuestionnaire)
                .WithMany(t => t.AreaQuestionnaires)
                .HasForeignKey(d => d.SubQuestionnaireId);

        }
    }
}
