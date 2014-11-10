using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class Visit
    {
        public Visit()
        {
            this.AccountingTransactions = new List<AccountingTransaction>();
            this.Assessments = new List<Assessment>();
            this.AssessorExpenses = new List<AssessorExpense>();
            this.StaffMembers = new List<StaffMember>();
            this.VisitActions = new List<VisitAction>();
            this.VisitAssessors = new List<VisitAssessor>();
            this.VisitCallBackRequests = new List<VisitCallBackRequest>();
            this.VisitCallInLogs = new List<VisitCallInLog>();
            this.VisitDetails = new List<VisitDetail>();
            this.VisitNotes = new List<VisitNote>();
            this.VisitPoints = new List<VisitPoint>();
            this.VisitStatusHistories = new List<VisitStatusHistory>();
            this.VisitTimeTrackers = new List<VisitTimeTracker>();
        }

        public int VisitID { get; set; }
        public int PeriodID { get; set; }
        public int AccountingPeriodID { get; set; }
        public short VisitStatusID { get; set; }
        public short VisitTypeID { get; set; }
        public int BranchID { get; set; }
        public System.DateTime DateAdded { get; set; }
        public System.DateTime DateAvailableFrom { get; set; }
        public Nullable<System.DateTime> DateAvailableTo { get; set; }
        public short AddedByAdminID { get; set; }
        public short OwnerAdminID { get; set; }
        public System.DateTime DateDisplay { get; set; }
        public string BestContactNo { get; set; }
        public string PublicNotes { get; set; }
        public bool LockedForEditing { get; set; }
        public Nullable<short> LockedByAdminID { get; set; }
        public Nullable<System.DateTime> DateLastLocked { get; set; }
        public Nullable<System.DateTime> DateCheckedOut { get; set; }
        public Nullable<short> CheckOutAdminID { get; set; }
        public Nullable<System.DateTime> DateCheckOutInvalid { get; set; }
        public string CheckOutKey { get; set; }
        public bool Analyse { get; set; }
        public bool Release { get; set; }
        public Nullable<int> ReleasedByAdminID { get; set; }
        public Nullable<System.DateTime> DateReleased { get; set; }
        public Nullable<double> Score { get; set; }
        public Nullable<System.DateTime> DateScoreCalculated { get; set; }
        public Nullable<int> CriteriaSetID { get; set; }
        public bool Invoiced { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual AccountingPeriod AccountingPeriod { get; set; }
        public virtual ICollection<AccountingTransaction> AccountingTransactions { get; set; }
        public virtual ICollection<Assessment> Assessments { get; set; }
        public virtual ICollection<AssessorExpense> AssessorExpenses { get; set; }
        public virtual CriteriaSet CriteriaSet { get; set; }
        public virtual Period Period { get; set; }
        public virtual ICollection<StaffMember> StaffMembers { get; set; }
        public virtual VisitStatu VisitStatu { get; set; }
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
