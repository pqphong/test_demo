using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using static Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory.ObjectFactory;

namespace Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory.Tests
{
    public partial class ObjectFactoryTest
    {
        [TestMethod]
        public void ClearCacheTest_8_1()
        {
            using (ShimsContext.Create())
            {
                /* Arrange */
                TestType04 type = invokeCreateInstance<TestType04>();
                Dictionary<Type, List<CacheObject>> cache = new Dictionary<Type, List<CacheObject>>();

                List<CacheObject> cacheObjects = new List<CacheObject>();
                cacheObjects.Add(new CacheObject(typeof(TestInterface01), type));
                cache.Add(typeof(TestType04), cacheObjects);

                typeof(ObjectFactory).GetField("cache", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static)
                    .SetValue(null, cache);

                /* Act */
                typeof(ObjectFactory).GetMethod("ClearCache", BindingFlags.Static | BindingFlags.Public, null, new Type[] { typeof(Type) }, null).Invoke(_target, new object[] {typeof(TestType04) });
                /* Assert */
                Dictionary<Type, List<CacheObject>>  result = (Dictionary<Type, List<CacheObject>>)typeof(ObjectFactory).GetField("cache", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static)
                    .GetValue(null);
                Assert.AreEqual(0,result.Count);

            }
        }

        [TestMethod]
        public void ClearCacheTest_8_2()
        {
            using (ShimsContext.Create())
            {
               /* Act */
                typeof(ObjectFactory).GetMethod("ClearCache", BindingFlags.Static | BindingFlags.Public, null, new Type[] { typeof(Type) }, null).Invoke(_target, new object[] { typeof(TestType04) });
                /* Assert */
                Dictionary<Type, List<CacheObject>> result = (Dictionary<Type, List<CacheObject>>)typeof(ObjectFactory).GetField("cache", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static)
                   .GetValue(null);
                Assert.AreEqual(0, result.Count);
            }
        }

       

    }
}