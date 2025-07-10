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

public partial class TestCdfDataDictionary
{
    [TestMethod]
    public void GetVariantCriterionModuleConfigTest_181_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9148 = "Criterion1";
            String variantcriterion = string9148;

            _target.GetType().GetField("VariantCriterionModuleConfig", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, variantcriterion);

            /* Act */
            string result = (string)_target.GetType().GetMethod("GetVariantCriterionModuleConfig", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{ });
            /* Assert */
            Assert.AreEqual("Criterion1", result);
        }
    }
}