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
    public void parseShortNameTest_35_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "abc123";
            String shrName = string91;
            string name = string.Empty;
            int number = 0;
            /* Act */
            Object[] paramArray = new object[]{shrName, name, number};
            typeof(StringUtils).GetMethod("parseShortName", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String).MakeByRefType(), typeof(Int32).MakeByRefType()}, null).Invoke(_target, paramArray);
            shrName = (String)paramArray[0];
            name = (String)paramArray[1];
            number = (Int32)paramArray[2];
            /* Assert */
            Assert.AreEqual((String)"abc", (String)name);
            Assert.AreEqual((Int32)123, (Int32)number);
        }
    }

    [TestMethod]
    public void parseShortNameTest_35_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string92 = "abc";
            String shrName = string92;
            string name = string.Empty;
            int number = 0;
            /* Act */
            Object[] paramArray = new object[]{shrName, name, number};
            typeof(StringUtils).GetMethod("parseShortName", BindingFlags.Static | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String).MakeByRefType(), typeof(Int32).MakeByRefType()}, null).Invoke(_target, paramArray);
            shrName = (String)paramArray[0];
            name = (String)paramArray[1];
            number = (Int32)paramArray[2];
            /* Assert */
            Assert.AreEqual((String)"abc", (String)name);
            Assert.AreEqual((Int32)0, (Int32)number);
        }
    }
}