using System;
using System.Collections.Generic;
using System.Text;

namespace Beyblade.Entities
{
    public class Driver
    {
        public string Name { get; private set; }
        public int Weight { get; private set; }
        public int Attack { get; private set; }
        public int Defense { get; private set; }
        public int Stamina { get; private set; }

        public Driver(string name, int weight, int attack, int defense, int stamina)
        {
            if (weight > 15)
            {
                throw new Exception("There aren't any drivers that weight over 15 grams.");
            }

            Name = name;
            Weight = weight;
            Attack = attack;
            Defense = defense;
            Stamina = stamina;
        }
    }
}
