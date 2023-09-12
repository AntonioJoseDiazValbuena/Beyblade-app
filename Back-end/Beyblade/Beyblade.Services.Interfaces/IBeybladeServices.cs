using Beyblade.Entities;
using System;
using System.Collections.Generic;

namespace Beyblade.Services.Interfaces
{
    public interface IBeybladeServices
    {
        List<Layer> ObtainLayers();
        Layer ObtainLayer(int id);
        void RegisterLayer(Layer layer);
        void DeleteLayer(int name);
        List<Disk> ObtainDisks();
        Disk ObtainDisk(int id);
        void RegisterDisk(Disk disk);
        void DeleteDisk(int id);
        /*List<Frame> ObtainFrames();
        Frame ObtainFrame(string name);
        void RegisterFrame(Frame frame);
        void DeleteFrame(string name);*/
        List<Driver> ObtainDrivers();
        Driver ObtainDriver(int id);
        void RegisterDriver(Driver driver);
        void DeleteDriver(int id);

        string StartBattle(BeybladeE firstBeyblade, BeybladeE secondBeyblade);
    }
}
