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
    public void FindStringTest_32_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = null;
            String text = string91;
            String string102 = "";
            String expression = string102;
            /* Act */
            String actualResult = (String)typeof(StringUtils).GetMethod("FindString", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{text, expression});
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
        }
    }

    [TestMethod]
    public void FindStringTest_32_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string93 = "";
            String text = string93;
            String string104 = null;
            String expression = string104;
            /* Act */
            String actualResult = (String)typeof(StringUtils).GetMethod("FindString", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{text, expression});
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
        }
    }

    [TestMethod]
    public void FindStringTest_32_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string95 = "abctestab]c";
            String text = string95;
            String string106 = "]";
            String expression = string106;
            /* Act */
            String actualResult = (String)typeof(StringUtils).GetMethod("FindString", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{text, expression});
            /* Assert */
            Assert.AreEqual((String)"]", (String)actualResult);
        }
    }

    [TestMethod]
    public void FindStringTest_32_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string97 = "abctestab]c";
            String text = string97;
            String string108 = "test";
            String expression = string108;
            /* Act */
            String actualResult = (String)typeof(StringUtils).GetMethod("FindString", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{text, expression});
            /* Assert */
            Assert.AreEqual((String)"test", (String)actualResult);
        }
    }
}