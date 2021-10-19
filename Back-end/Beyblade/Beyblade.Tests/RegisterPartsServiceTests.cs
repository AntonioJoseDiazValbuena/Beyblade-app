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
            Layer excpectedLayer = new Layer("Valkyrie", true, 20, 20, 10, 15);

            _services.RegisterLayer(new Layer("Valkyrie", true, 20, 20, 10, 15));

            Layer actualLayer = _services.ObtainLayer("Valkyrie");

            Assert.AreEqual(excpectedLayer.Name, actualLayer.Name);
            Assert.AreEqual(excpectedLayer.CanUseDisk, actualLayer.CanUseDisk);
            Assert.AreEqual(excpectedLayer.Weight, actualLayer.Weight);
            Assert.AreEqual(excpectedLayer.Attack, actualLayer.Attack);
            Assert.AreEqual(excpectedLayer.Defense, actualLayer.Defense);
            Assert.AreEqual(excpectedLayer.Stamina, actualLayer.Stamina);
        }
    }
}
