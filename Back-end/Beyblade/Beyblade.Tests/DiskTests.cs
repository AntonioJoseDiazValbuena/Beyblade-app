using Beyblade.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Beyblade.Tests
{
    [TestClass]
    public class DiskTests
    {
        [TestMethod]
        public void Should_Disk_IfNameIsNullOrEmpty_ThrowError()
        {
            string name = null;
            //bool canUseFrame = true;
            int weight = 41;
            int attack = 20;
            int defense = 10;
            int stamina = 10;

            try
            {
                //Disk disk = new Disk(name, canUseFrame, weight, attack, defense, stamina);
                Disk disk = new Disk(name, weight, attack, defense, stamina);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("The Disk should have a name.", exception.Message);
            }
        }

        [TestMethod]
        public void Should_Disk_IfWeightIsMoreThan40_ThrowError()
        {
            string name = "12";
            //bool canUseFrame = true;
            int weight = 41;
            int attack = 20;
            int defense = 10;
            int stamina = 10;

            try
            {
                //Disk disk = new Disk(name, canUseFrame, weight, attack, defense, stamina);
                Disk disk = new Disk(name, weight, attack, defense, stamina);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("There aren't any disks that weight over 40 grams.", exception.Message);
            }
        }

        [TestMethod]
        public void Should_Disk_IfAttackIsMoreThan100_ThrowError()
        {
            string name = "12";
            //bool canUseFrame = true;
            int weight = 20;
            int attack = 102;
            int defense = 10;
            int stamina = 10;

            try
            {
                //Disk disk = new Disk(name, canUseFrame, weight, attack, defense, stamina);
                Disk disk = new Disk(name, weight, attack, defense, stamina);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("The attack of the Disk can't be over 100 points.", exception.Message);
            }
        }

        [TestMethod]
        public void Should_Disk_IfDefenseIsMoreThan100_ThrowError()
        {
            string name = "12";
            //bool canUseFrame = true;
            int weight = 20;
            int attack = 20;
            int defense = 103;
            int stamina = 10;

            try
            {
                //Disk disk = new Disk(name, canUseFrame, weight, attack, defense, stamina);
                Disk disk = new Disk(name, weight, attack, defense, stamina);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("The defense of the Disk can't be over 100 points.", exception.Message);
            }
        }

        [TestMethod]
        public void Should_Disk_IfStaminaIsMoreThan100_ThrowError()
        {
            string name = "12";
            //bool canUseFrame = true;
            int weight = 20;
            int attack = 20;
            int defense = 10;
            int stamina = 102;

            try
            {
                //Disk disk = new Disk(name, canUseFrame, weight, attack, defense, stamina);
                Disk disk = new Disk(name, weight, attack, defense, stamina);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("The stamina of the Disk can't be over 100 points.", exception.Message);
            }
        }

        [TestMethod]
        public void Should_Disk_IfDefenseIsEqualToAttack_ThrowError()
        {
            string name = "12";
            //bool canUseFrame = true;
            int weight = 20;
            int attack = 20;
            int defense = 20;
            int stamina = 10;

            try
            {
                //Disk disk = new Disk(name, canUseFrame, weight, attack, defense, stamina);
                Disk disk = new Disk(name, weight, attack, defense, stamina);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("The defense and the attack of the Disk should have a difference of minimum 10 points.", exception.Message);
            }
        }

        [TestMethod]
        public void Should_Disk_IfDefenseAndAttackHaveDifferenceOfLessThanTen_ThrowError()
        {
            string name = "12";
            //bool canUseFrame = true;
            int weight = 20;
            int attack = 20;
            int defense = 15;
            int stamina = 10;

            try
            {
                //Disk disk = new Disk(name, canUseFrame, weight, attack, defense, stamina);
                Disk disk = new Disk(name, weight, attack, defense, stamina);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("The defense and the attack of the Disk should have a difference of minimum 10 points.", exception.Message);
            }
        }

        [TestMethod]
        public void Should_Disk_IfStaminaIsEqualToAttack_ThrowError()
        {
            string name = "12";
            //bool canUseFrame = true;
            int weight = 20;
            int attack = 20;
            int defense = 9;
            int stamina = 20;

            try
            {
                //Disk disk = new Disk(name, canUseFrame, weight, attack, defense, stamina);
                Disk disk = new Disk(name, weight, attack, defense, stamina);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("The stamina and the attack of the Disk should have a difference of minimum 5 points.", exception.Message);
            }
        }

        [TestMethod]
        public void Should_Disk_IfStaminaAndAttackHaveDifferenceOfLessThanFive_ThrowError()
        {
            string name = "12";
            //bool canUseFrame = true;
            int weight = 20;
            int attack = 20;
            int defense = 10;
            int stamina = 16;

            try
            {
                //Disk disk = new Disk(name, canUseFrame, weight, attack, defense, stamina);
                Disk disk = new Disk(name, weight, attack, defense, stamina);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("The stamina and the attack of the Disk should have a difference of minimum 5 points.", exception.Message);
            }
        }
    }
}
