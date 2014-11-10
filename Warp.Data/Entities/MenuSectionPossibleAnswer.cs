namespace Warp.Data.Entities
{
    public partial class MenuSectionPossibleAnswer
    {
        public int MenuSectionPossibleAnswerID { get; set; }
        public int MenuSectionID { get; set; }
        public int PossibleAnswerID { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual MenuSection MenuSection { get; set; }
        public virtual PossibleAnswer PossibleAnswer { get; set; }
    }
}
