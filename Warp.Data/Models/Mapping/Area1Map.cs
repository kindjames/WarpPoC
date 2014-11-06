using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class Area1Map : EntityTypeConfiguration<Area1>
    {
        public Area1Map()
        {
            // Primary Key
            this.HasKey(t => t.AreaID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Area");
            this.Property(t => t.AreaID).HasColumnName("AreaID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.AreaStatusID).HasColumnName("AreaStatusID");
            this.Property(t => t.ManagerID).HasColumnName("ManagerID");

            // Relationships
            this.HasRequired(t => t.AreaStatus1)
                .WithMany(t => t.Area1)
                .HasForeignKey(d => d.AreaStatusID);

        }
    }
}
