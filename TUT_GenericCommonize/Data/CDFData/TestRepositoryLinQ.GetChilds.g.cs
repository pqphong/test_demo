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
    public void GetChildsTest_5_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String moduleName = null;
            String shortName = null;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetContainerStringString = (RepositoryLinQ instance, String _moduleName, String _shortName) =>
            {
                Container container1138 = new Container();
                String container1138_Uuid = "f35faedc-bb22-4614-8a30-4654716b411c";
                String container1138_ShortName = "CanConfigSet0";
                String container1138_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet";
                List<Container> container1138_Childs = new List<Container>();
                Container container1138_Childs_0 = new Container();
                String container1138_Childs_0_Uuid = "bd356bd4-1f77-4fec-a267-1abe0c62b0bb";
                String container1138_Childs_0_ShortName = "CanController0";
                String container1138_Childs_0_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController";
                container1138.Uuid = container1138_Uuid;
                container1138.ShortName = container1138_ShortName;
                container1138.DefinitionRef = container1138_DefinitionRef;
                container1138.Childs = container1138_Childs;
                container1138_Childs.Add(container1138_Childs_0);
                container1138_Childs_0.Uuid = container1138_Childs_0_Uuid;
                container1138_Childs_0.ShortName = container1138_Childs_0_ShortName;
                container1138_Childs_0.DefinitionRef = container1138_Childs_0_DefinitionRef;
                return container1138;
            }

            ;
            /* Act */
            IList<Container> actualResult = (IList<Container>)typeof(RepositoryLinQ).GetMethod("GetChilds", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{moduleName, shortName});
            /* Assert */
            Object actualResult_count_1408 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)1, (Int32)actualResult_count_1408);
        }
    }

    [TestMethod]
    public void GetChildsTest_5_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String moduleName = null;
            String shortName = null;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetContainerStringString = (RepositoryLinQ instance, String _moduleName, String _shortName) =>
            {
                Container container1141 = new Container();
                String container1141_Uuid = "f35faedc-bb22-4614-8a30-4654716b411c";
                String container1141_ShortName = "CanConfigSet0";
                String container1141_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet";
                container1141.Uuid = container1141_Uuid;
                container1141.ShortName = container1141_ShortName;
                container1141.DefinitionRef = container1141_DefinitionRef;
                return container1141;
            }

            ;
            /* Act */
            IList<Container> actualResult = (IList<Container>)typeof(RepositoryLinQ).GetMethod("GetChilds", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{moduleName, shortName});
            /* Assert */
            Object actualResult_count_1409 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_count_1409);
        }
    }

    [TestMethod]
    public void GetChildsTest_5_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String moduleName = null;
            String shortName = null;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetContainerStringString = (RepositoryLinQ instance, String _moduleName, String _shortName) =>
            {
                Container container1144 = new Container();
                String container1144_Uuid = "f35faedc-bb22-4614-8a30-4654716b411c";
                String container1144_ShortName = "CanConfigSet0";
                String container1144_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet";
                List<Container> container1144_Childs = new List<Container>();
                Container container1144_Childs_0 = new Container();
                String container1144_Childs_0_Uuid = "bd356bd4-1f77-4fec-a267-1abe0c62b0bb";
                String container1144_Childs_0_ShortName = "CanController0";
                String container1144_Childs_0_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController";
                List<Container> container1144_Childs_0_Childs = new List<Container>();
                Container container1144_Childs_0_Childs_0 = new Container();
                String container1144_Childs_0_Childs_0_Uuid = "a33b7622-e0ec-4d18-8f76-5dfdf8465cdc";
                String container1144_Childs_0_Childs_0_ShortName = "CanControllerBaudrateConfig0";
                String container1144_Childs_0_Childs_0_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanController/CanControllerBaudrateConfig";
                container1144.Uuid = container1144_Uuid;
                container1144.ShortName = container1144_ShortName;
                container1144.DefinitionRef = container1144_DefinitionRef;
                container1144.Childs = container1144_Childs;
                container1144_Childs.Add(container1144_Childs_0);
                container1144_Childs_0.Uuid = container1144_Childs_0_Uuid;
                container1144_Childs_0.ShortName = container1144_Childs_0_ShortName;
                container1144_Childs_0.DefinitionRef = container1144_Childs_0_DefinitionRef;
                container1144_Childs_0.Childs = container1144_Childs_0_Childs;
                container1144_Childs_0_Childs.Add(container1144_Childs_0_Childs_0);
                container1144_Childs_0_Childs_0.Uuid = container1144_Childs_0_Childs_0_Uuid;
                container1144_Childs_0_Childs_0.ShortName = container1144_Childs_0_Childs_0_ShortName;
                container1144_Childs_0_Childs_0.DefinitionRef = container1144_Childs_0_Childs_0_DefinitionRef;
                return container1144;
            }

            ;
            /* Act */
            IList<Container> actualResult = (IList<Container>)typeof(RepositoryLinQ).GetMethod("GetChilds", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{moduleName, shortName});
            /* Assert */
            Object actualResult_count_1410 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)2, (Int32)actualResult_count_1410);
        }
    }

    [TestMethod]
    public void GetChildsTest_5_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String moduleName = null;
            String shortName = null;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetContainerStringString = (RepositoryLinQ instance, String _moduleName, String _shortName) =>
            {
                Container container1147 = null;
                return container1147;
            }

            ;
            /* Act */
            IList<Container> actualResult = (IList<Container>)typeof(RepositoryLinQ).GetMethod("GetChilds", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{moduleName, shortName});
            /* Assert */
            Object actualResult_count_1411 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_count_1411);
        }
    }
}