using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class VisitMap : EntityTypeConfiguration<Visit>
    {
        public VisitMap()
        {
            // Primary Key
            this.HasKey(t => t.VisitId);

            // Properties
            this.Property(t => t.VisitId)
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
            this.Property(t => t.VisitId).HasColumnName("VisitID");
            this.Property(t => t.PeriodId).HasColumnName("PeriodID");
            this.Property(t => t.AccountingPeriodId).HasColumnName("AccountingPeriodID");
            this.Property(t => t.VisitStatusId).HasColumnName("VisitStatusID");
            this.Property(t => t.VisitTypeId).HasColumnName("VisitTypeID");
            this.Property(t => t.BranchId).HasColumnName("BranchID");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");
            this.Property(t => t.DateAvailableFrom).HasColumnName("DateAvailableFrom");
            this.Property(t => t.DateAvailableTo).HasColumnName("DateAvailableTo");
            this.Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            this.Property(t => t.OwnerAdminId).HasColumnName("OwnerAdminID");
            this.Property(t => t.DateDisplay).HasColumnName("DateDisplay");
            this.Property(t => t.BestContactNo).HasColumnName("BestContactNo");
            this.Property(t => t.PublicNotes).HasColumnName("PublicNotes");
            this.Property(t => t.LockedForEditing).HasColumnName("LockedForEditing");
            this.Property(t => t.LockedByAdminId).HasColumnName("LockedByAdminID");
            this.Property(t => t.DateLastLocked).HasColumnName("DateLastLocked");
            this.Property(t => t.DateCheckedOut).HasColumnName("DateCheckedOut");
            this.Property(t => t.CheckOutAdminId).HasColumnName("CheckOutAdminID");
            this.Property(t => t.DateCheckOutInvalId).HasColumnName("DateCheckOutInvalid");
            this.Property(t => t.CheckOutKey).HasColumnName("CheckOutKey");
            this.Property(t => t.Analyse).HasColumnName("Analyse");
            this.Property(t => t.Release).HasColumnName("Release");
            this.Property(t => t.ReleasedByAdminId).HasColumnName("ReleasedByAdminID");
            this.Property(t => t.DateReleased).HasColumnName("DateReleased");
            this.Property(t => t.Score).HasColumnName("Score");
            this.Property(t => t.DateScoreCalculated).HasColumnName("DateScoreCalculated");
            this.Property(t => t.CriteriaSetId).HasColumnName("CriteriaSetID");
            this.Property(t => t.Invoiced).HasColumnName("Invoiced");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.AccountingPeriod)
                .WithMany(t => t.Visits)
                .HasForeignKey(d => d.AccountingPeriodId);
            this.HasOptional(t => t.CriteriaSet)
                .WithMany(t => t.Visits)
                .HasForeignKey(d => d.CriteriaSetId);
            this.HasRequired(t => t.Period)
                .WithMany(t => t.Visits)
                .HasForeignKey(d => d.PeriodId);
            this.HasRequired(t => t.VisitStatu)
                .WithMany(t => t.Visits)
                .HasForeignKey(d => d.VisitStatusId);
            this.HasRequired(t => t.VisitType)
                .WithMany(t => t.Visits)
                .HasForeignKey(d => d.VisitTypeId);

        }
    }
}
