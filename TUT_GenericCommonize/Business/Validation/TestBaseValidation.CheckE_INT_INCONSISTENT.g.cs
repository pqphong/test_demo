using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Validation;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;

public partial class TestBaseValidation
{
    class TestBaseValidationSub : BaseValidation
    {
        public TestBaseValidationSub()
        {

        }
    }

    [TestMethod]
    public void CheckE_INT_INCONSISTENTTest_111_1()
    {
        using (ShimsContext.Create())
        {
            TestBaseValidationSub call = new TestBaseValidationSub();
            /* Arrange */
            IBasicConfiguration ibasicconfiguration91 = BasicConfiguration.Instance;
            String ibasicconfiguration91_ModuleName = "Lin";
            ibasicconfiguration91.ModuleName = ibasicconfiguration91_ModuleName;
            typeof(BaseValidation).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration91);
            var repository116 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRepository();
            repository116.GetParameterValueStringStringString = (String moduleName, String defName, String variantID) =>
            {
                ItemValue itemvalue102 = new ItemValue(null, null);
                String itemvalue102_definitionRef = "LIN_E_INT_INCONSISTENT";
                Object itemvalue102_value = true;
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue102, itemvalue102_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue102, itemvalue102_value);
                return itemvalue102;
            }

            ;
            repository116.GetReferenceValueStringStringString = (String moduleName, String defName, String variantID) =>
            {
                ItemValue itemvalue113 = new ItemValue(null, null);
                String itemvalue113_definitionRef = "LIN_E_INT_INCONSISTENT";
                Object itemvalue113_value = "/ActiveEcuC/Dem/DemConfigSet/DemEventParameter_002";
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue113, itemvalue113_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue113, itemvalue113_value);
                return itemvalue113;
            }

            ;
            typeof(BaseValidation).GetField("Repository", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(call, repository116);
            /* Act */
            ValidationResult actualResult = (ValidationResult)typeof(BaseValidation).GetMethod("CheckE_INT_INCONSISTENT", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { }, null).Invoke(call, new object[] { });
            /* Assert */
            Object actualResult_code_117 = typeof(ValidationResult).GetProperty("Code", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_code_117);
        }
    }

    [TestMethod]
    public void CheckE_INT_INCONSISTENTTest_111_2()
    {
        using (ShimsContext.Create())
        {
            TestBaseValidationSub call = new TestBaseValidationSub();
            /* Arrange */
            IBasicConfiguration ibasicconfiguration94 = BasicConfiguration.Instance;
            String ibasicconfiguration94_ModuleName = "Lin";
            ibasicconfiguration94.ModuleName = ibasicconfiguration94_ModuleName;
            typeof(BaseValidation).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration94);
            var repository118 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRepository();
            repository118.GetParameterValueStringStringString = (String moduleName, String defName, String variantID) =>
            {
                ItemValue itemvalue105 = new ItemValue(null, null);
                String itemvalue105_definitionRef = "LIN_E_INT_INCONSISTENT";
                Object itemvalue105_value = false;
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue105, itemvalue105_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue105, itemvalue105_value);
                return itemvalue105;
            }

            ;
            repository118.GetReferenceValueStringStringString = (String moduleName, String defName, String variantID) =>
            {
                ItemValue itemvalue116 = new ItemValue(null, null);
                String itemvalue116_definitionRef = "LIN_E_INT_INCONSISTENT";
                Object itemvalue116_value = "/ActiveEcuC/Dem/DemConfigSet/DemEventParameter_002";
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue116, itemvalue116_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue116, itemvalue116_value);
                return itemvalue116;
            }

            ;
            typeof(BaseValidation).GetField("Repository", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(call, repository118);
            /* Act */
            ValidationResult actualResult = (ValidationResult)typeof(BaseValidation).GetMethod("CheckE_INT_INCONSISTENT", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { }, null).Invoke(call, new object[] { });
            /* Assert */
            Object actualResult_code_119 = typeof(ValidationResult).GetProperty("Code", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_code_119);
        }
    }

    [TestMethod]
    public void CheckE_INT_INCONSISTENTTest_111_3()
    {
        using (ShimsContext.Create())
        {
            TestBaseValidationSub call = new TestBaseValidationSub();
            /* Arrange */
            IBasicConfiguration ibasicconfiguration97 = BasicConfiguration.Instance;
            String ibasicconfiguration97_ModuleName = "Lin";
            ibasicconfiguration97.ModuleName = ibasicconfiguration97_ModuleName;
            typeof(BaseValidation).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration97);
            var repository120 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRepository();
            repository120.GetParameterValueStringStringString = (String moduleName, String defName, String variantID) =>
            {
                ItemValue itemvalue108 = new ItemValue(null, null);
                String itemvalue108_definitionRef = "LIN_E_INT_INCONSISTENT";
                Object itemvalue108_value = true;
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue108, itemvalue108_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue108, itemvalue108_value);
                return itemvalue108;
            }

            ;
            repository120.GetReferenceValueStringStringString = (String moduleName, String defName, String variantID) =>
            {
                ItemValue itemvalue119 = new ItemValue(null, null);
                String itemvalue119_definitionRef = "LIN_E_INT_INCONSISTENT";
                Object itemvalue119_value = "";
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue119, itemvalue119_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue119, itemvalue119_value);
                return itemvalue119;
            }

            ;
            typeof(BaseValidation).GetField("Repository", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(call, repository120);
            /* Act */
            ValidationResult actualResult = (ValidationResult)typeof(BaseValidation).GetMethod("CheckE_INT_INCONSISTENT", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { }, null).Invoke(call, new object[] { });
            /* Assert */
            Object actualResult_code_121 = typeof(ValidationResult).GetProperty("Code", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)41, (Int32)actualResult_code_121);
        }
    }

    [TestMethod]
    public void CheckE_INT_INCONSISTENTTest_111_4()
    {
        using (ShimsContext.Create())
        {
            TestBaseValidationSub call = new TestBaseValidationSub();
            /* Arrange */
            IBasicConfiguration ibasicconfiguration910 = BasicConfiguration.Instance;
            String ibasicconfiguration910_ModuleName = "Lin";
            ibasicconfiguration910.ModuleName = ibasicconfiguration910_ModuleName;
            typeof(BaseValidation).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration910);
            var repository122 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRepository();
            repository122.GetParameterValueStringStringString = (String moduleName, String defName, String variantID) =>
            {
                ItemValue itemvalue1011 = null;
                return itemvalue1011;
            }

            ;
            repository122.GetReferenceValueStringStringString = (String moduleName, String defNamey, String variantID) =>
            {
                ItemValue itemvalue1112 = new ItemValue(null, null);
                String itemvalue1112_definitionRef = "LIN_E_INT_INCONSISTENT";
                Object itemvalue1112_value = "";
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue1112, itemvalue1112_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue1112, itemvalue1112_value);
                return itemvalue1112;
            }

            ;
            typeof(BaseValidation).GetField("Repository", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(call, repository122);
            /* Act */
            ValidationResult actualResult = (ValidationResult)typeof(BaseValidation).GetMethod("CheckE_INT_INCONSISTENT", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { }, null).Invoke(call, new object[] { });
            /* Assert */
            Object actualResult_code_123 = typeof(ValidationResult).GetProperty("Code", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_code_123);
        }
    }

    [TestMethod]
    public void CheckE_INT_INCONSISTENTTest_111_5()
    {
        using (ShimsContext.Create())
        {
            TestBaseValidationSub call = new TestBaseValidationSub();
            /* Arrange */
            IBasicConfiguration ibasicconfiguration913 = BasicConfiguration.Instance;
            String ibasicconfiguration913_ModuleName = "Lin";
            ibasicconfiguration913.ModuleName = ibasicconfiguration913_ModuleName;
            typeof(BaseValidation).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration913);
            var repository124 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubIRepository();
            repository124.GetParameterValueStringStringString = (String moduleName, String defName, String variantID) =>
            {
                ItemValue itemvalue1014 = new ItemValue(null, null);
                String itemvalue1014_definitionRef = "LIN_E_INT_INCONSISTENT";
                Object itemvalue1014_value = true;
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue1014, itemvalue1014_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(itemvalue1014, itemvalue1014_value);
                return itemvalue1014;
            }

            ;
            repository124.GetReferenceValueStringStringString = (String moduleName, String defName, String variantID) =>
            {
                ItemValue itemvalue1115 = null;
                return itemvalue1115;
            }

            ;
            typeof(BaseValidation).GetField("Repository", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(call, repository124);
            /* Act */
            ValidationResult actualResult = (ValidationResult)typeof(BaseValidation).GetMethod("CheckE_INT_INCONSISTENT", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { }, null).Invoke(call, new object[] { });
            /* Assert */
            Object actualResult_code_125 = typeof(ValidationResult).GetProperty("Code", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)41, (Int32)actualResult_code_125);
        }
    }
}