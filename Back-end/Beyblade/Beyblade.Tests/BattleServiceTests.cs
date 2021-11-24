using Beyblade.Services;
using Beyblade.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using Beyblade.Entities;

namespace Beyblade.Tests
{
    [TestClass]
    public class BattleServiceTests
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
        public void Should_StartBattle_ReturnTheBeybladeDeathscytherAsTheWinner()
        {
            Layer firstLayer = new Layer("Deathscyther", true, 20, 20, 10, 15);
            //Disk firstDisk = new Disk("Oval", false, 19, 20, 10, 15);
            Disk firstDisk = new Disk("Oval", 19, 20, 10, 15);
            Driver firstDriver = new Driver("Assault", DriverType.Attack, 15, 20, 10, 15);
            _services.RegisterLayer(firstLayer);
            _services.RegisterDisk(firstDisk);
            _services.RegisterDriver(firstDriver);

            Layer secondLayer = new Layer("Horusood", true, 20, 20, 10, 15);
            //Disk secondDisk = new Disk("Spread", false, 19, 10, 20, 15);
            Disk secondDisk = new Disk("Spread", 19, 10, 20, 15);
            Driver secondDriver = new Driver("Edge", DriverType.Stamina, 15, 20, 10, 15);
            _services.RegisterLayer(secondLayer);
            _services.RegisterDisk(secondDisk);
            _services.RegisterDriver(secondDriver);

            BeybladeE firstBeyblade = new BeybladeE(firstLayer, firstDriver, firstDisk);
            BeybladeE secondBeyblade = new BeybladeE(secondLayer, secondDriver, secondDisk);

            string expectedWinner = "The winner of the battle is: Deathscyther Oval Assault";

            string actualWinner = _services.StartBattle(firstBeyblade, secondBeyblade);

            Assert.AreEqual(expectedWinner, actualWinner);
        }

        [TestMethod]
        public void Should_StartBattle_ReturnTheBeybladeWyvernAsTheWinner()
        {
            Layer firstLayer = new Layer("Xcalibur", true, 20, 30, 5, 5);
            //Disk firstDisk = new Disk("Force", false, 19, 30, 5, 5);
            Disk firstDisk = new Disk("Force", 19, 30, 5, 5);
            Driver firstDriver = new Driver("Xtreme", DriverType.Attack, 15, 30, 5, 5);
            _services.RegisterLayer(firstLayer);
            _services.RegisterDisk(firstDisk);
            _services.RegisterDriver(firstDriver);

            Layer secondLayer = new Layer("Wyvern", true, 20, 5, 20, 10);
            //Disk secondDisk = new Disk("Armored", false, 20, 5, 20, 10);
            Disk secondDisk = new Disk("Armored", 20, 5, 20, 10);
            Driver secondDriver = new Driver("Massive", DriverType.Defense, 15, 5, 20, 10);
            _services.RegisterLayer(secondLayer);
            _services.RegisterDisk(secondDisk);
            _services.RegisterDriver(secondDriver);

            BeybladeE firstBeyblade = new BeybladeE(firstLayer, firstDriver, firstDisk);
            BeybladeE secondBeyblade = new BeybladeE(secondLayer, secondDriver, secondDisk);

            string expectedWinner = "The winner of the battle is: Wyvern Armored Massive";

            string actualWinner = _services.StartBattle(firstBeyblade, secondBeyblade);

            Assert.AreEqual(expectedWinner, actualWinner);
        }

        [TestMethod]
        public void Should_StartBattle_Say_ItsADraw()
        {
            Layer firstLayer = new Layer("Kerbeus", true, 20, 5, 20, 10);
            //Disk firstDisk = new Disk("Central", false, 20, 5, 20, 10);
            Disk firstDisk = new Disk("Central", 20, 5, 20, 10);
            Driver firstDriver = new Driver("Defense", DriverType.Defense, 15, 5, 20, 10);

            _services.RegisterLayer(firstLayer);
            _services.RegisterDisk(firstDisk);
            _services.RegisterDriver(firstDriver);

            Layer secondLayer = new Layer("Kerbeus", true, 20, 5, 20, 10);
            //Disk secondDisk = new Disk("Central", false, 20, 5, 20, 10);
            Disk secondDisk = new Disk("Central", 20, 5, 20, 10);
            Driver secondDriver = new Driver("Defense", DriverType.Defense, 15, 5, 20, 10);

            BeybladeE firstBeyblade = new BeybladeE(firstLayer, firstDriver, firstDisk);
            BeybladeE secondBeyblade = new BeybladeE(secondLayer, secondDriver, secondDisk);

            string expectedMessage = BeybladeContext.DRAW;

            string actualMessage = _services.StartBattle(firstBeyblade, secondBeyblade);

            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}
