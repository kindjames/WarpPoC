namespace Warp.Data.Entities
{
    public partial class AssessorCallBackRequest
    {
        public int AssessorCallBackRequestID { get; set; }
        public int AssessorID { get; set; }
        public int CallBackRequestID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual CallBackRequest CallBackRequest { get; set; }
    }
}
