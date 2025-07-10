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
    public void GetBswConfigurationTest_45_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "Can";
            String moduleName = string91;
            Dictionary<String, List<BswConfig>> dictionary102 = new Dictionary<String, List<BswConfig>>();
            List<BswConfig> dictionary102_Can = new List<BswConfig>();
            BswConfig dictionary102_Can_0 = new BswConfig();
            String dictionary102_Can_0_SwVersion = "1.0.0";
            String dictionary102_Can_0_VendorApiInfix = "Inst0";
            String dictionary102_Can_0_VendorId = "59";
            BswConfig dictionary102_Can_1 = new BswConfig();
            String dictionary102_Can_1_SwVersion = "1.3.1";
            String dictionary102_Can_1_VendorApiInfix = "Inst1";
            String dictionary102_Can_1_VendorId = "59";
            dictionary102["Can"] = dictionary102_Can;
            dictionary102_Can.Add(dictionary102_Can_0);
            dictionary102_Can_0.SwVersion = dictionary102_Can_0_SwVersion;
            dictionary102_Can_0.VendorApiInfix = dictionary102_Can_0_VendorApiInfix;
            dictionary102_Can_0.VendorId = dictionary102_Can_0_VendorId;
            dictionary102_Can.Add(dictionary102_Can_1);
            dictionary102_Can_1.SwVersion = dictionary102_Can_1_SwVersion;
            dictionary102_Can_1.VendorApiInfix = dictionary102_Can_1_VendorApiInfix;
            dictionary102_Can_1.VendorId = dictionary102_Can_1_VendorId;
            _target.GetType().GetField("bswConfigs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary102);
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.GetCurrentInstanceBswConfigString = (CdfDataDictionary instance, String _moduleName) =>
            {
                BswConfig bswconfig113 = new BswConfig();
                String bswconfig113_SwVersion = "1.3.1";
                String bswconfig113_VendorApiInfix = "Inst1";
                String bswconfig113_VendorId = "59";
                bswconfig113.SwVersion = bswconfig113_SwVersion;
                bswconfig113.VendorApiInfix = bswconfig113_VendorApiInfix;
                bswconfig113.VendorId = bswconfig113_VendorId;
                return bswconfig113;
            }

            ;
            /* Act */
            BswConfig actualResult = (BswConfig)_target.GetType().GetMethod("GetBswConfiguration", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Object actualResult_swversion_110 = typeof(BswConfig).GetProperty("SwVersion", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"1.3.1", (String)actualResult_swversion_110);
            Object actualResult_vendorapiinfix_111 = typeof(BswConfig).GetProperty("VendorApiInfix", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"Inst1", (String)actualResult_vendorapiinfix_111);
            Object actualResult_vendorid_112 = typeof(BswConfig).GetProperty("VendorId", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"59", (String)actualResult_vendorid_112);
        }
    }

    [TestMethod]
    public void GetBswConfigurationTest_45_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string94 = "Can";
            String moduleName = string94;
            Dictionary<String, List<BswConfig>> dictionary105 = new Dictionary<String, List<BswConfig>>();
            List<BswConfig> dictionary105_Can = new List<BswConfig>();
            BswConfig dictionary105_Can_0 = new BswConfig();
            String dictionary105_Can_0_SwVersion = "1.0.0";
            String dictionary105_Can_0_VendorApiInfix = "Inst0";
            String dictionary105_Can_0_VendorId = "59";
            BswConfig dictionary105_Can_1 = new BswConfig();
            String dictionary105_Can_1_SwVersion = "1.3.1";
            String dictionary105_Can_1_VendorApiInfix = "Inst1";
            String dictionary105_Can_1_VendorId = "59";
            dictionary105["Can"] = dictionary105_Can;
            dictionary105_Can.Add(dictionary105_Can_0);
            dictionary105_Can_0.SwVersion = dictionary105_Can_0_SwVersion;
            dictionary105_Can_0.VendorApiInfix = dictionary105_Can_0_VendorApiInfix;
            dictionary105_Can_0.VendorId = dictionary105_Can_0_VendorId;
            dictionary105_Can.Add(dictionary105_Can_1);
            dictionary105_Can_1.SwVersion = dictionary105_Can_1_SwVersion;
            dictionary105_Can_1.VendorApiInfix = dictionary105_Can_1_VendorApiInfix;
            dictionary105_Can_1.VendorId = dictionary105_Can_1_VendorId;
            _target.GetType().GetField("bswConfigs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary105);
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.GetCurrentInstanceBswConfigString = (CdfDataDictionary instance, String _moduleName) =>
            {
                BswConfig bswconfig116 = null;
                return bswconfig116;
            }

            ;
            /* Act */
            BswConfig actualResult = (BswConfig)_target.GetType().GetMethod("GetBswConfiguration", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Assert.AreEqual((BswConfig)null, (BswConfig)actualResult);
        }
    }

    [TestMethod]
    public void GetBswConfigurationTest_45_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string97 = "";
            String moduleName = string97;
            Dictionary<String, List<BswConfig>> dictionary108 = new Dictionary<String, List<BswConfig>>();
            List<BswConfig> dictionary108_Can = new List<BswConfig>();
            BswConfig dictionary108_Can_0 = new BswConfig();
            String dictionary108_Can_0_SwVersion = "1.0.0";
            String dictionary108_Can_0_VendorApiInfix = "Inst0";
            String dictionary108_Can_0_VendorId = "59";
            BswConfig dictionary108_Can_1 = new BswConfig();
            String dictionary108_Can_1_SwVersion = "1.3.1";
            String dictionary108_Can_1_VendorApiInfix = "Inst1";
            String dictionary108_Can_1_VendorId = "59";
            dictionary108["Can"] = dictionary108_Can;
            dictionary108_Can.Add(dictionary108_Can_0);
            dictionary108_Can_0.SwVersion = dictionary108_Can_0_SwVersion;
            dictionary108_Can_0.VendorApiInfix = dictionary108_Can_0_VendorApiInfix;
            dictionary108_Can_0.VendorId = dictionary108_Can_0_VendorId;
            dictionary108_Can.Add(dictionary108_Can_1);
            dictionary108_Can_1.SwVersion = dictionary108_Can_1_SwVersion;
            dictionary108_Can_1.VendorApiInfix = dictionary108_Can_1_VendorApiInfix;
            dictionary108_Can_1.VendorId = dictionary108_Can_1_VendorId;
            _target.GetType().GetField("bswConfigs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary108);
            /* Act */
            BswConfig actualResult = (BswConfig)_target.GetType().GetMethod("GetBswConfiguration", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Object actualResult_swversion_113 = typeof(BswConfig).GetProperty("SwVersion", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"1.0.0", (String)actualResult_swversion_113);
            Object actualResult_vendorapiinfix_114 = typeof(BswConfig).GetProperty("VendorApiInfix", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"Inst0", (String)actualResult_vendorapiinfix_114);
            Object actualResult_vendorid_115 = typeof(BswConfig).GetProperty("VendorId", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"59", (String)actualResult_vendorid_115);
        }
    }
}