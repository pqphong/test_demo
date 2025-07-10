using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Parser;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;

public partial class TestParserXML
{
    [TestMethod]
    public void ShouldFilterOutConfigurationTest_28_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Configuration configuration91 = null;
            Configuration config = configuration91;
            String string102 = "Lin";
            Object basicconfiguration116 = typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IBasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(basicconfiguration116, string102);
            /* Act */
            Boolean actualResult = (Boolean)typeof(ParserXML).GetMethod("ShouldFilterOutConfiguration", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(Configuration)}, null).Invoke(_target, new object[]{config});
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void ShouldFilterOutConfigurationTest_28_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Configuration configuration94 = new Configuration();
            String configuration94_DefinitionRef = "/Renesas/EcucDefs_Lin/Lin";
            configuration94.DefinitionRef = configuration94_DefinitionRef;
            Configuration config = configuration94;
            String string105 = "Lin";
            Object basicconfiguration117 = typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IBasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(basicconfiguration117, string105);
            IRuntimeConfiguration iruntimeconfiguration116 = RuntimeConfiguration.Instance;
            String iruntimeconfiguration116_VendorFilter = "Renesas";
            iruntimeconfiguration116.VendorFilter = iruntimeconfiguration116_VendorFilter;
            typeof(ParserXML).GetField("RuntimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, iruntimeconfiguration116);
            /* Act */
            Boolean actualResult = (Boolean)typeof(ParserXML).GetMethod("ShouldFilterOutConfiguration", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(Configuration)}, null).Invoke(_target, new object[]{config});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void ShouldFilterOutConfigurationTest_28_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Configuration configuration97 = new Configuration();
            String configuration97_DefinitionRef = "/AUTOSAR/EcucDefs/Dem";
            configuration97.DefinitionRef = configuration97_DefinitionRef;
            Configuration config = configuration97;
            String string108 = "Lin";
            Object basicconfiguration118 = typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IBasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(basicconfiguration118, string108);
            IRuntimeConfiguration iruntimeconfiguration119 = RuntimeConfiguration.Instance;
            List<String> iruntimeconfiguration119_StubsFilter = new List<String>();
            String iruntimeconfiguration119_StubsFilter_0 = "Dem";
            iruntimeconfiguration119.StubsFilter = iruntimeconfiguration119_StubsFilter;
            iruntimeconfiguration119_StubsFilter.Add(iruntimeconfiguration119_StubsFilter_0);
            typeof(ParserXML).GetField("RuntimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, iruntimeconfiguration119);
            /* Act */
            Boolean actualResult = (Boolean)typeof(ParserXML).GetMethod("ShouldFilterOutConfiguration", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(Configuration)}, null).Invoke(_target, new object[]{config});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void ShouldFilterOutConfigurationTest_28_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Configuration configuration910 = new Configuration();
            String configuration910_DefinitionRef = "/Renesas/EcucDefs_Lin/Lin";
            configuration910.DefinitionRef = configuration910_DefinitionRef;
            Configuration config = configuration910;
            String string1011 = "Lin";
            Object basicconfiguration119 = typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IBasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(basicconfiguration119, string1011);
            IRuntimeConfiguration iruntimeconfiguration1112 = RuntimeConfiguration.Instance;
            String iruntimeconfiguration1112_VendorFilter = "Bosch";
            iruntimeconfiguration1112.VendorFilter = iruntimeconfiguration1112_VendorFilter;
            typeof(ParserXML).GetField("RuntimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, iruntimeconfiguration1112);
            /* Act */
            Boolean actualResult = (Boolean)typeof(ParserXML).GetMethod("ShouldFilterOutConfiguration", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(Configuration)}, null).Invoke(_target, new object[]{config});
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void ShouldFilterOutConfigurationTest_28_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Configuration configuration913 = new Configuration();
            String configuration913_DefinitionRef = "/Renesas/EcucDefs_Mcu/Mcu";
            configuration913.DefinitionRef = configuration913_DefinitionRef;
            Configuration config = configuration913;
            String string1014 = "Lin";
            Object basicconfiguration120 = typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IBasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(basicconfiguration120, string1014);
            IRuntimeConfiguration iruntimeconfiguration1115 = RuntimeConfiguration.Instance;
            List<String> iruntimeconfiguration1115_StubsFilter = new List<String>();
            String iruntimeconfiguration1115_StubsFilter_0 = "Dem";
            iruntimeconfiguration1115.StubsFilter = iruntimeconfiguration1115_StubsFilter;
            iruntimeconfiguration1115_StubsFilter.Add(iruntimeconfiguration1115_StubsFilter_0);
            typeof(ParserXML).GetField("RuntimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, iruntimeconfiguration1115);
            /* Act */
            Boolean actualResult = (Boolean)typeof(ParserXML).GetMethod("ShouldFilterOutConfiguration", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(Configuration)}, null).Invoke(_target, new object[]{config});
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }
}