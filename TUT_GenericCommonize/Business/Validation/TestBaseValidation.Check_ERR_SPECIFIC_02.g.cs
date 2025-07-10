using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Validation;
using System;
using System.Collections.Generic;
using System.Reflection;
using static Renesas.Generator.MCALConfGen.Business.Validation.ValidationResult;

public partial class TestBaseValidation
{
    [TestMethod]
    public void Check_ERR_SPECIFIC_02Test_110_1()
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
            /* Act */
            ValidationResult actualResult = (ValidationResult)typeof(BaseValidation).GetMethod("Check_ERR_SPECIFIC_02", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Object actualResult_type_111 = typeof(ValidationResult).GetProperty("Type", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((MessageType)MessageType.SUCCESS, (MessageType)actualResult_type_111);
        }
    }

    [TestMethod]
    public void Check_ERR_SPECIFIC_02Test_110_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.GetAllStructureData = (BaseValidation instance) =>
            {
                Dictionary<String, List<String>> dictionary93 = new Dictionary<String, List<String>>();
                List<String> dictionary93_ = new List<String>();
                dictionary93[""] = dictionary93_;
                return dictionary93;
            }

            ;
            /* Act */
            ValidationResult actualResult = (ValidationResult)typeof(BaseValidation).GetMethod("Check_ERR_SPECIFIC_02", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Object actualResult_type_112 = typeof(ValidationResult).GetProperty("Type", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((MessageType)MessageType.SUCCESS, (MessageType)actualResult_type_112);
        }
    }

    [TestMethod]
    public void Check_ERR_SPECIFIC_02Test_110_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.GetAllStructureData = (BaseValidation instance) =>
            {
                Dictionary<String, List<String>> dictionary95 = new Dictionary<String, List<String>>();
                List<String> dictionary95_structName = null;
                dictionary95["structName"] = dictionary95_structName;
                return dictionary95;
            }

            ;
            /* Act */
            ValidationResult actualResult = (ValidationResult)typeof(BaseValidation).GetMethod("Check_ERR_SPECIFIC_02", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Object actualResult_type_113 = typeof(ValidationResult).GetProperty("Type", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((MessageType)MessageType.SUCCESS, (MessageType)actualResult_type_113);
        }
    }

    [TestMethod]
    public void Check_ERR_SPECIFIC_02Test_110_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.GetAllStructureData = (BaseValidation instance) =>
            {
                Dictionary<String, List<String>> dictionary97 = new Dictionary<String, List<String>>();
                List<String> dictionary97_structName = new List<String>();
                dictionary97["structName"] = dictionary97_structName;
                return dictionary97;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.CheckRequiredFieldsOfSubstructsStringListOfString = (BaseValidation instance, String structName, List<String> requiredFields) =>
            {
                List<String> list108 = new List<String>();
                return list108;
            }

            ;
            /* Act */
            ValidationResult actualResult = (ValidationResult)typeof(BaseValidation).GetMethod("Check_ERR_SPECIFIC_02", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Object actualResult_type_114 = typeof(ValidationResult).GetProperty("Type", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((MessageType)MessageType.SUCCESS, (MessageType)actualResult_type_114);
        }
    }

    [TestMethod]
    public void Check_ERR_SPECIFIC_02Test_110_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.GetAllStructureData = (BaseValidation instance) =>
            {
                Dictionary<String, List<String>> dictionary99 = new Dictionary<String, List<String>>();
                List<String> dictionary99_structName = new List<String>();
                dictionary99["structName"] = dictionary99_structName;
                return dictionary99;
            }

            ;
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.CheckRequiredFieldsOfSubstructsStringListOfString = (BaseValidation instance, String structName, List<String> requiredFields) =>
            {
                List<String> list1010 = new List<String>();
                String list1010_0 = "Error_01";
                String list1010_1 = "Error_02";
                list1010.Add(list1010_0);
                list1010.Add(list1010_1);
                return list1010;
            }

            ;
            /* Act */
            ValidationResult actualResult = (ValidationResult)typeof(BaseValidation).GetMethod("Check_ERR_SPECIFIC_02", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Object actualResult_type_115 = typeof(ValidationResult).GetProperty("Type", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((MessageType)MessageType.ERROR, (MessageType)actualResult_type_115);
            Object actualResult_message_116 = typeof(ValidationResult).GetProperty("Message", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Object actualResult_message_116_0_217 = ((List<String>)actualResult_message_116)[0];
            Assert.AreEqual((String)"Error_01", (String)actualResult_message_116_0_217);
            Object actualResult_message_118 = typeof(ValidationResult).GetProperty("Message", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Object actualResult_message_118_1_219 = ((List<String>)actualResult_message_118)[1];
            Assert.AreEqual((String)"Error_02", (String)actualResult_message_118_1_219);
        }
    }
}