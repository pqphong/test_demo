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
    public void getListVariantIDsTest_177_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            List<VariantItemValue> listvar = new List<VariantItemValue>();
            VariantItemValue var1 = new VariantItemValue("0", 9600);
            VariantItemValue var2 = new VariantItemValue("1", 9600);
            listvar.Add(var1);
            listvar.Add(var2);
            typeof(ItemValue).GetField("variant", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target1, listvar);
            /* Act */
            List<String> actualResult = (List<String>)typeof(ItemValue).GetMethod("getListVariantIDs", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target1, new object[]{});
            /* Assert */
            Assert.AreEqual(2, actualResult.Count);
            Assert.AreEqual("0", actualResult[0]);
            Assert.AreEqual("1", actualResult[1]);
        }
    }
}