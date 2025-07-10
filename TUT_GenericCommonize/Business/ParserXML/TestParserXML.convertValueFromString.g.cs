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
    public void convertValueFromStringTest_14_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "ECUC-BOOLEAN-PARAM-DEF";
            String dataType = string91;
            String string102 = "TRUE";
            String dataValue = string102;
            /* Act */
            Object actualResult = (Object)typeof(ParserXML).GetMethod("convertValueFromString", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{dataType, dataValue});
            /* Assert */
            Assert.AreEqual((Object)true, (Object)actualResult);
        }
    }

    [TestMethod]
    public void convertValueFromStringTest_14_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string93 = "ECUC-INTEGER-PARAM-DEF";
            String dataType = string93;
            String string104 = "1";
            String dataValue = string104;
            /* Act */
            Object actualResult = (Object)typeof(ParserXML).GetMethod("convertValueFromString", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{dataType, dataValue});
            /* Assert */
            Assert.AreEqual((Object)(Int64)1, (Object)actualResult);
        }
    }

    [TestMethod]
    public void convertValueFromStringTest_14_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string95 = "ECUC-FLOAT-PARAM-DEF";
            String dataType = string95;
            String string106 = "3.3";
            String dataValue = string106;
            /* Act */
            Object actualResult = (Object)typeof(ParserXML).GetMethod("convertValueFromString", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{dataType, dataValue});
            /* Assert */
            Assert.AreEqual((Object)3.3, (Object)actualResult);
        }
    }

    [TestMethod]
    public void convertValueFromStringTest_14_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string97 = "ECUC-STRING-PARAM-DEF";
            String dataType = string97;
            String string108 = "A";
            String dataValue = string108;
            /* Act */
            Object actualResult = (Object)typeof(ParserXML).GetMethod("convertValueFromString", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{dataType, dataValue});
            /* Assert */
            Assert.AreEqual((Object)"A", (Object)actualResult);
        }
    }

    [TestMethod]
    public void convertValueFromStringTest_14_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string99 = "ECUC-LINKER-SYMBOL-DEF";
            String dataType = string99;
            String string1010 = "None";
            String dataValue = string1010;
            /* Act */
            Object actualResult = (Object)typeof(ParserXML).GetMethod("convertValueFromString", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{dataType, dataValue});
            /* Assert */
            Assert.AreEqual((Object)"None", (Object)actualResult);
        }
    }

    [TestMethod]
    public void convertValueFromStringTest_14_6()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string911 = "ECUC-FUNCTION-NAME-DEF";
            String dataType = string911;
            String string1012 = "None";
            String dataValue = string1012;
            /* Act */
            Object actualResult = (Object)typeof(ParserXML).GetMethod("convertValueFromString", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{dataType, dataValue});
            /* Assert */
            Assert.AreEqual((Object)"None", (Object)actualResult);
        }
    }

    [TestMethod]
    public void convertValueFromStringTest_14_7()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string913 = "ECUC-ENUMERATION-PARAM-DEF";
            String dataType = string913;
            String string1014 = "None";
            String dataValue = string1014;
            /* Act */
            Object actualResult = (Object)typeof(ParserXML).GetMethod("convertValueFromString", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{dataType, dataValue});
            /* Assert */
            Assert.AreEqual((Object)"None", (Object)actualResult);
        }
    }

    [TestMethod]
    public void convertValueFromStringTest_14_8()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string915 = "ECUC-ENUMERATION-LITERAL-DEF";
            String dataType = string915;
            String string1016 = "None";
            String dataValue = string1016;
            /* Act */
            Object actualResult = (Object)typeof(ParserXML).GetMethod("convertValueFromString", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{dataType, dataValue});
            /* Assert */
            Assert.AreEqual((Object)"None", (Object)actualResult);
        }
    }

    [TestMethod]
    public void convertValueFromStringTest_14_9()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string917 = "ECUC-SYMBOLIC-NAME-REFERENCE-DEF";
            String dataType = string917;
            String string1018 = "None";
            String dataValue = string1018;
            /* Act */
            Object actualResult = (Object)typeof(ParserXML).GetMethod("convertValueFromString", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{dataType, dataValue});
            /* Assert */
            Assert.AreEqual((Object)"None", (Object)actualResult);
        }
    }

    [TestMethod]
    public void convertValueFromStringTest_14_10()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string919 = "ECUC-URI-REFERENCE-DEF";
            String dataType = string919;
            String string1020 = "None";
            String dataValue = string1020;
            /* Act */
            Object actualResult = (Object)typeof(ParserXML).GetMethod("convertValueFromString", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{dataType, dataValue});
            /* Assert */
            Assert.AreEqual((Object)"None", (Object)actualResult);
        }
    }

    [TestMethod]
    public void convertValueFromStringTest_14_11()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string921 = "ECUC-ADD-INFO-PARAM-DEF";
            String dataType = string921;
            String string1022 = "None";
            String dataValue = string1022;
            /* Act */
            Object actualResult = (Object)typeof(ParserXML).GetMethod("convertValueFromString", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{dataType, dataValue});
            /* Assert */
            Assert.AreEqual((Object)"None", (Object)actualResult);
        }
    }

    [TestMethod]
    public void convertValueFromStringTest_14_12()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string923 = "Invalid DataType";
            String dataType = string923;
            String string1024 = "None";
            String dataValue = string1024;
            /* Act */
            Object actualResult = (Object)typeof(ParserXML).GetMethod("convertValueFromString", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{dataType, dataValue});
            /* Assert */
            Assert.AreEqual((Object)"None", (Object)actualResult);
        }
    }

    [TestMethod]
    public void convertValueFromStringTest_14_13()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string925 = "";
            String dataType = string925;
            String string1026 = "None";
            String dataValue = string1026;
            /* Act */
            Object actualResult = (Object)typeof(ParserXML).GetMethod("convertValueFromString", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{dataType, dataValue});
            /* Assert */
            Assert.AreEqual((Object)"None", (Object)actualResult);
        }
    }

    [TestMethod]
    public void convertValueFromStringTest_14_14()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string927 = "Invalid DataType";
            String dataType = string927;
            String string1028 = null;
            String dataValue = string1028;
            /* Act */
            Object actualResult = (Object)typeof(ParserXML).GetMethod("convertValueFromString", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{dataType, dataValue});
            /* Assert */
            Assert.AreEqual((Object)null, (Object)actualResult);
        }
    }
}