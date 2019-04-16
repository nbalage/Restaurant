using System;
using System.Collections.Generic;
using System.Text;

namespace Epam.Mep.Restaurant.Foods
{
    public class HotDog : Food
    {
        public HotDog() : base()
        {
        }

        public override double CalculateHappiness(double happiness)
        {
            return happiness + 2;
        }

        public override string ToString()
        {
            return "food=HOTDOG";
        }
    }
}
