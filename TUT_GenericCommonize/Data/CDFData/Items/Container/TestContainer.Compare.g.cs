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

public partial class TestContainer
{
    [TestMethod]
    public void CompareTest_111_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Container container9294 = new Container();
            String container9294_DefinitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortFilterGroupConfig";
            String container9294_ShortName = "PortFilterGroupConfig";
            container9294.DefinitionRef = container9294_DefinitionRef;
            container9294.ShortName = container9294_ShortName;
            Container con1 = container9294;
            Container container10295 = new Container();
            String container10295_DefinitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortFilterGroupConfig";
            String container10295_ShortName = "PortFilterGroupConfig";
            container10295.DefinitionRef = container10295_DefinitionRef;
            container10295.ShortName = container10295_ShortName;
            Container con2 = container10295;
            /* Act */
            Int32 actualResult = (Int32)typeof(Container).GetMethod("Compare", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(Container), typeof(Container)}, null).Invoke(_target, new object[]{con1, con2});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)actualResult);
        }
    }

    [TestMethod]
    public void CompareTest_111_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Container container9296 = new Container();
            String container9296_DefinitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup";
            String container9296_ShortName = "PortFilterGroupConfig0";
            container9296.DefinitionRef = container9296_DefinitionRef;
            container9296.ShortName = container9296_ShortName;
            Container con1 = container9296;
            Container container10297 = new Container();
            String container10297_DefinitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortGroup";
            String container10297_ShortName = "PortFilterGroupConfig1";
            container10297.DefinitionRef = container10297_DefinitionRef;
            container10297.ShortName = container10297_ShortName;
            Container con2 = container10297;
            /* Act */
            Int32 actualResult = (Int32)typeof(Container).GetMethod("Compare", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(Container), typeof(Container)}, null).Invoke(_target, new object[]{con1, con2});
            /* Assert */
            Assert.AreEqual((Int32)(-1), (Int32)actualResult);
        }
    }
}