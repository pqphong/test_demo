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
    public void GetAllInstanceConfigurationsTest_38_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "lin";
            String moduleName = string91;
            Dictionary<String, List<String>> dictionary102 = new Dictionary<String, List<String>>();
            List<String> dictionary102_LIN = new List<String>();
            String dictionary102_LIN_0 = "lin0";
            dictionary102["LIN"] = dictionary102_LIN;
            dictionary102_LIN.Add(dictionary102_LIN_0);
            _target.GetType().GetField("moduleInstances", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary102);
            Dictionary<String, Configuration> dictionary113 = new Dictionary<String, Configuration>();
            Configuration dictionary113_lin0 = new Configuration();
            String dictionary113_lin0_ShortName = "lin0";
            String dictionary113_lin0_DefinitionRef = "Renesas/Autosar/lin";
            dictionary113["lin0"] = dictionary113_lin0;
            dictionary113_lin0.ShortName = dictionary113_lin0_ShortName;
            dictionary113_lin0.DefinitionRef = dictionary113_lin0_DefinitionRef;
            _target.GetType().GetField("configurations", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary113);
            /* Act */
            IList<Configuration> actualResult = (IList<Configuration>)_target.GetType().GetMethod("GetAllInstanceConfigurations", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Object actualResult_0_113 = ((IList<Configuration>)actualResult)[0];
            Object actualResult_0_113_shortname_214 = typeof(Configuration).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_113);
            Assert.AreEqual((String)"lin0", (String)actualResult_0_113_shortname_214);
            Object actualResult_0_115 = ((IList<Configuration>)actualResult)[0];
            Object actualResult_0_115_definitionref_216 = typeof(Configuration).GetProperty("DefinitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_115);
            Assert.AreEqual((String)"Renesas/Autosar/lin", (String)actualResult_0_115_definitionref_216);
        }
    }

    [TestMethod]
    public void GetAllInstanceConfigurationsTest_38_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string94 = "";
            String moduleName = string94;
            Dictionary<String, List<String>> dictionary105 = new Dictionary<String, List<String>>();
            List<String> dictionary105_LIN = new List<String>();
            String dictionary105_LIN_0 = "lin0";
            dictionary105["LIN"] = dictionary105_LIN;
            dictionary105_LIN.Add(dictionary105_LIN_0);
            _target.GetType().GetField("moduleInstances", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary105);
            /* Act */
            IList<Configuration> actualResult = (IList<Configuration>)_target.GetType().GetMethod("GetAllInstanceConfigurations", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Object actualResult_count_117 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_count_117);
        }
    }

    [TestMethod]
    public void GetAllInstanceConfigurationsTest_38_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string97 = "can";
            String moduleName = string97;
            Dictionary<String, List<String>> dictionary108 = new Dictionary<String, List<String>>();
            List<String> dictionary108_LIN = new List<String>();
            String dictionary108_LIN_0 = "lin0";
            dictionary108["LIN"] = dictionary108_LIN;
            dictionary108_LIN.Add(dictionary108_LIN_0);
            _target.GetType().GetField("moduleInstances", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary108);
            Dictionary<String, Configuration> dictionary119 = new Dictionary<String, Configuration>();
            Configuration dictionary119_lin0 = new Configuration();
            String dictionary119_lin0_ShortName = "lin0";
            String dictionary119_lin0_DefinitionRef = "Renesas/Autosar/lin";
            dictionary119["lin0"] = dictionary119_lin0;
            dictionary119_lin0.ShortName = dictionary119_lin0_ShortName;
            dictionary119_lin0.DefinitionRef = dictionary119_lin0_DefinitionRef;
            _target.GetType().GetField("configurations", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary119);
            /* Act */
            IList<Configuration> actualResult = (IList<Configuration>)_target.GetType().GetMethod("GetAllInstanceConfigurations", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Object actualResult_count_118 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_count_118);
        }
    }

    [TestMethod]
    public void GetAllInstanceConfigurationsTest_38_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string910 = "lin";
            String moduleName = string910;
            Dictionary<String, List<String>> dictionary1011 = new Dictionary<String, List<String>>();
            List<String> dictionary1011_LIN = new List<String>();
            String dictionary1011_LIN_0 = "lin0";
            dictionary1011["LIN"] = dictionary1011_LIN;
            dictionary1011_LIN.Add(dictionary1011_LIN_0);
            _target.GetType().GetField("moduleInstances", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary1011);
            Dictionary<String, Configuration> dictionary1112 = new Dictionary<String, Configuration>();
            Configuration dictionary1112_can0 = new Configuration();
            String dictionary1112_can0_ShortName = "can0";
            String dictionary1112_can0_DefinitionRef = "Renesas/Autosar/can";
            dictionary1112["can0"] = dictionary1112_can0;
            dictionary1112_can0.ShortName = dictionary1112_can0_ShortName;
            dictionary1112_can0.DefinitionRef = dictionary1112_can0_DefinitionRef;
            _target.GetType().GetField("configurations", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary1112);
            /* Act */
            IList<Configuration> actualResult = (IList<Configuration>)_target.GetType().GetMethod("GetAllInstanceConfigurations", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Object actualResult_count_119 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_count_119);
        }
    }
}