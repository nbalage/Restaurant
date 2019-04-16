using Epam.Mep.Restaurant.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Epam.Mep.Restaurant
{
    public class Waitress
    {
        private Queue<Order> Orders;
        private Kitchen Kitchen;

        public Waitress(Kitchen kitchen)
        {
            Orders = new Queue<Order>();
            this.Kitchen = kitchen;
        }

        public void ServeOrders()
        {
            foreach (Order order in Orders)
            {
                var food = Kitchen.Cook(order);
                order.NotifyReady(food);
            }

            Console.WriteLine($"WaitressRobot: Orders processed.");
        }

        public void TakeOrder(Client client, Order order)
        {
            Orders.Enqueue(order);
            order.FoodReady += client.Order_ReadyFood;

            Console.WriteLine($"WaitressRobot: Order registered, client: Client {client}, order: Order {order}.");
            Console.WriteLine($"Processing {Orders.Count} order(s)...");
        }
    }
}
