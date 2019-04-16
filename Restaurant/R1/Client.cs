using Epam.Mep.Restaurant.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam.Mep.Restaurant
{
    public class Client
    {
        public double Happiness { get; set; }

        public string Name { get; set; }

        public Client(string name, double happiness)
        {
            Happiness = happiness;
            Name = name;
        }

        public void Eat(IFood food)
        {
            Console.WriteLine($"Client: Starting to eat food, client: Client {ToString()}, food: {food}");

            Happiness = food.CalculateHappiness(Happiness);

            Console.WriteLine("Client: Csam csam nyam nyam");
            Console.WriteLine($"Client: Food eaten, client: Client {ToString()}");
        }

        public void Order_ReadyFood(object sender, FoodReadyEventArgs e)
        {
            Eat(e.Food);
        }

        public override string ToString()
        {
            return $"[name={Name}, happiness={Happiness:F1}]";
        }
    }
}
