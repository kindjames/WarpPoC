using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ActionStatusMap : EntityTypeConfiguration<ActionStatus>
    {
        public ActionStatusMap()
        {
            // Primary Key
            this.HasKey(t => t.ActionStatusId);

            // Properties
            this.Property(t => t.ActionStatusId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ActionStatus");
            this.Property(t => t.ActionStatusId).HasColumnName("ActionStatusID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.OpenStatus).HasColumnName("OpenStatus");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
