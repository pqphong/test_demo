using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory.ObjectFactory;

namespace Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory.Tests
{
    public partial class ObjectFactoryTest
    {
        [TestMethod]
        public void createInstanceTest_5_1()
        {
            // Arrange

            // Act
            TestInterface01 instance = invokeCreateInstance<TestInterface01>();

            // Assert
            Assert.AreEqual(null, instance);
        }

        [TestMethod]
        public void createInstanceTest_5_2()
        {
            // Arrange

            // Act
            TestType04 instance = invokeCreateInstance<TestType04>();

            // Assert
            Assert.AreNotEqual(null, instance);
        }
        [TestMethod]
        public void createInstanceTest_5_3()
        {
            // Arrange

            // Act
            TestType05 instance = invokeCreateInstance<TestType05>();

            // Assert
            Assert.AreNotEqual(null, instance);
        }


        private T invokeCreateInstance<T>()
        {
            return (T)typeof(ObjectFactory)
                .GetMethod("createInstance", BindingFlags.NonPublic | BindingFlags.Static)
                .Invoke(null, new object[] { typeof(T) });
        }
    }
}
