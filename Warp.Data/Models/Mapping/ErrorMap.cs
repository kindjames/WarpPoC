using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ErrorMap : EntityTypeConfiguration<Error>
    {
        public ErrorMap()
        {
            // Primary Key
            this.HasKey(t => t.ErrorId);

            // Properties
            this.Property(t => t.Url)
                .HasMaxLength(400);

            this.Property(t => t.Exception)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Error");
            this.Property(t => t.ErrorId).HasColumnName("ErrorId");
            this.Property(t => t.CauseBy).HasColumnName("CauseBy");
            this.Property(t => t.Url).HasColumnName("Url");
            this.Property(t => t.Exception).HasColumnName("Exception");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasOptional(t => t.User)
                .WithMany(t => t.Errors)
                .HasForeignKey(d => d.CauseBy);

        }
    }
}
