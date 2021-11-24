using Beyblade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Beyblade.Services
{
    public partial class BeybladeContext
    {
        public static readonly string LAYER_WITH_SAME_NAME_ALREADY_REGISTERED = "There's already a layer with the same name, please insert another name.";
        public static readonly string DISK_WITH_SAME_NAME_ALREADY_REGISTERED = "There's already a disk with the same name, please insert another name.";
        public static readonly string FRAME_WITH_SAME_NAME_ALREADY_REGISTERED = "There's already a frame with the same name, please insert another name.";
        public static readonly string DRIVER_WITH_SAME_NAME_ALREADY_REGISTERED = "There's already a driver with the same name, please insert another name.";

        public Layer ObtainLayer(string name)
        {
            return Layers.FirstOrDefault(prop => prop.Name.ToLower() == name.ToLower());
        }

        public void RegisterLayer(Layer layer)
        {
            if (Layers.Any(prop => prop.Name.ToLower() == layer.Name.ToLower()))
                throw new Exception(LAYER_WITH_SAME_NAME_ALREADY_REGISTERED);

            Layers.Add(layer);
            SaveChanges();
        }

        public Disk ObtainDisk(string name)
        {
            return Disks.FirstOrDefault(prop => prop.Name.ToLower() == name.ToLower());
        }

        public void RegisterDisk(Disk disk)
        {
            if (Disks.Any(prop => prop.Name.ToLower() == disk.Name.ToLower()))
                throw new Exception(DISK_WITH_SAME_NAME_ALREADY_REGISTERED);

            Disks.Add(disk);
            SaveChanges();
        }

        /*public Frame ObtainFrame(string name)
        {
            return Frames.FirstOrDefault(prop => prop.Name.ToLower() == name.ToLower());
        }

        public void RegisterFrame(Frame frame)
        {
            if (Frames.Any(prop => prop.Name.ToLower() == frame.Name.ToLower()))
                throw new Exception(FRAME_WITH_SAME_NAME_ALREADY_REGISTERED);

            Frames.Add(frame);
            SaveChanges();
        }*/

        public Driver ObtainDriver(string name)
        {
            return Drivers.FirstOrDefault(prop => prop.Name.ToLower() == name.ToLower());
        }

        public void RegisterDriver(Driver driver)
        {
            if (Drivers.Any(prop => prop.Name.ToLower() == driver.Name.ToLower()))
                throw new Exception(DRIVER_WITH_SAME_NAME_ALREADY_REGISTERED);

            Drivers.Add(driver);
            SaveChanges();
        }
    }
}
