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

public partial class TestRepositoryLinQ
{
    [TestMethod]
    public void GetContainerByShortNamePathTest_13_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "Dem";
            String moduleName = string91;
            String string102 = "/ActiveEcuC/Dem/DemConfigSet/DemEventParameter";
            String path = string102;
            String variantID = "";
            var cdfdata17 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata17.GetAllInstanceContainersString = (String _moduleName) =>
            {
                Dictionary<String, IList<Container>> dictionary113 = new Dictionary<String, IList<Container>>();
                IList<Container> dictionary113_Dem = new List<Container>();
                Container dictionary113_Dem_0 = new Container();
                String dictionary113_Dem_0_Path = "/ActiveEcuC/Dem/DemConfigSet/DemEventParameter";
                Container dictionary113_Dem_1 = new Container();
                String dictionary113_Dem_1_Path = "/ActiveEcuC/Dem/DemConfigSet/DemEventParameter1";
                dictionary113["Dem"] = dictionary113_Dem;
                dictionary113_Dem.Add(dictionary113_Dem_0);
                dictionary113_Dem_0.Path = dictionary113_Dem_0_Path;
                dictionary113_Dem.Add(dictionary113_Dem_1);
                dictionary113_Dem_1.Path = dictionary113_Dem_1_Path;
                return dictionary113;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata17);
            /* Act */
            Container actualResult = (Container)typeof(RepositoryLinQ).GetMethod("GetContainerByShortNamePath", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String), typeof(String)}, null).Invoke(_target, new object[] { moduleName, path , variantID});
            /* Assert */
            Object actualResult_path_18 = typeof(Container).GetProperty("Path", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"/ActiveEcuC/Dem/DemConfigSet/DemEventParameter", (String)actualResult_path_18);
        }
    }

    [TestMethod]
    public void GetContainerByShortNamePathTest_13_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string94 = "Dem";
            String moduleName = string94;
            String string105 = "/ActiveEcuC/Dem/DemConfigSet/DemEventParameter2";
            String path = string105;
            String variantID = "";
            var cdfdata19 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata19.GetAllInstanceContainersString = (String _moduleName) =>
            {
                Dictionary<String, IList<Container>> dictionary116 = new Dictionary<String, IList<Container>>();
                IList<Container> dictionary116_Dem = new List<Container>();
                Container dictionary116_Dem_0 = new Container();
                String dictionary116_Dem_0_Path = "/ActiveEcuC/Dem/DemConfigSet/DemEventParameter";
                Container dictionary116_Dem_1 = new Container();
                String dictionary116_Dem_1_Path = "/ActiveEcuC/Dem/DemConfigSet/DemEventParameter1";
                dictionary116["Dem"] = dictionary116_Dem;
                dictionary116_Dem.Add(dictionary116_Dem_0);
                dictionary116_Dem_0.Path = dictionary116_Dem_0_Path;
                dictionary116_Dem.Add(dictionary116_Dem_1);
                dictionary116_Dem_1.Path = dictionary116_Dem_1_Path;
                return dictionary116;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata19);
            /* Act */
            Container actualResult = (Container)typeof(RepositoryLinQ).GetMethod("GetContainerByShortNamePath", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String), typeof(String) }, null).Invoke(_target, new object[] { moduleName, path, variantID});
            /* Assert */
            Assert.AreEqual((Container)null, (Container)actualResult);
        }
    }

    [TestMethod]
    public void GetContainerByShortNamePathTest_13_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "Dem";
            String moduleName = string91;
            String string102 = "/ActiveEcuC/Dem/DemConfigSet/DemEventParameter";
            String path = string102;
            String variantID = "0";
            var cdfdata17 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata17.GetAllInstanceContainersString = (String _moduleName) =>
            {
                Dictionary<String, IList<Container>> dictionary113 = new Dictionary<String, IList<Container>>();
                IList<Container> dictionary113_Dem = new List<Container>();
                Container dictionary113_Dem_0 = new Container();
                String dictionary113_Dem_0_Path = "/ActiveEcuC/Dem/DemConfigSet/DemEventParameter";
                Container dictionary113_Dem_1 = new Container();
                String dictionary113_Dem_1_Path = "/ActiveEcuC/Dem/DemConfigSet/DemEventParameter1";
                dictionary113["Dem"] = dictionary113_Dem;
                dictionary113_Dem.Add(dictionary113_Dem_0);
                dictionary113_Dem_0.Path = dictionary113_Dem_0_Path;
                dictionary113_Dem.Add(dictionary113_Dem_1);
                dictionary113_Dem_1.Path = dictionary113_Dem_1_Path;
                dictionary113_Dem_1.VariantID = "0";
                return dictionary113;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata17);
            /* Act */
            Container actualResult = (Container)typeof(RepositoryLinQ).GetMethod("GetContainerByShortNamePath", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String), typeof(String) }, null).Invoke(_target, new object[] { moduleName, path, variantID});
            /* Assert */
            Object actualResult_path_18 = typeof(Container).GetProperty("Path", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"/ActiveEcuC/Dem/DemConfigSet/DemEventParameter", (String)actualResult_path_18);
        }
    }

    [TestMethod]
    public void GetContainerByShortNamePathTest_13_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string94 = "Dem";
            String moduleName = string94;
            String string105 = "/ActiveEcuC/Dem/DemConfigSet/DemEventParameter1";
            String path = string105;
            String variantID = "1";
            var cdfdata19 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata19.GetAllInstanceContainersString = (String _moduleName) =>
            {
                Dictionary<String, IList<Container>> dictionary116 = new Dictionary<String, IList<Container>>();
                IList<Container> dictionary116_Dem = new List<Container>();
                Container dictionary116_Dem_0 = new Container();
                String dictionary116_Dem_0_Path = "/ActiveEcuC/Dem/DemConfigSet/DemEventParameter";
                Container dictionary116_Dem_1 = new Container();
                String dictionary116_Dem_1_Path = "/ActiveEcuC/Dem/DemConfigSet/DemEventParameter1";
                dictionary116["Dem"] = dictionary116_Dem;
                dictionary116_Dem.Add(dictionary116_Dem_0);
                dictionary116_Dem_0.Path = dictionary116_Dem_0_Path;
                dictionary116_Dem.Add(dictionary116_Dem_1);
                dictionary116_Dem_1.Path = dictionary116_Dem_1_Path;
                dictionary116_Dem_1.VariantID = "0";
                return dictionary116;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata19);
            /* Act */
            Container actualResult = (Container)typeof(RepositoryLinQ).GetMethod("GetContainerByShortNamePath", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(String), typeof(String) }, null).Invoke(_target, new object[] { moduleName, path, variantID });
            /* Assert */
            Assert.AreEqual((Container)null, (Container)actualResult);
        }
    }
}