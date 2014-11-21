using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ClientQuestionnaireMap : EntityTypeConfiguration<ClientQuestionnaire>
    {
        public ClientQuestionnaireMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientQuestionnaireId);

            // Properties
            this.Property(t => t.ClientQuestionnaireId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ClientQuestionnaire");
            this.Property(t => t.ClientQuestionnaireId).HasColumnName("ClientQuestionnaireID");
            this.Property(t => t.ClientId).HasColumnName("ClientID");
            this.Property(t => t.QuestionnaireId).HasColumnName("QuestionnaireID");
            this.Property(t => t.Permission).HasColumnName("Permission");
            this.Property(t => t.SubQuestionnaireId).HasColumnName("SubQuestionnaireID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.ClientQuestionnaires)
                .HasForeignKey(d => d.ClientId);
            this.HasRequired(t => t.Questionnaire)
                .WithMany(t => t.ClientQuestionnaires)
                .HasForeignKey(d => d.QuestionnaireId);
            this.HasRequired(t => t.SubQuestionnaire)
                .WithMany(t => t.ClientQuestionnaires)
                .HasForeignKey(d => d.SubQuestionnaireId);

        }
    }
}
