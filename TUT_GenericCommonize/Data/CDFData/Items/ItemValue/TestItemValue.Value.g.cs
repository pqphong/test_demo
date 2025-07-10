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
    public void ValueTest_125_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Object object91 = (long)1;
            typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, object91);
            /* Act */
            long actualResult = (long)typeof(ItemValue).GetMethod("Value", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).MakeGenericMethod(typeof(long)).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((long)(long)1, (long)actualResult);
        }
    }

    [TestMethod]
    public void ValueTest_125_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Object object92 = "str1";
            typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, object92);
            /* Act */
            string actualResult = (string)typeof(ItemValue).GetMethod("Value", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { }, null).MakeGenericMethod(typeof(string)).Invoke(_target, new object[] { });
            /* Assert */
            Assert.AreEqual((string)"str1", (string)actualResult);
        }
    }

    [TestMethod]
    public void ValueTest_125_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Object object93 = true;
            typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, object93);
            /* Act */
            bool actualResult = (bool)typeof(ItemValue).GetMethod("Value", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { }, null).MakeGenericMethod(typeof(bool)).Invoke(_target, new object[] { });
            /* Assert */
            Assert.AreEqual((bool)true, (bool)actualResult);
        }
    }
}