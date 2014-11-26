using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class VisitDetailMap : EntityTypeConfiguration<VisitDetail>
    {
        public VisitDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.VisitDetailsId);

            // Properties
            this.Property(t => t.VisitDetailsId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ReceiptNumber)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VisitDetails");
            this.Property(t => t.VisitDetailsId).HasColumnName("VisitDetailsID");
            this.Property(t => t.VisitId).HasColumnName("VisitID");
            this.Property(t => t.DateOfActualVisit).HasColumnName("DateOfActualVisit");
            this.Property(t => t.AdultGuests).HasColumnName("AdultGuests");
            this.Property(t => t.ChildGuests).HasColumnName("ChildGuests");
            this.Property(t => t.ChildGuestsNotInvolved).HasColumnName("ChildGuestsNotInvolved");
            this.Property(t => t.ReceiptNumber).HasColumnName("ReceiptNumber");
            this.Property(t => t.TradeLevelId).HasColumnName("TradeLevelID");
            this.Property(t => t.SeatingLevel).HasColumnName("SeatingLevel");
            this.Property(t => t.WeatherId).HasColumnName("WeatherID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.TradeLevel)
                .WithMany(t => t.VisitDetails)
                .HasForeignKey(d => d.TradeLevelId);
            this.HasRequired(t => t.Visit)
                .WithMany(t => t.VisitDetails)
                .HasForeignKey(d => d.VisitId);
            this.HasRequired(t => t.Weather)
                .WithMany(t => t.VisitDetails)
                .HasForeignKey(d => d.WeatherId);

        }
    }
}
