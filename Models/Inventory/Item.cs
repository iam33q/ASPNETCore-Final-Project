using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace build.Models.Inventory
{
    public class Item
    {
        public int itemID { get; set; }
        public int PropertyID { get; set; }
        public string name { get; set; }
        public decimal value { get; set; }
        public string description { get; set; }
        public Property Property {get;set;}
    }
}