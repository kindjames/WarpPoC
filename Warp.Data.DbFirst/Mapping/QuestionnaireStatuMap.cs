using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class QuestionnaireStatusMap : EntityTypeConfiguration<QuestionnaireStatus>
    {
        public QuestionnaireStatusMap()
        {
            // Primary Key
            this.HasKey(t => t.QuestionnaireStatusId);

            // Properties
            this.Property(t => t.QuestionnaireStatusId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("QuestionnaireStatus");
            this.Property(t => t.QuestionnaireStatusId).HasColumnName("QuestionnaireStatusID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
