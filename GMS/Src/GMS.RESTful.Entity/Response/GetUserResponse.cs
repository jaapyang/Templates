using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace GMS.RESTful.Entity
{
    [Serializable]
    [DataContract]
    public class GetUserResponse
    {
        [DataMember]
        public virtual String LoginName { get; set; }
        [DataMember]
        public virtual int UserID { get; set; }       

    }
}
