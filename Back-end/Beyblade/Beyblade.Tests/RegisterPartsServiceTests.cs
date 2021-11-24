using Beyblade.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Beyblade.Services.Interfaces;
using Beyblade.Entities;

namespace Beyblade.Tests
{
    [TestClass]
    public class RegisterPartsServiceTests
    {
        private IServiceProvider _servicesProvider;
        private IBeybladeServices _services;

        [TestInitialize]
        public void Initalize()
        {
            ServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddDbContext<IBeybladeServices, BeybladeContext>((prov, obj) => {
                obj.UseInMemoryDatabase("Tests");
            });

            _servicesProvider = serviceCollection.BuildServiceProvider();
            _services = _servicesProvider.GetService<IBeybladeServices>();
        }

        [TestMethod]
        public void Should_RegisterLayer()
        {
            Layer expectedLayer = new Layer("Ragnaruk", true, 20, 20, 10, 15);

            _services.RegisterLayer(new Layer("Ragnaruk", true, 20, 20, 10, 15));

            Layer actualLayer = _services.ObtainLayer("Ragnaruk");

            Assert.AreEqual(expectedLayer.Name, actualLayer.Name);
            Assert.AreEqual(expectedLayer.CanUseDisk, actualLayer.CanUseDisk);
            Assert.AreEqual(expectedLayer.Weight, actualLayer.Weight);
            Assert.AreEqual(expectedLayer.Attack, actualLayer.Attack);
            Assert.AreEqual(expectedLayer.Defense, actualLayer.Defense);
            Assert.AreEqual(expectedLayer.Stamina, actualLayer.Stamina);
        }

        [TestMethod]
        public void Should_RegisterLayer_WhenTryingToRegisterALayerAndTheresRegisteredAlreadyOneWithTheSameName_ThrowError()
        {
            _services.RegisterLayer(new Layer("Valkyrie", true, 20, 20, 10, 15));

            try
            {
                _services.RegisterLayer(new Layer("Valkyrie", true, 20, 20, 10, 15));
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual(BeybladeContext.LAYER_WITH_SAME_NAME_ALREADY_REGISTERED, exception.Message);
            }
        }

        [TestMethod]
        public void Should_RegisterDisk()
        {
            //Disk expectedDisk = new Disk("Wing", false, 19, 20, 10, 15);
            Disk expectedDisk = new Disk("Wing", 19, 20, 10, 15);

            //_services.RegisterDisk(new Disk("Wing", false, 19, 20, 10, 15));
            _services.RegisterDisk(new Disk("Wing", 19, 20, 10, 15));

            Disk actualDisk = _services.ObtainDisk("Wing");

            Assert.AreEqual(expectedDisk.Name, actualDisk.Name);
            //Assert.AreEqual(expectedDisk.CanUseFrame, actualDisk.CanUseFrame);
            Assert.AreEqual(expectedDisk.Weight, actualDisk.Weight);
            Assert.AreEqual(expectedDisk.Attack, actualDisk.Attack);
            Assert.AreEqual(expectedDisk.Defense, actualDisk.Defense);
            Assert.AreEqual(expectedDisk.Stamina, actualDisk.Stamina);
        }

        [TestMethod]
        public void Should_RegisterDisk_WhenTryingToRegisterADiskAndTheresRegisteredAlreadyOneWithTheSameName_ThrowError()
        {
            //_services.RegisterDisk(new Disk("Heavy", false, 19, 10, 20, 15));
            _services.RegisterDisk(new Disk("Heavy", 19, 10, 20, 15));

            try
            {
                //_services.RegisterDisk(new Disk("Heavy", false, 19, 10, 20, 15));
                _services.RegisterDisk(new Disk("Heavy", 19, 10, 20, 15));
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual(BeybladeContext.DISK_WITH_SAME_NAME_ALREADY_REGISTERED, exception.Message);
            }
        }

        /*[TestMethod]
        public void Should_RegisterFrame()
        {
            Frame expectedFrame = new Frame("Lift", 9);

            _services.RegisterFrame(new Frame("Lift", 9));

            Frame actualFrame = _services.ObtainFrame("Lift");

            Assert.AreEqual(expectedFrame.Name, actualFrame.Name);
            Assert.AreEqual(expectedFrame.Weight, actualFrame.Weight);
        }

        [TestMethod]
        public void Should_RegisterFrame_WhenTryingToRegisterAFrameAndTheresRegisteredAlreadyOneWithTheSameName_ThrowError()
        {
            _services.RegisterFrame(new Frame("Vortex", 10));

            try
            {
                _services.RegisterFrame(new Frame("Vortex", 10));
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual(BeybladeContext.FRAME_WITH_SAME_NAME_ALREADY_REGISTERED, exception.Message);
            }
        }*/

        [TestMethod]
        public void Should_RegisterDriver()
        {
            Driver expectedDriver = new Driver("Accel", DriverType.Attack, 15, 20, 10, 15);

            _services.RegisterDriver(new Driver("Accel", DriverType.Attack, 15, 20, 10, 15));

            Driver actualDriver = _services.ObtainDriver("Accel");

            Assert.AreEqual(expectedDriver.Name, actualDriver.Name);
            Assert.AreEqual(expectedDriver.Weight, actualDriver.Weight);
        }

        [TestMethod]
        public void Should_RegisterDriver_WhenTryingToRegisterADriverAndTheresRegisteredAlreadyOneWithTheSameName_ThrowError()
        {
            _services.RegisterDriver(new Driver("Survive", DriverType.Stamina, 15, 20, 10, 15));

            try
            {
                _services.RegisterDriver(new Driver("Survive", DriverType.Stamina, 15, 20, 10, 15));
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual(BeybladeContext.DRIVER_WITH_SAME_NAME_ALREADY_REGISTERED, exception.Message);
            }
        }
    }
}
