using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory.ObjectFactory;

namespace Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory.Tests
{
    [TestClass]
    public partial class ObjectFactoryTest
    {
        private ObjectFactory _target;
        private object _storeGentoolExecutableTypes;
        private object _storedRegisteredTypes;
        private object _storedCache;
        private object _storedSupportedDevices;

        [TestInitialize]
        public void Setup()
        {
            _target = new ObjectFactory();
            _storeGentoolExecutableTypes = gentoolExecutableTypesFields.GetValue(null);
            gentoolExecutableTypesFields.SetValue(null, new HashSet<Type>());

            _storedRegisteredTypes = registeredTypesField.GetValue(null);
            registeredTypesField.SetValue(null, new Dictionary<Type, List<Type>>());

            _storedCache = cacheFields.GetValue(null);
            cacheFields.SetValue(null, new Dictionary<Type, List<CacheObject>>());

            _storedSupportedDevices = supportedDevicesProperty.GetValue(null);
            supportedDevicesProperty.SetValue(null, new Dictionary<string,List<string>>());
        }

        [TestCleanup]
        public void TearDown()
        {
            gentoolExecutableTypesFields.SetValue(null, _storeGentoolExecutableTypes);
            registeredTypesField.SetValue(null, _storedRegisteredTypes);
            cacheFields.SetValue(null, _storedCache);
            supportedDevicesProperty.SetValue(null, _storedSupportedDevices);
        }

        private FieldInfo gentoolExecutableTypesFields
        {
            get { return typeof(ObjectFactory).GetField("gentoolExecutableTypes", BindingFlags.NonPublic | BindingFlags.Static); }
        }

        private FieldInfo registeredTypesField
        {
            get { return typeof(ObjectFactory).GetField("registeredTypes", BindingFlags.NonPublic | BindingFlags.Static); }
        }

        private FieldInfo cacheFields
        {
            get { return typeof(ObjectFactory).GetField("cache", BindingFlags.NonPublic | BindingFlags.Static); }
        }

        private PropertyInfo supportedDevicesProperty
        {
            get { return typeof(ObjectFactory).GetProperty("SupportedVariants"); }
        }
    }

    public class TestAssembly : Assembly
    {
        public static bool HasObjectFactoryAttribute = true;

        public override Type[] GetTypes()
        {
            if (HasObjectFactoryAttribute)
                return new Type[] { typeof(TestType01), typeof(TestType02), typeof(TestType03), typeof(TestType04), typeof(TestType06), typeof(TestType07) };
            else
                return new Type[] { typeof(TestType04) };
        }
    }

    [ObjectFactory(Device = "Device01,Device02")]
    public class TestType01 : TestInterface01
    {
    }

    [ObjectFactory(Device = "*")]
    public class TestType02 : TestInterface01
    {
        public string Verify { get; set; }

        public static TestType02 Instance = new TestType02() { Verify = "Instance" };

        public TestType02()
        {
            Verify = "Constructor";
        }
    }

    [ObjectFactory]
    public class TestType03 : TestInterface02
    {
    }

    public class TestType04
    {
        public static TestType04 Instance = new TestType04();

        private TestType04() { }
    }
    public class TestType05: TestInterface01
    {
        public TestType05()
        {

        }
    }

	[ObjectFactory(Device = "Device01,Device02", Variant = "U2x")]
    public class TestType06 : TestInterface01
    {
    }
	[ObjectFactory(Device = "Device03", Variant = "U2x")]
    public class TestType07 : TestInterface01
    {
    }

    interface TestInterface01
    {
    }

    interface TestInterface02
    {
    }
}
