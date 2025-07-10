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
    public void GetItemByPathTest_153_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.Data.IntermediateData.Items.Fakes.ShimBaseIntermediateItem.AllInstances.GetItemByPathString = (BaseIntermediateItem instance, String _path) =>
            {
                BaseIntermediateItem baseintermediateitem91 = new BaseIntermediateItem(null, null);
                String baseintermediateitem91_Name = "";
                String baseintermediateitem91_Value = "";
                baseintermediateitem91.Name = baseintermediateitem91_Name;
                baseintermediateitem91.Value = baseintermediateitem91_Value;
                return baseintermediateitem91;
            }

            ;
            String string102 = "/Renesas/can";
            String path = string102;
            /* Act */
            BaseIntermediateItem actualResult = (BaseIntermediateItem)typeof(IntermediateData).GetMethod("GetItemByPath", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{path});
            /* Assert */
            Object actualResult_name_13 = typeof(BaseIntermediateItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"", (String)actualResult_name_13);
            Object actualResult_value_14 = typeof(BaseIntermediateItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"", (String)actualResult_value_14);
        }
    }
}