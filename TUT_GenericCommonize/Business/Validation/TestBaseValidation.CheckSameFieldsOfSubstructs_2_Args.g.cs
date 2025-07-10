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
    public void CheckSameFieldsOfSubstructsTest_126_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = null;
            String dataPath = string91;
            String string102 = null;
            String structName = string102;
            var intermediatedata121 = new Renesas.Generator.MCALConfGen.Data.IntermediateData.Fakes.StubIIntermediateData();
            intermediatedata121.GetItemByPathString = (String path) =>
            {
                BaseIntermediateItem baseintermediateitem113 = new BaseIntermediateItem(null, null);
                List<BaseIntermediateItem> baseintermediateitem113_Childs = null;
                baseintermediateitem113.Childs = baseintermediateitem113_Childs;
                return baseintermediateitem113;
            }

            ;
            typeof(BaseValidation).GetField("IntermediateData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, intermediatedata121);
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.findFieldsOfAnyLastNodeStructBaseIntermediateItem = (BaseValidation instance, BaseIntermediateItem structData) =>
            {
                List<String> list124 = new List<String>();
                String list124_0 = "CanGeneral";
                list124.Add(list124_0);
                return list124;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.checkSameFieldsOfSubstructsStringBaseIntermediateItemListOfString = (BaseValidation instance, String rootStructName, BaseIntermediateItem structData, List<String> fields) =>
            {
                String string135 = "";
                return string135;
            }

            ;
            /* Act */
            List<String> actualResult = (List<String>)typeof(BaseValidation).GetMethod("CheckSameFieldsOfSubstructs", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String), typeof(String) }, null).Invoke(_target, new object[] { dataPath, structName });
            /* Assert */
            Object actualResult_count_122 = typeof(List<String>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_count_122);
        }
    }

    [TestMethod]
    public void CheckSameFieldsOfSubstructsTest_126_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string96 = "/";
            String dataPath = string96;
            String string107 = "GaaCanStructure";
            String structName = string107;
            var intermediatedata123 = new Renesas.Generator.MCALConfGen.Data.IntermediateData.Fakes.StubIIntermediateData();
            intermediatedata123.GetItemByPathString = (String path) =>
            {
                BaseIntermediateItem baseintermediateitem118 = new BaseIntermediateItem(null, null);
                return baseintermediateitem118;
            }

            ;
            typeof(BaseValidation).GetField("IntermediateData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, intermediatedata123);
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.findFieldsOfAnyLastNodeStructBaseIntermediateItem = (BaseValidation instance, BaseIntermediateItem structData) =>
            {
                List<String> list129 = new List<String>();
                String list129_0 = "CanGeneral";
                list129.Add(list129_0);
                return list129;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.checkSameFieldsOfSubstructsStringBaseIntermediateItemListOfString = (BaseValidation instance, String rootStructName, BaseIntermediateItem structData, List<String> fields) =>
            {
                String string1310 = "Can general is missing";
                return string1310;
            }

            ;
            /* Act */
            List<String> actualResult = (List<String>)typeof(BaseValidation).GetMethod("CheckSameFieldsOfSubstructs", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String), typeof(String) }, null).Invoke(_target, new object[] { dataPath, structName });
            /* Assert */
            Object actualResult_count_124 = typeof(List<String>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)1, (Int32)actualResult_count_124);
        }
    }

    [TestMethod]
    public void CheckSameFieldsOfSubstructsTest_126_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string911 = null;
            String dataPath = string911;
            String string1012 = null;
            String structName = string1012;
            var intermediatedata125 = new Renesas.Generator.MCALConfGen.Data.IntermediateData.Fakes.StubIIntermediateData();
            intermediatedata125.GetItemByPathString = (String path) =>
            {
                BaseIntermediateItem baseintermediateitem1113 = null;
                return baseintermediateitem1113;
            }

            ;
            typeof(BaseValidation).GetField("IntermediateData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, intermediatedata125);
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.findFieldsOfAnyLastNodeStructBaseIntermediateItem = (BaseValidation instance, BaseIntermediateItem structData) =>
            {
                List<String> list1214 = new List<String>();
                String list1214_0 = "CanGeneral";
                list1214.Add(list1214_0);
                return list1214;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.checkSameFieldsOfSubstructsStringBaseIntermediateItemListOfString = (BaseValidation instance, String rootStructName, BaseIntermediateItem structData, List<String> fields) =>
            {
                String string1315 = "";
                return string1315;
            }

            ;
            /* Act */
            List<String> actualResult = (List<String>)typeof(BaseValidation).GetMethod("CheckSameFieldsOfSubstructs", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String), typeof(String) }, null).Invoke(_target, new object[] { dataPath, structName });
            /* Assert */
            Object actualResult_count_126 = typeof(List<String>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_count_126);
        }
    }

    [TestMethod]
    public void CheckSameFieldsOfSubstructsTest_126_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string916 = "/";
            String dataPath = string916;
            String string1017 = "GaaCanStructure";
            String structName = string1017;
            var intermediatedata127 = new Renesas.Generator.MCALConfGen.Data.IntermediateData.Fakes.StubIIntermediateData();
            intermediatedata127.GetItemByPathString = (String path) =>
            {
                BaseIntermediateItem baseintermediateitem1118 = new BaseIntermediateItem(null, null);
                return baseintermediateitem1118;
            }

            ;
            typeof(BaseValidation).GetField("IntermediateData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, intermediatedata127);
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.findFieldsOfAnyLastNodeStructBaseIntermediateItem = (BaseValidation instance, BaseIntermediateItem structData) =>
            {
                List<String> list1219 = new List<String>();
                String list1219_0 = "CanGeneral";
                list1219.Add(list1219_0);
                return list1219;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.checkSameFieldsOfSubstructsStringBaseIntermediateItemListOfString = (BaseValidation instance, String rootStructName, BaseIntermediateItem structData, List<String> fields) =>
            {
                String string1320 = "";
                return string1320;
            }

            ;
            /* Act */
            List<String> actualResult = (List<String>)typeof(BaseValidation).GetMethod("CheckSameFieldsOfSubstructs", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String), typeof(String) }, null).Invoke(_target, new object[] { dataPath, structName });
            /* Assert */
            Object actualResult_count_128 = typeof(List<String>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_count_128);
        }
    }
}