using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.CDFData;

public partial class TestCdfDataDictionary
{
    [TestMethod]
    public void GetCdfFileTest_41_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "";
            String shortName = string91;
            Dictionary<String, String> dictionary102 = new Dictionary<String, String>();
            String dictionary102_CAN = "can.arxml";
            dictionary102["CAN"] = dictionary102_CAN;
            _target.GetType().GetField("cdfFiles", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary102);
            /* Act */
            String actualResult = (String)_target.GetType().GetMethod("GetCdfFile", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{shortName});
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetCdfFileTest_41_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string93 = "can";
            String shortName = string93;
            Dictionary<String, String> dictionary104 = new Dictionary<String, String>();
            String dictionary104_CAN = "can.arxml";
            dictionary104["CAN"] = dictionary104_CAN;
            _target.GetType().GetField("cdfFiles", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary104);
            /* Act */
            String actualResult = (String)_target.GetType().GetMethod("GetCdfFile", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{shortName});
            /* Assert */
            Assert.AreEqual((String)"can.arxml", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetCdfFileTest_41_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string95 = "mcu";
            String shortName = string95;
            Dictionary<String, String> dictionary106 = new Dictionary<String, String>();
            String dictionary106_CAN = "can.arxml";
            dictionary106["CAN"] = dictionary106_CAN;
            _target.GetType().GetField("cdfFiles", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary106);
            /* Act */
            String actualResult = (String)_target.GetType().GetMethod("GetCdfFile", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{shortName});
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
        }
    }
}