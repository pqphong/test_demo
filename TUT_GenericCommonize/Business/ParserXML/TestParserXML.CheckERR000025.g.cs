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
    public void CheckERR000025Test_29_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int3291 = 0;
            Int32 code = int3291;
            List<BswConfig> list102 = new List<BswConfig>();
            BswConfig list102_0 = new BswConfig();
            String list102_0_ImplementRootPath = "path1";
            BswConfig list102_2 = new BswConfig();
            String list102_2_ImplementRootPath = "path2";
            list102.Add(list102_0);
            list102_0.ImplementRootPath = list102_0_ImplementRootPath;
            list102.Add(list102_2);
            list102_2.ImplementRootPath = list102_2_ImplementRootPath;
            List<BswConfig> bswConfigs = list102;
            IBasicConfiguration ibasicconfiguration113 = BasicConfiguration.Instance;
            var cdfdata119 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata119.GetAllInstanceConfigurationsString = (String moduleName) =>
            {
                IList<Configuration> ilist124 = new List<Configuration>();
                Configuration ilist124_0 = new Configuration();
                String ilist124_0_ModuleDescriptionRef = "path1";
                Configuration ilist124_1 = new Configuration();
                String ilist124_1_ModuleDescriptionRef = "path2";
                ilist124.Add(ilist124_0);
                ilist124_0.ModuleDescriptionRef = ilist124_0_ModuleDescriptionRef;
                ilist124.Add(ilist124_1);
                ilist124_1.ModuleDescriptionRef = ilist124_1_ModuleDescriptionRef;
                return ilist124;
            }

            ;
            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata119);
            var userinterface120 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface120.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                code = errorCode;
            }

            ;
            userinterface120.Exit = () =>
            {
                return;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface120);
            /* Act */
            typeof(ParserXML).GetMethod("CheckERR000025", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(List<BswConfig>) }, null).Invoke(_target, new object[] { bswConfigs });
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)code);
        }
    }

    [TestMethod]
    public void CheckERR000025Test_29_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int3297 = 0;
            Int32 code = int3297;
            List<BswConfig> list108 = new List<BswConfig>();
            BswConfig list108_0 = new BswConfig();
            String list108_0_ImplementRootPath = "path1";
            list108.Add(list108_0);
            list108_0.ImplementRootPath = list108_0_ImplementRootPath;
            List<BswConfig> bswConfigs = list108;
            IBasicConfiguration ibasicconfiguration119 = BasicConfiguration.Instance;
            var cdfdata121 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata121.GetAllInstanceConfigurationsString = (String moduleName) =>
            {
                IList<Configuration> ilist1210 = new List<Configuration>();
                Configuration ilist1210_0 = new Configuration();
                String ilist1210_0_ModuleDescriptionRef = "path1";
                Configuration ilist1210_1 = new Configuration();
                String ilist1210_1_ModuleDescriptionRef = "path1";
                ilist1210.Add(ilist1210_0);
                ilist1210_0.ModuleDescriptionRef = ilist1210_0_ModuleDescriptionRef;
                ilist1210.Add(ilist1210_1);
                ilist1210_1.ModuleDescriptionRef = ilist1210_1_ModuleDescriptionRef;
                return ilist1210;
            }

            ;
            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata121);
            var userinterface122 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface122.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                code = errorCode;
            }

            ;
            userinterface122.Exit = () =>
            {
                return;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface122);
            /* Act */
            typeof(ParserXML).GetMethod("CheckERR000025", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(List<BswConfig>) }, null).Invoke(_target, new object[] { bswConfigs });
            /* Assert */
            Assert.AreEqual((Int32)25, (Int32)code);
        }
    }

    [TestMethod]
    public void CheckERR000025Test_29_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int32913 = 0;
            Int32 code = int32913;
            List<BswConfig> list1014 = new List<BswConfig>();
            BswConfig list1014_0 = new BswConfig();
            String list1014_0_ImplementRootPath = "path1";
            list1014.Add(list1014_0);
            list1014_0.ImplementRootPath = list1014_0_ImplementRootPath;
            List<BswConfig> bswConfigs = list1014;
            IBasicConfiguration ibasicconfiguration1115 = BasicConfiguration.Instance;
            var cdfdata123 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata123.GetAllInstanceConfigurationsString = (String moduleName) =>
            {
                IList<Configuration> ilist1216 = new List<Configuration>();
                Configuration ilist1216_0 = new Configuration();
                String ilist1216_0_ModuleDescriptionRef = "path1";
                Configuration ilist1216_1 = new Configuration();
                String ilist1216_1_ModuleDescriptionRef = "path2";
                ilist1216.Add(ilist1216_0);
                ilist1216_0.ModuleDescriptionRef = ilist1216_0_ModuleDescriptionRef;
                ilist1216.Add(ilist1216_1);
                ilist1216_1.ModuleDescriptionRef = ilist1216_1_ModuleDescriptionRef;
                return ilist1216;
            }

            ;
            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata123);
            var userinterface124 = new Renesas.Generator.MCALConfGen.CrossCutting.UserInterface.Fakes.StubIUserInterface();
            userinterface124.ErrorInt32Int32StringObjectArray = (Int32 moduleId, Int32 errorCode, String message, Object[] parameters) =>
            {
                code = errorCode;
            }

            ;
            userinterface124.Exit = () =>
            {
                return;
            }

            ;
            typeof(ParserXML).GetField("UserInterface", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, userinterface124);
            /* Act */
            typeof(ParserXML).GetMethod("CheckERR000025", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(List<BswConfig>) }, null).Invoke(_target, new object[] { bswConfigs });
            /* Assert */
            Assert.AreEqual((Int32)25, (Int32)code);
        }
    }
}