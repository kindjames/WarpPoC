using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class CommunicationType
    {
        public CommunicationType()
        {
            this.ClientCommunicationLogs = new List<ClientCommunicationLog>();
            this.CommunicationPreferences = new List<CommunicationPreference>();
        }

        public byte CommunicationTypeID { get; set; }
        public string Name { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ClientCommunicationLog> ClientCommunicationLogs { get; set; }
        public virtual ICollection<CommunicationPreference> CommunicationPreferences { get; set; }
    }
}
