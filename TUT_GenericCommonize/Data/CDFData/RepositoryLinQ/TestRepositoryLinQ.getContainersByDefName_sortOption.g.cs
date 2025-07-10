using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.CDFData;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;

public partial class TestRepositoryLinQ
{
    [TestMethod]
    public void getContainersByDefNameTest_4_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            IList<Container> ilist91 = new List<Container>();
            Container ilist91_0 = new Container();
            String ilist91_0_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController/CanBusoffProcessing";
            ilist91.Add(ilist91_0);
            ilist91_0.DefinitionRef = ilist91_0_DefinitionRef;
            IList<Container> containers = ilist91;
            String string102 = null;
            String defName = string102;
            Int32 int32113 = 0;
            Int32 sortOption = int32113;
            string variant = "";
            /* Act */
            IList<Container> actualResult = (IList<Container>)typeof(RepositoryLinQ).GetMethod("getContainersByDefName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(IList<Container>), typeof(String), typeof(Int32), typeof(String)}, null).Invoke(_target, new object[]{containers, defName, sortOption, variant});
            /* Assert */
            Object actualResult_count_116 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_count_116);
        }
    }

    [TestMethod]
    public void getContainersByDefNameTest_4_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            IList<Container> ilist94 = new List<Container>();
            Container ilist94_0 = new Container();
            String ilist94_0_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanBusoffProcessing";
            String ilist94_0_ShortName = "CanController";
            Container ilist94_1 = new Container();
            String ilist94_1_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController_001/CanBusoffProcessing";
            String ilist94_1_ShortName = "CanController_001";
            Container ilist94_2 = new Container();
            String ilist94_2_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController_002/CanRxProcessing";
            ilist94.Add(ilist94_0);
            ilist94_0.DefinitionRef = ilist94_0_DefinitionRef;
            ilist94_0.ShortName = ilist94_0_ShortName;
            ilist94.Add(ilist94_1);
            ilist94_1.DefinitionRef = ilist94_1_DefinitionRef;
            ilist94_1.ShortName = ilist94_1_ShortName;
            ilist94.Add(ilist94_2);
            ilist94_2.DefinitionRef = ilist94_2_DefinitionRef;
            IList<Container> containers = ilist94;
            String string105 = "CanBusoffProcessing";
            String defName = string105;
            Int32 int32116 = 0;
            Int32 sortOption = int32116;
            string variant = "";
            /* Act */
            IList<Container> actualResult = (IList<Container>)typeof(RepositoryLinQ).GetMethod("getContainersByDefName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(IList<Container>), typeof(String), typeof(Int32), typeof(String)}, null).Invoke(_target, new object[]{containers, defName, sortOption, variant});
            /* Assert */
            Object actualResult_count_117 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)2, (Int32)actualResult_count_117);
            Object actualResult_0_118 = ((IList<Container>)actualResult)[0];
            Object actualResult_0_118_definitionref_219 = typeof(Container).GetProperty("DefinitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_118);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Can/Can/CanConfigSet/CanBusoffProcessing", (String)actualResult_0_118_definitionref_219);
            Object actualResult_0_120 = ((IList<Container>)actualResult)[0];
            Object actualResult_0_120_shortname_221 = typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_120);
            Assert.AreEqual((String)"CanController", (String)actualResult_0_120_shortname_221);
            Object actualResult_1_122 = ((IList<Container>)actualResult)[1];
            Object actualResult_1_122_definitionref_223 = typeof(Container).GetProperty("DefinitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_1_122);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController_001/CanBusoffProcessing", (String)actualResult_1_122_definitionref_223);
            Object actualResult_1_124 = ((IList<Container>)actualResult)[1];
            Object actualResult_1_124_shortname_225 = typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_1_124);
            Assert.AreEqual((String)"CanController_001", (String)actualResult_1_124_shortname_225);
        }
    }

    [TestMethod]
    public void getContainersByDefNameTest_4_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            IList<Container> ilist97 = new List<Container>();
            Container ilist97_0 = new Container();
            String ilist97_0_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController_001/CanBusoffProcessing";
            String ilist97_0_ShortName = "CanController_001";
            Container ilist97_1 = new Container();
            String ilist97_1_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanBusoffProcessing";
            String ilist97_1_ShortName = "CanController";
            ilist97.Add(ilist97_0);
            ilist97_0.DefinitionRef = ilist97_0_DefinitionRef;
            ilist97_0.ShortName = ilist97_0_ShortName;
            ilist97.Add(ilist97_1);
            ilist97_1.DefinitionRef = ilist97_1_DefinitionRef;
            ilist97_1.ShortName = ilist97_1_ShortName;
            IList<Container> containers = ilist97;
            String string108 = "CanBusoffProcessing";
            String defName = string108;
            Int32 int32119 = 0;
            Int32 sortOption = int32119;
            string variant = "";
            /* Act */
            IList<Container> actualResult = (IList<Container>)typeof(RepositoryLinQ).GetMethod("getContainersByDefName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(IList<Container>), typeof(String), typeof(Int32), typeof(String)}, null).Invoke(_target, new object[]{containers, defName, sortOption, variant});
            /* Assert */
            Object actualResult_count_126 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)2, (Int32)actualResult_count_126);
            Object actualResult_0_127 = ((IList<Container>)actualResult)[0];
            Object actualResult_0_127_definitionref_228 = typeof(Container).GetProperty("DefinitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_127);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController_001/CanBusoffProcessing", (String)actualResult_0_127_definitionref_228);
            Object actualResult_0_129 = ((IList<Container>)actualResult)[0];
            Object actualResult_0_129_shortname_230 = typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_129);
            Assert.AreEqual((String)"CanController_001", (String)actualResult_0_129_shortname_230);
            Object actualResult_1_131 = ((IList<Container>)actualResult)[1];
            Object actualResult_1_131_definitionref_232 = typeof(Container).GetProperty("DefinitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_1_131);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Can/Can/CanConfigSet/CanBusoffProcessing", (String)actualResult_1_131_definitionref_232);
            Object actualResult_1_133 = ((IList<Container>)actualResult)[1];
            Object actualResult_1_133_shortname_234 = typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_1_133);
            Assert.AreEqual((String)"CanController", (String)actualResult_1_133_shortname_234);
        }
    }

    [TestMethod]
    public void getContainersByDefNameTest_4_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            IList<Container> ilist910 = new List<Container>();
            Container ilist910_0 = new Container();
            String ilist910_0_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController_001/CanBusoffProcessing";
            String ilist910_0_ShortName = "CanController_001";
            Container ilist910_1 = new Container();
            String ilist910_1_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanBusoffProcessing";
            String ilist910_1_ShortName = "CanController";
            ilist910.Add(ilist910_0);
            ilist910_0.DefinitionRef = ilist910_0_DefinitionRef;
            ilist910_0.ShortName = ilist910_0_ShortName;
            ilist910.Add(ilist910_1);
            ilist910_1.DefinitionRef = ilist910_1_DefinitionRef;
            ilist910_1.ShortName = ilist910_1_ShortName;
            IList<Container> containers = ilist910;
            String string1011 = "CanBusoffProcessing";
            String defName = string1011;
            Int32 int321112 = 1;
            Int32 sortOption = int321112;
            string variant = "";
            /* Act */
            IList<Container> actualResult = (IList<Container>)typeof(RepositoryLinQ).GetMethod("getContainersByDefName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(IList<Container>), typeof(String), typeof(Int32), typeof(String)}, null).Invoke(_target, new object[]{containers, defName, sortOption, variant});
            /* Assert */
            Object actualResult_count_135 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)2, (Int32)actualResult_count_135);
            Object actualResult_0_136 = ((IList<Container>)actualResult)[0];
            Object actualResult_0_136_definitionref_237 = typeof(Container).GetProperty("DefinitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_136);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Can/Can/CanConfigSet/CanBusoffProcessing", (String)actualResult_0_136_definitionref_237);
            Object actualResult_0_138 = ((IList<Container>)actualResult)[0];
            Object actualResult_0_138_shortname_239 = typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_138);
            Assert.AreEqual((String)"CanController", (String)actualResult_0_138_shortname_239);
            Object actualResult_1_140 = ((IList<Container>)actualResult)[1];
            Object actualResult_1_140_definitionref_241 = typeof(Container).GetProperty("DefinitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_1_140);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController_001/CanBusoffProcessing", (String)actualResult_1_140_definitionref_241);
            Object actualResult_1_142 = ((IList<Container>)actualResult)[1];
            Object actualResult_1_142_shortname_243 = typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_1_142);
            Assert.AreEqual((String)"CanController_001", (String)actualResult_1_142_shortname_243);
        }
    }

    [TestMethod]
    public void getContainersByDefNameTest_4_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            IList<Container> ilist913 = new List<Container>();
            Container ilist913_0 = new Container();
            String ilist913_0_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController_001/CanBusoffProcessing";
            String ilist913_0_ShortName = "CanController_001";
            Container ilist913_1 = new Container();
            String ilist913_1_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanBusoffProcessing";
            String ilist913_1_ShortName = "CanController";
            ilist913.Add(ilist913_0);
            ilist913_0.DefinitionRef = ilist913_0_DefinitionRef;
            ilist913_0.ShortName = ilist913_0_ShortName;
            ilist913.Add(ilist913_1);
            ilist913_1.DefinitionRef = ilist913_1_DefinitionRef;
            ilist913_1.ShortName = ilist913_1_ShortName;
            IList<Container> containers = ilist913;
            String string1014 = "CanBusoffProcessing";
            String defName = string1014;
            Int32 int321115 = 3;
            Int32 sortOption = int321115;
            string variant = "";
            /* Act */
            IList<Container> actualResult = (IList<Container>)typeof(RepositoryLinQ).GetMethod("getContainersByDefName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(IList<Container>), typeof(String), typeof(Int32), typeof(String)}, null).Invoke(_target, new object[]{containers, defName, sortOption, variant});
            /* Assert */
            Object actualResult_count_144 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)2, (Int32)actualResult_count_144);
            Object actualResult_0_145 = ((IList<Container>)actualResult)[0];
            Object actualResult_0_145_definitionref_246 = typeof(Container).GetProperty("DefinitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_145);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController_001/CanBusoffProcessing", (String)actualResult_0_145_definitionref_246);
            Object actualResult_0_147 = ((IList<Container>)actualResult)[0];
            Object actualResult_0_147_shortname_248 = typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_147);
            Assert.AreEqual((String)"CanController_001", (String)actualResult_0_147_shortname_248);
            Object actualResult_1_149 = ((IList<Container>)actualResult)[1];
            Object actualResult_1_149_definitionref_250 = typeof(Container).GetProperty("DefinitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_1_149);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Can/Can/CanConfigSet/CanBusoffProcessing", (String)actualResult_1_149_definitionref_250);
            Object actualResult_1_151 = ((IList<Container>)actualResult)[1];
            Object actualResult_1_151_shortname_252 = typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_1_151);
            Assert.AreEqual((String)"CanController", (String)actualResult_1_151_shortname_252);
        }
    }

    [TestMethod]
    public void getContainersByDefNameTest_4_6()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            IList<Container> ilist94 = new List<Container>();
            Container ilist94_0 = new Container();
            String ilist94_0_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanBusoffProcessing";
            String ilist94_0_ShortName = "CanController";
            Container ilist94_1 = new Container();
            String ilist94_1_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController_001/CanBusoffProcessing";
            String ilist94_1_ShortName = "CanController_001";
            Container ilist94_2 = new Container();
            String ilist94_2_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController_002/CanRxProcessing";
            ilist94.Add(ilist94_0);
            ilist94_0.DefinitionRef = ilist94_0_DefinitionRef;
            ilist94_0.ShortName = ilist94_0_ShortName;
            ilist94_0.VariantID = "0";
            ilist94.Add(ilist94_1);
            ilist94_1.DefinitionRef = ilist94_1_DefinitionRef;
            ilist94_1.ShortName = ilist94_1_ShortName;
            ilist94_1.VariantID = "1";
            ilist94.Add(ilist94_2);
            ilist94_2.DefinitionRef = ilist94_2_DefinitionRef;
            IList<Container> containers = ilist94;
            String string105 = "CanBusoffProcessing";
            String defName = string105;
            Int32 int32116 = 0;
            Int32 sortOption = int32116;
            string variant = "0";
            /* Act */
            IList<Container> actualResult = (IList<Container>)typeof(RepositoryLinQ).GetMethod("getContainersByDefName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(IList<Container>), typeof(String), typeof(Int32), typeof(String) }, null).Invoke(_target, new object[] { containers, defName, sortOption, variant });
            /* Assert */
            Object actualResult_count_117 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)1, (Int32)actualResult_count_117);
            Object actualResult_0_118 = ((IList<Container>)actualResult)[0];
            Object actualResult_0_118_definitionref_219 = typeof(Container).GetProperty("DefinitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_118);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Can/Can/CanConfigSet/CanBusoffProcessing", (String)actualResult_0_118_definitionref_219);
            Object actualResult_0_120 = ((IList<Container>)actualResult)[0];
            Object actualResult_0_120_shortname_221 = typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_120);
            Assert.AreEqual((String)"CanController", (String)actualResult_0_120_shortname_221);
        }
    }

    [TestMethod]
    public void getContainersByDefNameTest_4_7()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            IList<Container> ilist94 = new List<Container>();
            Container ilist94_0 = new Container();
            String ilist94_0_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanBusoffProcessing";
            String ilist94_0_ShortName = "CanController";
            Container ilist94_1 = new Container();
            String ilist94_1_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController_001/CanBusoffProcessing";
            String ilist94_1_ShortName = "CanController_001";
            Container ilist94_2 = new Container();
            String ilist94_2_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController_002/CanRxProcessing";
            ilist94.Add(ilist94_0);
            ilist94_0.DefinitionRef = ilist94_0_DefinitionRef;
            ilist94_0.ShortName = ilist94_0_ShortName;
            ilist94.Add(ilist94_1);
            ilist94_1.DefinitionRef = ilist94_1_DefinitionRef;
            ilist94_1.ShortName = ilist94_1_ShortName;
            ilist94.Add(ilist94_2);
            ilist94_2.DefinitionRef = ilist94_2_DefinitionRef;
            IList<Container> containers = ilist94;
            String string105 = "CanBusoffProcessing";
            String defName = string105;
            Int32 int32116 = 0;
            Int32 sortOption = int32116;
            string variant = "0";
            /* Act */
            IList<Container> actualResult = (IList<Container>)typeof(RepositoryLinQ).GetMethod("getContainersByDefName", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(IList<Container>), typeof(String), typeof(Int32), typeof(String) }, null).Invoke(_target, new object[] { containers, defName, sortOption, variant });
            /* Assert */
            Object actualResult_count_117 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)2, (Int32)actualResult_count_117);
            Object actualResult_0_118 = ((IList<Container>)actualResult)[0];
            Object actualResult_0_118_definitionref_219 = typeof(Container).GetProperty("DefinitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_118);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Can/Can/CanConfigSet/CanBusoffProcessing", (String)actualResult_0_118_definitionref_219);
            Object actualResult_0_120 = ((IList<Container>)actualResult)[0];
            Object actualResult_0_120_shortname_221 = typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_120);
            Assert.AreEqual((String)"CanController", (String)actualResult_0_120_shortname_221);
            Object actualResult_1_122 = ((IList<Container>)actualResult)[1];
            Object actualResult_1_122_definitionref_223 = typeof(Container).GetProperty("DefinitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_1_122);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController_001/CanBusoffProcessing", (String)actualResult_1_122_definitionref_223);
            Object actualResult_1_124 = ((IList<Container>)actualResult)[1];
            Object actualResult_1_124_shortname_225 = typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_1_124);
            Assert.AreEqual((String)"CanController_001", (String)actualResult_1_124_shortname_225);
        }
    }
}