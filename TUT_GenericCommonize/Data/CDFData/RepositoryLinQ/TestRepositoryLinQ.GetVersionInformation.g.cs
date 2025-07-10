using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.CDFData;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;

public partial class TestRepositoryLinQ
{
    [TestMethod]
    public void GetVersionInformation_Test_2_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string93 = "AR-RELEASE-VERSION";
            String name = string93;
            String string104 = "can";
            String moduleName = string104;
            var cdfdata1365 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata1365.GetBswConfigurationString = (String _moduleName) =>
            {
                BswConfig bswconfig115 = new BswConfig();
                String bswconfig115_ImplementUuid = "40665aa1-97e5-42a7-9d33-a3d85d9e5ab5";
                String bswconfig115_ImplementSortName = "Can_Impl";
                String bswconfig115_SwVersion = "1.4.3";
                String bswconfig115_VendorId = "59";
                String bswconfig115_ArReleaseVersion = "4.0.3";
                String bswconfig115_VendorApiInfix = "Renesas";
                String bswconfig115_ModuleId = "84";
                bswconfig115.ImplementUuid = bswconfig115_ImplementUuid;
                bswconfig115.ImplementSortName = bswconfig115_ImplementSortName;
                bswconfig115.SwVersion = bswconfig115_SwVersion;
                bswconfig115.VendorId = bswconfig115_VendorId;
                bswconfig115.ArReleaseVersion = bswconfig115_ArReleaseVersion;
                bswconfig115.VendorApiInfix = bswconfig115_VendorApiInfix;
                bswconfig115.ModuleId = bswconfig115_ModuleId;
                return bswconfig115;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata1365);
            /* Act */
            String actualResult = (String)typeof(RepositoryLinQ).GetMethod("GetVersionInformation", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{name, moduleName});
            /* Assert */
            Assert.AreEqual((String)"4.0.3", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetVersionInformation_Test_2_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string96 = "SW-VERSION";
            String name = string96;
            String string107 = "can";
            String moduleName = string107;
            var cdfdata1366 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata1366.GetBswConfigurationString = (String _moduleName) =>
            {
                BswConfig bswconfig118 = new BswConfig();
                String bswconfig118_ImplementUuid = "40665aa1-97e5-42a7-9d33-a3d85d9e5ab5";
                String bswconfig118_ImplementSortName = "Can_Impl";
                String bswconfig118_SwVersion = "1.4.3";
                String bswconfig118_VendorId = "59";
                String bswconfig118_ArReleaseVersion = "4.0.3";
                String bswconfig118_VendorApiInfix = "Renesas";
                String bswconfig118_ModuleId = "84";
                bswconfig118.ImplementUuid = bswconfig118_ImplementUuid;
                bswconfig118.ImplementSortName = bswconfig118_ImplementSortName;
                bswconfig118.SwVersion = bswconfig118_SwVersion;
                bswconfig118.VendorId = bswconfig118_VendorId;
                bswconfig118.ArReleaseVersion = bswconfig118_ArReleaseVersion;
                bswconfig118.VendorApiInfix = bswconfig118_VendorApiInfix;
                bswconfig118.ModuleId = bswconfig118_ModuleId;
                return bswconfig118;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata1366);
            /* Act */
            String actualResult = (String)typeof(RepositoryLinQ).GetMethod("GetVersionInformation", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{name, moduleName});
            /* Assert */
            Assert.AreEqual((String)"1.4.3", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetVersionInformation_Test_2_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string99 = "VENDOR-ID";
            String name = string99;
            String string1010 = "can";
            String moduleName = string1010;
            var cdfdata1367 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata1367.GetBswConfigurationString = (String _moduleName) =>
            {
                BswConfig bswconfig1111 = new BswConfig();
                String bswconfig1111_ImplementUuid = "40665aa1-97e5-42a7-9d33-a3d85d9e5ab5";
                String bswconfig1111_ImplementSortName = "Can_Impl";
                String bswconfig1111_SwVersion = "1.4.3";
                String bswconfig1111_VendorId = "59";
                String bswconfig1111_ArReleaseVersion = "4.0.3";
                String bswconfig1111_VendorApiInfix = "Renesas";
                String bswconfig1111_ModuleId = "84";
                bswconfig1111.ImplementUuid = bswconfig1111_ImplementUuid;
                bswconfig1111.ImplementSortName = bswconfig1111_ImplementSortName;
                bswconfig1111.SwVersion = bswconfig1111_SwVersion;
                bswconfig1111.VendorId = bswconfig1111_VendorId;
                bswconfig1111.ArReleaseVersion = bswconfig1111_ArReleaseVersion;
                bswconfig1111.VendorApiInfix = bswconfig1111_VendorApiInfix;
                bswconfig1111.ModuleId = bswconfig1111_ModuleId;
                return bswconfig1111;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata1367);
            /* Act */
            String actualResult = (String)typeof(RepositoryLinQ).GetMethod("GetVersionInformation", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{name, moduleName});
            /* Assert */
            Assert.AreEqual((String)"59", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetVersionInformation_Test_2_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string912 = "MODULE-ID";
            String name = string912;
            String string1013 = "can";
            String moduleName = string1013;
            var cdfdata1368 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata1368.GetBswConfigurationString = (String _moduleName) =>
            {
                BswConfig bswconfig1114 = new BswConfig();
                String bswconfig1114_ImplementUuid = "40665aa1-97e5-42a7-9d33-a3d85d9e5ab5";
                String bswconfig1114_ImplementSortName = "Can_Impl";
                String bswconfig1114_SwVersion = "1.4.3";
                String bswconfig1114_VendorId = "59";
                String bswconfig1114_ArReleaseVersion = "4.0.3";
                String bswconfig1114_VendorApiInfix = "Renesas";
                String bswconfig1114_ModuleId = "84";
                bswconfig1114.ImplementUuid = bswconfig1114_ImplementUuid;
                bswconfig1114.ImplementSortName = bswconfig1114_ImplementSortName;
                bswconfig1114.SwVersion = bswconfig1114_SwVersion;
                bswconfig1114.VendorId = bswconfig1114_VendorId;
                bswconfig1114.ArReleaseVersion = bswconfig1114_ArReleaseVersion;
                bswconfig1114.VendorApiInfix = bswconfig1114_VendorApiInfix;
                bswconfig1114.ModuleId = bswconfig1114_ModuleId;
                return bswconfig1114;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata1368);
            /* Act */
            String actualResult = (String)typeof(RepositoryLinQ).GetMethod("GetVersionInformation", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{name, moduleName});
            /* Assert */
            Assert.AreEqual((String)"84", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetVersionInformation_Test_2_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string915 = "VENDOR-API-INFIX";
            String name = string915;
            String string1016 = "can";
            String moduleName = string1016;
            var cdfdata1369 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata1369.GetBswConfigurationString = (String _moduleName) =>
            {
                BswConfig bswconfig1117 = new BswConfig();
                String bswconfig1117_ImplementUuid = "40665aa1-97e5-42a7-9d33-a3d85d9e5ab5";
                String bswconfig1117_ImplementSortName = "Can_Impl";
                String bswconfig1117_SwVersion = "1.4.3";
                String bswconfig1117_VendorId = "59";
                String bswconfig1117_ArReleaseVersion = "4.0.3";
                String bswconfig1117_VendorApiInfix = "Renesas";
                String bswconfig1117_ModuleId = "84";
                bswconfig1117.ImplementUuid = bswconfig1117_ImplementUuid;
                bswconfig1117.ImplementSortName = bswconfig1117_ImplementSortName;
                bswconfig1117.SwVersion = bswconfig1117_SwVersion;
                bswconfig1117.VendorId = bswconfig1117_VendorId;
                bswconfig1117.ArReleaseVersion = bswconfig1117_ArReleaseVersion;
                bswconfig1117.VendorApiInfix = bswconfig1117_VendorApiInfix;
                bswconfig1117.ModuleId = bswconfig1117_ModuleId;
                return bswconfig1117;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata1369);
            /* Act */
            String actualResult = (String)typeof(RepositoryLinQ).GetMethod("GetVersionInformation", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{name, moduleName});
            /* Assert */
            Assert.AreEqual((String)"Renesas", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetVersionInformation_Test_2_6()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String name = null;
            String moduleName = null;
            var cdfdata1370 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata1370.GetBswConfigurationString = (String _moduleName) =>
            {
                BswConfig bswconfig1120 = null;
                return bswconfig1120;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata1370);
            /* Act */
            String actualResult = (String)typeof(RepositoryLinQ).GetMethod("GetVersionInformation", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{name, moduleName});
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
        }
    }
}