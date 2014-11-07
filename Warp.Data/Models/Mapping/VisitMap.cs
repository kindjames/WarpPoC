using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class VisitMap : EntityTypeConfiguration<Visit>
    {
        public VisitMap()
        {
            // Primary Key
            this.HasKey(t => t.VisitID);

            // Properties
            this.Property(t => t.VisitID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BestContactNo)
                .HasMaxLength(30);

            this.Property(t => t.PublicNotes)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.CheckOutKey)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Visit");
            this.Property(t => t.VisitID).HasColumnName("VisitID");
            this.Property(t => t.PeriodID).HasColumnName("PeriodID");
            this.Property(t => t.AccountingPeriodID).HasColumnName("AccountingPeriodID");
            this.Property(t => t.VisitStatusID).HasColumnName("VisitStatusID");
            this.Property(t => t.VisitTypeID).HasColumnName("VisitTypeID");
            this.Property(t => t.BranchID).HasColumnName("BranchID");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");
            this.Property(t => t.DateAvailableFrom).HasColumnName("DateAvailableFrom");
            this.Property(t => t.DateAvailableTo).HasColumnName("DateAvailableTo");
            this.Property(t => t.AddedByAdminID).HasColumnName("AddedByAdminID");
            this.Property(t => t.OwnerAdminID).HasColumnName("OwnerAdminID");
            this.Property(t => t.DateDisplay).HasColumnName("DateDisplay");
            this.Property(t => t.BestContactNo).HasColumnName("BestContactNo");
            this.Property(t => t.PublicNotes).HasColumnName("PublicNotes");
            this.Property(t => t.LockedForEditing).HasColumnName("LockedForEditing");
            this.Property(t => t.LockedByAdminID).HasColumnName("LockedByAdminID");
            this.Property(t => t.DateLastLocked).HasColumnName("DateLastLocked");
            this.Property(t => t.DateCheckedOut).HasColumnName("DateCheckedOut");
            this.Property(t => t.CheckOutAdminID).HasColumnName("CheckOutAdminID");
            this.Property(t => t.DateCheckOutInvalid).HasColumnName("DateCheckOutInvalid");
            this.Property(t => t.CheckOutKey).HasColumnName("CheckOutKey");
            this.Property(t => t.Analyse).HasColumnName("Analyse");
            this.Property(t => t.Release).HasColumnName("Release");
            this.Property(t => t.ReleasedByAdminID).HasColumnName("ReleasedByAdminID");
            this.Property(t => t.DateReleased).HasColumnName("DateReleased");
            this.Property(t => t.Score).HasColumnName("Score");
            this.Property(t => t.DateScoreCalculated).HasColumnName("DateScoreCalculated");
            this.Property(t => t.CriteriaSetID).HasColumnName("CriteriaSetID");
            this.Property(t => t.Invoiced).HasColumnName("Invoiced");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.AccountingPeriod)
                .WithMany(t => t.Visits)
                .HasForeignKey(d => d.AccountingPeriodID);
            this.HasOptional(t => t.CriteriaSet)
                .WithMany(t => t.Visits)
                .HasForeignKey(d => d.CriteriaSetID);
            this.HasRequired(t => t.Period)
                .WithMany(t => t.Visits)
                .HasForeignKey(d => d.PeriodID);
            this.HasRequired(t => t.VisitStatu)
                .WithMany(t => t.Visits)
                .HasForeignKey(d => d.VisitStatusID);
            this.HasRequired(t => t.VisitType)
                .WithMany(t => t.Visits)
                .HasForeignKey(d => d.VisitTypeID);

        }
    }
}
