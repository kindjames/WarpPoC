using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ActionCommentMap : EntityTypeConfiguration<ActionComment>
    {
        public ActionCommentMap()
        {
            // Primary Key
            HasKey(t => t.ActionCommentId);

            // Properties
            Property(t => t.ActionCommentId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Comment)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("ActionComment");
            Property(t => t.ActionCommentId).HasColumnName("ActionCommentID");
            Property(t => t.ActionId).HasColumnName("ActionID");
            Property(t => t.UserId).HasColumnName("UserID");
            Property(t => t.Comment).HasColumnName("Comment");
            Property(t => t.ActionPriorityId).HasColumnName("ActionPriorityID");
            Property(t => t.ActionTypeId).HasColumnName("ActionTypeID");
            Property(t => t.ActionStatusId).HasColumnName("ActionStatusID");
            Property(t => t.Display).HasColumnName("Display");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.User)
                .WithMany(t => t.ActionComments)
                .HasForeignKey(d => d.UserId);
            HasRequired(t => t.Action)
                .WithMany(t => t.ActionComments)
                .HasForeignKey(d => d.ActionId);
            HasRequired(t => t.ActionStatus)
                .WithMany(t => t.ActionComments)
                .HasForeignKey(d => d.ActionStatusId);

        }
    }
}
