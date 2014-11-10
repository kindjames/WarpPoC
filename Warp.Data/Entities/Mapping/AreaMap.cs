using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class AreaMap : EntityTypeConfiguration<Area>
    {
        public AreaMap()
        {
            // Primary Key
            this.HasKey(t => t.AreaID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Area", "Client");
            this.Property(t => t.AreaID).HasColumnName("AreaID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.AreaStatusID).HasColumnName("AreaStatusID");
            this.Property(t => t.RegionID).HasColumnName("RegionID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.AreaStatu)
                .WithMany(t => t.Areas)
                .HasForeignKey(d => d.AreaStatusID);
            this.HasRequired(t => t.Region)
                .WithMany(t => t.Areas)
                .HasForeignKey(d => d.RegionID);

        }
    }
}
