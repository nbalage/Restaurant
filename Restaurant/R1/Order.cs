using Epam.Mep.Restaurant.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epam.Mep.Restaurant
{
    public class Order
    {
        public IEnumerable<string> Extras { get; set; }

        public string Food { get; set; }

        public Order(string food, IEnumerable<string> extras)
        {
            this.Food = food;
            this.Extras = extras;
        }

        public void NotifyReady(IFood food)
        {
            Console.WriteLine($"Order: Notify observers of Order [{food.ToString()}]...");

            FoodReady(this, new FoodReadyEventArgs { Food = food });

            Console.WriteLine("Order: Notification done.");
        }

        public event EventHandler<FoodReadyEventArgs> FoodReady;

        public override string ToString()
        {
            var retval = $"[food={Food.ToUpper()}, extras=";
            foreach (string e in Extras)
            {
                if (e != Extras.First() && e != Extras.Last())
                {
                    retval += ", ";
                }
                retval += $"[{e.ToUpper()}]";
            }
            retval += "]";
            return retval;
        }
    }
}
