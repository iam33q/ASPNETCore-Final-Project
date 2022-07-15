using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace build.Models.Inventory
{
    public class InventoryBase
    {
        public List<Item> content { get; set; }
        public InventoryBase(List<Item> content){
            this.content=content;
        }
    }
}