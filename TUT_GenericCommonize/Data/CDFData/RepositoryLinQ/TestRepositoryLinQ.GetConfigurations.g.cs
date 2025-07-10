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
    public void GetConfigurationsTest_26_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9115 = "can";
            String moduleName = string9115;
            var cdfdata1479 = new Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.StubICdfData();
            cdfdata1479.GetAllInstanceConfigurationsString = (String _moduleName) =>
            {
                IList<Configuration> ilist10116 = new List<Configuration>();
                Configuration ilist10116_0 = new Configuration();
                String ilist10116_0_Uuid = "f35faedc-bb22-4614-8a30-4654716b411c";
                String ilist10116_0_ShortName = "CanConfigSet";
                String ilist10116_0_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet";
                Configuration ilist10116_1 = new Configuration();
                String ilist10116_1_Uuid = "f35faedc-bb22-4614-8a30-4654716b411d";
                String ilist10116_1_ShortName = "CanConfigSet0";
                String ilist10116_1_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet0";
                ilist10116.Add(ilist10116_0);
                ilist10116_0.Uuid = ilist10116_0_Uuid;
                ilist10116_0.ShortName = ilist10116_0_ShortName;
                ilist10116_0.DefinitionRef = ilist10116_0_DefinitionRef;
                ilist10116.Add(ilist10116_1);
                ilist10116_1.Uuid = ilist10116_1_Uuid;
                ilist10116_1.ShortName = ilist10116_1_ShortName;
                ilist10116_1.DefinitionRef = ilist10116_1_DefinitionRef;
                return ilist10116;
            }

            ;
            typeof(RepositoryLinQ).GetField("cdfData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, cdfdata1479);
            /* Act */
            IList<Configuration> actualResult = (IList<Configuration>)typeof(RepositoryLinQ).GetMethod("GetConfigurations", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{moduleName});
            /* Assert */
            Object actualResult_count_1480 = actualResult.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)2, (Int32)actualResult_count_1480);
        }
    }
}