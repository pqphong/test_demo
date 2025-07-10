using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Validation;
using Renesas.Generator.MCALConfGen.Data.IntermediateData.Items;

public partial class TestBaseValidation
{
    [TestMethod]
    public void checkRequiredFieldsOfSubstructsTest_113_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "StructName";
            String rootStructName = string91;
            List<String> list102 = new List<String>();
            String list102_0 = "Field0";
            String list102_1 = "Field1";
            list102.Add(list102_0);
            list102.Add(list102_1);
            List<String> requiredFields = list102;
            BaseIntermediateItem baseintermediateitem113 = new BaseIntermediateItem(null, null);
            String baseintermediateitem113_Name = "DataPath";
            baseintermediateitem113.Name = baseintermediateitem113_Name;
            BaseIntermediateItem structData = baseintermediateitem113;
            /* Act */
            HashSet<String> actualResult = (HashSet<String>)typeof(BaseValidation).GetMethod("checkRequiredFieldsOfSubstructs", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(BaseIntermediateItem), typeof(List<String>)}, null).Invoke(_target, new object[]{rootStructName, structData, requiredFields});
            /* Assert */
            Object actualResult_count_116 = typeof(HashSet<String>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)2, (Int32)actualResult_count_116);
        }
    }

    [TestMethod]
    public void checkRequiredFieldsOfSubstructsTest_113_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string94 = "StructName";
            String rootStructName = string94;
            List<String> list105 = new List<String>();
            String list105_0 = "Field0";
            String list105_1 = "Field1";
            list105.Add(list105_0);
            list105.Add(list105_1);
            List<String> requiredFields = list105;
            BaseIntermediateItem baseintermediateitem116 = new BaseIntermediateItem(null, null);
            String baseintermediateitem116_Name = "DataPath";
            List<BaseIntermediateItem> baseintermediateitem116_Childs = new List<BaseIntermediateItem>();
            BaseIntermediateItem baseintermediateitem116_Childs_0 = new BaseIntermediateItem(null, null);
            String baseintermediateitem116_Childs_0_Name = "Field0";
            BaseIntermediateItem baseintermediateitem116_Childs_1 = new BaseIntermediateItem(null, null);
            String baseintermediateitem116_Childs_1_Name = "Field1";
            baseintermediateitem116.Name = baseintermediateitem116_Name;
            baseintermediateitem116.Childs = baseintermediateitem116_Childs;
            baseintermediateitem116_Childs.Add(baseintermediateitem116_Childs_0);
            baseintermediateitem116_Childs_0.Name = baseintermediateitem116_Childs_0_Name;
            baseintermediateitem116_Childs.Add(baseintermediateitem116_Childs_1);
            baseintermediateitem116_Childs_1.Name = baseintermediateitem116_Childs_1_Name;
            BaseIntermediateItem structData = baseintermediateitem116;
            /* Act */
            HashSet<String> actualResult = (HashSet<String>)typeof(BaseValidation).GetMethod("checkRequiredFieldsOfSubstructs", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(BaseIntermediateItem), typeof(List<String>)}, null).Invoke(_target, new object[]{rootStructName, structData, requiredFields});
            /* Assert */
            Object actualResult_count_117 = typeof(HashSet<String>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_count_117);
        }
    }

    [TestMethod]
    public void checkRequiredFieldsOfSubstructsTest_113_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string97 = "StructName";
            String rootStructName = string97;
            List<String> list108 = new List<String>();
            String list108_0 = "Field0";
            String list108_1 = "Field1";
            list108.Add(list108_0);
            list108.Add(list108_1);
            List<String> requiredFields = list108;
            BaseIntermediateItem baseintermediateitem119 = new BaseIntermediateItem(null, null);
            String baseintermediateitem119_Name = "DataPath";
            List<BaseIntermediateItem> baseintermediateitem119_Childs = new List<BaseIntermediateItem>();
            BaseIntermediateItem baseintermediateitem119_Childs_0 = new BaseIntermediateItem(null, null);
            String baseintermediateitem119_Childs_0_Name = "Filed0";
            BaseIntermediateItem baseintermediateitem119_Childs_1 = new BaseIntermediateItem(null, null);
            String baseintermediateitem119_Childs_1_Name = "Field1";
            List<BaseIntermediateItem> baseintermediateitem119_Childs_1_Childs = new List<BaseIntermediateItem>();
            BaseIntermediateItem baseintermediateitem119_Childs_1_Childs_0 = new BaseIntermediateItem(null, null);
            String baseintermediateitem119_Childs_1_Childs_0_Name = "Field3";
            baseintermediateitem119.Name = baseintermediateitem119_Name;
            baseintermediateitem119.Childs = baseintermediateitem119_Childs;
            baseintermediateitem119_Childs.Add(baseintermediateitem119_Childs_0);
            baseintermediateitem119_Childs_0.Name = baseintermediateitem119_Childs_0_Name;
            baseintermediateitem119_Childs.Add(baseintermediateitem119_Childs_1);
            baseintermediateitem119_Childs_1.Name = baseintermediateitem119_Childs_1_Name;
            baseintermediateitem119_Childs_1.Childs = baseintermediateitem119_Childs_1_Childs;
            baseintermediateitem119_Childs_1_Childs.Add(baseintermediateitem119_Childs_1_Childs_0);
            baseintermediateitem119_Childs_1_Childs_0.Name = baseintermediateitem119_Childs_1_Childs_0_Name;
            BaseIntermediateItem structData = baseintermediateitem119;
            /* Act */
            HashSet<String> actualResult = (HashSet<String>)typeof(BaseValidation).GetMethod("checkRequiredFieldsOfSubstructs", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(BaseIntermediateItem), typeof(List<String>)}, null).Invoke(_target, new object[]{rootStructName, structData, requiredFields});
            /* Assert */
            Object actualResult_count_118 = typeof(HashSet<String>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)2, (Int32)actualResult_count_118);
        }
    }

    [TestMethod]
    public void checkRequiredFieldsOfSubstructsTest_113_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String rootStructName = null;
            List<String> requiredFields = null;
            BaseIntermediateItem baseintermediateitem1112 = null;
            BaseIntermediateItem structData = baseintermediateitem1112;
            /* Act */
            HashSet<String> actualResult = (HashSet<String>)typeof(BaseValidation).GetMethod("checkRequiredFieldsOfSubstructs", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(BaseIntermediateItem), typeof(List<String>)}, null).Invoke(_target, new object[]{rootStructName, structData, requiredFields});
            /* Assert */
            Object actualResult_count_119 = typeof(HashSet<String>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_count_119);
        }
    }

    [TestMethod]
    public void checkRequiredFieldsOfSubstructsTest_113_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string913 = "StructName";
            String rootStructName = string913;
            List<String> list1014 = new List<String>();
            String list1014_0 = "Field0";
            String list1014_1 = "Field1";
            list1014.Add(list1014_0);
            list1014.Add(list1014_1);
            List<String> requiredFields = list1014;
            BaseIntermediateItem baseintermediateitem1115 = new BaseIntermediateItem(null, null);
            String baseintermediateitem1115_Name = "DataPath";
            List<BaseIntermediateItem> baseintermediateitem1115_Childs = new List<BaseIntermediateItem>();
            BaseIntermediateItem baseintermediateitem1115_Childs_0 = new BaseIntermediateItem(null, null);
            String baseintermediateitem1115_Childs_0_Name = "Filed0";
            BaseIntermediateItem baseintermediateitem1115_Childs_1 = null;
            baseintermediateitem1115.Name = baseintermediateitem1115_Name;
            baseintermediateitem1115.Childs = baseintermediateitem1115_Childs;
            baseintermediateitem1115_Childs.Add(baseintermediateitem1115_Childs_0);
            baseintermediateitem1115_Childs_0.Name = baseintermediateitem1115_Childs_0_Name;
            baseintermediateitem1115_Childs.Add(baseintermediateitem1115_Childs_1);
            BaseIntermediateItem structData = baseintermediateitem1115;
            /* Act */
            HashSet<String> actualResult = (HashSet<String>)typeof(BaseValidation).GetMethod("checkRequiredFieldsOfSubstructs", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(BaseIntermediateItem), typeof(List<String>)}, null).Invoke(_target, new object[]{rootStructName, structData, requiredFields});
            /* Assert */
            Object actualResult_count_120 = typeof(HashSet<String>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)2, (Int32)actualResult_count_120);
        }
    }
}