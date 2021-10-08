using Beyblade.Entities;
using System;

namespace Beyblade.Services.Interfaces
{
    public interface IBeybladeContext
    {
        void RegisterLayer(Layer layer);
        void RegisterDisk(Disk disk);
        void RegisterFrame(Frame frame);
        void RegisterDriver(Driver driver);
    }
}
