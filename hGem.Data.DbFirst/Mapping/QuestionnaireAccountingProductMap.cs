using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class QuestionnaireAccountingProductMap : EntityTypeConfiguration<QuestionnaireAccountingProduct>
    {
        public QuestionnaireAccountingProductMap()
        {
            // Primary Key
            HasKey(t => t.QuestionnaireAccountingProductId);

            // Properties
            Property(t => t.QuestionnaireAccountingProductId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("QuestionnaireAccountingProduct");
            Property(t => t.QuestionnaireAccountingProductId).HasColumnName("QuestionnaireAccountingProductID");
            Property(t => t.QuestionnaireId).HasColumnName("QuestionnaireID");
            Property(t => t.SubQuestionnaireId).HasColumnName("SubQuestionnaireID");
            Property(t => t.AccountingProductId).HasColumnName("AccountingProductID");
            Property(t => t.DefaultValue).HasColumnName("DefaultValue");
            Property(t => t.KashFlowId).HasColumnName("KashFlowID");
            Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.AccountingProduct)
                .WithMany(t => t.QuestionnaireAccountingProducts)
                .HasForeignKey(d => d.AccountingProductId);
            HasRequired(t => t.Questionnaire)
                .WithMany(t => t.QuestionnaireAccountingProducts)
                .HasForeignKey(d => d.QuestionnaireId);
            HasOptional(t => t.SubQuestionnaire)
                .WithMany(t => t.QuestionnaireAccountingProducts)
                .HasForeignKey(d => d.SubQuestionnaireId);

        }
    }
}
