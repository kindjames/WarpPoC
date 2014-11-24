using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class Assessor
    {
        public Assessor()
        {
            AssessorAttributes = new List<AssessorAttribute>();
            AssessorCallBackRequests = new List<AssessorCallBackRequest>();
            AssessorCallInLogs = new List<AssessorCallInLog>();
            AssessorExpenses = new List<AssessorExpense>();
            AssessorGeographicPostCodes = new List<AssessorGeographicPostCode>();
            AssessorHistories = new List<AssessorHistory>();
            AssessorNotes = new List<AssessorNote>();
            AssessorTimeTrackers = new List<AssessorTimeTracker>();
            AuditAssessorEvents = new List<AuditAssessorEvent>();
            BanBranches = new List<BanBranch>();
            BanBrands = new List<BanBrand>();
            BanClients = new List<BanClient>();
            CommunicationPreferences = new List<CommunicationPreference>();
            ForumAssessorReplies = new List<ForumAssessorReply>();
            ForumReportedReplies = new List<ForumReportedReply>();
            ForumThreads = new List<ForumThread>();
            Points = new List<Point>();
            QuestionResults = new List<QuestionResult>();
            ResultComments = new List<ResultComment>();
            SimpleVisits = new List<SimpleVisit>();
            Suggestions = new List<Suggestion>();
            SuggestionVotes = new List<SuggestionVote>();
            TelephoneRecordings = new List<TelephoneRecording>();
            VisitAssessors = new List<VisitAssessor>();
        }

        public int AssessorId { get; set; }
        public int UserId { get; set; }
        public short AssessorStatusId { get; set; }
        public short AssessorLevelId { get; set; }
        public bool AssessorLevelLock { get; set; }
        public short CurrencyId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string HomeTelephone { get; set; }
        public string WorkTelephone { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string BankName { get; set; }
        public string BankAddress { get; set; }
        public string SortCode { get; set; }
        public string AccountNumber { get; set; }
        public string Occupation { get; set; }
        public byte? GenderId { get; set; }
        public DateTime DateOfLastProfileUpdate { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
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