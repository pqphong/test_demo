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
    public void IsNullPointerTest_34_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = null;
            String value = string91;
            /* Act */
            Boolean actualResult = (Boolean)typeof(StringUtils).GetMethod("IsNullPointer", BindingFlags.Instance | BindingFlags.Public|BindingFlags.Static, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{value});
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void IsNullPointerTest_34_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string92 = "";
            String value = string92;
            /* Act */
            Boolean actualResult = (Boolean)typeof(StringUtils).GetMethod("IsNullPointer", BindingFlags.Instance | BindingFlags.Public|BindingFlags.Static, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{value});
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void IsNullPointerTest_34_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string93 = "valid";
            String value = string93;
            /* Act */
            Boolean actualResult = (Boolean)typeof(StringUtils).GetMethod("IsNullPointer", BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{value});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }
}