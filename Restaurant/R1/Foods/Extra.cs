using System;
using System.Collections.Generic;
using System.Text;

namespace Epam.Mep.Restaurant.Foods
{
    public abstract class Extra : IFood
    {
        public IFood Food { get; set; }

        internal Extra(IFood food)
        {
            this.Food = food;
        }

        public abstract double CalculateHappiness(double happiness);
    }
}
