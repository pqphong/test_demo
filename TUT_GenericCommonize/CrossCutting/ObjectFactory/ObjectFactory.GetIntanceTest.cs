using System;
using System.Collections.Generic;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory.ObjectFactory;

namespace Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory.Tests
{
    public partial class ObjectFactoryTest
    {
        [TestMethod]
        public void GetInstanceTest_7_1()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                Fakes.ShimObjectFactory.getCacheObjectsOfInterfaceType = (type) =>
                {
                    return null;
                };

                // Act
                var instance = ObjectFactory.GetInstance<object>();

                // Assert
                Assert.AreEqual(null, instance);
            }
        }

        [TestMethod]
        public void GetInstanceTest_7_2()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                Fakes.ShimObjectFactory.getCacheObjectsOfInterfaceType = (type) =>
                {
                    return new List<CacheObject>();
                };

                // Act
                var instance = ObjectFactory.GetInstance<object>();

                // Assert
                Assert.AreEqual(null, instance);
            }
        }

        [TestMethod]
        public void GetInstanceTest_7_3()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                var cacheInstance = new object();

                Fakes.ShimObjectFactory.getCacheObjectsOfInterfaceType = (type) =>
                {
                    return new List<CacheObject>()
                    {
                        new CacheObject(typeof(object), cacheInstance),
                    };
                };

                // Act
                var instance = ObjectFactory.GetInstance<object>();

                // Assert
                Assert.AreEqual(cacheInstance, instance);
            }
        }
    }
}
