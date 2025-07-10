using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.CrossCutting.Util;

public partial class TestStringUtils
{
    [TestMethod]
    public void CompareShortNameTest_29_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "abc123";
            String shrName1 = string91;
            String string102 = "abc123";
            String shrName2 = string102;
            /* Act */
            Int32 actualResult = (Int32)typeof(StringUtils).GetMethod("CompareShortName", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{shrName1, shrName2});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)actualResult);
        }
    }

    [TestMethod]
    public void CompareShortNameTest_29_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string93 = "abc123";
            String shrName1 = string93;
            String string104 = "abc456";
            String shrName2 = string104;
            /* Act */
            Int32 actualResult = (Int32)typeof(StringUtils).GetMethod("CompareShortName", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{shrName1, shrName2});
            /* Assert */
            Assert.AreEqual((Int32)(-1), (Int32)actualResult);
        }
    }

    [TestMethod]
    public void CompareShortNameTest_29_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string95 = "abc123";
            String shrName1 = string95;
            String string106 = "xyz123";
            String shrName2 = string106;
            /* Act */
            Int32 actualResult = (Int32)typeof(StringUtils).GetMethod("CompareShortName", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{shrName1, shrName2});
            /* Assert */
            Assert.AreEqual((Int32)(-1), (Int32)actualResult);
        }
    }
}