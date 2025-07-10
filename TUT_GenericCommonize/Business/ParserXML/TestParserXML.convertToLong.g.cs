using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Parser;

public partial class TestParserXML
{
    [TestMethod]
    public void convertToLongTest_1_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "0xA7";
            String value = string91;
            /* Act */
            Object actualResult = (Object)typeof(ParserXML).GetMethod("convertToLong", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String) }, null).Invoke(_target, new object[] { value });
            /* Assert */
            Assert.AreEqual((Object)(long)167, (Object)actualResult);
        }
    }

    [TestMethod]
    public void convertToLongTest_1_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string92 = "9223372036854775808";
            String value = string92;
            /* Act */
            Object actualResult = (Object)typeof(ParserXML).GetMethod("convertToLong", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String) }, null).Invoke(_target, new object[] { value });
            /* Assert */
            Assert.AreEqual((Object)(ulong)9223372036854775808, (Object)actualResult);
        }
    }

    [TestMethod]
    public void convertToLongTest_1_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string93 = "-12";
            String value = string93;
            /* Act */
            Object actualResult = (Object)typeof(ParserXML).GetMethod("convertToLong", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String) }, null).Invoke(_target, new object[] { value });
            /* Assert */
            Assert.AreEqual((Object)(long)(-12), (Object)actualResult);
        }
    }

    [TestMethod]
    public void convertToLongTest_1_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string94 = "0b1010000";
            String value = string94;
            /* Act */
            Object actualResult = (Object)typeof(ParserXML).GetMethod("convertToLong", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[] { typeof(String) }, null).Invoke(_target, new object[] { value });
            /* Assert */
            Assert.AreEqual((Object)(long)80, (Object)actualResult);
        }
    }
}