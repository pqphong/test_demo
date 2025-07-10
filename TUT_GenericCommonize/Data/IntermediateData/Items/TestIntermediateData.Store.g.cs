using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.IntermediateData;
using Renesas.Generator.MCALConfGen.Data.IntermediateData.Items;

public partial class TestIntermediateData
{
    [TestMethod]
    public void StoreTest_158_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Int32 int3291 = 0;
            Int32 stored = int3291;
            Renesas.Generator.MCALConfGen.Data.IntermediateData.Items.Fakes.ShimBaseIntermediateItem.AllInstances.StoreStringBaseIntermediateItem = (BaseIntermediateItem instance, String _path, BaseIntermediateItem _target) =>
            {
                stored = 1;
            }

            ;
            String string113 = "/Renesas/can";
            String path = string113;
            BaseIntermediateItem baseintermediateitem124 = new BaseIntermediateItem(null, null);
            String baseintermediateitem124_Name = "A";
            String baseintermediateitem124_Value = "B";
            baseintermediateitem124.Name = baseintermediateitem124_Name;
            baseintermediateitem124.Value = baseintermediateitem124_Value;
            BaseIntermediateItem target = baseintermediateitem124;
            /* Act */
            typeof(IntermediateData).GetMethod("Store", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String), typeof(BaseIntermediateItem)}, null).Invoke(_target, new object[]{path, target});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)stored);
        }
    }
}