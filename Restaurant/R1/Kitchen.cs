using Epam.Mep.Restaurant.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace Epam.Mep.Restaurant
{
    public class Kitchen
    {

        private IFood AddExtras(IFood mainFood, IEnumerable<string> extras)
        {
            foreach (string extra in extras)
            {
                if (extra == nameof(Ketchup))
                {
                    mainFood = new Ketchup(mainFood);
                }
                else
                {
                    mainFood = new Mustard(mainFood);
                }
            }

            return mainFood;
        }

        internal IFood Cook(Order order)
        {
            Console.WriteLine($"Kitchen: Preparing food, order Order [{order}]");

            var preparedFood = AddExtras(CreateMainFood(order.Food), order.Extras);

            Console.WriteLine($"Kitchen: Food prepared, food: {preparedFood.ToString()}.");

            return preparedFood;
        }

        private IFood CreateMainFood(string food)
        {
            if (food == nameof(HotDog))
            {
                return new HotDog();
            }
            else
            {
                return new Chips();
            }
        }
    }
}
