using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class SubDynamicQuestionMap : EntityTypeConfiguration<SubDynamicQuestion>
    {
        public SubDynamicQuestionMap()
        {
            // Primary Key
            this.HasKey(t => t.SubDynamicQuestionId);

            // Properties
            this.Property(t => t.SubDynamicQuestionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SubDynamicQuestion");
            this.Property(t => t.SubDynamicQuestionId).HasColumnName("SubDynamicQuestionID");
            this.Property(t => t.MasterSubQuestionnaireQuestionOverwriteId).HasColumnName("MasterSubQuestionnaireQuestionOverwriteID");
            this.Property(t => t.PossibleAnswerId).HasColumnName("PossibleAnswerID");
            this.Property(t => t.ChildSubQuestionnaireQuestionOverwriteId).HasColumnName("ChildSubQuestionnaireQuestionOverwriteID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.PossibleAnswer)
                .WithMany(t => t.SubDynamicQuestions)
                .HasForeignKey(d => d.PossibleAnswerId);
            this.HasRequired(t => t.SubQuestionnaireQuestionOverwrite)
                .WithMany(t => t.SubDynamicQuestions)
                .HasForeignKey(d => d.ChildSubQuestionnaireQuestionOverwriteId);
            this.HasRequired(t => t.SubQuestionnaireQuestionOverwrite1)
                .WithMany(t => t.SubDynamicQuestions1)
                .HasForeignKey(d => d.MasterSubQuestionnaireQuestionOverwriteId);

        }
    }
}
