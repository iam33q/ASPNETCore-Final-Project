using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace build.Models
{
    public class Address
    {
        public string street { get; set; } = "Random Street";
        public string number {get; set;} = "123";
        public string postCode { get; set; } ="abc123";
        public string city { get; set; } ="Random Towm";
        public DateOnly moveInDate {get;set;}
        public Address(string street, string number, string postCode, string city){
            this.street = street;
            this.number = number;
            this.postCode=postCode;
            this.city=city;
        }
        public Address(){
            this.street = street;
            this.number = number;
            this.postCode=postCode;
            this.city=city;
        }
        public string toString(){
            return this.number+" "+this.street+", "+this.city+", "+this.postCode;
        }
    }
}