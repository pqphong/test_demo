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
    public void GetContainerByDefNameTest_27_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String moduleName = null;
            String defName = null;
            Int32 sortOption = 0;
            Renesas.Generator.MCALConfGen.Data.CDFData.Fakes.ShimRepositoryLinQ.AllInstances.GetContainersByDefNameStringStringInt32 = (RepositoryLinQ instance, String _moduleName, String _defName, Int32 _sortOption) =>
            {
                IList<Container> ilist12120 = new List<Container>();
                Container ilist12120_0 = new Container();
                String ilist12120_0_Uuid = "f35faedc-bb22-4614-8a30-4654716b411c";
                String ilist12120_0_ShortName = "CanConfigSet0";
                String ilist12120_0_DefinitionRef = "/Renesas/EcucDefs_Can/Can/CanConfigSet";
                ilist12120.Add(ilist12120_0);
                ilist12120_0.Uuid = ilist12120_0_Uuid;
                ilist12120_0.ShortName = ilist12120_0_ShortName;
                ilist12120_0.DefinitionRef = ilist12120_0_DefinitionRef;
                return ilist12120;
            }

            ;
            /* Act */
            Container actualResult = (Container)typeof(RepositoryLinQ).GetMethod("GetContainerByDefName", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String), typeof(Int32)}, null).Invoke(_target, new object[]{moduleName, defName, sortOption});
            /* Assert */
            Object actualResult_uuid_1481 = typeof(Container).GetProperty("Uuid", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"f35faedc-bb22-4614-8a30-4654716b411c", (String)actualResult_uuid_1481);
            Object actualResult_shortname_1482 = typeof(Container).GetProperty("ShortName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"CanConfigSet0", (String)actualResult_shortname_1482);
            Object actualResult_definitionref_1483 = typeof(Container).GetProperty("DefinitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Can/Can/CanConfigSet", (String)actualResult_definitionref_1483);
        }
    }
}