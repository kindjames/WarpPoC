using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class StaffMemberMap : EntityTypeConfiguration<StaffMember>
    {
        public StaffMemberMap()
        {
            // Primary Key
            HasKey(t => t.StaffMemberId);

            // Properties
            Property(t => t.StaffMemberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .HasMaxLength(200);

            Property(t => t.Notes)
                .HasMaxLength(500);

            // Table & Column Mappings
            ToTable("StaffMember");
            Property(t => t.StaffMemberId).HasColumnName("StaffMemberID");
            Property(t => t.VisitId).HasColumnName("VisitID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.AssessorId).HasColumnName("AssessorID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Notes).HasColumnName("Notes");
            Property(t => t.StaffAgeId).HasColumnName("StaffAgeID");
            Property(t => t.StaffHeightId).HasColumnName("StaffHeightID");
            Property(t => t.StaffHairColourId).HasColumnName("StaffHairColourID");
            Property(t => t.StaffHairLengthId).HasColumnName("StaffHairLengthID");
            Property(t => t.StaffHairStyleId).HasColumnName("StaffHairStyleID");
            Property(t => t.GenderId).HasColumnName("GenderID");
            Property(t => t.CheckedByAdminId).HasColumnName("CheckedByAdminID");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.Approved).HasColumnName("Approved");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            HasRequired(t => t.Gender)
                .WithMany(t => t.StaffMembers)
                .HasForeignKey(d => d.GenderId);
            HasRequired(t => t.StaffAge)
                .WithMany(t => t.StaffMembers)
                .HasForeignKey(d => d.StaffAgeId);
            HasRequired(t => t.StaffHairColour)
                .WithMany(t => t.StaffMembers)
                .HasForeignKey(d => d.StaffHairColourId);
            HasRequired(t => t.StaffHairLength)
                .WithMany(t => t.StaffMembers)
                .HasForeignKey(d => d.StaffHairLengthId);
            HasRequired(t => t.StaffHairStyle)
                .WithMany(t => t.StaffMembers)
                .HasForeignKey(d => d.StaffHairStyleId);
            HasRequired(t => t.StaffHeight)
                .WithMany(t => t.StaffMembers)
                .HasForeignKey(d => d.StaffHeightId);
            HasRequired(t => t.Visit)
                .WithMany(t => t.StaffMembers)
                .HasForeignKey(d => d.VisitId);

        }
    }
}
