using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class Assessor
    {
        public Assessor()
        {
            this.AssessorAttributes = new List<AssessorAttribute>();
            this.AssessorCallBackRequests = new List<AssessorCallBackRequest>();
            this.AssessorCallInLogs = new List<AssessorCallInLog>();
            this.AssessorExpenses = new List<AssessorExpense>();
            this.AssessorGeographicPostCodes = new List<AssessorGeographicPostCode>();
            this.AssessorHistories = new List<AssessorHistory>();
            this.AssessorNotes = new List<AssessorNote>();
            this.AssessorTimeTrackers = new List<AssessorTimeTracker>();
            this.AuditAssessorEvents = new List<AuditAssessorEvent>();
            this.BanBranches = new List<BanBranch>();
            this.BanBrands = new List<BanBrand>();
            this.BanClients = new List<BanClient>();
            this.CommunicationPreferences = new List<CommunicationPreference>();
            this.ForumAssessorReplies = new List<ForumAssessorReply>();
            this.ForumReportedReplies = new List<ForumReportedReply>();
            this.ForumThreads = new List<ForumThread>();
            this.Points = new List<Point>();
            this.QuestionResults = new List<QuestionResult>();
            this.ResultComments = new List<ResultComment>();
            this.SimpleVisits = new List<SimpleVisit>();
            this.Suggestions = new List<Suggestion>();
            this.SuggestionVotes = new List<SuggestionVote>();
            this.TelephoneRecordings = new List<TelephoneRecording>();
            this.VisitAssessors = new List<VisitAssessor>();
        }

        public int AssessorID { get; set; }
        public int UserID { get; set; }
        public short AssessorStatusID { get; set; }
        public short AssessorLevelID { get; set; }
        public bool AssessorLevelLock { get; set; }
        public short CurrencyID { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string HomeTelephone { get; set; }
        public string WorkTelephone { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string BankName { get; set; }
        public string BankAddress { get; set; }
        public string SortCode { get; set; }
        public string AccountNumber { get; set; }
        public string Occupation { get; set; }
        public Nullable<byte> GenderID { get; set; }
        public System.DateTime DateOfLastProfileUpdate { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<AssessorAttribute> AssessorAttributes { get; set; }
        public virtual ICollection<AssessorCallBackRequest> AssessorCallBackRequests { get; set; }
        public virtual ICollection<AssessorCallInLog> AssessorCallInLogs { get; set; }
        public virtual ICollection<AssessorExpense> AssessorExpenses { get; set; }
        public virtual ICollection<AssessorGeographicPostCode> AssessorGeographicPostCodes { get; set; }
        public virtual ICollection<AssessorHistory> AssessorHistories { get; set; }
        public virtual ICollection<AssessorNote> AssessorNotes { get; set; }
        public virtual ICollection<AssessorTimeTracker> AssessorTimeTrackers { get; set; }
        public virtual ICollection<AuditAssessorEvent> AuditAssessorEvents { get; set; }
        public virtual ICollection<BanBranch> BanBranches { get; set; }
        public virtual ICollection<BanBrand> BanBrands { get; set; }
        public virtual ICollection<BanClient> BanClients { get; set; }
        public virtual ICollection<CommunicationPreference> CommunicationPreferences { get; set; }
        public virtual ICollection<ForumAssessorReply> ForumAssessorReplies { get; set; }
        public virtual ICollection<ForumReportedReply> ForumReportedReplies { get; set; }
        public virtual ICollection<ForumThread> ForumThreads { get; set; }
        public virtual ICollection<Point> Points { get; set; }
        public virtual ICollection<QuestionResult> QuestionResults { get; set; }
        public virtual ICollection<ResultComment> ResultComments { get; set; }
        public virtual ICollection<SimpleVisit> SimpleVisits { get; set; }
        public virtual ICollection<Suggestion> Suggestions { get; set; }
        public virtual ICollection<SuggestionVote> SuggestionVotes { get; set; }
        public virtual ICollection<TelephoneRecording> TelephoneRecordings { get; set; }
        public virtual ICollection<VisitAssessor> VisitAssessors { get; set; }
    }
}
