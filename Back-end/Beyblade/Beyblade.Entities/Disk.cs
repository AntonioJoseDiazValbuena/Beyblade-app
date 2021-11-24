using System;

namespace Beyblade.Entities
{
    public class Disk
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        //public bool CanUseFrame { get; private set; }
        public int Weight { get; private set; }
        public int Attack { get; private set; }
        public int Defense { get; private set; }
        public int Stamina { get; private set; }

        //public Disk(string name, bool canUseFrame, int weight, int attack, int defense, int stamina)
        public Disk(string name, int weight, int attack, int defense, int stamina)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("The Disk should have a name.");

            if (weight > 40)
                throw new Exception("There aren't any disks that weight over 40 grams.");

            if (attack > 100)
                throw new Exception("The attack of the Disk can't be over 100 points.");

            if (defense > 100)
                throw new Exception("The defense of the Disk can't be over 100 points.");

            if (stamina > 100)
                throw new Exception("The stamina of the Disk can't be over 100 points.");

            if (defense == attack || ((defense - attack) < 10 && (defense - attack) > 0) || ((attack - defense) < 10 && (attack - defense) > 0))
                throw new Exception("The defense and the attack of the Disk should have a difference of minimum 10 points.");

            if (stamina == attack || ((stamina - attack) < 5 && (stamina - attack) > 0) || ((attack - stamina) < 5 && (attack - stamina) > 0))
                throw new Exception("The stamina and the attack of the Disk should have a difference of minimum 5 points.");

            Name = name;
            //CanUseFrame = canUseFrame;
            Weight = weight;
            Attack = attack;
            Defense = defense;
            Stamina = stamina;
        }
    }
}
