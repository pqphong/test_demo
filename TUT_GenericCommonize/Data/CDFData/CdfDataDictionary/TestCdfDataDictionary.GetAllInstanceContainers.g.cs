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
    public void GetAllInstanceContainersTest_36_1()
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
            Dictionary<String, Dictionary<String, Container>> dictionary113 = new Dictionary<String, Dictionary<String, Container>>();
            Dictionary<String, Container> dictionary113_lin0 = new Dictionary<String, Container>();
            Container dictionary113_lin0_linGeneral0 = new Container();
            String dictionary113_lin0_linGeneral0_ShortName = "linGeneral0";
            String dictionary113_lin0_linGeneral0_DefinitionRef = "/Renesas/Autosar/General";
            Container dictionary113_lin0_configSet = new Container();
            String dictionary113_lin0_configSet_ShortName = "configSet";
            String dictionary113_lin0_configSet_DefinitionRef = "/Renesas/Autosar/linConfigSet";
            dictionary113["lin0"] = dictionary113_lin0;
            dictionary113_lin0["linGeneral0"] = dictionary113_lin0_linGeneral0;
            dictionary113_lin0_linGeneral0.ShortName = dictionary113_lin0_linGeneral0_ShortName;
            dictionary113_lin0_linGeneral0.DefinitionRef = dictionary113_lin0_linGeneral0_DefinitionRef;
            dictionary113_lin0["configSet"] = dictionary113_lin0_configSet;
            dictionary113_lin0_configSet.ShortName = dictionary113_lin0_configSet_ShortName;
            dictionary113_lin0_configSet.DefinitionRef = dictionary113_lin0_configSet_DefinitionRef;
            _target.GetType().GetField("dataContext", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary113);
            /* Act */
            Dictionary<String, IList<Container>> actualResult = (Dictionary<String, IList<Container>>)_target.GetType().GetMethod("GetAllInstanceContainers", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Object actualResult_lin0_113 = ((Dictionary<String, IList<Container>>)actualResult)["lin0"];
            Object actualResult_lin0_113_0_214 = ((IList<Container>)actualResult_lin0_113)[0];
            Object actualResult_lin0_113_0_214_shortname_315 = typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_lin0_113_0_214);
            Assert.AreEqual((String)"linGeneral0", (String)actualResult_lin0_113_0_214_shortname_315);
            Object actualResult_lin0_116 = ((Dictionary<String, IList<Container>>)actualResult)["lin0"];
            Object actualResult_lin0_116_0_217 = ((IList<Container>)actualResult_lin0_116)[0];
            Object actualResult_lin0_116_0_217_definitionref_318 = typeof(Container).GetProperty("DefinitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_lin0_116_0_217);
            Assert.AreEqual((String)"/Renesas/Autosar/General", (String)actualResult_lin0_116_0_217_definitionref_318);
            Object actualResult_lin0_119 = ((Dictionary<String, IList<Container>>)actualResult)["lin0"];
            Object actualResult_lin0_119_1_220 = ((IList<Container>)actualResult_lin0_119)[1];
            Object actualResult_lin0_119_1_220_shortname_321 = typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_lin0_119_1_220);
            Assert.AreEqual((String)"configSet", (String)actualResult_lin0_119_1_220_shortname_321);
            Object actualResult_lin0_122 = ((Dictionary<String, IList<Container>>)actualResult)["lin0"];
            Object actualResult_lin0_122_1_223 = ((IList<Container>)actualResult_lin0_122)[1];
            Object actualResult_lin0_122_1_223_definitionref_324 = typeof(Container).GetProperty("DefinitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_lin0_122_1_223);
            Assert.AreEqual((String)"/Renesas/Autosar/linConfigSet", (String)actualResult_lin0_122_1_223_definitionref_324);
        }
    }

    [TestMethod]
    public void GetAllInstanceContainersTest_36_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string94 = "lin";
            String moduleName = string94;
            Dictionary<String, List<String>> dictionary105 = new Dictionary<String, List<String>>();
            List<String> dictionary105_LIN = new List<String>();
            String dictionary105_LIN_0 = null;
            dictionary105["LIN"] = dictionary105_LIN;
            dictionary105_LIN.Add(dictionary105_LIN_0);
            _target.GetType().GetField("moduleInstances", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary105);
            Dictionary<String, Dictionary<String, Container>> dictionary116 = new Dictionary<String, Dictionary<String, Container>>();
            Dictionary<String, Container> dictionary116_lin0 = new Dictionary<String, Container>();
            Container dictionary116_lin0_linGeneral0 = new Container();
            String dictionary116_lin0_linGeneral0_ShortName = "linGeneral0";
            String dictionary116_lin0_linGeneral0_DefinitionRef = "/Renesas/Autosar/General";
            Container dictionary116_lin0_configSet = new Container();
            String dictionary116_lin0_configSet_ShortName = "configSet";
            String dictionary116_lin0_configSet_DefinitionRef = "/Renesas/Autosar/linConfigSet";
            dictionary116["lin0"] = dictionary116_lin0;
            dictionary116_lin0["linGeneral0"] = dictionary116_lin0_linGeneral0;
            dictionary116_lin0_linGeneral0.ShortName = dictionary116_lin0_linGeneral0_ShortName;
            dictionary116_lin0_linGeneral0.DefinitionRef = dictionary116_lin0_linGeneral0_DefinitionRef;
            dictionary116_lin0["configSet"] = dictionary116_lin0_configSet;
            dictionary116_lin0_configSet.ShortName = dictionary116_lin0_configSet_ShortName;
            dictionary116_lin0_configSet.DefinitionRef = dictionary116_lin0_configSet_DefinitionRef;
            _target.GetType().GetField("dataContext", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary116);
            /* Act */
            Dictionary<String, IList<Container>> actualResult = (Dictionary<String, IList<Container>>)_target.GetType().GetMethod("GetAllInstanceContainers", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Object actualResult_count_125 = typeof(Dictionary<String, IList<Container>>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_count_125);
        }
    }

    [TestMethod]
    public void GetAllInstanceContainersTest_36_3()
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
            Dictionary<String, Dictionary<String, Container>> dictionary119 = new Dictionary<String, Dictionary<String, Container>>();
            Dictionary<String, Container> dictionary119_lin0 = new Dictionary<String, Container>();
            Container dictionary119_lin0_linGeneral0 = new Container();
            String dictionary119_lin0_linGeneral0_ShortName = "linGeneral0";
            String dictionary119_lin0_linGeneral0_DefinitionRef = "/Renesas/Autosar/General";
            Container dictionary119_lin0_configSet = new Container();
            String dictionary119_lin0_configSet_ShortName = "configSet";
            String dictionary119_lin0_configSet_DefinitionRef = "/Renesas/Autosar/linConfigSet";
            dictionary119["lin0"] = dictionary119_lin0;
            dictionary119_lin0["linGeneral0"] = dictionary119_lin0_linGeneral0;
            dictionary119_lin0_linGeneral0.ShortName = dictionary119_lin0_linGeneral0_ShortName;
            dictionary119_lin0_linGeneral0.DefinitionRef = dictionary119_lin0_linGeneral0_DefinitionRef;
            dictionary119_lin0["configSet"] = dictionary119_lin0_configSet;
            dictionary119_lin0_configSet.ShortName = dictionary119_lin0_configSet_ShortName;
            dictionary119_lin0_configSet.DefinitionRef = dictionary119_lin0_configSet_DefinitionRef;
            _target.GetType().GetField("dataContext", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary119);
            /* Act */
            Dictionary<String, IList<Container>> actualResult = (Dictionary<String, IList<Container>>)_target.GetType().GetMethod("GetAllInstanceContainers", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Object actualResult_count_126 = typeof(Dictionary<String, IList<Container>>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_count_126);
        }
    }

    [TestMethod]
    public void GetAllInstanceContainersTest_36_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string910 = "";
            String moduleName = string910;
            Dictionary<String, List<String>> dictionary1011 = new Dictionary<String, List<String>>();
            List<String> dictionary1011_LIN = new List<String>();
            String dictionary1011_LIN_0 = "lin0";
            dictionary1011["LIN"] = dictionary1011_LIN;
            dictionary1011_LIN.Add(dictionary1011_LIN_0);
            _target.GetType().GetField("moduleInstances", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary1011);
            Dictionary<String, Dictionary<String, Container>> dictionary1112 = new Dictionary<String, Dictionary<String, Container>>();
            Dictionary<String, Container> dictionary1112_lin0 = new Dictionary<String, Container>();
            Container dictionary1112_lin0_linGeneral0 = new Container();
            String dictionary1112_lin0_linGeneral0_ShortName = "linGeneral0";
            String dictionary1112_lin0_linGeneral0_DefinitionRef = "/Renesas/Autosar/General";
            Container dictionary1112_lin0_configSet = new Container();
            String dictionary1112_lin0_configSet_ShortName = "configSet";
            String dictionary1112_lin0_configSet_DefinitionRef = "/Renesas/Autosar/linConfigSet";
            dictionary1112["lin0"] = dictionary1112_lin0;
            dictionary1112_lin0["linGeneral0"] = dictionary1112_lin0_linGeneral0;
            dictionary1112_lin0_linGeneral0.ShortName = dictionary1112_lin0_linGeneral0_ShortName;
            dictionary1112_lin0_linGeneral0.DefinitionRef = dictionary1112_lin0_linGeneral0_DefinitionRef;
            dictionary1112_lin0["configSet"] = dictionary1112_lin0_configSet;
            dictionary1112_lin0_configSet.ShortName = dictionary1112_lin0_configSet_ShortName;
            dictionary1112_lin0_configSet.DefinitionRef = dictionary1112_lin0_configSet_DefinitionRef;
            _target.GetType().GetField("dataContext", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary1112);
            /* Act */
            Dictionary<String, IList<Container>> actualResult = (Dictionary<String, IList<Container>>)_target.GetType().GetMethod("GetAllInstanceContainers", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Object actualResult_count_127 = typeof(Dictionary<String, IList<Container>>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_count_127);
        }
    }
}