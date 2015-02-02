using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ActionMap : EntityTypeConfiguration<Action>
    {
        public ActionMap()
        {
            // Primary Key
            HasKey(t => t.ActionId);

            // Properties
            Property(t => t.ActionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("Action");
            Property(t => t.ActionId).HasColumnName("ActionID");
            Property(t => t.Title).HasColumnName("Title");
            Property(t => t.Added).HasColumnName("Added");
            Property(t => t.AddedUser).HasColumnName("AddedUser");
            Property(t => t.ActionPriorityId).HasColumnName("ActionPriorityID");
            Property(t => t.ActionTypeId).HasColumnName("ActionTypeID");
            Property(t => t.ActionStatusId).HasColumnName("ActionStatusID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.User)
                .WithMany(t => t.Actions)
                .HasForeignKey(d => d.AddedUser);
            HasRequired(t => t.ActionPriority)
                .WithMany(t => t.Actions)
                .HasForeignKey(d => d.ActionPriorityId);
            HasRequired(t => t.ActionStatus)
                .WithMany(t => t.Actions)
                .HasForeignKey(d => d.ActionStatusId);
            HasRequired(t => t.ActionType)
                .WithMany(t => t.Actions)
                .HasForeignKey(d => d.ActionTypeId);

        }
    }
}
