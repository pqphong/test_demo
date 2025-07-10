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
    public void GetBswConfigurationsTest_51_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Dictionary<String, List<BswConfig>> dictionary91 = new Dictionary<String, List<BswConfig>>();
            List<BswConfig> dictionary91_LIN = new List<BswConfig>();
            BswConfig dictionary91_LIN_0 = new BswConfig();
            String dictionary91_LIN_0_VendorId = "59";
            String dictionary91_LIN_0_ArReleaseVersion = "4.2.2";
            List<BswConfig> dictionary91_CAN = new List<BswConfig>();
            BswConfig dictionary91_CAN_0 = new BswConfig();
            String dictionary91_CAN_0_VendorId = "59";
            String dictionary91_CAN_0_ArReleaseVersion = "4.2.2";
            dictionary91["LIN"] = dictionary91_LIN;
            dictionary91_LIN.Add(dictionary91_LIN_0);
            dictionary91_LIN_0.VendorId = dictionary91_LIN_0_VendorId;
            dictionary91_LIN_0.ArReleaseVersion = dictionary91_LIN_0_ArReleaseVersion;
            dictionary91["CAN"] = dictionary91_CAN;
            dictionary91_CAN.Add(dictionary91_CAN_0);
            dictionary91_CAN_0.VendorId = dictionary91_CAN_0_VendorId;
            dictionary91_CAN_0.ArReleaseVersion = dictionary91_CAN_0_ArReleaseVersion;
            _target.GetType().GetField("bswConfigs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary91);
            /* Act */
            IList<BswConfig> actualResult = (IList<BswConfig>)_target.GetType().GetMethod("GetBswConfigurations", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Object actualResult_count_12 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)2, (Int32)actualResult_count_12);
        }
    }
}