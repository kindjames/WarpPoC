using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class SocialNetworkMap : EntityTypeConfiguration<SocialNetwork>
    {
        public SocialNetworkMap()
        {
            // Primary Key
            HasKey(t => t.SocialNetworkId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("SocialNetwork", "Social");
            Property(t => t.SocialNetworkId).HasColumnName("SocialNetworkID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
