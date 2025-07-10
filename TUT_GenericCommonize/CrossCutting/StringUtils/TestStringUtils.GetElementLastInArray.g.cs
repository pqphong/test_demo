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
    public void GetElementLastInArrayTest_33_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = null;
            String path = string91;
            Char char102 = '/';
            Char delimeter = char102;
            /* Act */
            String actualResult = (String)typeof(StringUtils).GetMethod("GetElementLastInArray", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(Char)}, null).Invoke(_target, new object[]{path, delimeter});
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetElementLastInArrayTest_33_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string93 = "";
            String path = string93;
            Char char104 = '/';
            Char delimeter = char104;
            /* Act */
            String actualResult = (String)typeof(StringUtils).GetMethod("GetElementLastInArray", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(Char)}, null).Invoke(_target, new object[]{path, delimeter});
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetElementLastInArrayTest_33_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string95 = "a/b/c";
            String path = string95;
            Char char106 = '/';
            Char delimeter = char106;
            /* Act */
            String actualResult = (String)typeof(StringUtils).GetMethod("GetElementLastInArray", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(Char)}, null).Invoke(_target, new object[]{path, delimeter});
            /* Assert */
            Assert.AreEqual((String)"c", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetElementLastInArrayTest_33_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string97 = "abc";
            String path = string97;
            Char char108 = '/';
            Char delimeter = char108;
            /* Act */
            String actualResult = (String)typeof(StringUtils).GetMethod("GetElementLastInArray", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(Char)}, null).Invoke(_target, new object[]{path, delimeter});
            /* Assert */
            Assert.AreEqual((String)"abc", (String)actualResult);
        }
    }

    [TestMethod]
    public void GetElementLastInArrayTest_33_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string99 = ".";
            String path = string99;
            Char char1010 = '/';
            Char delimeter = char1010;
            /* Act */
            String actualResult = (String)typeof(StringUtils).GetMethod("GetElementLastInArray", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(Char)}, null).Invoke(_target, new object[]{path, delimeter});
            /* Assert */
            Assert.AreEqual((String)".", (String)actualResult);
        }
    }
}