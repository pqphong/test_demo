using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;
using Renesas.Generator.MCALConfGen.Data.CDFData;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;
using Renesas.Generator.MCALConfGen.Data.IntermediateData.Items;
using static Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory.ObjectFactory;

public partial class TestRepositoryLinQ
{
    [TestMethod]
    public void GetVersionInformationTest_1_1()
    {
        using (ShimsContext.Create())
        {
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetVersionInformationStringString = (instance, name, modulename) =>
            {
                if (name == "AR-RELEASE-VERSION")
                    return "4.2.2";
                if (name == "SW-VERSION")
                    return "1.2.10";
                if (name == "VENDOR-ID")
                    return "59";
                if (name == "MODULE-ID")
                    return "82";
                else
                    return "";
            };

            

            var cdfdata1370 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata1370.GetBswConfigurationString = (String _moduleName) =>
            {
                BswConfig config = new BswConfig();
                config.SwVersion = "1.2.10";
                config.VendorId = "59";
                config.ArReleaseVersion = "4.2.2";
                config.ModuleId = "82";
                return config;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata1370);

            Renesas.Generator.MCALConfGen.CrossCutting.ObjectFactory.Fakes.ShimObjectFactory.getCacheObjectsOfInterfaceType = (type) =>
            {
                var basicConfiguration = new BasicConfigurationClassTest();
                if (type == typeof(IBasicConfiguration))
                {
                    return new List<CacheObject>()
                    {
                        new CacheObject(typeof(IBasicConfiguration), basicConfiguration),
                    };
                }
                else
                {
                    return new List<CacheObject>();
                }
            };

            /* Act */
            BaseIntermediateItem actualResult = (BaseIntermediateItem)typeof(RepositoryLinQ).GetMethod("GetVersionInformation", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual(actualResult.Childs.Count, 4);
            Assert.IsTrue(actualResult.Childs[0].Name.Contains("VERSION_INFORMATION_CFG"));
            Assert.IsTrue(actualResult.Childs[1].Name.Contains("VERSION_INFORMATION_CBK"));
            Assert.IsTrue(actualResult.Childs[2].Name.Contains("VERSION_INFORMATION_PBCFG"));
            Assert.IsTrue(actualResult.Childs[3].Name.Contains("VERSION_INFORMATION_LT"));
        }
    }

    [TestMethod]
    public void GetVersionInformationTest_1_2()
    {
        using (ShimsContext.Create())
        {
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetVersionInformationStringString = (instance, name, modulename) =>
            {
                if (name == "AR-RELEASE-VERSION")
                    return "4.2.2";
                if (name == "SW-VERSION")
                    return "1.2.10";
                if (name == "VENDOR-ID")
                    return "59";
                if (name == "MODULE-ID")
                    return "82";
                else
                    return "";
            };

            var cdfdata1370 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata1370.GetBswConfigurationString = (String _moduleName) =>
            {

                BswConfig config = new BswConfig();
                config.SwVersion = "1.2.10";
                config.VendorId = "59";
                config.ArReleaseVersion = "4.2.2";
                config.ModuleId = "82";
                config.VendorApiInfix = "1";
                return config;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata1370);

            IBasicConfiguration basicConfiguration = ObjectFactory.GetInstance<IBasicConfiguration>();
            basicConfiguration.ModuleName = "Can";
            /* Act */
            /* Assert */
            BaseIntermediateItem actualResult = (BaseIntermediateItem)typeof(RepositoryLinQ).GetMethod("GetVersionInformation", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { }, null).Invoke(_target, new object[] { });
            /* Assert */
            Assert.AreEqual(actualResult.Childs.Count, 4);
            Assert.IsTrue(actualResult.Childs[0].Name.Contains("VERSION_INFORMATION_CFG"));
            Assert.IsTrue(actualResult.Childs[1].Name.Contains("VERSION_INFORMATION_CBK"));
            Assert.IsTrue(actualResult.Childs[2].Name.Contains("VERSION_INFORMATION_PBCFG"));
            Assert.IsTrue(actualResult.Childs[3].Name.Contains("VERSION_INFORMATION_LT"));
        }
    }

}

public class BasicConfigurationClassTest : IBasicConfiguration
{
    public bool MultiInstanceWithInfix { get; set; } = false;
    public int NumberOfInstances { get; set; } = 0;
    public string VendorApiInfix { get; set; } = "";
    public string ModuleName { get => "Can"; set => value = "Can"; }
    public string MicroFamilyName { get => "U2x"; set => value = "U2x"; }
    public string AutoSARVersion { get => "4.2.2"; set => value = "4.2.2"; }
    public List<string> DeviceNames { get => new List<string>() { "R707401" }; set => value = new List<string>() { "R707401" }; }
    public string ExeDirectory { get => "U:\\"; set => value = "U:\\"; }
    public int ModuleId { get => 82; set => value = 82; }
    public string OutputFolder { get => "output"; set => value = "output"; }
    public string ExecutionName { get => "MCALConfGen.exe"; set => value = "MCALConfGen.exe"; }
    public List<string> ModuleRequired { get => new List<string>() { "CAN", "MCU" }; set => value = new List<string>() { "CAN", "MCU" }; }
    public string ProjectTitle { get => "MCALConfGen"; set => value = "MCALConfGen"; }

    
    public bool HasInstanceSetting { get; set; }
    public int InstanceIndex { get; set; }
    public InstanceOutputType InstanceOutType { get; set; } = InstanceOutputType.DEFAULT;
    public int VendorId { get; set; }
    public string ExecutionVersion { get; set; }
    public string DeviceVariant { get; set; }

    public string AppendInstanceToFileName(string fileName)
    {
        return "";
    }

    public string AppendInstanceToMacro(string macro, AppendType type = AppendType.FULL_UPPER)
    {
        return "";
    }

    public string ToInstanceValue(AppendType type = AppendType.FULL_UPPER)
    {
        return "";
    }
}