using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AreaQuestionnaireMap : EntityTypeConfiguration<AreaQuestionnaire>
    {
        public AreaQuestionnaireMap()
        {
            // Primary Key
            HasKey(t => t.AreaQuestionnaireId);

            // Properties
            Property(t => t.AreaQuestionnaireId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("AreaQuestionnaire");
            Property(t => t.AreaQuestionnaireId).HasColumnName("AreaQuestionnaireID");
            Property(t => t.AreaId).HasColumnName("AreaID");
            Property(t => t.QuestionnaireId).HasColumnName("QuestionnaireID");
            Property(t => t.Permission).HasColumnName("Permission");
            Property(t => t.SubQuestionnaireId).HasColumnName("SubQuestionnaireID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Questionnaire)
                .WithMany(t => t.AreaQuestionnaires)
                .HasForeignKey(d => d.QuestionnaireId);
            HasRequired(t => t.SubQuestionnaire)
                .WithMany(t => t.AreaQuestionnaires)
                .HasForeignKey(d => d.SubQuestionnaireId);

        }
    }
}
