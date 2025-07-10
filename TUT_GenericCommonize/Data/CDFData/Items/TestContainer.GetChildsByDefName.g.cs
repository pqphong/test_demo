using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;

public partial class TestContainer
{
    [TestMethod]
    public void GetChildsByDefNameTest_112_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "PortGroup0";
            String defName = string91;
            Int32 int32102 = 0;
            Int32 sortOption = int32102;
            List<Container> list113 = new List<Container>();
            Container list113_0 = new Container();
            String list113_0_DefinitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup0";
            Container list113_1 = new Container();
            String list113_1_DefinitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup1";
            Container list113_2 = new Container();
            String list113_2_DefinitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup2";
            list113.Add(list113_0);
            list113_0.DefinitionRef = list113_0_DefinitionRef;
            list113.Add(list113_1);
            list113_1.DefinitionRef = list113_1_DefinitionRef;
            list113.Add(list113_2);
            list113_2.DefinitionRef = list113_2_DefinitionRef;
            typeof(Container).GetProperty("Childs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, list113);
            /* Act */
            IList<Container> actualResult = (IList<Container>)typeof(Container).GetMethod("GetChildsByDefName", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(Int32)}, null).Invoke(_target, new object[]{defName, sortOption});
            /* Assert */
            Object actualResult_0_17 = ((IList<Container>)actualResult)[0];
            Object actualResult_0_17_definitionref_28 = typeof(Container).GetProperty("DefinitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_17);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup0", (String)actualResult_0_17_definitionref_28);
        }
    }

    [TestMethod]
    public void GetChildsByDefNameTest_112_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string94 = "PortGroup0";
            String defName = string94;
            Int32 int32105 = 1;
            Int32 sortOption = int32105;
            List<Container> list116 = new List<Container>();
            Container list116_0 = new Container();
            String list116_0_DefinitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup2";
            Container list116_1 = new Container();
            String list116_1_DefinitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup0";
            Container list116_2 = new Container();
            String list116_2_DefinitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup1";
            list116.Add(list116_0);
            list116_0.DefinitionRef = list116_0_DefinitionRef;
            list116.Add(list116_1);
            list116_1.DefinitionRef = list116_1_DefinitionRef;
            list116.Add(list116_2);
            list116_2.DefinitionRef = list116_2_DefinitionRef;
            typeof(Container).GetProperty("Childs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, list116);
            /* Act */
            IList<Container> actualResult = (IList<Container>)typeof(Container).GetMethod("GetChildsByDefName", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(Int32)}, null).Invoke(_target, new object[]{defName, sortOption});
            /* Assert */
            Object actualResult_0_19 = ((IList<Container>)actualResult)[0];
            Object actualResult_0_19_definitionref_210 = typeof(Container).GetProperty("DefinitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_19);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup0", (String)actualResult_0_19_definitionref_210);
        }
    }
}