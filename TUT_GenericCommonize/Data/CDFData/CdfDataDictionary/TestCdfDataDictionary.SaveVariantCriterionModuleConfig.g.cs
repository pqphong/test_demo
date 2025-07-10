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
    public void SaveVariantCriterionModuleConfigTest_182_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string9148 = "Criterion1";
            String variantcriterion = string9148;

            /* Act */
            _target.GetType().GetMethod("SaveVariantCriterionModuleConfig", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{ variantcriterion});
            /* Assert */
            Object datacontext1495 = _target.GetType().GetField("VariantCriterionModuleConfig", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).GetValue(_target);
            Assert.AreEqual("Criterion1", datacontext1495);
        }
    }
}