﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Animals
{
    public abstract class Animal : ITalk
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }

        public Animal(string name, double weidht)
        {
            Name = name;
            Weight = weidht;
            FoodEaten = 0;
        }

        public abstract string Talk();
    }
}
