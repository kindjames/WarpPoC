using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class Visit
    {
        public Visit()
        {
            AccountingTransactions = new List<AccountingTransaction>();
            Assessments = new List<Assessment>();
            AssessorExpenses = new List<AssessorExpense>();
            StaffMembers = new List<StaffMember>();
            VisitActions = new List<VisitAction>();
            VisitAssessors = new List<VisitAssessor>();
            VisitCallBackRequests = new List<VisitCallBackRequest>();
            VisitCallInLogs = new List<VisitCallInLog>();
            VisitDetails = new List<VisitDetail>();
            VisitNotes = new List<VisitNote>();
            VisitPoints = new List<VisitPoint>();
            VisitStatusHistories = new List<VisitStatusHistory>();
            VisitTimeTrackers = new List<VisitTimeTracker>();
        }

        public int VisitId { get; set; }
        public int PeriodId { get; set; }
        public int AccountingPeriodId { get; set; }
        public short VisitStatusId { get; set; }
        public short VisitTypeId { get; set; }
        public int BranchId { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateAvailableFrom { get; set; }
        public DateTime? DateAvailableTo { get; set; }
        public short AddedByAdminId { get; set; }
        public short OwnerAdminId { get; set; }
        public DateTime DateDisplay { get; set; }
        public string BestContactNo { get; set; }
        public string PublicNotes { get; set; }
        public bool LockedForEditing { get; set; }
        public short? LockedByAdminId { get; set; }
        public DateTime? DateLastLocked { get; set; }
        public DateTime? DateCheckedOut { get; set; }
        public short? CheckOutAdminId { get; set; }
        public DateTime? DateCheckOutInvalId { get; set; }
        public string CheckOutKey { get; set; }
        public bool Analyse { get; set; }
        public bool Release { get; set; }
        public int? ReleasedByAdminId { get; set; }
        public DateTime? DateReleased { get; set; }
        public double? Score { get; set; }
        public DateTime? DateScoreCalculated { get; set; }
        public int? CriteriaSetId { get; set; }
        public bool Invoiced { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual AccountingPeriod AccountingPeriod { get; set; }
        public virtual ICollection<AccountingTransaction> AccountingTransactions { get; set; }
        public virtual ICollection<Assessment> Assessments { get; set; }
        public virtual ICollection<AssessorExpense> AssessorExpenses { get; set; }
        public virtual CriteriaSet CriteriaSet { get; set; }
        public virtual Period Period { get; set; }
        public virtual ICollection<StaffMember> StaffMembers { get; set; }
        public virtual VisitStatus VisitStatus { get; set; }
        public virtual VisitType VisitType { get; set; }
        public virtual ICollection<VisitAction> VisitActions { get; set; }
        public virtual ICollection<VisitAssessor> VisitAssessors { get; set; }
        public virtual ICollection<VisitCallBackRequest> VisitCallBackRequests { get; set; }
        public virtual ICollection<VisitCallInLog> VisitCallInLogs { get; set; }
        public virtual ICollection<VisitDetail> VisitDetails { get; set; }
        public virtual ICollection<VisitNote> VisitNotes { get; set; }
        public virtual ICollection<VisitPoint> VisitPoints { get; set; }
        public virtual ICollection<VisitStatusHistory> VisitStatusHistories { get; set; }
        public virtual ICollection<VisitTimeTracker> VisitTimeTrackers { get; set; }
    }
}