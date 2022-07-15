using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using build.Models;
using build.Models.EventLog;
using build.Models.Inventory;
using build.Models.Balance;
using build.Models.Tenant;

namespace build.Data
{
    public class DbInitializer
    {
        public static void Initialize(PropertiesContext context)
        {
            context.Database.EnsureCreated();
            if (context.Properties.Any())
            {
                return;   // DB has been seeded
            }
            var properties =new Property[] // FIll in dummy data here
            {
                new Property{propertyID=1, name="Random Property 1", details="A truly random, mythical property."},
                new Property{propertyID=2, name="Random Property 2", details="Another truly random, mythical property."},
                new Property{propertyID=3, name="Random Property 3", details="One more truly random, mythical property."}
            };
            foreach (Property s in properties)
            {
                context.Properties.Add(s);
            }
            context.SaveChanges();
            var events =new Event[] // FIll in data here
            {
                new Event{eventID=1,PropertyID=1,name="Inauguration", description="Opening House to the market", time=new DateTime(2022,10,1,12,0,0)},
                new Event{eventID=2,PropertyID=1,name="Inauguration", description="Opening House to the market", time=new DateTime(2022,10,1,12,0,0)},
                new Event{eventID=3,PropertyID=1,name="Inauguration", description="Opening House to the market", time=new DateTime(2022,10,1,12,0,0)},
            };
            foreach (Event s in events)
            {
                context.Events.Add(s);
            }
            context.SaveChanges();
            var inventory =new Item[] // FIll in data here
            {
                new Item{itemID=1,PropertyID=1,name="Door",value=350},
                new Item{itemID=2,PropertyID=2,name="Window",value=500},
                new Item{itemID=3,PropertyID=3,name="Fence",value=800},
            };
            foreach (Item s in inventory)
            {
                context.Items.Add(s);
            }            
            context.SaveChanges();
            var transactionHistory =new Transaction[] // FIll in data here
            {
                new Transaction{transactionID=1,PropertyID=1,amount=300,sender="Dr. Stone", recipient="Me", description="big brain bucks",outbound=false,date=new DateTime(2009, 6, 1, 16, 37, 0)},
                new Transaction{transactionID=2,PropertyID=1,amount=300,sender="Dr. Stone", recipient="Me", description="more big brain bucks",outbound=false,date=new DateTime(2009, 7, 1, 16, 37, 0)}
            };
            foreach (Transaction s in transactionHistory)
            {
                context.Transactions.Add(s);
            }
            context.SaveChanges();
            var tenantList =new Tenant[] // FIll in data here
            {
                new Tenant{tenantID=1,PropertyID=1,name="Joe Cocker",telephone="07969696969",email="youcanleaveyourhaton@aol.com",dateOfBirth=new DateTime(1944,5,20)}
            };
            foreach (Tenant s in tenantList)
            {
                context.Tenants.Add(s);
            }
            context.SaveChanges();
        }
    }
}