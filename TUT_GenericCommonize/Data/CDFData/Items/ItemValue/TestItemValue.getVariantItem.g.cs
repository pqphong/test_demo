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
    public void getVariantItemTest_175_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String varinput = "0";
            List<VariantItemValue> listvar = new List<VariantItemValue>();
            VariantItemValue var1 = new VariantItemValue("0", 9600);
            listvar.Add(var1);
            typeof(ItemValue).GetField("variant", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target1, listvar);
            /* Act */
            VariantItemValue actualResult = (VariantItemValue)typeof(ItemValue).GetMethod("getVariantItem", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target1, new object[]{ varinput });
            /* Assert */
            Assert.AreEqual("0", actualResult.VariantID());
            Assert.AreEqual(9600, actualResult.InternalValue());
        }
    }
}