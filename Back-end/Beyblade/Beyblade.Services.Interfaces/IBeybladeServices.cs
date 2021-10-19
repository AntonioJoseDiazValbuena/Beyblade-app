using Beyblade.Entities;
using System;

namespace Beyblade.Services.Interfaces
{
    public interface IBeybladeServices
    {
        Layer ObtainLayer(string name);
        void RegisterLayer(Layer layer);
        void RegisterDisk(Disk disk);
        void RegisterFrame(Frame frame);
        void RegisterDriver(Driver driver);
    }
}
