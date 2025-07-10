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
    public void ParseHexToIntTest_30_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = null;
            String inputString = string91;
            /* Act */
            Int32 actualResult = (Int32)typeof(StringUtils).GetMethod("ParseHexToInt", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{inputString});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)actualResult);
        }
    }

    [TestMethod]
    public void ParseHexToIntTest_30_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string92 = "valid";
            String inputString = string92;
            /* Act */
            Int32 actualResult = (Int32)typeof(StringUtils).GetMethod("ParseHexToInt", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{inputString});
            /* Assert */
            Assert.AreEqual((Int32)0, (Int32)actualResult);
        }
    }

    [TestMethod]
    public void ParseHexToIntTest_30_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string93 = "0x34";
            String inputString = string93;
            /* Act */
            Int32 actualResult = (Int32)typeof(StringUtils).GetMethod("ParseHexToInt", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{inputString});
            /* Assert */
            Assert.AreEqual((Int32)52, (Int32)actualResult);
        }
    }

    [TestMethod]
    public void ParseHexToIntTest_30_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string94 = "0x0001U";
            String inputString = string94;
            /* Act */
            Int32 actualResult = (Int32)typeof(StringUtils).GetMethod("ParseHexToInt", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{inputString});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)actualResult);
        }
    }

    [TestMethod]
    public void ParseHexToIntTest_30_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string95 = "0x0001UL";
            String inputString = string95;
            /* Act */
            Int32 actualResult = (Int32)typeof(StringUtils).GetMethod("ParseHexToInt", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{inputString});
            /* Assert */
            Assert.AreEqual((Int32)1, (Int32)actualResult);
        }
    }
}