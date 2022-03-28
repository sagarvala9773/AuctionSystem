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
    public class Player
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string P_Name { get; set; }
        [DataMember]
        public int J_No { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string P_Type { get; set; }
    }
}
