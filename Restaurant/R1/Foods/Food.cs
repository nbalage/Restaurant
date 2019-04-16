﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Epam.Mep.Restaurant.Foods
{
    public abstract class Food : IFood
    {
        protected Food()
        {

        }

        public abstract double CalculateHappiness(double happiness);
    }
}
