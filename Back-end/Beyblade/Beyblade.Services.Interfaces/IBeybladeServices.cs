using Beyblade.Entities;
using System;
using System.Collections.Generic;

namespace Beyblade.Services.Interfaces
{
    public interface IBeybladeServices
    {
        List<Layer> ObtainLayers();
        Layer ObtainLayer(string name);
        void RegisterLayer(Layer layer);
        void DeleteLayer(string name);
        List<Disk> ObtainDisks();
        Disk ObtainDisk(string name);
        void RegisterDisk(Disk disk);
        void DeleteDisk(string name);
        /*List<Frame> ObtainFrames();
        Frame ObtainFrame(string name);
        void RegisterFrame(Frame frame);
        void DeleteFrame(string name);*/
        List<Driver> ObtainDrivers();
        Driver ObtainDriver(string name);
        void RegisterDriver(Driver driver);
        void DeleteDriver(string name);

        string StartBattle(BeybladeE firstBeyblade, BeybladeE secondBeyblade);
    }
}
