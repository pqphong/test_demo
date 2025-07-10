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
    public void GetModulesTest_49_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Dictionary<String, List<String>> dictionary9177 = new Dictionary<String, List<String>>();
            List<String> dictionary9177_CAN = new List<String>();
            String dictionary9177_CAN_0 = "test1";
            String dictionary9177_CAN_1 = "test2";
            dictionary9177["CAN"] = dictionary9177_CAN;
            dictionary9177_CAN.Add(dictionary9177_CAN_0);
            dictionary9177_CAN.Add(dictionary9177_CAN_1);
            _target.GetType().GetField("moduleInstances", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary9177);
            /* Act */
            IList<String> actualResult = (IList<String>)_target.GetType().GetMethod("GetModules", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Object moduleinstances1515 = _target.GetType().GetField("moduleInstances", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object moduleinstances1515_count_1516 = typeof(Dictionary<String, List<String>>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(moduleinstances1515);
            Assert.AreEqual((Int32)1, (Int32)moduleinstances1515_count_1516);
        }
    }
}