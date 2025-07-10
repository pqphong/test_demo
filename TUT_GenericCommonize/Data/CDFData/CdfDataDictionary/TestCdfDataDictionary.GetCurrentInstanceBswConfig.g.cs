using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.CDFData;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;

public partial class TestCdfDataDictionary
{
    [TestMethod]
    public void GetCurrentInstanceBswConfigTest_165_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.isCurrentInstanceAvailable = (CdfDataDictionary instance) =>
            {
                Boolean boolean91 = true;
                return boolean91;
            }

            ;
            String string102 = "CAN";
            String moduleName = string102;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.GetCurrentInstanceConfigurationString = (CdfDataDictionary instance, String _moduleName) =>
            {
                Configuration configuration113 = new Configuration();
                String configuration113_ModuleDescriptionRef = "/Renesas/BswModuleDescriptions_Can/Can_Impl";
                configuration113.ModuleDescriptionRef = configuration113_ModuleDescriptionRef;
                return configuration113;
            }

            ;
            Dictionary<String, List<BswConfig>> dictionary124 = new Dictionary<String, List<BswConfig>>();
            List<BswConfig> dictionary124_CAN = new List<BswConfig>();
            BswConfig dictionary124_CAN_0 = new BswConfig();
            String dictionary124_CAN_0_ImplementRootPath = "/Renesas/BswModuleDescriptions_Can/Can_Impl";
            String dictionary124_CAN_0_VendorId = "59";
            String dictionary124_CAN_0_VendorApiInfix = "Inst0";
            dictionary124["CAN"] = dictionary124_CAN;
            dictionary124_CAN.Add(dictionary124_CAN_0);
            dictionary124_CAN_0.ImplementRootPath = dictionary124_CAN_0_ImplementRootPath;
            dictionary124_CAN_0.VendorId = dictionary124_CAN_0_VendorId;
            dictionary124_CAN_0.VendorApiInfix = dictionary124_CAN_0_VendorApiInfix;
            _target.GetType().GetField("bswConfigs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary124);
            /* Act */
            BswConfig actualResult = (BswConfig)_target.GetType().GetMethod("GetCurrentInstanceBswConfig", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Object actualResult_vendorid_129 = typeof(BswConfig).GetProperty("VendorId", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"59", (String)actualResult_vendorid_129);
            Object actualResult_vendorapiinfix_130 = typeof(BswConfig).GetProperty("VendorApiInfix", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"Inst0", (String)actualResult_vendorapiinfix_130);
        }
    }

    [TestMethod]
    public void GetCurrentInstanceBswConfigTest_165_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.isCurrentInstanceAvailable = (CdfDataDictionary instance) =>
            {
                Boolean boolean95 = true;
                return boolean95;
            }

            ;
            String string106 = "CAN";
            String moduleName = string106;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.GetCurrentInstanceConfigurationString = (CdfDataDictionary instance, String _moduleName) =>
            {
                Configuration configuration117 = new Configuration();
                String configuration117_ModuleDescriptionRef = "/Renesas/BswModuleDescriptions_Can/Can_Impl1";
                configuration117.ModuleDescriptionRef = configuration117_ModuleDescriptionRef;
                return configuration117;
            }

            ;
            Dictionary<String, List<BswConfig>> dictionary128 = new Dictionary<String, List<BswConfig>>();
            List<BswConfig> dictionary128_CAN = new List<BswConfig>();
            BswConfig dictionary128_CAN_0 = new BswConfig();
            String dictionary128_CAN_0_ImplementRootPath = "/Renesas/BswModuleDescriptions_Can/Can_Impl";
            String dictionary128_CAN_0_VendorId = "59";
            String dictionary128_CAN_0_VendorApiInfix = "Inst0";
            dictionary128["CAN"] = dictionary128_CAN;
            dictionary128_CAN.Add(dictionary128_CAN_0);
            dictionary128_CAN_0.ImplementRootPath = dictionary128_CAN_0_ImplementRootPath;
            dictionary128_CAN_0.VendorId = dictionary128_CAN_0_VendorId;
            dictionary128_CAN_0.VendorApiInfix = dictionary128_CAN_0_VendorApiInfix;
            _target.GetType().GetField("bswConfigs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary128);
            /* Act */
            BswConfig actualResult = (BswConfig)_target.GetType().GetMethod("GetCurrentInstanceBswConfig", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Assert.AreEqual((BswConfig)null, (BswConfig)actualResult);
        }
    }

    [TestMethod]
    public void GetCurrentInstanceBswConfigTest_165_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.isCurrentInstanceAvailable = (CdfDataDictionary instance) =>
            {
                Boolean boolean99 = true;
                return boolean99;
            }

