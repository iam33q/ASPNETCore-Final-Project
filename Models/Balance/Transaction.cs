using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace build.Models.Balance
{
    public class Transaction
    {
        public int transactionID { get; set; }
        public int PropertyID { get; set; }
        public float amount { get; set; }
        public string sender { get; set; }
        public string recipient { get; set; }
        public string description { get; set; }
        public bool outbound {get;set;}
        public DateTime date {get;set;}
        public Property Property {get;set;}
    }
}