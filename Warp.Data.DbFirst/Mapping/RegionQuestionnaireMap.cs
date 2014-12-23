using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class RegionQuestionnaireMap : EntityTypeConfiguration<RegionQuestionnaire>
    {
        public RegionQuestionnaireMap()
        {
            // Primary Key
            HasKey(t => t.RegionQuestionnaireId);

            // Properties
            Property(t => t.RegionQuestionnaireId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("RegionQuestionnaire");
            Property(t => t.RegionQuestionnaireId).HasColumnName("RegionQuestionnaireID");
            Property(t => t.RegionId).HasColumnName("RegionID");
            Property(t => t.QuestionnaireId).HasColumnName("QuestionnaireID");
            Property(t => t.Permission).HasColumnName("Permission");
            Property(t => t.SubQuestionnaireId).HasColumnName("SubQuestionnaireID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Region)
                .WithMany(t => t.RegionQuestionnaires)
                .HasForeignKey(d => d.RegionId);
            HasRequired(t => t.Questionnaire)
                .WithMany(t => t.RegionQuestionnaires)
                .HasForeignKey(d => d.QuestionnaireId);
            HasRequired(t => t.SubQuestionnaire)
                .WithMany(t => t.RegionQuestionnaires)
                .HasForeignKey(d => d.SubQuestionnaireId);

        }
    }
}
