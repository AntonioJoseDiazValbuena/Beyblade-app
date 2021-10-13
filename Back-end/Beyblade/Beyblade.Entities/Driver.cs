using System;
using System.Collections.Generic;
using System.Text;

namespace Beyblade.Entities
{
    public class Driver
    {
        public string Name { get; private set; }
        public DriverType Type { get; private set; }
        public int Weight { get; private set; }
        public int Attack { get; private set; }
        public int Defense { get; private set; }
        public int Stamina { get; private set; }

        public Driver(string name, DriverType type, int weight, int attack, int defense, int stamina)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("The Driver should have a name.");

            if (weight > 15)
                throw new Exception("There aren't any drivers that weight over 15 grams.");

            if (attack > 100)
                throw new Exception("The attack of the Driver can't be over 100 points.");

            if (defense > 100)
                throw new Exception("The defense of the Driver can't be over 100 points.");

            if (stamina > 100)
                throw new Exception("The stamina of the Driver can't be over 100 points.");

            if (defense == attack || ((defense - attack) < 10 && (defense - attack) > 0) || ((attack - defense) < 10 && (attack - defense) > 0))
                throw new Exception("The defense and the attack of the Driver should have a difference of minimum 10 points.");

            if (stamina == attack || ((stamina - attack) < 5 && (stamina - attack) > 0) || ((attack - stamina) < 5 && (attack - stamina) > 0))
                throw new Exception("The stamina and the attack of the Driver should have a difference of minimum 5 points.");

            Name = name;
            Type = type;
            Weight = weight;
            Attack = attack;
            Defense = defense;
            Stamina = stamina;
        }
    }
}
