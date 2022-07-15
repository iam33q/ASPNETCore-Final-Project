using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace build.Models.EventLog
{
    public class EventLogger
    {
        List<Event> content{get;set;}
        public EventLogger( List<Event> content){
            this.content =  content;
        }
        public List<Event> eventRange(DateTime dateFrom, DateTime dateTo){
            List<Event> res = new List<Event>();
            foreach(var item in this.content){
                if(DateTime.Compare(item.time,dateFrom) > 0 && DateTime.Compare(item.time,dateTo) < 0){
                    res.Add(item);
                }
            }
            return res;
        }
        public void addEvent(){
            
        }
        public void ListUpcomingForWeek(){
            // Take specified week's events and do something with them
        }
    }
}
