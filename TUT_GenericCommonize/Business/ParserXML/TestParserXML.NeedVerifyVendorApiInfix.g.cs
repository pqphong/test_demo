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
    public void NeedVerifyVendorApiInfixTest_188_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            BswConfig bswconfig91 = new BswConfig();
            String bswconfig91_ImplementRootPath = "path1";
            bswconfig91.ImplementRootPath = bswconfig91_ImplementRootPath;
            BswConfig bswNode = bswconfig91;
            IBasicConfiguration ibasicconfiguration102 = BasicConfiguration.Instance;
            Boolean ibasicconfiguration102_HasInstanceSetting = true;
            ibasicconfiguration102.HasInstanceSetting = ibasicconfiguration102_HasInstanceSetting;
            typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration102);
            var cdfdata113 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata113.GetAllInstanceConfigurationsString = (String moduleName) =>
            {
                IList<Configuration> ilist113 = new List<Configuration>();
                Configuration ilist113_0 = new Configuration();
                String ilist113_0_ModuleDescriptionRef = "path1";
                ilist113.Add(ilist113_0);
                ilist113_0.ModuleDescriptionRef = ilist113_0_ModuleDescriptionRef;
                return ilist113;
            }

            ;
            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata113);
            /* Act */
            Boolean actualResult = (Boolean)typeof(ParserXML).GetMethod("needVerifyVendorApiInfix", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(BswConfig) }, null).Invoke(_target, new object[] { bswNode });
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void NeedVerifyVendorApiInfixTest_188_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            BswConfig bswconfig94 = new BswConfig();
            String bswconfig94_ImplementRootPath = "path1";
            bswconfig94.ImplementRootPath = bswconfig94_ImplementRootPath;
            BswConfig bswNode = bswconfig94;
            IBasicConfiguration ibasicconfiguration105 = BasicConfiguration.Instance;
            Boolean ibasicconfiguration105_HasInstanceSetting = true;
            ibasicconfiguration105.HasInstanceSetting = ibasicconfiguration105_HasInstanceSetting;
            typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration105);
            var cdfdata114 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata114.GetAllInstanceConfigurationsString = (String moduleName) =>
            {
                IList<Configuration> ilist116 = new List<Configuration>();
                Configuration ilist116_0 = new Configuration();
                String ilist116_0_ModuleDescriptionRef = "path2";
                ilist116.Add(ilist116_0);
                ilist116_0.ModuleDescriptionRef = ilist116_0_ModuleDescriptionRef;
                return ilist116;
            }

            ;
            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata114);
            /* Act */
            Boolean actualResult = (Boolean)typeof(ParserXML).GetMethod("needVerifyVendorApiInfix", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(BswConfig) }, null).Invoke(_target, new object[] { bswNode });
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void NeedVerifyVendorApiInfixTest_188_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            BswConfig bswconfig97 = new BswConfig();
            String bswconfig97_ImplementRootPath = "path1";
            bswconfig97.ImplementRootPath = bswconfig97_ImplementRootPath;
            BswConfig bswNode = bswconfig97;
            IBasicConfiguration ibasicconfiguration108 = BasicConfiguration.Instance;
            Boolean ibasicconfiguration108_HasInstanceSetting = false;
            ibasicconfiguration108.HasInstanceSetting = ibasicconfiguration108_HasInstanceSetting;
            typeof(ParserXML).GetField("BasicConfiguration", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, ibasicconfiguration108);
            var cdfdata115 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata115.GetAllInstanceConfigurationsString = (String moduleName) =>
            {
                IList<Configuration> ilist119 = new List<Configuration>();
                Configuration ilist119_0 = new Configuration();
                String ilist119_0_ModuleDescriptionRef = "path2";
                ilist119.Add(ilist119_0);
                ilist119_0.ModuleDescriptionRef = ilist119_0_ModuleDescriptionRef;
                return ilist119;
            }

            ;
            typeof(ParserXML).GetField("CdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata115);
            /* Act */
            Boolean actualResult = (Boolean)typeof(ParserXML).GetMethod("needVerifyVendorApiInfix", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(BswConfig) }, null).Invoke(_target, new object[] { bswNode });
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }
}