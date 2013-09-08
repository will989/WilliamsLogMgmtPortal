using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WilliamsLogMgmtPortal.Models
{
    
    public partial class Message
    {
        public int MessageId { get; set; }
        public int CorrelationIdentifier { get; set; }
        public int SendingOrgId { get; set; }
        public int ReceivingOrgId { get; set; }
        public int Severity { get; set; }
        public string OrgMessage { get; set; }
        public System.DateTime Timestamp { get; set; }
    
        public virtual Organization Organization { get; set; }
        public virtual Organization Organization1 { get; set; }

        //verify that message properties are valid
        public bool validate()
        {
            if (MessageId < 0) return false;
            if (CorrelationIdentifier < 0) return false;
            if (SendingOrgId < 0) return false;
            if (ReceivingOrgId < 0) return false;
            if (Severity < 0 || Severity > 4) return false;
            if (OrgMessage == null) return false;
            if (Timestamp == null) return false;
            return true;
        }//end validate

        public bool equals(Message message)
        {
            if (MessageId != message.MessageId) return false;
            if (CorrelationIdentifier != message.CorrelationIdentifier) return false;
            if (ReceivingOrgId != message.ReceivingOrgId) return false;
            if (Severity != message.Severity) return false;
            if (OrgMessage != message.OrgMessage) return false;
            if (Timestamp != message.Timestamp) return false;
            return true;
        }//end equals
    }
}
