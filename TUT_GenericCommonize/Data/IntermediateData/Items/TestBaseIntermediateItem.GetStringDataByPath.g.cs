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
using Renesas.Generator.MCALConfGen.Data.RuntimeConfiguration;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;

public partial class TestBaseIntermediateItem
{
    [TestMethod]
    public void GetStringDataByPathTest_151_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.Data.IntermediateData.Items.Fakes.ShimBaseIntermediateItem.AllInstances.GetItemByPathString = (BaseIntermediateItem instance, String _path) =>
            {
                BaseIntermediateItem baseintermediateitem9355 = null;
                return baseintermediateitem9355;
            }

            ;
            String string10356 = "";
            String path = string10356;
            /* Act */
            String actualResult = (String)typeof(BaseIntermediateItem).GetMethod("GetStringDataByPath", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{path});
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetStringDataByPathTest_151_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.Data.IntermediateData.Items.Fakes.ShimBaseIntermediateItem.AllInstances.GetItemByPathString = (BaseIntermediateItem instance, String _path) =>
            {
                BaseIntermediateItem baseintermediateitem9357 = new BaseIntermediateItem(null, null);
                String baseintermediateitem9357_Value = "abc";
                baseintermediateitem9357.Value = baseintermediateitem9357_Value;
                return baseintermediateitem9357;
            }

            ;
            String string10358 = "";
            String path = string10358;
            /* Act */
            String actualResult = (String)typeof(BaseIntermediateItem).GetMethod("GetStringDataByPath", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{path});
            /* Assert */
            Assert.AreEqual((String)"abc", (String)actualResult);
        }
    }
}