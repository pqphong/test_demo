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
    public void GetContainersTest_28_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9121 = "can";
            String moduleName = string9121;
            var cdfdata1484 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata1484.GetCurrentInstanceContainersString = (String _moduleName) =>
            {
                IList<Container> ilist10122 = new List<Container>();
                Container ilist10122_0 = new Container();
                String ilist10122_0_Uuid = "f35faedc-bb22-4614-8a30-4654716b411c";
                String ilist10122_0_ShortName = "CanConfigSet0";
                String ilist10122_0_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet";
                String ilist10122_0_Path = "EcucDefs_Can/Can/CanConfigSet";
                IList<ItemValue> ilist10122_0_ParameterValues = new List<ItemValue>();
                ItemValue ilist10122_0_ParameterValues_0 = new ItemValue(null, null);
                String ilist10122_0_ParameterValues_0_definitionRef = "/CanControllerMaxReceiveBuffer";
                Object ilist10122_0_ParameterValues_0_value = "64";
                ilist10122.Add(ilist10122_0);
                ilist10122_0.Uuid = ilist10122_0_Uuid;
                ilist10122_0.ShortName = ilist10122_0_ShortName;
                ilist10122_0.DefinitionRef = ilist10122_0_DefinitionRef;
                ilist10122_0.Path = ilist10122_0_Path;
                ilist10122_0.ParameterValues = ilist10122_0_ParameterValues;
                ilist10122_0_ParameterValues.Add(ilist10122_0_ParameterValues_0);
                typeof(ItemValue).GetField("definitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist10122_0_ParameterValues_0, ilist10122_0_ParameterValues_0_definitionRef);
                typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(ilist10122_0_ParameterValues_0, ilist10122_0_ParameterValues_0_value);
                return ilist10122;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata1484);
            /* Act */
            IList<Container> actualResult = (IList<Container>)typeof(RepositoryLinQ).GetMethod("GetContainers", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Object actualResult_count_1485 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)1, (Int32)actualResult_count_1485);
        }
    }
}