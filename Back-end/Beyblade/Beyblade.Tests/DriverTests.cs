using Beyblade.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Beyblade.Tests
{
    [TestClass]
    public class DriverTests
    {
        [TestMethod]
        public void Should_Driver_IfNameIsNullOrEmpty_ThrowError()
        {
            string name = null;
            DriverType type = DriverType.Attack;
            int weight = 15;
            int attack = 20;
            int defense = 10;
            int stamina = 10;

            try
            {
                Driver driver = new Driver(name, type, weight, attack, defense, stamina);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("The Driver should have a name.", exception.Message);
            }
        }

        [TestMethod]
        public void Should_Driver_IfWeightIsMoreThan15_ThrowError()
        {
            string name = "Accel";
            DriverType type = DriverType.Attack;
            int weight = 16;
            int attack = 20;
            int defense = 10;
            int stamina = 10;

            try
            {
                Driver driver = new Driver(name, type, weight, attack, defense, stamina);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("There aren't any drivers that weight over 15 grams.", exception.Message);
            }
        }

        [TestMethod]
        public void Should_Driver_IfAttackIsMoreThan100_ThrowError()
        {
            string name = "Accel";
            DriverType type = DriverType.Attack;
            int weight = 15;
            int attack = 102;
            int defense = 10;
            int stamina = 10;

            try
            {
                Driver driver = new Driver(name, type, weight, attack, defense, stamina);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("The attack of the Driver can't be over 100 points.", exception.Message);
            }
        }

        [TestMethod]
        public void Should_Driver_IfDefenseIsMoreThan100_ThrowError()
        {
            string name = "Accel";
            DriverType type = DriverType.Attack;
            int weight = 15;
            int attack = 20;
            int defense = 103;
            int stamina = 10;

            try
            {
                Driver driver = new Driver(name, type, weight, attack, defense, stamina);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("The defense of the Driver can't be over 100 points.", exception.Message);
            }
        }

        [TestMethod]
        public void Should_Driver_IfStaminaIsMoreThan100_ThrowError()
        {
            string name = "Accel";
            DriverType type = DriverType.Attack;
            int weight = 15;
            int attack = 20;
            int defense = 10;
            int stamina = 102;

            try
            {
                Driver driver = new Driver(name, type, weight, attack, defense, stamina);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("The stamina of the Driver can't be over 100 points.", exception.Message);
            }
        }

        [TestMethod]
        public void Should_Driver_IfDefenseIsEqualToAttack_ThrowError()
        {
            string name = "Accel";
            DriverType type = DriverType.Attack;
            int weight = 15;
            int attack = 20;
            int defense = 20;
            int stamina = 10;

            try
            {
                Driver driver = new Driver(name, type, weight, attack, defense, stamina);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("The defense and the attack of the Driver should have a difference of minimum 10 points.", exception.Message);
            }
        }

        [TestMethod]
        public void Should_Driver_IfDefenseAndAttackHaveDifferenceOfLessThanTen_ThrowError()
        {
            string name = "Accel";
            DriverType type = DriverType.Attack;
            int weight = 15;
            int attack = 20;
            int defense = 15;
            int stamina = 10;

            try
            {
                Driver driver = new Driver(name, type, weight, attack, defense, stamina);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("The defense and the attack of the Driver should have a difference of minimum 10 points.", exception.Message);
            }
        }

        [TestMethod]
        public void Should_Driver_IfStaminaIsEqualToAttack_ThrowError()
        {
            string name = "Accel";
            DriverType type = DriverType.Attack;
            int weight = 15;
            int attack = 20;
            int defense = 9;
            int stamina = 20;

            try
            {
                Driver driver = new Driver(name, type, weight, attack, defense, stamina);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("The stamina and the attack of the Driver should have a difference of minimum 5 points.", exception.Message);
            }
        }

        [TestMethod]
        public void Should_Driver_IfStaminaAndAttackHaveDifferenceOfLessThanFive_ThrowError()
        {
            string name = "Accel";
            DriverType type = DriverType.Attack;
            int weight = 15;
            int attack = 20;
            int defense = 10;
            int stamina = 16;

            try
            {
                Driver driver = new Driver(name, type, weight, attack, defense, stamina);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("The stamina and the attack of the Driver should have a difference of minimum 5 points.", exception.Message);
            }
        }
    }
}
