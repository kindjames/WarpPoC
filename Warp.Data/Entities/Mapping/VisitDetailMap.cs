using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class VisitDetailMap : EntityTypeConfiguration<VisitDetail>
    {
        public VisitDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.VisitDetailsID);

            // Properties
            this.Property(t => t.VisitDetailsID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ReceiptNumber)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VisitDetails");
            this.Property(t => t.VisitDetailsID).HasColumnName("VisitDetailsID");
            this.Property(t => t.VisitID).HasColumnName("VisitID");
            this.Property(t => t.DateOfActualVisit).HasColumnName("DateOfActualVisit");
            this.Property(t => t.AdultGuests).HasColumnName("AdultGuests");
            this.Property(t => t.ChildGuests).HasColumnName("ChildGuests");
            this.Property(t => t.ChildGuestsNotInvolved).HasColumnName("ChildGuestsNotInvolved");
            this.Property(t => t.ReceiptNumber).HasColumnName("ReceiptNumber");
            this.Property(t => t.TradeLevelID).HasColumnName("TradeLevelID");
            this.Property(t => t.SeatingLevel).HasColumnName("SeatingLevel");
            this.Property(t => t.WeatherID).HasColumnName("WeatherID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.TradeLevel)
                .WithMany(t => t.VisitDetails)
                .HasForeignKey(d => d.TradeLevelID);
            this.HasRequired(t => t.Visit)
                .WithMany(t => t.VisitDetails)
                .HasForeignKey(d => d.VisitID);
            this.HasRequired(t => t.Weather)
                .WithMany(t => t.VisitDetails)
                .HasForeignKey(d => d.WeatherID);

        }
    }
}
