using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [DataContract]
    public class User
    {
        private string userName;
        private string ipAddress;

        [DataMember]
        public string UserName { get { return userName; } set { userName = value; } }
        [DataMember]
        public string IpAddress { get { return ipAddress; } set { ipAddress = value; } }

    }

}
