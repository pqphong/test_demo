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
    public void IsInvalidNameTest_37_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "";
            String name = string91;
            /* Act */
            Boolean actualResult = (Boolean)typeof(StringUtils).GetMethod("IsInvalidName", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{name});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void IsInvalidNameTest_37_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string92 = "-test";
            String name = string92;
            /* Act */
            Boolean actualResult = (Boolean)typeof(StringUtils).GetMethod("IsInvalidName", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{name});
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void IsInvalidNameTest_37_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string93 = "\test\\abc|";
            String name = string93;
            /* Act */
            Boolean actualResult = (Boolean)typeof(StringUtils).GetMethod("IsInvalidName", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{name});
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void IsInvalidNameTest_37_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string94 = "\"test\"";
            String name = string94;
            /* Act */
            Boolean actualResult = (Boolean)typeof(StringUtils).GetMethod("IsInvalidName", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{name});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void IsInvalidNameTest_37_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string95 = "\"test";
            String name = string95;
            /* Act */
            Boolean actualResult = (Boolean)typeof(StringUtils).GetMethod("IsInvalidName", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{name});
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void IsInvalidNameTest_37_6()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string96 = "test|";
            String name = string96;
            /* Act */
            Boolean actualResult = (Boolean)typeof(StringUtils).GetMethod("IsInvalidName", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{name});
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void IsInvalidNameTest_37_7()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string96 = "\test:";
            String name = string96;
            /* Act */
            Boolean actualResult = (Boolean)typeof(StringUtils).GetMethod("IsInvalidName", BindingFlags.Static | BindingFlags.Public, null, new Type[] { typeof(String) }, null).Invoke(_target, new object[] { name });
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void IsInvalidNameTest_37_8()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string96 = ":";
            String name = string96;
            /* Act */
            Boolean actualResult = (Boolean)typeof(StringUtils).GetMethod("IsInvalidName", BindingFlags.Static | BindingFlags.Public, null, new Type[] { typeof(String) }, null).Invoke(_target, new object[] { name });
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }
}