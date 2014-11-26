using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PersonStatusMap : EntityTypeConfiguration<PersonStatus>
    {
        public PersonStatusMap()
        {
            // Primary Key
            this.HasKey(t => t.PersonStatusId);

            // Properties
            this.Property(t => t.Status)
                .IsRequired()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("PersonStatus", "Client");
            this.Property(t => t.PersonStatusId).HasColumnName("PersonStatusId");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
