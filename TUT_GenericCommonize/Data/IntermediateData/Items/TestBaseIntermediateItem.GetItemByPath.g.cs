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
    public void GetItemByPathTest_147_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9350 = "/0/fCAN/";
            String path = string9350;
            List<BaseIntermediateItem> list10351 = new List<BaseIntermediateItem>();
            typeof(BaseIntermediateItem).GetProperty("Childs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, list10351);
            /* Act */
            BaseIntermediateItem actualResult = (BaseIntermediateItem)typeof(BaseIntermediateItem).GetMethod("GetItemByPath", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{path});
            /* Assert */
            Assert.AreEqual((BaseIntermediateItem)null, (BaseIntermediateItem)actualResult);
        }
    }

    [TestMethod]
    public void GetItemByPathTest_147_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9352 = "/Renesas/fCAN/";
            String path = string9352;
            List<BaseIntermediateItem> list10353 = new List<BaseIntermediateItem>();
            BaseIntermediateItem list10353_0 = new BaseIntermediateItem(null, null);
            String list10353_0_Name = "Renesas";
            List<BaseIntermediateItem> list10353_0_Childs = new List<BaseIntermediateItem>();
            BaseIntermediateItem list10353_0_Childs_0 = new BaseIntermediateItem(null, null);
            String list10353_0_Childs_0_Name = "fCAN";
            String list10353_0_Childs_0_Value = "test";
            list10353.Add(list10353_0);
            list10353_0.Name = list10353_0_Name;
            list10353_0.Childs = list10353_0_Childs;
            list10353_0_Childs.Add(list10353_0_Childs_0);
            list10353_0_Childs_0.Name = list10353_0_Childs_0_Name;
            list10353_0_Childs_0.Value = list10353_0_Childs_0_Value;
            typeof(BaseIntermediateItem).GetProperty("Childs", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, list10353);
            /* Act */
            BaseIntermediateItem actualResult = (BaseIntermediateItem)typeof(BaseIntermediateItem).GetMethod("GetItemByPath", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{path});
            /* Assert */
            Object actualResult_name_1640 = typeof(BaseIntermediateItem).GetProperty("Name", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"fCAN", (String)actualResult_name_1640);
            Object actualResult_value_1641 = typeof(BaseIntermediateItem).GetProperty("Value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((String)"test", (String)actualResult_value_1641);
        }
    }
}