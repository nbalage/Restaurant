using System;
using System.Collections.Generic;
using System.Text;

namespace Epam.Mep.Restaurant.Foods
{
    public class Chips : Food
    {
        public Chips() : base()
        {

        }

        public override double CalculateHappiness(double happiness)
        {
            return happiness * 1.05;
        }

        public override string ToString()
        {
            return "food=CHIPS";
        }
    }
}
