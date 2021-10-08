using System;
using System.Collections.Generic;
using System.Text;

namespace Beyblade.Entities
{
    public class BeybladeE
    {
        public Layer Layer { get; private set; }
        public Disk Disk { get; private set; }
        public Frame Frame { get; private set; }
        public Driver Driver { get; private set; }

        public BeybladeE(Layer layer, Disk disk, Frame frame, Driver driver)
        {
            if (layer == null)
                throw new Exception("There can't be a Beyblade if there is no layer");

            Layer = layer;

            if (layer.CanUseDisk)
            {
                if (disk == null)
                    throw new Exception("The Beyblade must use a disk if it can use it");

                Disk = disk;

                if (disk.CanUseFrame)
                    Frame = frame;
            }

            if (driver == null)
                throw new Exception("You need a driver in every Beyblade to make it work");

            Driver = driver;
        }
    }
}
