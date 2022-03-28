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
    public class Team
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string T_Name { get; set; }
        [DataMember]
        public string T_Owner { get; set; }
        [DataMember]
        public int T_BValue { get; set; }
        [DataMember]
        public string T_Captain { get; set; }
      
        [DataMember]
        public string T_HCoach { get; set; }
    }
}
