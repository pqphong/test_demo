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
    public void ValidateBswConfigurationsGeneralTest_24_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            var cdfdata116 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata116.GetBswConfigurations = () =>
            {
                List<BswConfig> list91 = new List<BswConfig>();
                BswConfig list91_0 = new BswConfig();
                String list91_0_DescriptionShortName = "Lin";
                list91.Add(list91_0);
                list91_0.DescriptionShortName = list91_0_DescriptionShortName;
                return list91;
            }

            ;
            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata116);
            IBasicConfiguration ibasicconfiguration102 = BasicConfiguration.Instance;
            String ibasicconfiguration102_ModuleName = "Lin";
            ibasicconfiguration102.ModuleName = ibasicconfiguration102_ModuleName;
            typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration102);
            Int32 int32113 = 0;
            Int32 flag = int32113;
            var userinterface117 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface117.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            userinterface117.Exit = () =>
            {
                return;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface117);
            /* Act */
            typeof(ParserXML).GetMethod("ValidateBswConfigurationsGeneral", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void ValidateBswConfigurationsGeneralTest_24_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            var cdfdata118 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata118.GetBswConfigurations = () =>
            {
                List<BswConfig> list96 = new List<BswConfig>();
                BswConfig list96_0 = new BswConfig();
                String list96_0_DescriptionShortName = "Lin";
                list96.Add(list96_0);
                list96_0.DescriptionShortName = list96_0_DescriptionShortName;
                return list96;
            }

            ;
            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata118);
            IBasicConfiguration ibasicconfiguration107 = BasicConfiguration.Instance;
            String ibasicconfiguration107_ModuleName = "Can";
            ibasicconfiguration107.ModuleName = ibasicconfiguration107_ModuleName;
            typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration107);
            Int32 int32118 = 0;
            Int32 flag = int32118;
            var userinterface119 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface119.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            userinterface119.Exit = () =>
            {
                return;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface119);
            /* Act */
            typeof(ParserXML).GetMethod("ValidateBswConfigurationsGeneral", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Int32)36, (Int32)flag);
        }
    }

    [TestMethod]
    public void ValidateBswConfigurationsGeneralTest_24_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            var cdfdata120 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata120.GetBswConfigurations = () =>
            {
                List<BswConfig> list911 = new List<BswConfig>();
                BswConfig list911_0 = new BswConfig();
                String list911_0_DescriptionShortName = null;
                list911.Add(list911_0);
                list911_0.DescriptionShortName = list911_0_DescriptionShortName;
                return list911;
            }

            ;
            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata120);
            IBasicConfiguration ibasicconfiguration1012 = BasicConfiguration.Instance;
            String ibasicconfiguration1012_ModuleName = "Can";
            ibasicconfiguration1012.ModuleName = ibasicconfiguration1012_ModuleName;
            typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration1012);
            Int32 int321113 = 0;
            Int32 flag = int321113;
            var userinterface121 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface121.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                flag = errorCode;
                ;
            }

            ;
            userinterface121.Exit = () =>
            {
                return;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface121);
            /* Act */
            typeof(ParserXML).GetMethod("ValidateBswConfigurationsGeneral", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Int32)36, (Int32)flag);
        }
    }
}