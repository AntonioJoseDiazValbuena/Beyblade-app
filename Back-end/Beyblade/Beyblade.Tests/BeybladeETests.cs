using Beyblade.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Beyblade.Tests
{
    [TestClass]
    public class BeybladeETests
    {
        [TestMethod]
        public void Should_BeybladeE_IfLayerIsNull_ThrowError()
        {
            //Layer layer = new Layer("Valkyrie", true, 18, 20, 10, 15);
            Layer layer = null;
            //Disk disk = new Disk("Wing", false, 24, 10, 20, 18);
            Disk disk = new Disk("Wing", 24, 10, 20, 18);
            Driver driver = new Driver("Accel", DriverType.Attack, 6, 18, 8, 23);

            try
            {
                BeybladeE beyblade = new BeybladeE(layer, driver, disk);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual(BeybladeE.LAYER_REQUIRED, exception.Message);
            }
        }

        [TestMethod]
        public void Should_BeybladeE_IfLayerCantUseDiskAndAddOne_ThrowError()
        {
            Layer layer = new Layer("Valkyrie", false, 18, 20, 10, 15);
            //Disk disk = new Disk("Wing", false, 24, 10, 20, 18);
            Disk disk = new Disk("Wing", 24, 10, 20, 18);
            Driver driver = new Driver("Accel", DriverType.Attack, 6, 18, 8, 23);

            try
            {
                BeybladeE beyblade = new BeybladeE(layer, driver, disk);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual(BeybladeE.DISK_REGISTERED_WHEN_CANNOT, exception.Message);
            }
        }

        [TestMethod]
        public void Should_BeybladeE_IfLayerCanUseDiskAndAndDontHaveOne_ThrowError()
        {
            Layer layer = new Layer("Valkyrie", true, 18, 20, 10, 15);
            //Disk disk = new Disk("Wing", false, 24, 10, 20, 18);
            Disk disk = null;
            Driver driver = new Driver("Accel", DriverType.Attack, 6, 18, 8, 23);

            try
            {
                BeybladeE beyblade = new BeybladeE(layer, driver, disk);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual(BeybladeE.DISK_IS_REQUIRED, exception.Message);
            }
        }

        [TestMethod]
        public void Should_BeybladeE_IfBeybladeDontHaveDriver_ThrowError()
        {
            Layer layer = new Layer("Valkyrie", true, 18, 20, 10, 15);
            //Disk disk = new Disk("Wing", false, 24, 10, 20, 18);
            Disk disk = new Disk("Wing", 24, 10, 20, 18);
            Driver driver = null;

            try
            {
                BeybladeE beyblade = new BeybladeE(layer, driver, disk);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual(BeybladeE.DRIVER_IS_REQUIRED, exception.Message);
            }
        }
    }
}
