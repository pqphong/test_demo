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
    public void IsNameSyntaxAsCTest_26_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "";
            String name = string91;
            /* Act */
            Boolean actualResult = (Boolean)typeof(StringUtils).GetMethod("IsNameSyntaxAsC", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{name});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void IsNameSyntaxAsCTest_26_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string92 = "auto";
            String name = string92;
            /* Act */
            Boolean actualResult = (Boolean)typeof(StringUtils).GetMethod("IsNameSyntaxAsC", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{name});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void IsNameSyntaxAsCTest_26_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string93 = "valid";
            String name = string93;
            /* Act */
            Boolean actualResult = (Boolean)typeof(StringUtils).GetMethod("IsNameSyntaxAsC", BindingFlags.Static | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{name});
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }
}