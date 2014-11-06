using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class RemovalReasonMap : EntityTypeConfiguration<RemovalReason>
    {
        public RemovalReasonMap()
        {
            // Primary Key
            this.HasKey(t => t.RemovalReasonID);

            // Properties
            this.Property(t => t.RemovalReasonID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("RemovalReason");
            this.Property(t => t.RemovalReasonID).HasColumnName("RemovalReasonID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
