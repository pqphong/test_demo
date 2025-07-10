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
    public void SaveBswConfigurationTest_46_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "LIN";
            String moduleName = string91;
            BswConfig bswconfig102 = new BswConfig();
            String bswconfig102_VendorId = "59";
            String bswconfig102_ArReleaseVersion = "4.2.2";
            bswconfig102.VendorId = bswconfig102_VendorId;
            bswconfig102.ArReleaseVersion = bswconfig102_ArReleaseVersion;
            BswConfig config = bswconfig102;
            Dictionary<String, List<BswConfig>> dictionary113 = new Dictionary<String, List<BswConfig>>();
            List<BswConfig> dictionary113_LIN = new List<BswConfig>();
            BswConfig dictionary113_LIN_0 = new BswConfig();
            String dictionary113_LIN_0_VendorId = "59";
            String dictionary113_LIN_0_ArReleaseVersion = "4.2.2";
            dictionary113["LIN"] = dictionary113_LIN;
            dictionary113_LIN.Add(dictionary113_LIN_0);
            dictionary113_LIN_0.VendorId = dictionary113_LIN_0_VendorId;
            dictionary113_LIN_0.ArReleaseVersion = dictionary113_LIN_0_ArReleaseVersion;
            _target.GetType().GetField("bswConfigs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary113);
            /* Act */
            _target.GetType().GetMethod("SaveBswConfiguration", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(BswConfig)}, null).Invoke(_target, new object[]{moduleName, config});
            /* Assert */
            Object bswconfigs110 = _target.GetType().GetField("bswConfigs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object bswconfigs110_lin_111 = ((Dictionary<String, List<BswConfig>>)bswconfigs110)["LIN"];
            Object bswconfigs110_lin_111_count_212 = typeof(List<BswConfig>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(bswconfigs110_lin_111);
            Assert.AreEqual((Int32)2, (Int32)bswconfigs110_lin_111_count_212);
            Object bswconfigs110_lin_113 = ((Dictionary<String, List<BswConfig>>)bswconfigs110)["LIN"];
            Object bswconfigs110_lin_113_0_214 = ((List<BswConfig>)bswconfigs110_lin_113)[0];
            Object bswconfigs110_lin_113_0_214_vendorid_315 = typeof(BswConfig).GetProperty("VendorId", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(bswconfigs110_lin_113_0_214);
            Assert.AreEqual((String)"59", (String)bswconfigs110_lin_113_0_214_vendorid_315);
            Object bswconfigs110_lin_116 = ((Dictionary<String, List<BswConfig>>)bswconfigs110)["LIN"];
            Object bswconfigs110_lin_116_0_217 = ((List<BswConfig>)bswconfigs110_lin_116)[0];
            Object bswconfigs110_lin_116_0_217_arreleaseversion_318 = typeof(BswConfig).GetProperty("ArReleaseVersion", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(bswconfigs110_lin_116_0_217);
            Assert.AreEqual((String)"4.2.2", (String)bswconfigs110_lin_116_0_217_arreleaseversion_318);
            Object bswconfigs110_lin_119 = ((Dictionary<String, List<BswConfig>>)bswconfigs110)["LIN"];
            Object bswconfigs110_lin_119_1_220 = ((List<BswConfig>)bswconfigs110_lin_119)[1];
            Object bswconfigs110_lin_119_1_220_vendorid_321 = typeof(BswConfig).GetProperty("VendorId", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(bswconfigs110_lin_119_1_220);
            Assert.AreEqual((String)"59", (String)bswconfigs110_lin_119_1_220_vendorid_321);
            Object bswconfigs110_lin_122 = ((Dictionary<String, List<BswConfig>>)bswconfigs110)["LIN"];
            Object bswconfigs110_lin_122_1_223 = ((List<BswConfig>)bswconfigs110_lin_122)[1];
            Object bswconfigs110_lin_122_1_223_arreleaseversion_324 = typeof(BswConfig).GetProperty("ArReleaseVersion", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(bswconfigs110_lin_122_1_223);
            Assert.AreEqual((String)"4.2.2", (String)bswconfigs110_lin_122_1_223_arreleaseversion_324);
        }
    }

    [TestMethod]
    public void SaveBswConfigurationTest_46_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string94 = "CAN";
            String moduleName = string94;
            BswConfig bswconfig105 = new BswConfig();
            String bswconfig105_VendorId = "59";
            String bswconfig105_ArReleaseVersion = "4.2.2";
            bswconfig105.VendorId = bswconfig105_VendorId;
            bswconfig105.ArReleaseVersion = bswconfig105_ArReleaseVersion;
            BswConfig config = bswconfig105;
            Dictionary<String, List<BswConfig>> dictionary116 = new Dictionary<String, List<BswConfig>>();
            List<BswConfig> dictionary116_LIN = new List<BswConfig>();
            BswConfig dictionary116_LIN_0 = new BswConfig();
            String dictionary116_LIN_0_VendorId = "59";
            String dictionary116_LIN_0_ArReleaseVersion = "4.2.2";
            dictionary116["LIN"] = dictionary116_LIN;
            dictionary116_LIN.Add(dictionary116_LIN_0);
            dictionary116_LIN_0.VendorId = dictionary116_LIN_0_VendorId;
            dictionary116_LIN_0.ArReleaseVersion = dictionary116_LIN_0_ArReleaseVersion;
            _target.GetType().GetField("bswConfigs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary116);
            /* Act */
            _target.GetType().GetMethod("SaveBswConfiguration", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(BswConfig)}, null).Invoke(_target, new object[]{moduleName, config});
            /* Assert */
            Object bswconfigs125 = _target.GetType().GetField("bswConfigs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object bswconfigs125_lin_126 = ((Dictionary<String, List<BswConfig>>)bswconfigs125)["LIN"];
            Object bswconfigs125_lin_126_count_227 = typeof(List<BswConfig>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(bswconfigs125_lin_126);
            Assert.AreEqual((Int32)1, (Int32)bswconfigs125_lin_126_count_227);
            Object bswconfigs125_lin_128 = ((Dictionary<String, List<BswConfig>>)bswconfigs125)["LIN"];
            Object bswconfigs125_lin_128_0_229 = ((List<BswConfig>)bswconfigs125_lin_128)[0];
            Object bswconfigs125_lin_128_0_229_vendorid_330 = typeof(BswConfig).GetProperty("VendorId", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(bswconfigs125_lin_128_0_229);
            Assert.AreEqual((String)"59", (String)bswconfigs125_lin_128_0_229_vendorid_330);
            Object bswconfigs125_lin_131 = ((Dictionary<String, List<BswConfig>>)bswconfigs125)["LIN"];
            Object bswconfigs125_lin_131_0_232 = ((List<BswConfig>)bswconfigs125_lin_131)[0];
            Object bswconfigs125_lin_131_0_232_arreleaseversion_333 = typeof(BswConfig).GetProperty("ArReleaseVersion", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(bswconfigs125_lin_131_0_232);
            Assert.AreEqual((String)"4.2.2", (String)bswconfigs125_lin_131_0_232_arreleaseversion_333);
            Object bswconfigs125_can_134 = ((Dictionary<String, List<BswConfig>>)bswconfigs125)["CAN"];
            Object bswconfigs125_can_134_count_235 = typeof(List<BswConfig>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(bswconfigs125_can_134);
            Assert.AreEqual((Int32)1, (Int32)bswconfigs125_can_134_count_235);
            Object bswconfigs125_can_136 = ((Dictionary<String, List<BswConfig>>)bswconfigs125)["CAN"];
            Object bswconfigs125_can_136_0_237 = ((List<BswConfig>)bswconfigs125_can_136)[0];
            Object bswconfigs125_can_136_0_237_vendorid_338 = typeof(BswConfig).GetProperty("VendorId", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(bswconfigs125_can_136_0_237);
            Assert.AreEqual((String)"59", (String)bswconfigs125_can_136_0_237_vendorid_338);
            Object bswconfigs125_can_139 = ((Dictionary<String, List<BswConfig>>)bswconfigs125)["CAN"];
            Object bswconfigs125_can_139_0_240 = ((List<BswConfig>)bswconfigs125_can_139)[0];
            Object bswconfigs125_can_139_0_240_arreleaseversion_341 = typeof(BswConfig).GetProperty("ArReleaseVersion", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(bswconfigs125_can_139_0_240);
            Assert.AreEqual((String)"4.2.2", (String)bswconfigs125_can_139_0_240_arreleaseversion_341);
        }
    }

    [TestMethod]
    public void SaveBswConfigurationTest_46_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string97 = "";
            String moduleName = string97;
            BswConfig bswconfig108 = null;
            BswConfig config = bswconfig108;
            Dictionary<String, List<BswConfig>> dictionary119 = new Dictionary<String, List<BswConfig>>();
            List<BswConfig> dictionary119_LIN = new List<BswConfig>();
            BswConfig dictionary119_LIN_0 = new BswConfig();
            String dictionary119_LIN_0_VendorId = "59";
            String dictionary119_LIN_0_ArReleaseVersion = "4.2.2";
            dictionary119["LIN"] = dictionary119_LIN;
            dictionary119_LIN.Add(dictionary119_LIN_0);
            dictionary119_LIN_0.VendorId = dictionary119_LIN_0_VendorId;
            dictionary119_LIN_0.ArReleaseVersion = dictionary119_LIN_0_ArReleaseVersion;
            _target.GetType().GetField("bswConfigs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary119);
            /* Act */
            _target.GetType().GetMethod("SaveBswConfiguration", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(BswConfig)}, null).Invoke(_target, new object[]{moduleName, config});
            /* Assert */
            Object bswconfigs142 = _target.GetType().GetField("bswConfigs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object bswconfigs142_lin_143 = ((Dictionary<String, List<BswConfig>>)bswconfigs142)["LIN"];
            Object bswconfigs142_lin_143_count_244 = typeof(List<BswConfig>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(bswconfigs142_lin_143);
            Assert.AreEqual((Int32)1, (Int32)bswconfigs142_lin_143_count_244);
            Object bswconfigs142_lin_145 = ((Dictionary<String, List<BswConfig>>)bswconfigs142)["LIN"];
            Object bswconfigs142_lin_145_0_246 = ((List<BswConfig>)bswconfigs142_lin_145)[0];
            Object bswconfigs142_lin_145_0_246_vendorid_347 = typeof(BswConfig).GetProperty("VendorId", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(bswconfigs142_lin_145_0_246);
            Assert.AreEqual((String)"59", (String)bswconfigs142_lin_145_0_246_vendorid_347);
            Object bswconfigs142_lin_148 = ((Dictionary<String, List<BswConfig>>)bswconfigs142)["LIN"];
            Object bswconfigs142_lin_148_0_249 = ((List<BswConfig>)bswconfigs142_lin_148)[0];
            Object bswconfigs142_lin_148_0_249_arreleaseversion_350 = typeof(BswConfig).GetProperty("ArReleaseVersion", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(bswconfigs142_lin_148_0_249);
            Assert.AreEqual((String)"4.2.2", (String)bswconfigs142_lin_148_0_249_arreleaseversion_350);
        }
    }
}