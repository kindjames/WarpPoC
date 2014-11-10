namespace Warp.Data.Entities
{
    public partial class SubDynamicQuestion
    {
        public int SubDynamicQuestionID { get; set; }
        public int MasterSubQuestionnaireQuestionOverwriteID { get; set; }
        public int PossibleAnswerID { get; set; }
        public int ChildSubQuestionnaireQuestionOverwriteID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual PossibleAnswer PossibleAnswer { get; set; }
        public virtual SubQuestionnaireQuestionOverwrite SubQuestionnaireQuestionOverwrite { get; set; }
        public virtual SubQuestionnaireQuestionOverwrite SubQuestionnaireQuestionOverwrite1 { get; set; }
    }
}
