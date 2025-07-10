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

public partial class TestContainer
{
    [TestMethod]
    public void GetChildByDefNameTest_119_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9308 = "PortFilterGroupConfig";
            String defName = string9308;
            Int32 int3210309 = 0;
            Int32 sortOption = int3210309;
            Renesas.Generator.MCALConfGen.Data.CDFData.Items.Fakes.ShimContainer.AllInstances.GetChildsByDefNameStringInt32 = (Container instance, String _defName, Int32 _sortOption) =>
            {
                IList<Container> ilist11310 = new List<Container>();
                Container ilist11310_0 = new Container();
                String ilist11310_0_DefinitionRef = "/Renesas/EcucDefs_Port/Port/PortConfigSet/PortFilterGroupConfig";
                ilist11310.Add(ilist11310_0);
                ilist11310_0.DefinitionRef = ilist11310_0_DefinitionRef;
                return ilist11310;
            }

            ;
            /* Act */
            Container actualResult = (Container)typeof(Container).GetMethod("GetChildByDefName", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(Int32)}, null).Invoke(_target, new object[]{defName, sortOption});
            /* Assert */
            Object actualResult_definitionref_1579 = typeof(Container).GetProperty("DefinitionRef", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"/Renesas/EcucDefs_Port/Port/PortConfigSet/PortFilterGroupConfig", (String)actualResult_definitionref_1579);
        }
    }
}