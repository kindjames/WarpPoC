using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class SocialNetworkMap : EntityTypeConfiguration<SocialNetwork>
    {
        public SocialNetworkMap()
        {
            // Primary Key
            this.HasKey(t => t.SocialNetworkID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SocialNetwork", "Social");
            this.Property(t => t.SocialNetworkID).HasColumnName("SocialNetworkID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
