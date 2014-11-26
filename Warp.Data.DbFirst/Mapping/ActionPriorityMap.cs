using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ActionPriorityMap : EntityTypeConfiguration<ActionPriority>
    {
        public ActionPriorityMap()
        {
            // Primary Key
            this.HasKey(t => t.ActionPriorityId);

            // Properties
            this.Property(t => t.ActionPriorityId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("ActionPriority");
            this.Property(t => t.ActionPriorityId).HasColumnName("ActionPriorityID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.WorkingDays).HasColumnName("WorkingDays");
            this.Property(t => t.Hours).HasColumnName("Hours");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}