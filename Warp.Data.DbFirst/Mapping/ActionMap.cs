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
            this.HasKey(t => t.ActionId);

            // Properties
            this.Property(t => t.ActionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Action");
            this.Property(t => t.ActionId).HasColumnName("ActionID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Added).HasColumnName("Added");
            this.Property(t => t.AddedUser).HasColumnName("AddedUser");
            this.Property(t => t.ActionPriorityId).HasColumnName("ActionPriorityID");
            this.Property(t => t.ActionTypeId).HasColumnName("ActionTypeID");
            this.Property(t => t.ActionStatusId).HasColumnName("ActionStatusID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.User)
                .WithMany(t => t.Actions)
                .HasForeignKey(d => d.AddedUser);
            this.HasRequired(t => t.ActionPriority)
                .WithMany(t => t.Actions)
                .HasForeignKey(d => d.ActionPriorityId);
            this.HasRequired(t => t.ActionStatus)
                .WithMany(t => t.Actions)
                .HasForeignKey(d => d.ActionStatusId);
            this.HasRequired(t => t.ActionType)
                .WithMany(t => t.Actions)
                .HasForeignKey(d => d.ActionTypeId);

        }
    }
}
