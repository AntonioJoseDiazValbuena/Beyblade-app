using System;
using System.Collections.Generic;
using System.Text;

namespace Beyblade.Entities
{
    public class Layer
    {
        public string Name { get; private set; }
        public bool CanUseDisk { get; private set; }
        public int Weight { get; private set; }
        public int Attack { get; private set; }
        public int Defense { get; private set; }
        public int Stamina { get; private set; }

        public Layer(string name, bool canUseDisk, int weight, int attack, int defense, int stamina)
        {
            if (weight > 40)
            {
                throw new Exception("There aren't any layers that weight over 40 grams.");
            }

            Name = name;
            CanUseDisk = canUseDisk;
            Weight = weight;
            Attack = attack;
            Defense = defense;
            Stamina = stamina;
        }
    }
}
