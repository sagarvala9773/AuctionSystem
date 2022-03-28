using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace PlayerService
{
    [DataContract]
    public class Auction
    {
        
        [DataMember]
        public int Id { get; set; }
        [DataMember]

        public int Season { get; set; }
        [DataMember]
        public string S_Name { get; set; }
        [DataMember]
        public int T_Player { get; set; }
        [DataMember]
        public int T_Team { get; set; }
        [DataMember]
        public int F_Player { get; set; }

        [DataMember]
        public int I_Player { get; set; }
    }
}
