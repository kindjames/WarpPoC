using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ErrorMap : EntityTypeConfiguration<Error>
    {
        public ErrorMap()
        {
            // Primary Key
            HasKey(t => t.ErrorId);

            // Properties
            Property(t => t.Url)
                .HasMaxLength(400);

            Property(t => t.Exception)
                .HasMaxLength(2000);

            // Table & Column Mappings
            ToTable("Error");
            Property(t => t.ErrorId).HasColumnName("ErrorId");
            Property(t => t.CauseBy).HasColumnName("CauseBy");
            Property(t => t.Url).HasColumnName("Url");
            Property(t => t.Exception).HasColumnName("Exception");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasOptional(t => t.User)
                .WithMany(t => t.Errors)
                .HasForeignKey(d => d.CauseBy);

        }
    }
}
