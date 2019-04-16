using Epam.Mep.Restaurant.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Mep.Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Client peter = new Client("Peter", 100);
            Client berci = new Client("Berci", 200);
            Kitchen kitchen = new Kitchen();
            WaitressRobot robot = new WaitressRobot(kitchen);

            robot.TakeOrder(peter, new Order("HotDog", new List<string> { "Ketchup" }));
            robot.TakeOrder(berci, new Order("Chips", new List<string> { "Mustard" }));

            robot.ServeOrders();

            Console.ReadKey();
        }
    }
}
