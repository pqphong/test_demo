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
    public void SaveCdfFilesTest_39_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9136 = "can";
            String moduleName = string9136;
            String string10137 = "CanConfigSet";
            String shortName = string10137;
            String string11138 = "can.arxml";
            String fileName = string11138;
            Dictionary<String, String> dictionary12139 = new Dictionary<String, String>();
            String dictionary12139_CAN = "can.arxml";
            String dictionary12139_CANCONFIGSET = "can.arxml";
            dictionary12139["CAN"] = dictionary12139_CAN;
            dictionary12139["CANCONFIGSET"] = dictionary12139_CANCONFIGSET;
            _target.GetType().GetField("cdfFiles", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary12139);
            /* Act */
            _target.GetType().GetMethod("SaveCdfFiles", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String), typeof(String)}, null).Invoke(_target, new object[]{moduleName, shortName, fileName});
            /* Assert */
            Object cdffiles1489 = _target.GetType().GetField("cdfFiles", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object cdffiles1489_count_1490 = typeof(Dictionary<String, String>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(cdffiles1489);
            Assert.AreEqual((Int32)2, (Int32)cdffiles1489_count_1490);
        }
    }

    [TestMethod]
    public void SaveCdfFilesTest_39_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9140 = "can";
            String moduleName = string9140;
            String string10141 = "CanConfigSet";
            String shortName = string10141;
            String string11142 = "can.arxml";
            String fileName = string11142;
            Dictionary<String, String> dictionary12143 = new Dictionary<String, String>();
            String dictionary12143_MCU = "mcu.arxml";
            String dictionary12143_MCUCONFIGSET = "mcu.arxml";
            dictionary12143["MCU"] = dictionary12143_MCU;
            dictionary12143["MCUCONFIGSET"] = dictionary12143_MCUCONFIGSET;
            _target.GetType().GetField("cdfFiles", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary12143);
            /* Act */
            _target.GetType().GetMethod("SaveCdfFiles", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String), typeof(String)}, null).Invoke(_target, new object[]{moduleName, shortName, fileName});
            /* Assert */
            Object cdffiles1491 = _target.GetType().GetField("cdfFiles", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object cdffiles1491_count_1492 = typeof(Dictionary<String, String>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(cdffiles1491);
            Assert.AreEqual((Int32)4, (Int32)cdffiles1491_count_1492);
        }
    }

    [TestMethod]
    public void SaveCdfFilesTest_39_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9144 = "";
            String moduleName = string9144;
            String string10145 = null;
            String shortName = string10145;
            String string11146 = null;
            String fileName = string11146;
            Dictionary<String, String> dictionary12147 = new Dictionary<String, String>();
            String dictionary12147_MCU = "mcu.arxml";
            String dictionary12147_MCUCONFIGSET = "mcu.arxml";
            dictionary12147["MCU"] = dictionary12147_MCU;
            dictionary12147["MCUCONFIGSET"] = dictionary12147_MCUCONFIGSET;
            _target.GetType().GetField("cdfFiles", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary12147);
            /* Act */
            _target.GetType().GetMethod("SaveCdfFiles", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String), typeof(String)}, null).Invoke(_target, new object[]{moduleName, shortName, fileName});
            /* Assert */
            Object cdffiles1493 = _target.GetType().GetField("cdfFiles", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object cdffiles1493_count_1494 = typeof(Dictionary<String, String>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(cdffiles1493);
            Assert.AreEqual((Int32)2, (Int32)cdffiles1493_count_1494);
        }
    }
}