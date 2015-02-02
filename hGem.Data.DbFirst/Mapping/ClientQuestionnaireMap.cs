using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ClientQuestionnaireMap : EntityTypeConfiguration<ClientQuestionnaire>
    {
        public ClientQuestionnaireMap()
        {
            // Primary Key
            HasKey(t => t.ClientQuestionnaireId);

            // Properties
            Property(t => t.ClientQuestionnaireId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("ClientQuestionnaire");
            Property(t => t.ClientQuestionnaireId).HasColumnName("ClientQuestionnaireID");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.QuestionnaireId).HasColumnName("QuestionnaireID");
            Property(t => t.Permission).HasColumnName("Permission");
            Property(t => t.SubQuestionnaireId).HasColumnName("SubQuestionnaireID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Client)
                .WithMany(t => t.ClientQuestionnaires)
                .HasForeignKey(d => d.ClientId);
            HasRequired(t => t.Questionnaire)
                .WithMany(t => t.ClientQuestionnaires)
                .HasForeignKey(d => d.QuestionnaireId);
            HasRequired(t => t.SubQuestionnaire)
                .WithMany(t => t.ClientQuestionnaires)
                .HasForeignKey(d => d.SubQuestionnaireId);

        }
    }
}
