using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using build.Models.Balance;
using build.Models.Tenant;
using build.Models.EventLog;
using build.Models.Inventory;

namespace build.Models
{
    public class Property
    {
        public int propertyID { get; set; }
        public string name { get; set; }
        public string details {get;set;}
        public ICollection<Event> Events {get;set;}
        public ICollection<Item> Items {get;set;}
        public ICollection<Transaction> Transactions {get;set;}
    }
}