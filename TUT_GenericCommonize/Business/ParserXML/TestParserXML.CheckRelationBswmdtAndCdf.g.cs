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
    public void CheckRelationBswmdtAndCdfTest_27_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            BswConfig ilist91_0 = new BswConfig();
            String ilist91_0_VendorSpecificModuleDefRef = "Renesas/Mcu";
            ilist91_0.VendorSpecificModuleDefRef = ilist91_0_VendorSpecificModuleDefRef;
            Int32 int32102 = 0;
            Int32 code = int32102;
            var userinterface125 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface125.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                code = errorCode;
            }

            ;
            userinterface125.Exit = () =>
            {
                return;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface125);
            var cdfdata126 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata126.GetAllInstanceConfigurationsString = (String moduleName) =>
            {
                Configuration[] configuration124 = new Configuration[1];
                Configuration configuration124_0 = new Configuration();
                String configuration124_0_DefinitionRef = "Renesas/Mcu";
                configuration124[0] = configuration124_0;
                configuration124_0.DefinitionRef = configuration124_0_DefinitionRef;
                return configuration124;
            }

            ;
            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata126);
            String string146 = "Mcu";
            Object basicconfiguration127 = typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IBasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(basicconfiguration127, string146);
            /* Act */
            typeof(ParserXML).GetMethod("CheckRelationBswmdtAndCdf", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(BswConfig)}, null).Invoke(_target, new object[]{ ilist91_0 });
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)code);
        }
    }

    [TestMethod]
    public void CheckRelationBswmdtAndCdfTest_27_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            BswConfig ilist97_0 = new BswConfig();
            String ilist97_0_VendorSpecificModuleDefRef = "Renesas/Mcu";
            ilist97_0.VendorSpecificModuleDefRef = ilist97_0_VendorSpecificModuleDefRef;
            Int32 int32108 = 0;
            Int32 code = int32108;
            var userinterface128 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface128.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                code = errorCode;
            }

            ;
            userinterface128.Exit = () =>
            {
                return;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface128);
            var cdfdata129 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata129.GetAllInstanceConfigurationsString = (String moduleName) =>
            {
                Configuration[] configuration1210 = new Configuration[1];
                Configuration configuration1210_0 = new Configuration();
                String configuration1210_0_DefinitionRef = "Autosar/Mcu";
                configuration1210[0] = configuration1210_0;
                configuration1210_0.DefinitionRef = configuration1210_0_DefinitionRef;
                return configuration1210;
            }

            ;
            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata129);
            String string1412 = "Mcu";
            Object basicconfiguration130 = typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IBasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(basicconfiguration130, string1412);
            /* Act */
            typeof(ParserXML).GetMethod("CheckRelationBswmdtAndCdf", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(BswConfig)}, null).Invoke(_target, new object[]{ ilist97_0 });
            /* Assert */
            Assert.AreEqual((Int32)48, (Int32)code);
        }
    }

    [TestMethod]
    public void CheckRelationBswmdtAndCdfTest_27_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            BswConfig ilist913_0 = new BswConfig();
            String ilist913_0_VendorSpecificModuleDefRef = "Renesas/Mcu";
            ilist913_0.VendorSpecificModuleDefRef = ilist913_0_VendorSpecificModuleDefRef;
            Int32 int321014 = 0;
            Int32 code = int321014;
            var userinterface131 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface131.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                code = errorCode;
            }

            ;
            userinterface131.Exit = () =>
            {
                return;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface131);
            var cdfdata132 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata132.GetAllInstanceConfigurationsString = (String moduleName) =>
            {
                Configuration[] configuration1216 = new Configuration[1];
                return configuration1216;
            }

            ;
            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata132);
            String string1418 = "Mcu";
            Object basicconfiguration133 = typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IBasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(basicconfiguration133, string1418);
            /* Act */
            typeof(ParserXML).GetMethod("CheckRelationBswmdtAndCdf", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(BswConfig)}, null).Invoke(_target, new object[]{ ilist913_0 });
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)code);
        }
    }

    [TestMethod]
    public void CheckRelationBswmdtAndCdfTest_27_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            BswConfig ilist919_0 = new BswConfig();
            String ilist919_0_VendorSpecificModuleDefRef = "";
            ilist919_0.VendorSpecificModuleDefRef = ilist919_0_VendorSpecificModuleDefRef;
            Int32 int321020 = 0;
            Int32 code = int321020;
            var userinterface134 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface134.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                code = errorCode;
            }

            ;
            userinterface134.Exit = () =>
            {
                return;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface134);
            var cdfdata135 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata135.GetAllInstanceConfigurationsString = (String moduleName) =>
            {
                Configuration[] configuration1222 = new Configuration[0];
                return configuration1222;
            }

            ;
            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata135);
            String string1424 = "Mcu";
            Object basicconfiguration136 = typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            typeof(IBasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(basicconfiguration136, string1424);
            /* Act */
            typeof(ParserXML).GetMethod("CheckRelationBswmdtAndCdf", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(BswConfig)}, null).Invoke(_target, new object[]{ ilist919_0 });
            /* Assert */
            Assert.AreEqual((Int32)49, (Int32)code);
        }
    }
}