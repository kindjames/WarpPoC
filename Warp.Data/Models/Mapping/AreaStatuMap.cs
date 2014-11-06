using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class AreaStatuMap : EntityTypeConfiguration<AreaStatu>
    {
        public AreaStatuMap()
        {
            // Primary Key
            this.HasKey(t => t.AreaStatusID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("AreaStatus", "Client");
            this.Property(t => t.AreaStatusID).HasColumnName("AreaStatusID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
