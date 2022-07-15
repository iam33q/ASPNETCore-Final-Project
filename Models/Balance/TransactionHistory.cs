using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace build.Models.Balance
{
    public class TransactionHistory
    {
        public List<Transaction> content { get; set; } = new List<Transaction>();
        public float total {get;set;}=0;

        public float getTotal(){
            float total =0;
            foreach(var item in this.content){
                if(item.outbound){
                    total -= item.amount;
                } else total += item.amount;
            }
            return total;
        }
        public List<Transaction> rangeBalance(DateTime dateFrom, DateTime dateTo){ // Limits the time domain
            List<Transaction> container = new List<Transaction>();
            foreach(var item in this.content){
                if (DateTime.Compare(item.date,dateFrom) > 0 && DateTime.Compare(item.date,dateTo) < 0){
                    container.Add(item);
                }
            }
            return container;
        }

        public void GenerateStatement(){
            //big research time 
            //document builder (html+convert?)
        }
    }
}
