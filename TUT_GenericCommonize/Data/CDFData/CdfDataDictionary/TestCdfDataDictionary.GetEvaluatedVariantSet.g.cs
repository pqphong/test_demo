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
    public void GetEvaluatedVariantSetTest_179_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String variantname = "Variant_1";
            String variantvalue = "0";
            Dictionary<String, String> dic = new Dictionary<String, String>();
            dic.Add(variantname, variantvalue);

            _target.GetType().GetField("EvaluatedVariantSet", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, dic);

            /* Act */
            Dictionary<String, String> result = (Dictionary<String,String>)_target.GetType().GetMethod("GetEvaluatedVariantSet", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { }, null).Invoke(_target, new object[] { });
            /* Assert */

            Assert.AreEqual("0", result["Variant_1"]);
        }
    }
}