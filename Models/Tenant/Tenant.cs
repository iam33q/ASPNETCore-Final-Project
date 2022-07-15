using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace build.Models.Tenant
{
    public class Tenant
    {
        public int tenantID { get; set; }
        public int PropertyID { get; set; }
        public string name { get; set; }
        public string telephone { get; set; }
        public string email { get; set; }
        public DateTime dateOfBirth { get; set; }
        public Property Property {get;set;}
    }
}