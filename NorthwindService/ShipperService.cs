using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Configuration;

namespace NorthwindService
{
    [DataContract]
    public class MyShipper
    {
        [DataMember]
        public int ShipperId { get; set; }
        [DataMember]
        public string CompanyName { get; set; }
        [DataMember]
        public string Phone { get; set; }
    }
}