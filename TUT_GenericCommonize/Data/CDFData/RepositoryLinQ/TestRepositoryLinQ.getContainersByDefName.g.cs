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
    public void GetContainersByDefNameTest_18_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string994 = "Can";
            String moduleName = string994;
            String string1095 = "CanControllerPclkClockImmediateValue";
            String defName = string1095;
            Int32 int321196 = 0;
            Int32 sortOption = int321196;
            string variant = "";
            var cdfdata1440 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata1440.GetCurrentInstanceContainersString = (String _moduleName) =>
            {
                IList<Container> ilist1297 = new List<Container>();
                Container ilist1297_0 = new Container();
                String ilist1297_0_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanControllerPclkClockImmediateValue";
                ilist1297.Add(ilist1297_0);
                ilist1297_0.DefinitionRef = ilist1297_0_DefinitionRef;
                return ilist1297;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata1440);
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.getContainersByDefNameIListOfContainerStringInt32String = (RepositoryLinQ instance, IList<Container> containers, String _defName, Int32 _sortOption, String variantID) =>
            {
                IList<Container> ilist1398 = new List<Container>();
                Container ilist1398_0 = new Container();
                String ilist1398_0_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet/CanControllerPclkClockImmediateValue";
                ilist1398.Add(ilist1398_0);
                ilist1398_0.DefinitionRef = ilist1398_0_DefinitionRef;
                return ilist1398;
            }

            ;
            /* Act */
            IList<Container> actualResult = (IList<Container>)typeof(RepositoryLinQ).GetMethod("GetContainersByDefName", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String), typeof(Int32), typeof(String)}, null).Invoke(_target, new object[]{moduleName, defName, sortOption, variant });
            /* Assert */
            Object actualResult_count_1441 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)1, (Int32)actualResult_count_1441);
            Object actualResult_0_1442 = ((IList<Container>)actualResult)[0];
            Object actualResult_0_1442_definitionref_2443 = typeof(Container).GetProperty("DefinitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_0_1442);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Can/Can/CanConfigSet/CanControllerPclkClockImmediateValue", (String)actualResult_0_1442_definitionref_2443);
        }
    }
}