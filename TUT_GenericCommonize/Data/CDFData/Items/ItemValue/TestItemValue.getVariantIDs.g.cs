using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;
using static Renesas.Generator.MCALConfGen.Data.CDFData.Items.ItemValue;

public partial class TestItemValue
{
    [TestMethod]
    public void getVariantIDsTest_176_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            List<VariantItemValue> listvar = new List<VariantItemValue>();
            VariantItemValue var1 = new VariantItemValue("0", 9600);
            listvar.Add(var1);
            typeof(ItemValue).GetField("variant", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target1, listvar);
            /* Act */
            List<VariantItemValue> actualResult = (List<VariantItemValue>)typeof(ItemValue).GetMethod("getVariantIDs", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target1, new object[]{});
            /* Assert */
            VariantItemValue result1 = actualResult[0];
            Assert.AreEqual("0", result1.VariantID());
            Assert.AreEqual(9600, result1.InternalValue());
        }
    }
}