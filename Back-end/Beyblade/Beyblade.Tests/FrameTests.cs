using Beyblade.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Beyblade.Tests
{
    [TestClass]
    public class FrameTests
    {
        [TestMethod]
        public void Should_Frame_IfNameIsNullOrEmpty_ThrowError()
        {
            string name = null;
            int weight = 15;

            try
            {
                Frame frame = new Frame(name, weight);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("The Frame should have a name.", exception.Message);
            }
        }

        [TestMethod]
        public void Should_Frame_IfWeightIsMoreThan15_ThrowError()
        {
            string name = "Valkyrie";
            int weight = 16;

            try
            {
                Frame frame = new Frame(name, weight);
                Assert.Fail();
            }
            catch (Exception exception)
            {
                Assert.AreEqual("There aren't any frames that weight over 15 grams.", exception.Message);
            }
        }
    }
}
