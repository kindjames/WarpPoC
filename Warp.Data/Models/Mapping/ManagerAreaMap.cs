using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ManagerAreaMap : EntityTypeConfiguration<ManagerArea>
    {
        public ManagerAreaMap()
        {
            // Primary Key
            this.HasKey(t => t.ManagerAreaID);

            // Properties
            this.Property(t => t.ManagerAreaID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ManagerArea");
            this.Property(t => t.ManagerAreaID).HasColumnName("ManagerAreaID");
            this.Property(t => t.ManagerID).HasColumnName("ManagerID");
            this.Property(t => t.AreaID).HasColumnName("AreaID");

            // Relationships
            this.HasRequired(t => t.Area1)
                .WithMany(t => t.ManagerAreas)
                .HasForeignKey(d => d.AreaID);

        }
    }
}
