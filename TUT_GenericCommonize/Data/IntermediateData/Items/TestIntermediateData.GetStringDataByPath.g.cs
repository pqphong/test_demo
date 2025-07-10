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
    public void GetStringDataByPathTest_155_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String path = null;
            Renesas.Generator.MCALConfGen.Data.IntermediateData.Items.Fakes.ShimBaseIntermediateItem.AllInstances.GetStringDataByPathString = (BaseIntermediateItem instance, String _path) =>
            {
                String string102 = "";
                return string102;
            }

            ;
            /* Act */
            String actualResult = (String)typeof(IntermediateData).GetMethod("GetStringDataByPath", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{path});
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
        }
    }
}