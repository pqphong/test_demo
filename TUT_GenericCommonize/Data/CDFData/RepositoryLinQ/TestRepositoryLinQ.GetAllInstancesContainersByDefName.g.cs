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
    public void GetAllInstancesContainersByDefNameTest_16_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "lin";
            String moduleName = string91;
            String string102 = "General0";
            String defName = string102;
            Int32 int32113 = 0;
            Int32 sortOption = int32113;
            string variantID = "";
            var cdfdata16 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata16.GetAllInstanceContainersString = (String _moduleName) =>
            {
                Dictionary<String, IList<Container>> dictionary124 = new Dictionary<String, IList<Container>>();
                IList<Container> dictionary124_lin = new List<Container>();
                Container dictionary124_lin_0 = new Container();
                String dictionary124_lin_0_ShortName = "General0";
                String dictionary124_lin_0_DefinitionRef = "Renesas/Autosar/General";
                Container dictionary124_lin_1 = new Container();
                String dictionary124_lin_1_ShortName = "linConfig0";
                String dictionary124_lin_1_DefinitionRef = "Renesas/Autosar/linConfigSet";
                dictionary124["lin"] = dictionary124_lin;
                dictionary124_lin.Add(dictionary124_lin_0);
                dictionary124_lin_0.ShortName = dictionary124_lin_0_ShortName;
                dictionary124_lin_0.DefinitionRef = dictionary124_lin_0_DefinitionRef;
                dictionary124_lin.Add(dictionary124_lin_1);
                dictionary124_lin_1.ShortName = dictionary124_lin_1_ShortName;
                dictionary124_lin_1.DefinitionRef = dictionary124_lin_1_DefinitionRef;
                return dictionary124;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata16);
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.getContainersByDefNameIListOfContainerStringInt32String = (RepositoryLinQ instance, IList<Container> containers, String _defName, Int32 _sortOption, String _variantID) =>
            {
                IList<Container> ilist135 = new List<Container>();
                Container ilist135_0 = new Container();
                String ilist135_0_ShortName = "General0";
                String ilist135_0_DefinitionRef = "Renesas/Autosar/General";
                ilist135.Add(ilist135_0);
                ilist135_0.ShortName = ilist135_0_ShortName;
                ilist135_0.DefinitionRef = ilist135_0_DefinitionRef;
                return ilist135;
            }

            ;
            /* Act */
            Dictionary<String, IList<Container>> actualResult = (Dictionary<String, IList<Container>>)typeof(RepositoryLinQ).GetMethod("GetAllInstancesContainersByDefName", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String), typeof(Int32), typeof(String)}, null).Invoke(_target, new object[]{moduleName, defName, sortOption, variantID});
            /* Assert */
            Object actualResult_lin_17 = ((Dictionary<String, IList<Container>>)actualResult)["lin"];
            Object actualResult_lin_17_0_28 = ((IList<Container>)actualResult_lin_17)[0];
            Object actualResult_lin_17_0_28_shortname_39 = typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_lin_17_0_28);
            Assert.AreEqual((String)"General0", (String)actualResult_lin_17_0_28_shortname_39);
            Object actualResult_lin_110 = ((Dictionary<String, IList<Container>>)actualResult)["lin"];
            Object actualResult_lin_110_0_211 = ((IList<Container>)actualResult_lin_110)[0];
            Object actualResult_lin_110_0_211_definitionref_312 = typeof(Container).GetProperty("DefinitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_lin_110_0_211);
            Assert.AreEqual((String)"Renesas/Autosar/General", (String)actualResult_lin_110_0_211_definitionref_312);
        }
    }
}