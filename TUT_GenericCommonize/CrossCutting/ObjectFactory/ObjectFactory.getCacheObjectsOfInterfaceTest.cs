using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.UserInterface;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.CDFData;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;
using static Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory.ObjectFactory;

namespace Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory.Tests
{
    public partial class ObjectFactoryTest
    {
        [TestMethod]
        public void getCacheObjectsOfInterfaceTest_3_1()
        {
            // Arrange
            Type interfaceType = typeof(TestInterfaceGetCacheObjectsOfInterface);

            // Act
            var objects = invokeGetCacheObjectsOfInterface(interfaceType);

            // Assert
            Assert.AreEqual(null, objects);
        }

        [TestMethod]
        public void getCacheObjectsOfInterfaceTest_3_2()
        {
            // Arrange
            Type interfaceType = typeof(TestInterfaceGetCacheObjectsOfInterface);

            ((Dictionary<Type, List<CacheObject>>)cacheFields.GetValue(null)).Add(
                interfaceType,
                new List<CacheObject>());

            // Act
            var objects = invokeGetCacheObjectsOfInterface(interfaceType);

            // Assert
            Assert.AreEqual(null, objects);
        }

        [TestMethod]
        public void getCacheObjectsOfInterfaceTest_3_3()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                Type interfaceType = typeof(TestInterfaceGetCacheObjectsOfInterface);
                var instance = new TestClassGetCacheObjectsOfInterface();

                ((Dictionary<Type, List<Type>>)registeredTypesField.GetValue(null)).Add(
                    interfaceType,
                    new List<Type> { typeof(TestClassGetCacheObjectsOfInterface), typeof(TestClassGetCacheObjectsOfInterface) });

                Fakes.ShimObjectFactory.checkConditionTypeType = (type) =>
                {
                    return false;
                };

                // Act
                var objects = invokeGetCacheObjectsOfInterface(interfaceType);

                // Assert
                Assert.AreEqual(0, objects.Count);
            }
        }

        [TestMethod]
        public void getCacheObjectsOfInterfaceTest_3_4()
        {
            // Arrange
            Type interfaceType = typeof(TestInterfaceGetCacheObjectsOfInterface);
            var instance = new TestClassGetCacheObjectsOfInterface();

            ((Dictionary<Type, List<CacheObject>>)cacheFields.GetValue(null)).Add(
                interfaceType,
                new List<CacheObject> { new CacheObject(typeof(TestClassGetCacheObjectsOfInterface), instance) });

            // Act
            var objects = invokeGetCacheObjectsOfInterface(interfaceType);

            // Assert
            Assert.AreEqual(1, objects.Count);
            Assert.AreEqual(instance, objects[0].Instance);
        }

        [TestMethod]
        public void getCacheObjectsOfInterfaceTest_3_5()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                Type interfaceType = typeof(TestInterfaceGetCacheObjectsOfInterface);
                var instance = new TestClassGetCacheObjectsOfInterface();

                ((Dictionary<Type, List<Type>>)registeredTypesField.GetValue(null)).Add(
                    interfaceType,
                    new List<Type> { typeof(TestClassGetCacheObjectsOfInterface), typeof(TestClassGetCacheObjectsOfInterface) });

                Fakes.ShimObjectFactory.checkConditionTypeType = (type) =>
                {
                    return true;
                };

                Fakes.ShimObjectFactory.createInstanceType = (type) =>
                {
                    return instance;
                };

                // Act
                var objects = invokeGetCacheObjectsOfInterface(interfaceType);

                // Assert
                Assert.AreEqual(2, objects.Count);
            }
        }

        private List<CacheObject> invokeGetCacheObjectsOfInterface(Type interfaceType)
        {
            return (List<CacheObject>)typeof(ObjectFactory)
                .GetMethod("getCacheObjectsOfInterface", BindingFlags.NonPublic | BindingFlags.Static)
                .Invoke(null, new object[] { interfaceType });
        }

        interface TestInterfaceGetCacheObjectsOfInterface { }

        [ObjectFactory(Version = "1.00")]
        class TestClassGetCacheObjectsOfInterface { }
    }
}
