using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class AreaQuestionnaireMap : EntityTypeConfiguration<AreaQuestionnaire>
    {
        public AreaQuestionnaireMap()
        {
            // Primary Key
            this.HasKey(t => t.AreaQuestionnaireID);

            // Properties
            this.Property(t => t.AreaQuestionnaireID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AreaQuestionnaire");
            this.Property(t => t.AreaQuestionnaireID).HasColumnName("AreaQuestionnaireID");
            this.Property(t => t.AreaID).HasColumnName("AreaID");
            this.Property(t => t.QuestionnaireID).HasColumnName("QuestionnaireID");
            this.Property(t => t.Permission).HasColumnName("Permission");
            this.Property(t => t.SubQuestionnaireID).HasColumnName("SubQuestionnaireID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Questionnaire)
                .WithMany(t => t.AreaQuestionnaires)
                .HasForeignKey(d => d.QuestionnaireID);
            this.HasRequired(t => t.SubQuestionnaire)
                .WithMany(t => t.AreaQuestionnaires)
                .HasForeignKey(d => d.SubQuestionnaireID);

        }
    }
}
