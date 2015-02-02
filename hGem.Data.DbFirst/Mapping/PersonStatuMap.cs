using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class PersonStatusMap : EntityTypeConfiguration<PersonStatus>
    {
        public PersonStatusMap()
        {
            // Primary Key
            HasKey(t => t.PersonStatusId);

            // Properties
            Property(t => t.Status)
                .IsRequired()
                .HasMaxLength(15);

            // Table & Column Mappings
            ToTable("PersonStatus", "Client");
            Property(t => t.PersonStatusId).HasColumnName("PersonStatusId");
            Property(t => t.Status).HasColumnName("Status");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
