using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.CDFData.Items;

public partial class TestContainer
{
    [TestMethod]
    public void GetHashCodeTest_113_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "";
            typeof(Container).GetProperty("Uuid", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, string91);
            /* Act */
            Int32 actualResult = (Int32)typeof(Container).GetMethod("GetHashCode", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreNotEqual((Int32)0, (Int32)actualResult);
        }
    }

    [TestMethod]
    public void GetHashCodeTest_113_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string92 = "Value of Uuid";
            typeof(Container).GetProperty("Uuid", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, string92);
            /* Act */
            Int32 actualResult = (Int32)typeof(Container).GetMethod("GetHashCode", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{}, null).Invoke(_target, new object[]{});
            /* Assert */
            Assert.AreNotEqual((Int32)0, (Int32)actualResult);
        }
    }
}