namespace Warp.Data.Entities
{
    public partial class PasswordQuestion
    {
        public int PasswordQuestionID { get; set; }
        public string Question { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
    }
}
