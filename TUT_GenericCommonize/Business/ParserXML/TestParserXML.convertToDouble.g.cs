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
    public void convertToDoubleTest_25_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "NAN";
            String value = string91;
            /* Act */
            Double actualResult = (Double)typeof(ParserXML).GetMethod("convertToDouble", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{value});
            /* Assert */
            Assert.AreEqual((Double)double.NaN, (Double)actualResult);
        }
    }

    [TestMethod]
    public void convertToDoubleTest_25_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string92 = "-INF";
            String value = string92;
            /* Act */
            Double actualResult = (Double)typeof(ParserXML).GetMethod("convertToDouble", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{value});
            /* Assert */
            Assert.AreEqual((Double)double.MinValue, (Double)actualResult);
        }
    }

    [TestMethod]
    public void convertToDoubleTest_25_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string93 = "INF";
            String value = string93;
            /* Act */
            Double actualResult = (Double)typeof(ParserXML).GetMethod("convertToDouble", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{value});
            /* Assert */
            Assert.AreEqual((Double)double.MaxValue, (Double)actualResult);
        }
    }

    [TestMethod]
    public void convertToDoubleTest_25_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string94 = "12.5";
            String value = string94;
            /* Act */
            Double actualResult = (Double)typeof(ParserXML).GetMethod("convertToDouble", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{value});
            /* Assert */
            Assert.AreEqual((Double)12.5, (Double)actualResult);
        }
    }
}