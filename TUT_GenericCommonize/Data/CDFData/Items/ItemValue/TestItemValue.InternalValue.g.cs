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

public partial class TestItemValue
{
    [TestMethod]
    public void InternalValueTest_124_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Object object9312 = "str1";
            typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, object9312);
            /* Act */
            Object actualResult = (Object)typeof(ItemValue).GetMethod("InternalValue", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Object)"str1", (Object)actualResult);
        }
    }

    [TestMethod]
    public void InternalValueTest_124_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            Object object9313 = 1;
            typeof(ItemValue).GetField("value", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, object9313);
            /* Act */
            Object actualResult = (Object)typeof(ItemValue).GetMethod("InternalValue", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreEqual((Object)1, (Object)actualResult);
        }
    }
}