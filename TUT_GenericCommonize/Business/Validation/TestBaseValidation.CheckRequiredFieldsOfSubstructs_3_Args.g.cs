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
    public void CheckRequiredFieldsOfSubstructsTest_125_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "/";
            String dataPath = string91;
            String string102 = "GaaCanStruct";
            String structName = string102;
            List<String> list113 = new List<String>();
            List<String> requiredFields = list113;
            var intermediatedata16 = new Renesas.Generator.MCALConfGen.Data.IntermediateData.Fakes.StubIIntermediateData();
            intermediatedata16.GetItemByPathString = (String path) =>
            {
                BaseIntermediateItem baseintermediateitem124 = new BaseIntermediateItem(null, null);
                return baseintermediateitem124;
            }

            ;
            typeof(BaseValidation).GetField("IntermediateData", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, intermediatedata16);
            Renesas.Generator.MCALConfGen.Business.Validation.Fakes.ShimBaseValidation.AllInstances.checkRequiredFieldsOfSubstructsStringBaseIntermediateItemListOfString = (BaseValidation instance, String rootStructName, BaseIntermediateItem structData, List<String> _requiredFields) =>
            {
                HashSet<String> hashset135 = new HashSet<String>();
                return hashset135;
            }

            ;
            /* Act */
            List<String> actualResult = (List<String>)typeof(BaseValidation).GetMethod("CheckRequiredFieldsOfSubstructs", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String), typeof(List<String>)}, null).Invoke(_target, new object[]{dataPath, structName, requiredFields});
            /* Assert */
            Object actualResult_count_17 = typeof(List<String>).GetProperty("Count", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)0, (Int32)actualResult_count_17);
        }
    }
}