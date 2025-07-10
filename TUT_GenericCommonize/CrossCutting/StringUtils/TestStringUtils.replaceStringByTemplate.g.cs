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
    public void replaceStringByTemplateTest_27_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "a";
            String inputString = string91;
            Dictionary<String, String> dictionary102 = new Dictionary<String, String>();
            String dictionary102_a = "abc";
            dictionary102["a"] = dictionary102_a;
            Dictionary<String, String> dictionary = dictionary102;
            /* Act */
            String actualResult = (String)typeof(StringUtils).GetMethod("replaceStringByTemplate", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(Dictionary<String, String>)}, null).Invoke(_target, new object[]{inputString, dictionary});
            /* Assert */
            Assert.AreEqual((String)"abc", (String)actualResult);
        }
    }

    [TestMethod]
    public void replaceStringByTemplateTest_27_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string93 = "a:10";
            String inputString = string93;
            Dictionary<String, String> dictionary104 = new Dictionary<String, String>();
            String dictionary104_a = "abc";
            dictionary104["a"] = dictionary104_a;
            Dictionary<String, String> dictionary = dictionary104;
            /* Act */
            String actualResult = (String)typeof(StringUtils).GetMethod("replaceStringByTemplate", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(Dictionary<String, String>)}, null).Invoke(_target, new object[]{inputString, dictionary});
            /* Assert */
            Assert.AreEqual((String)"abc       ", (String)actualResult);
        }
    }

    [TestMethod]
    public void replaceStringByTemplateTest_27_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string95 = "a:10:C";
            String inputString = string95;
            Dictionary<String, String> dictionary106 = new Dictionary<String, String>();
            String dictionary106_a = "abc";
            dictionary106["a"] = dictionary106_a;
            Dictionary<String, String> dictionary = dictionary106;
            /* Act */
            String actualResult = (String)typeof(StringUtils).GetMethod("replaceStringByTemplate", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(Dictionary<String, String>)}, null).Invoke(_target, new object[]{inputString, dictionary});
            /* Assert */
            Assert.AreEqual((String)"   abc    ", (String)actualResult);
        }
    }

    [TestMethod]
    public void replaceStringByTemplateTest_27_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string97 = "$a:10:R:d";
            String inputString = string97;
            Dictionary<String, String> dictionary108 = new Dictionary<String, String>();
            String dictionary108_a = "abc";
            dictionary108["a"] = dictionary108_a;
            Dictionary<String, String> dictionary = dictionary108;
            /* Act */
            String actualResult = (String)typeof(StringUtils).GetMethod("replaceStringByTemplate", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(Dictionary<String, String>)}, null).Invoke(_target, new object[]{inputString, dictionary});
            /* Assert */
            Assert.AreEqual((String)"     abcd", (String)actualResult);
        }
    }
}