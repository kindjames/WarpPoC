using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ClientCommunicationLog
    {
        public int ClientCommunicationLogID { get; set; }
        public System.DateTime Timestamp { get; set; }
        public byte CommunicationStatusID { get; set; }
        public int PersonID { get; set; }
        public byte CommunicationTypeID { get; set; }
        public string Details { get; set; }
        public virtual CommunicationStatu CommunicationStatu { get; set; }
        public virtual CommunicationType CommunicationType { get; set; }
    }
}
