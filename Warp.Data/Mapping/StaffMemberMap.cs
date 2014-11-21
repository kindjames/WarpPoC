using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class StaffMemberMap : EntityTypeConfiguration<StaffMember>
    {
        public StaffMemberMap()
        {
            // Primary Key
            this.HasKey(t => t.StaffMemberId);

            // Properties
            this.Property(t => t.StaffMemberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .HasMaxLength(200);

            this.Property(t => t.Notes)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("StaffMember");
            this.Property(t => t.StaffMemberId).HasColumnName("StaffMemberID");
            this.Property(t => t.VisitId).HasColumnName("VisitID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.AssessorId).HasColumnName("AssessorID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.StaffAgeId).HasColumnName("StaffAgeID");
            this.Property(t => t.StaffHeightId).HasColumnName("StaffHeightID");
            this.Property(t => t.StaffHairColourId).HasColumnName("StaffHairColourID");
            this.Property(t => t.StaffHairLengthId).HasColumnName("StaffHairLengthID");
            this.Property(t => t.StaffHairStyleId).HasColumnName("StaffHairStyleID");
            this.Property(t => t.GenderId).HasColumnName("GenderID");
            this.Property(t => t.CheckedByAdminId).HasColumnName("CheckedByAdminID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.Approved).HasColumnName("Approved");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.Gender)
                .WithMany(t => t.StaffMembers)
                .HasForeignKey(d => d.GenderId);
            this.HasRequired(t => t.StaffAge)
                .WithMany(t => t.StaffMembers)
                .HasForeignKey(d => d.StaffAgeId);
            this.HasRequired(t => t.StaffHairColour)
                .WithMany(t => t.StaffMembers)
                .HasForeignKey(d => d.StaffHairColourId);
            this.HasRequired(t => t.StaffHairLength)
                .WithMany(t => t.StaffMembers)
                .HasForeignKey(d => d.StaffHairLengthId);
            this.HasRequired(t => t.StaffHairStyle)
                .WithMany(t => t.StaffMembers)
                .HasForeignKey(d => d.StaffHairStyleId);
            this.HasRequired(t => t.StaffHeight)
                .WithMany(t => t.StaffMembers)
                .HasForeignKey(d => d.StaffHeightId);
            this.HasRequired(t => t.Visit)
                .WithMany(t => t.StaffMembers)
                .HasForeignKey(d => d.VisitId);

        }
    }
}
