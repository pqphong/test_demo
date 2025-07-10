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
        public void GetInstancesTest_6_1()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                Fakes.ShimObjectFactory.getCacheObjectsOfInterfaceType = (type) =>
                {
                    return null;
                };

                // Act
                var instances = ObjectFactory.GetInstances<object>();

                // Assert
                Assert.AreEqual(null, instances);
            }
        }

        [TestMethod]
        public void GetInstancesTest_6_2()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                Fakes.ShimObjectFactory.getCacheObjectsOfInterfaceType = (type) =>
                {
                    return new List<CacheObject>();
                };

                // Act
                var instances = ObjectFactory.GetInstances<object>();

                // Assert
                Assert.AreEqual(null, instances);
            }
        }

        [TestMethod]
        public void GetInstancesTest_6_3()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                var cacheInstance1 = new object();
                var cacheInstance2 = new object();

                Fakes.ShimObjectFactory.getCacheObjectsOfInterfaceType = (type) =>
                {
                    return new List<CacheObject>()
                    {
                        new CacheObject(typeof(object), cacheInstance1),
                        new CacheObject(typeof(object), cacheInstance2),
                    };
                };

                // Act
                var instances = ObjectFactory.GetInstances<object>();

                // Assert
                Assert.AreEqual(2, instances.Length);
            }
        }
    }
}
