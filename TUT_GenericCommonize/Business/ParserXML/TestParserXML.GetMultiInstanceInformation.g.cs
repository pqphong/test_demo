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

public partial class TestParserXML
{
    [TestMethod]
    public void GetMultiInstanceInformationTest_186_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            var cdfdata13 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata13.GetAllInstanceConfigurationsString = (String moduleName) =>
            {
                IList<Configuration> ilist91 = new List<Configuration>();
                Configuration ilist91_0 = new Configuration();
                Configuration ilist91_2 = new Configuration();
                ilist91.Add(ilist91_0);
                ilist91.Add(ilist91_2);
                return ilist91;
            }

            ;
            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata13);
            /* Act */
            typeof(ParserXML).GetMethod("GetMultiInstanceInformation", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Object basicconfiguration14 = typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object basicconfiguration14_numberofinstances_15 = typeof(IBasicConfiguration).GetProperty("NumberOfInstances", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(basicconfiguration14);
            Assert.AreEqual((Int32)2, (Int32)basicconfiguration14_numberofinstances_15);
            Object basicconfiguration14_instanceouttype_16 = typeof(IBasicConfiguration).GetProperty("InstanceOutType", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(basicconfiguration14);
            Assert.AreEqual((InstanceOutputType)InstanceOutputType.FILES, (InstanceOutputType)basicconfiguration14_instanceouttype_16);
            Object basicconfiguration14_hasinstancesetting_17 = typeof(IBasicConfiguration).GetProperty("HasInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(basicconfiguration14);
            Assert.AreEqual((Boolean)true, (Boolean)basicconfiguration14_hasinstancesetting_17);
        }
    }

    [TestMethod]
    public void GetMultiInstanceInformationTest_186_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            var cdfdata18 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata18.GetAllInstanceConfigurationsString = (String moduleName) =>
            {
                IList<Configuration> ilist92 = new List<Configuration>();
                Configuration ilist92_0 = new Configuration();
                ilist92.Add(ilist92_0);
                return ilist92;
            }

            ;
            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata18);
            /* Act */
            typeof(ParserXML).GetMethod("GetMultiInstanceInformation", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Object basicconfiguration19 = typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object basicconfiguration19_numberofinstances_110 = typeof(IBasicConfiguration).GetProperty("NumberOfInstances", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(basicconfiguration19);
            Assert.AreEqual((Int32)1, (Int32)basicconfiguration19_numberofinstances_110);
            Object basicconfiguration19_instanceouttype_111 = typeof(IBasicConfiguration).GetProperty("InstanceOutType", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(basicconfiguration19);
            Assert.AreEqual((InstanceOutputType)InstanceOutputType.DEFAULT, (InstanceOutputType)basicconfiguration19_instanceouttype_111);
            Object basicconfiguration19_hasinstancesetting_112 = typeof(IBasicConfiguration).GetProperty("HasInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(basicconfiguration19);
            Assert.AreEqual((Boolean)false, (Boolean)basicconfiguration19_hasinstancesetting_112);
        }
    }
}