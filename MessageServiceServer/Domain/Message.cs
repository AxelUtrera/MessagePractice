using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [DataContract]
    public class Message
    {
        private User userMessage;
        private string messageData;
        private DateTime dateMessage;

        [DataMember]
        public User UserMessage { get { return userMessage; } set { userMessage = value; } }
        [DataMember]
        public string MessageData { get { return messageData; } set { messageData = value; } }
        [DataMember]
        public DateTime DateMessage { get { return dateMessage; } set { dateMessage = value; } }

    }
}
