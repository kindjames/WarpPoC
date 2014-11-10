using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class ActionStatuMap : EntityTypeConfiguration<ActionStatu>
    {
        public ActionStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.ActionStatusID);

            // Properties
            this.Property(t => t.ActionStatusID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ActionStatus");
            this.Property(t => t.ActionStatusID).HasColumnName("ActionStatusID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.OpenStatus).HasColumnName("OpenStatus");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
