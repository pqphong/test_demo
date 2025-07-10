using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public void checkConditionTypeTest_1_1()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                Type concreteType = typeof(TestClassCheckConditionType_ADMO_Value);


                
                ((HashSet<Type>)gentoolExecutableTypesFields.GetValue(null)).Add(concreteType);
                ObjectFactory.ModuleName = "Adc";
                // Act
                var result = invokeCheckConditionType(concreteType);
                
                // Assert
                Assert.AreEqual(true, result);
            }
        }

        [TestMethod]
        public void checkConditionTypeTest_1_2()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                Type concreteType_1 = typeof(TestClassCheckConditionType_AD_Value);
                Type concreteType_2 = typeof(TestClassCheckConditionType_AD_All);

                var basicConfig = new Data.BasicConfiguration.Fakes.StubIBasicConfiguration
                {
                    AutoSARVersionGet = () => { return "4.2.2"; },
                    DeviceNamesGet = () => { return new List<string> { "ABCD0123" }; }
                };
                Fakes.ShimObjectFactory.GetInstanceOf1<IBasicConfiguration>(() => { return basicConfig; });
                // Act
                var result_1 = invokeCheckConditionType(concreteType_1);
                var result_2 = invokeCheckConditionType(concreteType_2);

                // Assert
                Assert.AreEqual(true, result_1);
                Assert.AreEqual(true, result_2);
            }
        }

        [TestMethod]
        public void checkConditionTypeTest_1_3()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                Type concreteType_1 = typeof(TestClassCheckConditionType_ADMO_Value);
                Type concreteType_2 = typeof(TestClassCheckConditionType_ADO_All);

                ObjectFactory.ModuleName = "Adc";

                var basicConfig = new Data.BasicConfiguration.Fakes.StubIBasicConfiguration
                {
                    AutoSARVersionGet = () => { return "4.2.2"; },
                    DeviceNamesGet = () => { return new List<string> { "ABCD0123" }; },
                };
                Fakes.ShimObjectFactory.GetInstanceOf1<IBasicConfiguration>(() => { return basicConfig; });

                var repo = new Data.CDFData.Fakes.StubIRepository
                {
                    GetParameterValueStringStringString = (m, d, v) => { return new ItemValue("_Param", "_Value"); },
                    GetReferenceValueStringStringString = (m, d, v) => { return null; },
                };
                Fakes.ShimObjectFactory.GetInstanceOf1<IRepository>(() => { return repo; });

                var ui = new CrossCutting.UserInterface.Fakes.StubIUserInterface
                {
                    ErrorInt32Int32StringObjectArray = (id, e, m, p) => { },
                    ExitInt32 = (e) => { }
                };
                Fakes.ShimObjectFactory.GetInstanceOf1<IUserInterface>(() => { return ui; });

                // Act
                var result_1 = invokeCheckConditionType(concreteType_1);
                var result_2 = invokeCheckConditionType(concreteType_2);

                // Assert
                Assert.AreEqual(true, result_1);
                Assert.AreEqual(true, result_2);
            }
        }

        [TestMethod]
        public void checkConditionTypeTest_1_4()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                Type concreteType = typeof(TestClassCheckConditionType_ADMO_Value);

                var basicConfig = new Data.BasicConfiguration.Fakes.StubIBasicConfiguration
                {
                    AutoSARVersionGet = () => { return "4.0.3"; },
                    DeviceNamesGet = () => { return new List<string> { "ABCD0123" }; }
                };
                Fakes.ShimObjectFactory.GetInstanceOf1<IBasicConfiguration>(() => { return basicConfig; });

                // Act
                var result = invokeCheckConditionType(concreteType);

                // Assert
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void checkConditionTypeTest_1_5()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                Type concreteType = typeof(TestClassCheckConditionType_A_Empty);

                var basicConfig = new Data.BasicConfiguration.Fakes.StubIBasicConfiguration
                {
                    AutoSARVersionGet = () => { return "4.2.2"; },
                    DeviceNamesGet = () => { return new List<string> { "ABCD0123" }; }
                };
                Fakes.ShimObjectFactory.GetInstanceOf1<IBasicConfiguration>(() => { return basicConfig; });

                // Act
                var result = invokeCheckConditionType(concreteType);

                // Assert
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void checkConditionTypeTest_1_6()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                Type concreteType = typeof(TestClassCheckConditionType_ADMO_Value);

                var basicConfig = new Data.BasicConfiguration.Fakes.StubIBasicConfiguration
                {
                    AutoSARVersionGet = () => { return "4.2.2"; },
                    DeviceNamesGet = () => { return new List<string> { "__ABCD0123" }; }
                };
                Fakes.ShimObjectFactory.GetInstanceOf1<IBasicConfiguration>(() => { return basicConfig; });

                // Act
                var result = invokeCheckConditionType(concreteType);

                // Assert
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void checkConditionTypeTest_1_7()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                Type concreteType = typeof(TestClassCheckConditionType_D_Empty);

                var basicConfig = new Data.BasicConfiguration.Fakes.StubIBasicConfiguration
                {
                    AutoSARVersionGet = () => { return "4.2.2"; },
                    DeviceNamesGet = () => { return new List<string> { "ABCD0123" }; }
                };
                Fakes.ShimObjectFactory.GetInstanceOf1<IBasicConfiguration>(() => { return basicConfig; });

                // Act
                var result = invokeCheckConditionType(concreteType);

                // Assert
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void checkConditionTypeTest_1_8()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                Type concreteType = typeof(TestClassCheckConditionType_ADMO_Value);

                ObjectFactory.ModuleName = "Can";

                var basicConfig = new Data.BasicConfiguration.Fakes.StubIBasicConfiguration
                {
                    AutoSARVersionGet = () => { return "4.2.2"; },
                    DeviceNamesGet = () => { return new List<string> { "ABCD0123" }; }
                };
                Fakes.ShimObjectFactory.GetInstanceOf1<IBasicConfiguration>(() => { return basicConfig; });

                var repo = new Data.CDFData.Fakes.StubIRepository
                {
                    GetParameterValueStringStringString = (m, d, v) => { return new ItemValue("_Param", "_Value"); },
                    GetReferenceValueStringStringString = (m, d, v) => { return null; },
                };
                Fakes.ShimObjectFactory.GetInstanceOf1<IRepository>(() => { return repo; });

                // Act
                var result = invokeCheckConditionType(concreteType);

                // Assert
                Assert.AreEqual(false, result);
            }
        }

        [TestMethod]
        public void checkConditionTypeTest_1_9()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                Type concreteType = typeof(TestClassCheckConditionType_ADMO2_Value);

                var basicConfig = new Data.BasicConfiguration.Fakes.StubIBasicConfiguration
                {
                    AutoSARVersionGet = () => { return "4.2.2"; },
                    DeviceNamesGet = () => { return new List<string> { "ABCD0123" }; }
                };
                Fakes.ShimObjectFactory.GetInstanceOf1<IBasicConfiguration>(() => { return basicConfig; });

                var repo = new Data.CDFData.Fakes.StubIRepository
                {
                    GetParameterValueStringStringString = (m, d, v) => { return null; },
                    GetReferenceValueStringStringString = (m, d, v) => { return null; },
                };
                Fakes.ShimObjectFactory.GetInstanceOf1<IRepository>(() => { return repo; });

                var ui = new UserInterface.Fakes.StubIUserInterface
                {
                    ErrorInt32Int32StringObjectArray = (id, e, m, p) => { },
                    ExitInt32 = (e) => { }
                };
                Fakes.ShimObjectFactory.GetInstanceOf1<IUserInterface>(() => { return ui; });
                DotNetApiWrapper.Fakes.ShimIOWrapper.GetFullPathStringNullableOfInt32 = (p, e) => { return p; };

                // Act
                var result = invokeCheckConditionType(concreteType);

                // Assert
                Assert.AreEqual(false, result);
            }
        }

        private bool invokeCheckConditionType(Type concreteType)
        {
            return (bool)typeof(ObjectFactory)
                .GetMethod("checkConditionType", BindingFlags.NonPublic | BindingFlags.Static)
                .Invoke(null, new object[] { concreteType});
        }

        [ObjectFactory(AutoSarVersion = "4.2.2", Device = "ABCD0123", ModuleNames = "Adc")]
        public class TestClassCheckConditionType_ADMO_Value
        {
        }

        [ObjectFactory(AutoSarVersion = "4.2.2", Device = "ABCD0123", ModuleNames = "Adc")]
        public class TestClassCheckConditionType_ADMO2_Value
        {
        }

        [ObjectFactory(AutoSarVersion = "*", Device = "*", ModuleNames = "*")]
        public class TestClassCheckConditionType_ADO_All
        {
        }

        [ObjectFactory(AutoSarVersion = "4.2.2", Device = "ABCD0123")]
        public class TestClassCheckConditionType_AD_Value
        {
        }

        [ObjectFactory(AutoSarVersion = "", Device = "*")]
        public class TestClassCheckConditionType_A_Empty
        {
        }

        [ObjectFactory(AutoSarVersion = "*", Device = "")]
        public class TestClassCheckConditionType_D_Empty
        {
        }

        [ObjectFactory(AutoSarVersion = "*", Device = "*")]
        public class TestClassCheckConditionType_AD_All
        {
        }
    }
}
