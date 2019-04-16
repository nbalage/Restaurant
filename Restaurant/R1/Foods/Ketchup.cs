using System;
using System.Collections.Generic;
using System.Text;

namespace Epam.Mep.Restaurant.Foods
{
    public class Ketchup : Extra
    {
        IFood food;

        public Ketchup(IFood food) : base(food)
        {
            this.food = food;
        }

        public override double CalculateHappiness(double happiness)
        {
            return food.CalculateHappiness(food.CalculateHappiness(happiness));
        }

        public override string ToString()
        {
            return $"KETCHUP[{food.ToString()}]";
        }
    }
}
