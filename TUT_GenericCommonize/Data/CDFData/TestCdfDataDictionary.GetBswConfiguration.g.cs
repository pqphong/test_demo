using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.CDFData;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;
using Renesas.Generator.MCALConfGen.Data.IntermediateData.Items;

public partial class TestCdfDataDictionary
{
    [TestMethod]
    public void GetBswConfigurationTest_45_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9164 = "can";
            String moduleName = string9164;
            Dictionary<String, BswConfig> dictionary10165 = new Dictionary<String, BswConfig>();
            BswConfig dictionary10165_key1 = new BswConfig();
            String dictionary10165_key1_SwVersion = "1.0.0";
            BswConfig dictionary10165_key2 = new BswConfig();
            String dictionary10165_key2_VendorId = "59";
            dictionary10165["key1"] = dictionary10165_key1;
            dictionary10165_key1.SwVersion = dictionary10165_key1_SwVersion;
            dictionary10165["key2"] = dictionary10165_key2;
            dictionary10165_key2.VendorId = dictionary10165_key2_VendorId;
            _target.GetType().GetField("bswConfigs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary10165);
            /* Act */
            BswConfig actualResult = (BswConfig)_target.GetType().GetMethod("GetBswConfiguration", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Object actualResult_swversion_1511 = typeof(BswConfig).GetProperty("SwVersion", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"1.0.0", (String)actualResult_swversion_1511);
            Object actualResult_vendorid_1512 = typeof(BswConfig).GetProperty("VendorId", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)null, (String)actualResult_vendorid_1512);
        }
    }

    [TestMethod]
    public void GetBswConfigurationTest_45_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9166 = "can";
            String moduleName = string9166;
            Dictionary<String, BswConfig> dictionary10167 = new Dictionary<String, BswConfig>();
            _target.GetType().GetField("bswConfigs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary10167);
            /* Act */
            BswConfig actualResult = (BswConfig)_target.GetType().GetMethod("GetBswConfiguration", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Assert.AreEqual((BswConfig)null, (BswConfig)actualResult);
        }
    }
}