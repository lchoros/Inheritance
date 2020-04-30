﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        private const decimal DefaultCakePrice = 5M;
        private const double DefaultGrams = 250;
        private const double DefaultCalories = 1000;

        public Cake(string name)
            : base(name, DefaultCakePrice, DefaultGrams, DefaultCalories)
        {

        }
    }
}
