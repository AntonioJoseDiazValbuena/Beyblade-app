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
        public static readonly string LAYER_NOT_FOUND = "Layer not found";
        public static readonly string DISK_NOT_FOUND = "Disk not found";
        public static readonly string DRIVER_NOT_FOUND = "Driver not found";

        public Layer ObtainLayer(string name)
        {
            Layer layer = Layers.FirstOrDefault(prop => prop.Name == name);
            if (layer == null)
                throw new Exception(LAYER_NOT_FOUND);

            return layer;
        }

        public void RegisterLayer(Layer layer)
        {
            if (Layers.Any(prop => prop.Name.ToLower() == layer.Name.ToLower()))
                throw new Exception(LAYER_WITH_SAME_NAME_ALREADY_REGISTERED);

            Layers.Add(layer);
            SaveChanges();
        }

        public void DeleteLayer(string name)
        {
            Layer layerToDelete = ObtainLayer(name);

            Layers.Remove(layerToDelete);

            SaveChanges();
        }

        public Disk ObtainDisk(string name)
        {
            Disk disk = Disks.FirstOrDefault(prop => prop.Name == name);
            if (disk == null)
                throw new Exception(DISK_NOT_FOUND);

            return disk;
        }

        public void RegisterDisk(Disk disk)
        {
            if (Disks.Any(prop => prop.Name.ToLower() == disk.Name.ToLower()))
                throw new Exception(DISK_WITH_SAME_NAME_ALREADY_REGISTERED);

            Disks.Add(disk);
            SaveChanges();
        }

        public void DeleteDisk(string name)
        {
            Disk diskToDelete = ObtainDisk(name);

            Disks.Remove(diskToDelete);

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
            Driver driver = Drivers.FirstOrDefault(prop => prop.Name == name);
            if (driver == null)
                throw new Exception(DRIVER_NOT_FOUND);

            return driver;
        }

        public void RegisterDriver(Driver driver)
        {
            if (Drivers.Any(prop => prop.Name.ToLower() == driver.Name.ToLower()))
                throw new Exception(DRIVER_WITH_SAME_NAME_ALREADY_REGISTERED);

            Drivers.Add(driver);
            SaveChanges();
        }

        public void DeleteDriver(string name)
        {
            Driver driverToDelete = ObtainDriver(name);

            Drivers.Remove(driverToDelete);

            SaveChanges();
        }
    }
}
