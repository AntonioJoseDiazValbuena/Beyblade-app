using System;

namespace Beyblade.Entities
{
    public class Disk
    {
        public string Name { get; private set; }
        public bool CanUseFrame { get; private set; }
        public int Weight { get; private set; }
        public int Attack { get; private set; }
        public int Defense { get; private set; }
        public int Stamina { get; private set; }

        public Disk(string name, bool canUseFrame, int weight, int attack, int defense, int stamina)
        {
            if (weight > 40)
            {
                throw new Exception("There aren't any disks that weight over 40 grams.");
            }

            Name = name;
            CanUseFrame = canUseFrame;
            Weight = weight;
            Attack = attack;
            Defense = defense;
            Stamina = stamina;
        }
    }
}
