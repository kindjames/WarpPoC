namespace Warp.Data.Entities
{
    public partial class ClientCommunicationLog
    {
        public int ClientCommunicationLogID { get; set; }
        public byte CommunicationStatusID { get; set; }
        public int PersonID { get; set; }
        public byte CommunicationTypeID { get; set; }
        public string Details { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual CommunicationStatu CommunicationStatu { get; set; }
        public virtual CommunicationType CommunicationType { get; set; }
    }
}
