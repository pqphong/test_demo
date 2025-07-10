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
    public void addVariantValueTest_178_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String value1 = "abc";
            VariantItemValue var1 = new VariantItemValue("0", 9600);
            List<VariantItemValue> Lvar = new List<VariantItemValue>();
            typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target1, value1);
            typeof(ItemValue).GetField("variant", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target1, Lvar);
            /* Act */
            typeof(ItemValue).GetMethod("addVariantValue", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(VariantItemValue)}, null).Invoke(_target1, new object[]{ var1 });
            /* Assert */
            String result1 = (string)typeof(ItemValue).GetMethod("Value", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { }, null).MakeGenericMethod(typeof(string)).Invoke(_target1, new object[] { });
            Assert.AreEqual(null, result1);
            List<VariantItemValue> result2 = (List<VariantItemValue>)typeof(ItemValue).GetMethod("getVariantIDs", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { }, null).Invoke(_target1, new object[] { });
            Assert.AreEqual("0", result2[0].VariantID());
            Assert.AreEqual(9600, result2[0].InternalValue());
        }
    }
}