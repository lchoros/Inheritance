﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const decimal DefaultCoffeePrice = 3.50M;
        private const double DefaultCoffeeMilliliters = 50;

        public Coffee(string name, double caffeine)
            : base(name, DefaultCoffeePrice, DefaultCoffeeMilliliters)

        {
            this.Caffeine = caffeine;
        }

        public double Caffeine { get; set; }
    }
}
