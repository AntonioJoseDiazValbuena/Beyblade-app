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
        List<Disk> ObtainDisks();
        Disk ObtainDisk(string name);
        void RegisterDisk(Disk disk);
        /*List<Frame> ObtainFrames();
        Frame ObtainFrame(string name);
        void RegisterFrame(Frame frame);*/
        List<Driver> ObtainDrivers();
        Driver ObtainDriver(string name);
        void RegisterDriver(Driver driver);

        string StartBattle(BeybladeE firstBeyblade, BeybladeE secondBeyblade);
    }
}
