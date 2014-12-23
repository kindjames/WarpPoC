using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class SubDynamicQuestionMap : EntityTypeConfiguration<SubDynamicQuestion>
    {
        public SubDynamicQuestionMap()
        {
            // Primary Key
            HasKey(t => t.SubDynamicQuestionId);

            // Properties
            Property(t => t.SubDynamicQuestionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("SubDynamicQuestion");
            Property(t => t.SubDynamicQuestionId).HasColumnName("SubDynamicQuestionID");
            Property(t => t.MasterSubQuestionnaireQuestionOverwriteId).HasColumnName("MasterSubQuestionnaireQuestionOverwriteID");
            Property(t => t.PossibleAnswerId).HasColumnName("PossibleAnswerID");
            Property(t => t.ChildSubQuestionnaireQuestionOverwriteId).HasColumnName("ChildSubQuestionnaireQuestionOverwriteID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.PossibleAnswer)
                .WithMany(t => t.SubDynamicQuestions)
                .HasForeignKey(d => d.PossibleAnswerId);
            HasRequired(t => t.SubQuestionnaireQuestionOverwrite)
                .WithMany(t => t.SubDynamicQuestions)
                .HasForeignKey(d => d.ChildSubQuestionnaireQuestionOverwriteId);
            HasRequired(t => t.SubQuestionnaireQuestionOverwrite1)
                .WithMany(t => t.SubDynamicQuestions1)
                .HasForeignKey(d => d.MasterSubQuestionnaireQuestionOverwriteId);

        }
    }
}
