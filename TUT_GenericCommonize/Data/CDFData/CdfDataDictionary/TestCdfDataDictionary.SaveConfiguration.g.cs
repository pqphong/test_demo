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
    public void SaveConfigurationTest_47_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "";
            String key = string91;
            Configuration configuration102 = null;
            Configuration config = configuration102;
            Dictionary<String, Configuration> dictionary113 = new Dictionary<String, Configuration>();
            _target.GetType().GetField("configurations", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary113);
            /* Act */
            _target.GetType().GetMethod("SaveConfiguration", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(Configuration)}, null).Invoke(_target, new object[]{key, config});
            /* Assert */
            Object configurations110 = _target.GetType().GetField("configurations", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object configurations110_count_111 = typeof(Dictionary<String, Configuration>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(configurations110);
            Assert.AreEqual((Int32)0, (Int32)configurations110_count_111);
        }
    }

    [TestMethod]
    public void SaveConfigurationTest_47_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string94 = "can";
            String key = string94;
            Configuration configuration105 = new Configuration();
            String configuration105_Uuid = "fe550c68-2859-4789-8e74-0dcb5106be96";
            String configuration105_ShortName = "CanGeneral0";
            String configuration105_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanGeneral";
            configuration105.Uuid = configuration105_Uuid;
            configuration105.ShortName = configuration105_ShortName;
            configuration105.DefinitionRef = configuration105_DefinitionRef;
            Configuration config = configuration105;
            Dictionary<String, Configuration> dictionary116 = new Dictionary<String, Configuration>();
            _target.GetType().GetField("configurations", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary116);
            /* Act */
            _target.GetType().GetMethod("SaveConfiguration", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(Configuration)}, null).Invoke(_target, new object[]{key, config});
            /* Assert */
            Object configurations112 = _target.GetType().GetField("configurations", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object configurations112_count_113 = typeof(Dictionary<String, Configuration>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(configurations112);
            Assert.AreEqual((Int32)1, (Int32)configurations112_count_113);
        }
    }

    [TestMethod]
    public void SaveConfigurationTest_47_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string97 = "MCU";
            String key = string97;
            Configuration configuration108 = new Configuration();
            String configuration108_Uuid = "f35faedc-bb22-4614-8a30-4654716b411c";
            String configuration108_ShortName = "CanConfigSet0";
            String configuration108_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet";
            configuration108.Uuid = configuration108_Uuid;
            configuration108.ShortName = configuration108_ShortName;
            configuration108.DefinitionRef = configuration108_DefinitionRef;
            Configuration config = configuration108;
            Dictionary<String, Configuration> dictionary119 = new Dictionary<String, Configuration>();
            Configuration dictionary119_CAN = new Configuration();
            String dictionary119_CAN_Uuid = "fe550c68-2859-4789-8e74-0dcb5106be96";
            String dictionary119_CAN_ShortName = "CanGeneral0";
            String dictionary119_CAN_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanGeneral";
            Configuration dictionary119_MCU = new Configuration();
            String dictionary119_MCU_Uuid = "f35faedc-bb22-4614-8a30-4654716b411c";
            String dictionary119_MCU_ShortName = "CanConfigSet0";
            String dictionary119_MCU_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet";
            dictionary119["CAN"] = dictionary119_CAN;
            dictionary119_CAN.Uuid = dictionary119_CAN_Uuid;
            dictionary119_CAN.ShortName = dictionary119_CAN_ShortName;
            dictionary119_CAN.DefinitionRef = dictionary119_CAN_DefinitionRef;
            dictionary119["MCU"] = dictionary119_MCU;
            dictionary119_MCU.Uuid = dictionary119_MCU_Uuid;
            dictionary119_MCU.ShortName = dictionary119_MCU_ShortName;
            dictionary119_MCU.DefinitionRef = dictionary119_MCU_DefinitionRef;
            _target.GetType().GetField("configurations", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary119);
            /* Act */
            _target.GetType().GetMethod("SaveConfiguration", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(Configuration)}, null).Invoke(_target, new object[]{key, config});
            /* Assert */
            Object configurations114 = _target.GetType().GetField("configurations", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object configurations114_count_115 = typeof(Dictionary<String, Configuration>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(configurations114);
            Assert.AreEqual((Int32)2, (Int32)configurations114_count_115);
        }
    }
}