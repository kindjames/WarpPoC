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
            HasKey(t => t.VisitDetailsId);

            // Properties
            Property(t => t.VisitDetailsId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.ReceiptNumber)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("VisitDetails");
            Property(t => t.VisitDetailsId).HasColumnName("VisitDetailsID");
            Property(t => t.VisitId).HasColumnName("VisitID");
            Property(t => t.DateOfActualVisit).HasColumnName("DateOfActualVisit");
            Property(t => t.AdultGuests).HasColumnName("AdultGuests");
            Property(t => t.ChildGuests).HasColumnName("ChildGuests");
            Property(t => t.ChildGuestsNotInvolved).HasColumnName("ChildGuestsNotInvolved");
            Property(t => t.ReceiptNumber).HasColumnName("ReceiptNumber");
            Property(t => t.TradeLevelId).HasColumnName("TradeLevelID");
            Property(t => t.SeatingLevel).HasColumnName("SeatingLevel");
            Property(t => t.WeatherId).HasColumnName("WeatherID");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.TradeLevel)
                .WithMany(t => t.VisitDetails)
                .HasForeignKey(d => d.TradeLevelId);
            HasRequired(t => t.Visit)
                .WithMany(t => t.VisitDetails)
                .HasForeignKey(d => d.VisitId);
            HasRequired(t => t.Weather)
                .WithMany(t => t.VisitDetails)
                .HasForeignKey(d => d.WeatherId);

        }
    }
}
