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
            if (string.IsNullOrEmpty(name))
                throw new Exception("The Beyblade should have a name.");

            if (weight > 40)
                throw new Exception("There aren't any layers that weight over 40 grams.");

            if (attack > 100)
                throw new Exception("The attack of the Layer can't be over 100 points.");

            if (defense > 100)
                throw new Exception("The defense of the Layer can't be over 100 points.");

            if (stamina > 100)
                throw new Exception("The stamina of the Layer can't be over 100 points.");

            if (defense == attack || ((defense - attack) < 10 && (defense - attack) > 0) || ((attack - defense) < 10 && (attack - defense) > 0))
                throw new Exception("The defense and the attack of the Layer should have a difference of minimum 10 points.");

            if (stamina == attack || ((stamina - attack) < 5 && (stamina - attack) > 0) || ((attack - stamina) < 5 && (attack - stamina) > 0))
                throw new Exception("The stamina and the attack of the Layer should have a difference of minimum 5 points.");

            Name = name;
            CanUseDisk = canUseDisk;
            Weight = weight;
            Attack = attack;
            Defense = defense;
            Stamina = stamina;
        }
    }
}