            ;
            String string1010 = "";
            String moduleName = string1010;
            /* Act */
            BswConfig actualResult = (BswConfig)_target.GetType().GetMethod("GetCurrentInstanceBswConfig", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Assert.AreEqual((BswConfig)null, (BswConfig)actualResult);
        }
    }

    [TestMethod]
    public void GetCurrentInstanceBswConfigTest_165_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.isCurrentInstanceAvailable = (CdfDataDictionary instance) =>
            {
                Boolean boolean913 = false;
                return boolean913;
            }

            ;
            String string1014 = "CAN";
            String moduleName = string1014;
            /* Act */
            BswConfig actualResult = (BswConfig)_target.GetType().GetMethod("GetCurrentInstanceBswConfig", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Assert.AreEqual((BswConfig)null, (BswConfig)actualResult);
        }
    }

    [TestMethod]
    public void GetCurrentInstanceBswConfigTest_165_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.isCurrentInstanceAvailable = (CdfDataDictionary instance) =>
            {
                Boolean boolean917 = true;
                return boolean917;
            }

            ;
            String string1018 = "CAN";
            String moduleName = string1018;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.GetCurrentInstanceConfigurationString = (CdfDataDictionary instance, String _moduleName) =>
            {
                Configuration configuration1119 = new Configuration();
                String configuration1119_ModuleDescriptionRef = "/Renesas/BswModuleDescriptions_Can/Can_Impl";
                configuration1119.ModuleDescriptionRef = configuration1119_ModuleDescriptionRef;
                return configuration1119;
            }

            ;
            Dictionary<String, List<BswConfig>> dictionary1220 = null;
            _target.GetType().GetField("bswConfigs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary1220);
            /* Act */
            BswConfig actualResult = (BswConfig)_target.GetType().GetMethod("GetCurrentInstanceBswConfig", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Assert.AreEqual((BswConfig)null, (BswConfig)actualResult);
        }
    }

    [TestMethod]
    public void GetCurrentInstanceBswConfigTest_165_6()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.isCurrentInstanceAvailable = (CdfDataDictionary instance) =>
            {
                Boolean boolean921 = true;
                return boolean921;
            }

            ;
            String string1022 = "ICU";
            String moduleName = string1022;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.GetCurrentInstanceConfigurationString = (CdfDataDictionary instance, String _moduleName) =>
            {
                Configuration configuration1123 = new Configuration();
                String configuration1123_ModuleDescriptionRef = "/Renesas/BswModuleDescriptions_Can/Can_Impl";
                configuration1123.ModuleDescriptionRef = configuration1123_ModuleDescriptionRef;
                return configuration1123;
            }

            ;
            Dictionary<String, List<BswConfig>> dictionary1224 = new Dictionary<String, List<BswConfig>>();
            List<BswConfig> dictionary1224_CAN = new List<BswConfig>();
            BswConfig dictionary1224_CAN_0 = new BswConfig();
            String dictionary1224_CAN_0_ImplementRootPath = "/Renesas/BswModuleDescriptions_Can/Can_Impl";
            String dictionary1224_CAN_0_VendorId = "59";
            String dictionary1224_CAN_0_VendorApiInfix = "Inst0";
            dictionary1224["CAN"] = dictionary1224_CAN;
            dictionary1224_CAN.Add(dictionary1224_CAN_0);
            dictionary1224_CAN_0.ImplementRootPath = dictionary1224_CAN_0_ImplementRootPath;
            dictionary1224_CAN_0.VendorId = dictionary1224_CAN_0_VendorId;
            dictionary1224_CAN_0.VendorApiInfix = dictionary1224_CAN_0_VendorApiInfix;
            _target.GetType().GetField("bswConfigs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary1224);
            /* Act */
            BswConfig actualResult = (BswConfig)_target.GetType().GetMethod("GetCurrentInstanceBswConfig", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Assert.AreEqual((BswConfig)null, (BswConfig)actualResult);
        }
    }

    [TestMethod]
    public void GetCurrentInstanceBswConfigTest_165_7()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.isCurrentInstanceAvailable = (CdfDataDictionary instance) =>
            {
                Boolean boolean925 = true;
                return boolean925;
            }

            ;
            String string1026 = "CAN";
            String moduleName = string1026;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.GetCurrentInstanceConfigurationString = (CdfDataDictionary instance, String _moduleName) =>
            {
                Configuration configuration1127 = null;
                return configuration1127;
            }

            ;
            /* Act */
            BswConfig actualResult = (BswConfig)_target.GetType().GetMethod("GetCurrentInstanceBswConfig", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Assert.AreEqual((BswConfig)null, (BswConfig)actualResult);
        }
    }
}