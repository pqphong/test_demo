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
    public void GetCurrentInstanceContainersTest_35_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "lin";
            String moduleName = string91;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.isCurrentInstanceAvailable = (CdfDataDictionary instance) =>
            {
                Boolean boolean102 = true;
                return boolean102;
            }

            ;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.getCurrentInstanceKeyString = (CdfDataDictionary instance, String _moduleName) =>
            {
                String string113 = "lin";
                return string113;
            }

            ;
            Dictionary<String, Dictionary<String, Container>> dictionary124 = new Dictionary<String, Dictionary<String, Container>>();
            Dictionary<String, Container> dictionary124_lin = new Dictionary<String, Container>();
            Container dictionary124_lin_linGeneral0 = new Container();
            String dictionary124_lin_linGeneral0_ShortName = "linGeneral0";
            String dictionary124_lin_linGeneral0_DefinitionRef = "/Renesas/Autosar/General";
            Container dictionary124_lin_configSet = new Container();
            String dictionary124_lin_configSet_ShortName = "configSet";
            String dictionary124_lin_configSet_DefinitionRef = "/Renesas/Autosar/linConfigSet";
            dictionary124["lin"] = dictionary124_lin;
            dictionary124_lin["linGeneral0"] = dictionary124_lin_linGeneral0;
            dictionary124_lin_linGeneral0.ShortName = dictionary124_lin_linGeneral0_ShortName;
            dictionary124_lin_linGeneral0.DefinitionRef = dictionary124_lin_linGeneral0_DefinitionRef;
            dictionary124_lin["configSet"] = dictionary124_lin_configSet;
            dictionary124_lin_configSet.ShortName = dictionary124_lin_configSet_ShortName;
            dictionary124_lin_configSet.DefinitionRef = dictionary124_lin_configSet_DefinitionRef;
            _target.GetType().GetField("dataContext", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary124);
            /* Act */
            IList<Container> actualResult = (IList<Container>)_target.GetType().GetMethod("GetCurrentInstanceContainers", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Object actualResult_count_121 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)2, (Int32)actualResult_count_121);
            Object actualResult_0_122 = ((IList<Container>)actualResult)[0];
            Object actualResult_0_122_shortname_223 = typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_122);
            Assert.AreEqual((String)"linGeneral0", (String)actualResult_0_122_shortname_223);
            Object actualResult_0_124 = ((IList<Container>)actualResult)[0];
            Object actualResult_0_124_definitionref_225 = typeof(Container).GetProperty("DefinitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_124);
            Assert.AreEqual((String)"/Renesas/Autosar/General", (String)actualResult_0_124_definitionref_225);
            Object actualResult_1_126 = ((IList<Container>)actualResult)[1];
            Object actualResult_1_126_shortname_227 = typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_1_126);
            Assert.AreEqual((String)"configSet", (String)actualResult_1_126_shortname_227);
            Object actualResult_1_128 = ((IList<Container>)actualResult)[1];
            Object actualResult_1_128_definitionref_229 = typeof(Container).GetProperty("DefinitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_1_128);
            Assert.AreEqual((String)"/Renesas/Autosar/linConfigSet", (String)actualResult_1_128_definitionref_229);
        }
    }

    [TestMethod]
    public void GetCurrentInstanceContainersTest_35_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string96 = "lin";
            String moduleName = string96;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.isCurrentInstanceAvailable = (CdfDataDictionary instance) =>
            {
                Boolean boolean107 = true;
                return boolean107;
            }

            ;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.getCurrentInstanceKeyString = (CdfDataDictionary instance, String _moduleName) =>
            {
                String string118 = "";
                return string118;
            }

            ;
            Dictionary<String, Dictionary<String, Container>> dictionary129 = new Dictionary<String, Dictionary<String, Container>>();
            Dictionary<String, Container> dictionary129_lin = new Dictionary<String, Container>();
            Container dictionary129_lin_linGeneral0 = new Container();
            String dictionary129_lin_linGeneral0_ShortName = "linGeneral0";
            String dictionary129_lin_linGeneral0_DefinitionRef = "/Renesas/Autosar/General";
            Container dictionary129_lin_configSet = new Container();
            String dictionary129_lin_configSet_ShortName = "configSet";
            String dictionary129_lin_configSet_DefinitionRef = "/Renesas/Autosar/linConfigSet";
            dictionary129["lin"] = dictionary129_lin;
            dictionary129_lin["linGeneral0"] = dictionary129_lin_linGeneral0;
            dictionary129_lin_linGeneral0.ShortName = dictionary129_lin_linGeneral0_ShortName;
            dictionary129_lin_linGeneral0.DefinitionRef = dictionary129_lin_linGeneral0_DefinitionRef;
            dictionary129_lin["configSet"] = dictionary129_lin_configSet;
            dictionary129_lin_configSet.ShortName = dictionary129_lin_configSet_ShortName;
            dictionary129_lin_configSet.DefinitionRef = dictionary129_lin_configSet_DefinitionRef;
            _target.GetType().GetField("dataContext", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary129);
            /* Act */
            IList<Container> actualResult = (IList<Container>)_target.GetType().GetMethod("GetCurrentInstanceContainers", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Object actualResult_count_130 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_count_130);
        }
    }

    [TestMethod]
    public void GetCurrentInstanceContainersTest_35_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string911 = "";
            String moduleName = string911;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.isCurrentInstanceAvailable = (CdfDataDictionary instance) =>
            {
                Boolean boolean1012 = true;
                return boolean1012;
            }

            ;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.getCurrentInstanceKeyString = (CdfDataDictionary instance, String _moduleName) =>
            {
                String string1113 = "lin";
                return string1113;
            }

            ;
            Dictionary<String, Dictionary<String, Container>> dictionary1214 = new Dictionary<String, Dictionary<String, Container>>();
            Dictionary<String, Container> dictionary1214_lin = new Dictionary<String, Container>();
            Container dictionary1214_lin_linGeneral0 = new Container();
            String dictionary1214_lin_linGeneral0_ShortName = "linGeneral0";
            String dictionary1214_lin_linGeneral0_DefinitionRef = "/Renesas/Autosar/General";
            Container dictionary1214_lin_configSet = new Container();
            String dictionary1214_lin_configSet_ShortName = "configSet";
            String dictionary1214_lin_configSet_DefinitionRef = "/Renesas/Autosar/linConfigSet";
            dictionary1214["lin"] = dictionary1214_lin;
            dictionary1214_lin["linGeneral0"] = dictionary1214_lin_linGeneral0;
            dictionary1214_lin_linGeneral0.ShortName = dictionary1214_lin_linGeneral0_ShortName;
            dictionary1214_lin_linGeneral0.DefinitionRef = dictionary1214_lin_linGeneral0_DefinitionRef;
            dictionary1214_lin["configSet"] = dictionary1214_lin_configSet;
            dictionary1214_lin_configSet.ShortName = dictionary1214_lin_configSet_ShortName;
            dictionary1214_lin_configSet.DefinitionRef = dictionary1214_lin_configSet_DefinitionRef;
            _target.GetType().GetField("dataContext", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary1214);
            Dictionary<String, List<String>> dictionary1315 = new Dictionary<String, List<String>>();
            List<String> dictionary1315_lin = new List<String>();
            String dictionary1315_lin_0 = "lin0";
            dictionary1315["lin"] = dictionary1315_lin;
            dictionary1315_lin.Add(dictionary1315_lin_0);
            _target.GetType().GetField("moduleInstances", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dictionary1315);
            /* Act */
            IList<Container> actualResult = (IList<Container>)_target.GetType().GetMethod("GetCurrentInstanceContainers", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Object actualResult_count_131 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)2, (Int32)actualResult_count_131);
            Object actualResult_0_132 = ((IList<Container>)actualResult)[0];
            Object actualResult_0_132_shortname_233 = typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_132);
            Assert.AreEqual((String)"linGeneral0", (String)actualResult_0_132_shortname_233);
            Object actualResult_0_134 = ((IList<Container>)actualResult)[0];
            Object actualResult_0_134_definitionref_235 = typeof(Container).GetProperty("DefinitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_134);
            Assert.AreEqual((String)"/Renesas/Autosar/General", (String)actualResult_0_134_definitionref_235);
            Object actualResult_1_136 = ((IList<Container>)actualResult)[1];
            Object actualResult_1_136_shortname_237 = typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_1_136);
            Assert.AreEqual((String)"configSet", (String)actualResult_1_136_shortname_237);
            Object actualResult_1_138 = ((IList<Container>)actualResult)[1];
            Object actualResult_1_138_definitionref_239 = typeof(Container).GetProperty("DefinitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_1_138);
            Assert.AreEqual((String)"/Renesas/Autosar/linConfigSet", (String)actualResult_1_138_definitionref_239);
        }
    }

    [TestMethod]
    public void GetCurrentInstanceContainersTest_35_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String moduleName = null;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimCdfDataDictionary.AllInstances.isCurrentInstanceAvailable = (CdfDataDictionary instance) =>
            {
                Boolean boolean1017 = false;
                return boolean1017;
            }

            ;
            /* Act */
            IList<Container> actualResult = (IList<Container>)_target.GetType().GetMethod("GetCurrentInstanceContainers", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Object actualResult_count_140 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_count_140);
        }
    }
}