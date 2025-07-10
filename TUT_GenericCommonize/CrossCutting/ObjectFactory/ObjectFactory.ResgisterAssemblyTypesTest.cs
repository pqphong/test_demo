using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory.Tests
{
    public partial class ObjectFactoryTest
    {
        [TestMethod]
        public void RegisterAssemblyTypesTest_2_1()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                string[] assemblyFilePaths = new string[] { };
                DotNetApiWrapper.Fakes.ShimReflectionWrapper.LoadFromStringNullableOfInt32 = (p, e) =>
                {
                    return null;
                };
                // Act
                ObjectFactory.RegisterAssemblyTypes(assemblyFilePaths);
                // Assert
                Dictionary<Type, List<Type>> registeredTypes = (Dictionary<Type, List<Type>>)registeredTypesField.GetValue(null);
                Dictionary<string, List<string>> supportedVariants = (Dictionary<string, List<string>>)supportedDevicesProperty.GetValue(null);				
				List<string> supportedDevices = supportedVariants.SelectMany(x => x.Value).ToList();

                Assert.AreEqual(0, registeredTypes.Count);
                Assert.AreEqual(0, supportedDevices.Count);
            }
        }

        [TestMethod]
        public void RegisterAssemblyTypesTest_2_2()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                string[] assemblyFilePaths = new string[] { "1st.dll", "2nd.dll" };
                DotNetApiWrapper.Fakes.ShimReflectionWrapper.LoadFromStringNullableOfInt32 = (p, e) =>
                {
                    return null;
                };
                // Act
                ObjectFactory.RegisterAssemblyTypes(assemblyFilePaths);
                // Assert
                Dictionary<Type, List<Type>> registeredTypes = (Dictionary<Type, List<Type>>)registeredTypesField.GetValue(null);
                Dictionary<string, List<string>> supportedVariants = (Dictionary<string, List<string>>)supportedDevicesProperty.GetValue(null);				
				List<string> supportedDevices = supportedVariants.SelectMany(x => x.Value).ToList();
                Assert.AreEqual(0, registeredTypes.Count);
                Assert.AreEqual(0, supportedDevices.Count);
            }
        }

        [TestMethod]
        public void RegisterAssemblyTypesTest_2_3()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                string[] assemblyFilePaths = new string[] { "1st.dll", "2nd.dll" };

                TestAssembly.HasObjectFactoryAttribute = false;

                DotNetApiWrapper.Fakes.ShimReflectionWrapper.LoadFromStringNullableOfInt32 = (p, e) =>
                {
                    return new TestAssembly();
                };

                // Act
                ObjectFactory.RegisterAssemblyTypes(assemblyFilePaths);

                // Assert
                Dictionary<Type, List<Type>> registeredTypes = (Dictionary<Type, List<Type>>)registeredTypesField.GetValue(null);
                Dictionary<string, List<string>> supportedVariants = (Dictionary<string, List<string>>)supportedDevicesProperty.GetValue(null);				
				List<string> supportedDevices = supportedVariants.SelectMany(x => x.Value).ToList();

                Assert.AreEqual(0, registeredTypes.Count);
                Assert.AreEqual(0, supportedDevices.Count);
            }
        }

        [TestMethod]
        public void RegisterAssemblyTypesTest_2_4()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                string[] assemblyFilePaths = new string[] { "1st.dll", "2nd.dll" };

                TestAssembly.HasObjectFactoryAttribute = true;

                DotNetApiWrapper.Fakes.ShimReflectionWrapper.LoadFromStringNullableOfInt32 = (p, e) =>
                {
                    return new TestAssembly();
                };
                ObjectFactory.SupportedVariants.Add("X2x", new List<string>() { "Device02" });
                // Act
                ObjectFactory.RegisterAssemblyTypes(assemblyFilePaths);

                
                // Assert

                Dictionary<Type, List<Type>> registeredTypes = (Dictionary<Type, List<Type>>)registeredTypesField.GetValue(null);
                Dictionary<string, List<string>> supportedVariants = (Dictionary<string, List<string>>)supportedDevicesProperty.GetValue(null);				
				List<string> supportedDevices = supportedVariants.SelectMany(x => x.Value).ToList();

                Assert.AreEqual(2, registeredTypes.Count);
                Assert.AreEqual(8, registeredTypes[typeof(TestInterface01)].Count);
                Assert.AreEqual(2, registeredTypes[typeof(TestInterface02)].Count);
                Assert.AreEqual(6, supportedDevices.Count);
            }
        }
    }
}
