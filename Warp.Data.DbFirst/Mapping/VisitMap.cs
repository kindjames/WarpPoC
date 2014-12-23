using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class VisitMap : EntityTypeConfiguration<Visit>
    {
        public VisitMap()
        {
            // Primary Key
            HasKey(t => t.VisitId);

            // Properties
            Property(t => t.VisitId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.BestContactNo)
                .HasMaxLength(30);

            Property(t => t.PublicNotes)
                .IsRequired()
                .HasMaxLength(300);

            Property(t => t.CheckOutKey)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            ToTable("Visit");
            Property(t => t.VisitId).HasColumnName("VisitID");
            Property(t => t.PeriodId).HasColumnName("PeriodID");
            Property(t => t.AccountingPeriodId).HasColumnName("AccountingPeriodID");
            Property(t => t.VisitStatusId).HasColumnName("VisitStatusID");
            Property(t => t.VisitTypeId).HasColumnName("VisitTypeID");
            Property(t => t.BranchId).HasColumnName("BranchID");
            Property(t => t.DateAdded).HasColumnName("DateAdded");
            Property(t => t.DateAvailableFrom).HasColumnName("DateAvailableFrom");
            Property(t => t.DateAvailableTo).HasColumnName("DateAvailableTo");
            Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            Property(t => t.OwnerAdminId).HasColumnName("OwnerAdminID");
            Property(t => t.DateDisplay).HasColumnName("DateDisplay");
            Property(t => t.BestContactNo).HasColumnName("BestContactNo");
            Property(t => t.PublicNotes).HasColumnName("PublicNotes");
            Property(t => t.LockedForEditing).HasColumnName("LockedForEditing");
            Property(t => t.LockedByAdminId).HasColumnName("LockedByAdminID");
            Property(t => t.DateLastLocked).HasColumnName("DateLastLocked");
            Property(t => t.DateCheckedOut).HasColumnName("DateCheckedOut");
            Property(t => t.CheckOutAdminId).HasColumnName("CheckOutAdminID");
            Property(t => t.DateCheckOutInvalId).HasColumnName("DateCheckOutInvalid");
            Property(t => t.CheckOutKey).HasColumnName("CheckOutKey");
            Property(t => t.Analyse).HasColumnName("Analyse");
            Property(t => t.Release).HasColumnName("Release");
            Property(t => t.ReleasedByAdminId).HasColumnName("ReleasedByAdminID");
            Property(t => t.DateReleased).HasColumnName("DateReleased");
            Property(t => t.Score).HasColumnName("Score");
            Property(t => t.DateScoreCalculated).HasColumnName("DateScoreCalculated");
            Property(t => t.CriteriaSetId).HasColumnName("CriteriaSetID");
            Property(t => t.Invoiced).HasColumnName("Invoiced");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.AccountingPeriod)
                .WithMany(t => t.Visits)
                .HasForeignKey(d => d.AccountingPeriodId);
            HasOptional(t => t.CriteriaSet)
                .WithMany(t => t.Visits)
                .HasForeignKey(d => d.CriteriaSetId);
            HasRequired(t => t.Period)
                .WithMany(t => t.Visits)
                .HasForeignKey(d => d.PeriodId);
            HasRequired(t => t.VisitStatus)
                .WithMany(t => t.Visits)
                .HasForeignKey(d => d.VisitStatusId);
            HasRequired(t => t.VisitType)
                .WithMany(t => t.Visits)
                .HasForeignKey(d => d.VisitTypeId);

        }
    }
}
