using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace build.Models.EventLog
{
    public class Event
    {
        public int eventID { get; set; }
        public int PropertyID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime time { get; set; }
        public Property Property {get;set;}
    }
}