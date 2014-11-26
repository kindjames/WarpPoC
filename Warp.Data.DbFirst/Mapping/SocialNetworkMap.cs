using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class SocialNetworkMap : EntityTypeConfiguration<SocialNetwork>
    {
        public SocialNetworkMap()
        {
            // Primary Key
            this.HasKey(t => t.SocialNetworkId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SocialNetwork", "Social");
            this.Property(t => t.SocialNetworkId).HasColumnName("SocialNetworkID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
