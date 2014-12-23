using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PossibleAnswerMap : EntityTypeConfiguration<PossibleAnswer>
    {
        public PossibleAnswerMap()
        {
            // Primary Key
            HasKey(t => t.PossibleAnswerId);

            // Properties
            Property(t => t.PossibleAnswerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Text)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Value)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("PossibleAnswer");
            Property(t => t.PossibleAnswerId).HasColumnName("PossibleAnswerID");
            Property(t => t.Text).HasColumnName("Text");
            Property(t => t.Value).HasColumnName("Value");
            Property(t => t.Score).HasColumnName("Score");
            Property(t => t.PossibleAnswerTypeId).HasColumnName("PossibleAnswerTypeID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
