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
    public void Check_ERR_SPECIFIC_01Test_114_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.GetAllStructureData = (BaseValidation instance) =>
            {
                Dictionary<String, List<String>> dictionary91 = null;
                return dictionary91;
            }

            ;
            var intermediatedata17 = new Renesas.Generator.MCALConfGen.Data.IntermediateData.Fakes.StubIIntermediateData();
            typeof(BaseValidation).GetField("IntermediateData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, intermediatedata17);
            /* Act */
            ValidationResult actualResult = (ValidationResult)typeof(BaseValidation).GetMethod("Check_ERR_SPECIFIC_01", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Object actualResult_message_18 = typeof(ValidationResult).GetProperty("Message", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Object actualResult_message_18_count_29 = typeof(List<String>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_message_18);
            Assert.AreEqual((Int32)0, (Int32)actualResult_message_18_count_29);
        }
    }

    [TestMethod]
    public void Check_ERR_SPECIFIC_01Test_114_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.GetAllStructureData = (BaseValidation instance) =>
            {
                Dictionary<String, List<String>> dictionary93 = new Dictionary<String, List<String>>();
                List<String> dictionary93_LinStructure = new List<String>();
                String dictionary93_LinStructure_0 = "field0";
                String dictionary93_LinStructure_1 = "field1";
                dictionary93["LinStructure"] = dictionary93_LinStructure;
                dictionary93_LinStructure.Add(dictionary93_LinStructure_0);
                dictionary93_LinStructure.Add(dictionary93_LinStructure_1);
                return dictionary93;
            }

            ;
            var intermediatedata110 = new Renesas.Generator.MCALConfGen.Data.IntermediateData.Fakes.StubIIntermediateData();
            intermediatedata110.GetItemByPathString = (String path) =>
            {
                BaseIntermediateItem baseintermediateitem104 = new BaseIntermediateItem(null, null);
                String baseintermediateitem104_Name = "LinStructure";
                List<BaseIntermediateItem> baseintermediateitem104_Childs = new List<BaseIntermediateItem>();
                BaseIntermediateItem baseintermediateitem104_Childs_0 = new BaseIntermediateItem(null, null);
                String baseintermediateitem104_Childs_0_Name = "Field0";
                BaseIntermediateItem baseintermediateitem104_Childs_1 = new BaseIntermediateItem(null, null);
                String baseintermediateitem104_Childs_1_Name = "Field1";
                List<BaseIntermediateItem> baseintermediateitem104_Childs_1_Childs = new List<BaseIntermediateItem>();
                BaseIntermediateItem baseintermediateitem104_Childs_1_Childs_0 = new BaseIntermediateItem(null, null);
                String baseintermediateitem104_Childs_1_Childs_0_Name = "Field0";
                baseintermediateitem104.Name = baseintermediateitem104_Name;
                baseintermediateitem104.Childs = baseintermediateitem104_Childs;
                baseintermediateitem104_Childs.Add(baseintermediateitem104_Childs_0);
                baseintermediateitem104_Childs_0.Name = baseintermediateitem104_Childs_0_Name;
                baseintermediateitem104_Childs.Add(baseintermediateitem104_Childs_1);
                baseintermediateitem104_Childs_1.Name = baseintermediateitem104_Childs_1_Name;
                baseintermediateitem104_Childs_1.Childs = baseintermediateitem104_Childs_1_Childs;
                baseintermediateitem104_Childs_1_Childs.Add(baseintermediateitem104_Childs_1_Childs_0);
                baseintermediateitem104_Childs_1_Childs_0.Name = baseintermediateitem104_Childs_1_Childs_0_Name;
                return baseintermediateitem104;
            }

            ;
            typeof(BaseValidation).GetField("IntermediateData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, intermediatedata110);
            /* Act */
            ValidationResult actualResult = (ValidationResult)typeof(BaseValidation).GetMethod("Check_ERR_SPECIFIC_01", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Object actualResult_message_111 = typeof(ValidationResult).GetProperty("Message", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Object actualResult_message_111_count_212 = typeof(List<String>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_message_111);
            Assert.AreEqual((Int32)1, (Int32)actualResult_message_111_count_212);
        }
    }

    [TestMethod]
    public void Check_ERR_SPECIFIC_01Test_114_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.GetAllStructureData = (BaseValidation instance) =>
            {
                Dictionary<String, List<String>> dictionary95 = new Dictionary<String, List<String>>();
                List<String> dictionary95_LinStructure = new List<String>();
                String dictionary95_LinStructure_0 = "field0";
                String dictionary95_LinStructure_1 = "field1";
                dictionary95["LinStructure"] = dictionary95_LinStructure;
                dictionary95_LinStructure.Add(dictionary95_LinStructure_0);
                dictionary95_LinStructure.Add(dictionary95_LinStructure_1);
                return dictionary95;
            }

            ;
            var intermediatedata113 = new Renesas.Generator.MCALConfGen.Data.IntermediateData.Fakes.StubIIntermediateData();
            intermediatedata113.GetItemByPathString = (String path) =>
            {
                BaseIntermediateItem baseintermediateitem106 = new BaseIntermediateItem(null, null);
                String baseintermediateitem106_Name = "LinStructure";
                List<BaseIntermediateItem> baseintermediateitem106_Childs = new List<BaseIntermediateItem>();
                BaseIntermediateItem baseintermediateitem106_Childs_0 = new BaseIntermediateItem(null, null);
                String baseintermediateitem106_Childs_0_Name = "Field0";
                BaseIntermediateItem baseintermediateitem106_Childs_1 = new BaseIntermediateItem(null, null);
                String baseintermediateitem106_Childs_1_Name = "Field1";
                baseintermediateitem106.Name = baseintermediateitem106_Name;
                baseintermediateitem106.Childs = baseintermediateitem106_Childs;
                baseintermediateitem106_Childs.Add(baseintermediateitem106_Childs_0);
                baseintermediateitem106_Childs_0.Name = baseintermediateitem106_Childs_0_Name;
                baseintermediateitem106_Childs.Add(baseintermediateitem106_Childs_1);
                baseintermediateitem106_Childs_1.Name = baseintermediateitem106_Childs_1_Name;
                return baseintermediateitem106;
            }

            ;
            typeof(BaseValidation).GetField("IntermediateData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, intermediatedata113);
            /* Act */
            ValidationResult actualResult = (ValidationResult)typeof(BaseValidation).GetMethod("Check_ERR_SPECIFIC_01", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Object actualResult_message_114 = typeof(ValidationResult).GetProperty("Message", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Object actualResult_message_114_count_215 = typeof(List<String>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult_message_114);
            Assert.AreEqual((Int32)0, (Int32)actualResult_message_114_count_215);
        }
    }
}