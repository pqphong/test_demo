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
    public void findFieldsOfAnyLastNodeStructTest_112_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            BaseIntermediateItem baseintermediateitem91 = new BaseIntermediateItem(null, null);
            String baseintermediateitem91_Name = "DataPath";
            List<BaseIntermediateItem> baseintermediateitem91_Childs = new List<BaseIntermediateItem>();
            BaseIntermediateItem baseintermediateitem91_Childs_0 = new BaseIntermediateItem(null, null);
            String baseintermediateitem91_Childs_0_Name = "Filed0";
            BaseIntermediateItem baseintermediateitem91_Childs_1 = new BaseIntermediateItem(null, null);
            String baseintermediateitem91_Childs_1_Name = "Field1";
            List<BaseIntermediateItem> baseintermediateitem91_Childs_1_Childs = new List<BaseIntermediateItem>();
            BaseIntermediateItem baseintermediateitem91_Childs_1_Childs_0 = new BaseIntermediateItem(null, null);
            baseintermediateitem91.Name = baseintermediateitem91_Name;
            baseintermediateitem91.Childs = baseintermediateitem91_Childs;
            baseintermediateitem91_Childs.Add(baseintermediateitem91_Childs_0);
            baseintermediateitem91_Childs_0.Name = baseintermediateitem91_Childs_0_Name;
            baseintermediateitem91_Childs.Add(baseintermediateitem91_Childs_1);
            baseintermediateitem91_Childs_1.Name = baseintermediateitem91_Childs_1_Name;
            baseintermediateitem91_Childs_1.Childs = baseintermediateitem91_Childs_1_Childs;
            baseintermediateitem91_Childs_1_Childs.Add(baseintermediateitem91_Childs_1_Childs_0);
            BaseIntermediateItem structData = baseintermediateitem91;
            /* Act */
            List<String> actualResult = (List<String>)typeof(BaseValidation).GetMethod("findFieldsOfAnyLastNodeStruct", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(BaseIntermediateItem)}, null).Invoke(_target, new object[]{structData});
            /* Assert */
            Object actualResult_count_14 = typeof(List<String>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)1, (Int32)actualResult_count_14);
        }
    }

    [TestMethod]
    public void findFieldsOfAnyLastNodeStructTest_112_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            BaseIntermediateItem baseintermediateitem92 = new BaseIntermediateItem(null, null);
            String baseintermediateitem92_Name = "DataPath";
            List<BaseIntermediateItem> baseintermediateitem92_Childs = new List<BaseIntermediateItem>();
            BaseIntermediateItem baseintermediateitem92_Childs_0 = new BaseIntermediateItem(null, null);
            String baseintermediateitem92_Childs_0_Name = "Filed0";
            BaseIntermediateItem baseintermediateitem92_Childs_1 = null;
            baseintermediateitem92.Name = baseintermediateitem92_Name;
            baseintermediateitem92.Childs = baseintermediateitem92_Childs;
            baseintermediateitem92_Childs.Add(baseintermediateitem92_Childs_0);
            baseintermediateitem92_Childs_0.Name = baseintermediateitem92_Childs_0_Name;
            baseintermediateitem92_Childs.Add(baseintermediateitem92_Childs_1);
            BaseIntermediateItem structData = baseintermediateitem92;
            /* Act */
            List<String> actualResult = (List<String>)typeof(BaseValidation).GetMethod("findFieldsOfAnyLastNodeStruct", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(BaseIntermediateItem)}, null).Invoke(_target, new object[]{structData});
            /* Assert */
            Object actualResult_count_15 = typeof(List<String>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)1, (Int32)actualResult_count_15);
        }
    }

    [TestMethod]
    public void findFieldsOfAnyLastNodeStructTest_112_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            BaseIntermediateItem baseintermediateitem93 = null;
            BaseIntermediateItem structData = baseintermediateitem93;
            /* Act */
            List<String> actualResult = (List<String>)typeof(BaseValidation).GetMethod("findFieldsOfAnyLastNodeStruct", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(BaseIntermediateItem)}, null).Invoke(_target, new object[]{structData});
            /* Assert */
            Object actualResult_count_16 = typeof(List<String>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_count_16);
        }
    }
}