using Beyblade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Beyblade.Services
{
    public partial class BeybladeContext
    {
        public static readonly string DRAW = "It's a draw";
        public static readonly string WINNER = "The winner of the battle is:";

        public List<Layer> ObtainLayers()
        {
            return Layers.OrderBy(layer => layer.Name.ToLower()).ToList();
        }

        public List<Disk> ObtainDisks()
        {
            return Disks.OrderBy(layer => layer.Name.ToLower()).ToList();
        }

        public List<Frame> ObtainFrames()
        {
            return Frames.OrderBy(layer => layer.Name.ToLower()).ToList();
        }

        public List<Driver> ObtainDrivers()
        {
            return Drivers.OrderBy(layer => layer.Name.ToLower()).ToList();
        }

        public string StartBattle(BeybladeE firstBeyblade, BeybladeE secondBeyblade)
        {
            int firstBeybladePoints = firstBeyblade.Attack + firstBeyblade.Defense + firstBeyblade.Stamina;
            int secondBeybladePoints = secondBeyblade.Attack + secondBeyblade.Defense + secondBeyblade.Stamina;

            switch (firstBeyblade.Driver.Type, secondBeyblade.Driver.Type)
            {
                case (DriverType.Attack, DriverType.Stamina):
                    {
                        firstBeybladePoints += 15;
                        break;
                    }

                case (DriverType.Attack, DriverType.Defense):
                    {
                        secondBeybladePoints += 15;
                        break;
                    }
                case (DriverType.Defense, DriverType.Stamina):
                    {
                        secondBeybladePoints += 15;
                        break;
                    }
                case (DriverType.Stamina, DriverType.Attack):
                    {
                        secondBeybladePoints += 15;
                        break;
                    }
                case (DriverType.Defense, DriverType.Attack):
                    {
                        firstBeybladePoints += 15;
                        break;
                    }
                case (DriverType.Stamina, DriverType.Defense):
                    {
                        firstBeybladePoints += 15;
                        break;
                    }
            }

            //if (firstBeyblade.Driver.Type == DriverType.Attack && secondBeyblade.Driver.Type == DriverType.Stamina)
            //    firstBeybladePoints += 15;

            //else if (firstBeyblade.Driver.Type == DriverType.Attack && secondBeyblade.Driver.Type == DriverType.Defense)
            //    secondBeybladePoints += 15;

            //else if (firstBeyblade.Driver.Type == DriverType.Defense && secondBeyblade.Driver.Type == DriverType.Stamina)
            //    secondBeybladePoints += 15;

            //else if (secondBeyblade.Driver.Type == DriverType.Attack && firstBeyblade.Driver.Type == DriverType.Stamina)
            //    secondBeybladePoints += 15;

            //else if (secondBeyblade.Driver.Type == DriverType.Attack && firstBeyblade.Driver.Type == DriverType.Defense)
            //    firstBeybladePoints += 15;

            //else if (secondBeyblade.Driver.Type == DriverType.Defense && firstBeyblade.Driver.Type == DriverType.Stamina)
            //    firstBeybladePoints += 15;

            if (firstBeyblade.weight > secondBeyblade.weight)
                firstBeybladePoints += (firstBeyblade.weight - secondBeyblade.weight);
            else if (firstBeyblade.weight < secondBeyblade.weight)
                secondBeybladePoints += (secondBeyblade.weight - firstBeyblade.weight);

            if (firstBeybladePoints > secondBeybladePoints)
                return $"{WINNER} {firstBeyblade.Layer.Name} {firstBeyblade.Disk.Name} {firstBeyblade.Driver.Name}";
            else if (firstBeybladePoints < secondBeybladePoints)
                return $"{WINNER} {secondBeyblade.Layer.Name} {secondBeyblade.Disk.Name} {secondBeyblade.Driver.Name}";

            return DRAW;
        }
    }
}
