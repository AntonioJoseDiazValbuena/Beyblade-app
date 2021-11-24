using System;
using System.Collections.Generic;
using System.Text;

namespace Beyblade.Entities
{
    public class BeybladeE
    {
        public static readonly string LAYER_REQUIRED = "There can't be a Beyblade if there is no layer";
        public static readonly string DISK_REGISTERED_WHEN_CANNOT = "If the Beyblade can't use a disk, don't add one";
        public static readonly string DISK_IS_REQUIRED = "The Beyblade must use a disk if it can use it";
        public static readonly string DRIVER_IS_REQUIRED = "You need a driver in every Beyblade to make it work";

        public Layer Layer { get; private set; }
        public Disk Disk { get; private set; }
        //public Frame Frame { get; private set; }
        public Driver Driver { get; private set; }
        public int Attack { get; private set; }
        public int Defense { get; private set; }
        public int Stamina { get; private set; }
        public int Weight { get; private set; }

        //public BeybladeE(Layer layer, Driver driver, Disk disk = null, Frame frame = null)
        public BeybladeE(Layer layer, Driver driver, Disk disk = null)
        {
            if (layer == null)
                throw new Exception(BeybladeE.LAYER_REQUIRED);

            Layer = layer;

            if (layer.CanUseDisk)
            {
                if (disk == null)
                    throw new Exception(DISK_IS_REQUIRED);

                Disk = disk;

                /*if (disk.CanUseFrame)
                    Frame = frame;*/

            }
            else if (disk != null)
            {
                throw new Exception(BeybladeE.DISK_REGISTERED_WHEN_CANNOT);
            }

            if (driver == null)
                throw new Exception(DRIVER_IS_REQUIRED);

            Driver = driver;

            Attack = Layer.Attack + Disk.Attack + Driver.Attack;
            Defense = Layer.Defense + Disk.Defense + Driver.Defense;
            Stamina = Layer.Stamina + Disk.Stamina + Driver.Stamina;
            Weight = Layer.Weight + Disk.Weight + Driver.Weight;
        }
    }
}
