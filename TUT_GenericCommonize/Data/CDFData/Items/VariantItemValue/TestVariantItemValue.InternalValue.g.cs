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
using static Renesas.Generator.MCALConfGen.Data.CDFData.Items.VariantItemValue;

public partial class TestVariantItemValue
{
    [TestMethod]
    public void InternalValueTest_173_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Object string9311 = "0";
            typeof(VariantItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string9311);
            /* Act */
            String actualResult = (String)typeof(VariantItemValue).GetMethod("InternalValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual("0", actualResult);
        }
    }
}