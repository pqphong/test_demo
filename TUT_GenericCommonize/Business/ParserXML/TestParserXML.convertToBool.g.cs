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
    public void convertToBoolTest_32_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "0";
            String value = string91;
            /* Act */
            Boolean actualResult = (Boolean)typeof(ParserXML).GetMethod("convertToBool", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{value});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void convertToBoolTest_32_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string92 = "1";
            String value = string92;
            /* Act */
            Boolean actualResult = (Boolean)typeof(ParserXML).GetMethod("convertToBool", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{value});
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void convertToBoolTest_32_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string93 = "false";
            String value = string93;
            /* Act */
            Boolean actualResult = (Boolean)typeof(ParserXML).GetMethod("convertToBool", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{value});
            /* Assert */
            Assert.AreEqual((Boolean)false, (Boolean)actualResult);
        }
    }

    [TestMethod]
    public void convertToBoolTest_32_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string94 = "true";
            String value = string94;
            /* Act */
            Boolean actualResult = (Boolean)typeof(ParserXML).GetMethod("convertToBool", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{value});
            /* Assert */
            Assert.AreEqual((Boolean)true, (Boolean)actualResult);
        }
    }
}