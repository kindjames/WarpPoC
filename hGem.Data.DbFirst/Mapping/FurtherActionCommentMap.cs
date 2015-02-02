using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class FurtherActionCommentMap : EntityTypeConfiguration<FurtherActionComment>
    {
        public FurtherActionCommentMap()
        {
            // Primary Key
            HasKey(t => t.FurtherActionCommentId);

            // Properties
            Property(t => t.FurtherActionCommentId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Comment1)
                .IsRequired()
                .HasMaxLength(300);

            Property(t => t.Comment2)
                .HasMaxLength(500);

            Property(t => t.Comment3)
                .HasMaxLength(500);

            // Table & Column Mappings
            ToTable("FurtherActionComment");
            Property(t => t.FurtherActionCommentId).HasColumnName("FurtherActionCommentID");
            Property(t => t.ActionCommentId).HasColumnName("ActionCommentID");
            Property(t => t.Comment1).HasColumnName("Comment1");
            Property(t => t.Comment2).HasColumnName("Comment2");
            Property(t => t.Comment3).HasColumnName("Comment3");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.ActionComment)
                .WithMany(t => t.FurtherActionComments)
                .HasForeignKey(d => d.ActionCommentId);

        }
    }
}
