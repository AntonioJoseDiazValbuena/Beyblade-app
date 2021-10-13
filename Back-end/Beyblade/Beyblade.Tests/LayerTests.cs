using Beyblade.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Beyblade.Tests
{
    [TestClass]
    public class LayerTests
    {
        [TestMethod]
        public void Should_Layer_IfNameIsNullOrEmpty_ThrowError()
        {
            string name = null;
            bool canUseDisk = true;
            int weight = 41;
            int attack = 20;
            int defense = 10;
            int stamina = 10;

            try
            {
                Layer layer = new Layer(name, canUseDisk, weight, attack, defense, stamina);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("The Beyblade should have a name.", exception.Message);
            }
        }

        [TestMethod]
        public void Should_Layer_IfWeightIsMoreThan40_ThrowError()
        {
            string name = "Valkyrie";
            bool canUseDisk = true;
            int weight = 41;
            int attack = 20;
            int defense = 10;
            int stamina = 10;

            try
            {
                Layer layer = new Layer(name, canUseDisk, weight, attack, defense, stamina);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("There aren't any layers that weight over 40 grams.", exception.Message);
            }
        }

        [TestMethod]
        public void Should_Layer_IfAttackIsMoreThan100_ThrowError()
        {
            string name = "Valkyrie";
            bool canUseDisk = true;
            int weight = 20;
            int attack = 102;
            int defense = 10;
            int stamina = 10;

            try
            {
                Layer layer = new Layer(name, canUseDisk, weight, attack, defense, stamina);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("The attack of the Layer can't be over 100 points.", exception.Message);
            }
        }

        [TestMethod]
        public void Should_Layer_IfDefenseIsMoreThan100_ThrowError()
        {
            string name = "Valkyrie";
            bool canUseDisk = true;
            int weight = 20;
            int attack = 20;
            int defense = 103;
            int stamina = 10;

            try
            {
                Layer layer = new Layer(name, canUseDisk, weight, attack, defense, stamina);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("The defense of the Layer can't be over 100 points.", exception.Message);
            }
        }

        [TestMethod]
        public void Should_Layer_IfStaminaIsMoreThan100_ThrowError()
        {
            string name = "Valkyrie";
            bool canUseDisk = true;
            int weight = 20;
            int attack = 20;
            int defense = 10;
            int stamina = 102;

            try
            {
                Layer layer = new Layer(name, canUseDisk, weight, attack, defense, stamina);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("The stamina of the Layer can't be over 100 points.", exception.Message);
            }
        }

        [TestMethod]
        public void Should_Layer_IfDefenseIsEqualToAttack_ThrowError()
        {
            string name = "Valkyrie";
            bool canUseDisk = true;
            int weight = 20;
            int attack = 20;
            int defense = 20;
            int stamina = 10;

            try
            {
                Layer layer = new Layer(name, canUseDisk, weight, attack, defense, stamina);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("The defense and the attack of the Layer should have a difference of minimum 10 points.", exception.Message);
            }
        }

        [TestMethod]
        public void Should_Layer_IfDefenseAndAttackHaveDifferenceOfLessThanTen_ThrowError()
        {
            string name = "Valkyrie";
            bool canUseDisk = true;
            int weight = 20;
            int attack = 20;
            int defense = 15;
            int stamina = 10;

            try
            {
                Layer layer = new Layer(name, canUseDisk, weight, attack, defense, stamina);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("The defense and the attack of the Layer should have a difference of minimum 10 points.", exception.Message);
            }
        }

        [TestMethod]
        public void Should_Layer_IfStaminaIsEqualToAttack_ThrowError()
        {
            string name = "Valkyrie";
            bool canUseDisk = true;
            int weight = 20;
            int attack = 20;
            int defense = 9;
            int stamina = 20;

            try
            {
                Layer layer = new Layer(name, canUseDisk, weight, attack, defense, stamina);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("The stamina and the attack of the Layer should have a difference of minimum 5 points.", exception.Message);
            }
        }

        [TestMethod]
        public void Should_Layer_IfStaminaAndAttackHaveDifferenceOfLessThanFive_ThrowError()
        {
            string name = "Valkyrie";
            bool canUseDisk = true;
            int weight = 20;
            int attack = 20;
            int defense = 10;
            int stamina = 16;

            try
            {
                Layer layer = new Layer(name, canUseDisk, weight, attack, defense, stamina);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("The stamina and the attack of the Layer should have a difference of minimum 5 points.", exception.Message);
            }
        }
    }
}
