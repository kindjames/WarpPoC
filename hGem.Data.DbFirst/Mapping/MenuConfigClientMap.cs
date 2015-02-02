using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class MenuConfigClientMap : EntityTypeConfiguration<MenuConfigClient>
    {
        public MenuConfigClientMap()
        {
            // Primary Key
            HasKey(t => t.MenuConfigClientId);

            // Properties
            Property(t => t.MenuConfigClientId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("MenuConfigClient");
            Property(t => t.MenuConfigClientId).HasColumnName("MenuConfigClientID");
            Property(t => t.MenuConfigId).HasColumnName("MenuConfigID");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.Permission).HasColumnName("Permission");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Client)
                .WithMany(t => t.MenuConfigClients)
                .HasForeignKey(d => d.ClientId);
            HasRequired(t => t.MenuConfig)
                .WithMany(t => t.MenuConfigClients)
                .HasForeignKey(d => d.MenuConfigId);

        }
    }
}
