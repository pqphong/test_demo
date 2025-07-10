using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.CommandLine;
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;

public partial class TestCommandLine
{
    [TestMethod]
    public void parseXmlConfigTest_48_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.FileExistsStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                Boolean boolean91 = true;
                return boolean91;
            }

            ;
            Int32 int32102 = 0;
            Int32 flag = int32102;
            var userinterface116 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface116.ErrorFileNotFoundString = (String fileName) =>
            {
                flag = 1;
                ;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface116);
            String string124 = "";
            String path = string124;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.LoadXMLStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                XDocument retDocument = new XDocument(new XElement("XML", new XElement("OPTION", new XElement("LOG", "ON"), new XElement("DRYRUN", "ON"), new XElement("OUTPUT", "ON"), new XElement("FILTER-NAME", "Renesas"), new XElement("STUBS", "Dem, EcuM"), new XElement("OUTPUT-PATH", "U:\\output_path")), new XElement("INPUT-FILE", "U:\\input_files\\file.arxml")));
                return retDocument;
                ;
            }

            ;
            List<string> initList = new List<string>();
            object iRuntimestub = new Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration.Fakes.StubIRuntimeConfiguration();
            typeof(IRuntimeConfiguration).GetProperty("StubsFilter", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(iRuntimestub,  initList );
            _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, iRuntimestub);
            /* Act */
            CommandLineInput actualResult = (CommandLineInput)_target.GetType().GetMethod("parseXmlConfig", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{path});
            /* Assert */
            Object actualResult_optionswithvalues_119 = actualResult.GetType().GetProperty("OptionsWithValues", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Object actualResult_optionswithvalues_119_l_220 = ((Dictionary<String, String>)actualResult_optionswithvalues_119)["-l"];
            Assert.AreEqual((String)"True", (String)actualResult_optionswithvalues_119_l_220);
            Object actualResult_optionswithvalues_121 = actualResult.GetType().GetProperty("OptionsWithValues", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Object actualResult_optionswithvalues_121_d_222 = ((Dictionary<String, String>)actualResult_optionswithvalues_121)["-d"];
            Assert.AreEqual((String)"True", (String)actualResult_optionswithvalues_121_d_222);
            Object runtimeconfiguration123 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object stubsfilter224 = typeof(IRuntimeConfiguration).GetProperty("StubsFilter", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(runtimeconfiguration123);
            Object stubsfilter224_count_125 = typeof(List<String>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(stubsfilter224);
            Assert.AreEqual((Int32)2, (Int32)stubsfilter224_count_125);
            Object stubsfilter224_0_126 = ((List<String>)stubsfilter224)[0];
            Assert.AreEqual((String)"Dem", (String)stubsfilter224_0_126);
            Object stubsfilter224_1_127 = ((List<String>)stubsfilter224)[1];
            Assert.AreEqual((String)"EcuM", (String)stubsfilter224_1_127);
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void parseXmlConfigTest_48_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.FileExistsStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                Boolean boolean96 = true;
                return boolean96;
            }

            ;
            Int32 int32107 = 0;
            Int32 flag = int32107;
            var userinterface128 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface128.ErrorFileNotFoundString = (String fileName) =>
            {
                flag = 1;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface128);
            String string129 = "";
            String path = string129;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.LoadXMLStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                XDocument retDocument = new XDocument(new XElement("XML", new XElement("OPTION", new XElement("HELP", "OFF"), new XElement("LOG", "OFF"), new XElement("DRYRUN", "OFF"), new XElement("OUTPUT", "OFF"), new XElement("FILTER-NAME", ""), new XElement("STUBS", ""), new XElement("OUTPUT-PATH", "")), new XElement("INPUT-FILE", "")));
                return retDocument;
                ;
            }

            ;
            List<string> initList = new List<string>();
            object iRuntimestub = new Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration.Fakes.StubIRuntimeConfiguration();
            typeof(IRuntimeConfiguration).GetProperty("StubsFilter", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(iRuntimestub, initList);
            _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, iRuntimestub);

            /* Act */
            CommandLineInput actualResult = (CommandLineInput)_target.GetType().GetMethod("parseXmlConfig", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{path});
            /* Assert */
            Object actualResult_optionswithvalues_129 = actualResult.GetType().GetProperty("OptionsWithValues", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Object actualResult_optionswithvalues_129_h_230 = ((Dictionary<String, String>)actualResult_optionswithvalues_129)["-h"];
            Assert.AreEqual((String)"False", (String)actualResult_optionswithvalues_129_h_230);
            Object actualResult_optionswithvalues_131 = actualResult.GetType().GetProperty("OptionsWithValues", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Object actualResult_optionswithvalues_131_l_232 = ((Dictionary<String, String>)actualResult_optionswithvalues_131)["-l"];
            Assert.AreEqual((String)"False", (String)actualResult_optionswithvalues_131_l_232);
            Object actualResult_optionswithvalues_133 = actualResult.GetType().GetProperty("OptionsWithValues", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Object actualResult_optionswithvalues_133_d_234 = ((Dictionary<String, String>)actualResult_optionswithvalues_133)["-d"];
            Assert.AreEqual((String)"False", (String)actualResult_optionswithvalues_133_d_234);
            Object runtimeconfiguration135 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object stubsfilter236 = typeof(IRuntimeConfiguration).GetProperty("StubsFilter", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(runtimeconfiguration135);
            Object stubsfilter236_count_137 = typeof(List<String>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(stubsfilter236);
            Assert.AreEqual((Int32)0, (Int32)stubsfilter236_count_137);
            Assert.AreEqual((Int32)0, (Int32)flag);
        }
    }

    [TestMethod]
    public void parseXmlConfigTest_48_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.FileExistsStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                Boolean boolean911 = false;
                return boolean911;
            }

            ;
            Int32 int321012 = 0;
            Int32 flag = int321012;
            var userinterface138 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface138.ErrorFileNotFoundString = (String fileName) =>
            {
                flag = 1;
            }

            ;
            _target.GetType().GetField("userInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface138);
            String string1214 = "";
            String path = string1214;
            Renesas.Generator.MCALConfGen.CrossCutting.DotNetApiWrapper.Fakes.ShimIOWrapper.LoadXMLStringNullableOfInt32 = (String file, Nullable<Int32> exitCode) =>
            {
                XDocument retDocument = new XDocument();
                return retDocument;
                ;
            }

            ;
            List<string> initList = new List<string>();
            object iRuntimestub = new Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration.Fakes.StubIRuntimeConfiguration();
            typeof(IRuntimeConfiguration).GetProperty("StubsFilter", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(iRuntimestub, initList);
            _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, iRuntimestub);
            /* Act */
            CommandLineInput actualResult = (CommandLineInput)_target.GetType().GetMethod("parseXmlConfig", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{path});
            /* Assert */
            Assert.AreEqual((CommandLineInput)null, (CommandLineInput)actualResult);
            Object runtimeconfiguration139 = _target.GetType().GetField("runtimeConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Object stubsfilter240 = typeof(IRuntimeConfiguration).GetProperty("StubsFilter", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(runtimeconfiguration139);
            Object stubsfilter240_count_141 = typeof(List<String>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(stubsfilter240);
            Assert.AreEqual((Int32)0, (Int32)stubsfilter240_count_141);
            Assert.AreEqual((Int32)1, (Int32)flag);
        }
    }
}