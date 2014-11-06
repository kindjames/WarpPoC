using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ClientQuestionnaireMap : EntityTypeConfiguration<ClientQuestionnaire>
    {
        public ClientQuestionnaireMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientQuestionnaireID);

            // Properties
            this.Property(t => t.ClientQuestionnaireID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ClientQuestionnaire");
            this.Property(t => t.ClientQuestionnaireID).HasColumnName("ClientQuestionnaireID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.QuestionnaireID).HasColumnName("QuestionnaireID");
            this.Property(t => t.Permission).HasColumnName("Permission");
            this.Property(t => t.SubQuestionnaireID).HasColumnName("SubQuestionnaireID");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.ClientQuestionnaires)
                .HasForeignKey(d => d.ClientID);
            this.HasRequired(t => t.Questionnaire)
                .WithMany(t => t.ClientQuestionnaires)
                .HasForeignKey(d => d.QuestionnaireID);
            this.HasRequired(t => t.SubQuestionnaire)
                .WithMany(t => t.ClientQuestionnaires)
                .HasForeignKey(d => d.SubQuestionnaireID);

        }
    }
}
