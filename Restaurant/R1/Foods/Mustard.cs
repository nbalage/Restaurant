using System;
using System.Collections.Generic;
using System.Text;

namespace Epam.Mep.Restaurant.Foods
{
    public class Mustard : Extra
    {
        IFood food;

        public Mustard(IFood food) : base(food)
        {
            this.food = food;
        }

        public override double CalculateHappiness(double happiness)
        {
            return happiness + 1; // todo: ???
        }

        public override string ToString()
        {
            return $"MUSTARD[{food.ToString()}]";
        }
    }
}
