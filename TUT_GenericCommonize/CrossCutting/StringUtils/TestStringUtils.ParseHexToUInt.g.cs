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
    public void ParseHexToUIntTest_31_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = null;
            String inputString = string91;
            /* Act */
            UInt32 actualResult = (UInt32)typeof(StringUtils).GetMethod("ParseHexToUInt", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{inputString});
            /* Assert */
            Assert.AreEqual((UInt32)0, (UInt32)actualResult);
        }
    }

    [TestMethod]
    public void ParseHexToUIntTest_31_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string92 = "valid";
            String inputString = string92;
            /* Act */
            UInt32 actualResult = (UInt32)typeof(StringUtils).GetMethod("ParseHexToUInt", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{inputString});
            /* Assert */
            Assert.AreEqual((UInt32)0, (UInt32)actualResult);
        }
    }

    [TestMethod]
    public void ParseHexToUIntTest_31_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string93 = "0x34";
            String inputString = string93;
            /* Act */
            UInt32 actualResult = (UInt32)typeof(StringUtils).GetMethod("ParseHexToUInt", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{inputString});
            /* Assert */
            Assert.AreEqual((UInt32)52, (UInt32)actualResult);
        }
    }

    [TestMethod]
    public void ParseHexToUIntTest_31_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string94 = "0x0001U";
            String inputString = string94;
            /* Act */
            UInt32 actualResult = (UInt32)typeof(StringUtils).GetMethod("ParseHexToUInt", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{inputString});
            /* Assert */
            Assert.AreEqual((UInt32)1, (UInt32)actualResult);
        }
    }

    [TestMethod]
    public void ParseHexToUIntTest_31_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string95 = "0x0001UL";
            String inputString = string95;
            /* Act */
            UInt32 actualResult = (UInt32)typeof(StringUtils).GetMethod("ParseHexToUInt", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{inputString});
            /* Assert */
            Assert.AreEqual((UInt32)1, (UInt32)actualResult);
        }
    }
}