using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Business.Generation.GenerationItems;

public partial class TestDefineGenerationItem
{
    [TestMethod]
    public void computeSpacesTest_94_1()
    {
        using (ShimsContext.Create())
        {
            Dictionary<string, string> string179 = new Dictionary<string, string>() { { "0123", "JV-01" } };
            typeof(DefineGenerationItem).GetField("QACMessage", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string179);
            /* Arrange */
            String string91 = "LIN_DEV_ERROR_DETECT";
            String name = string91;
            String string102 = "STD_OFF";
            String value = string102;
            /* Act */
            String actualResult = (String)typeof(DefineGenerationItem).GetMethod("computeSpaces", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{name, value});
            /* Assert */
            Object actualResult_length_119 = typeof(String).GetProperty("Length", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)145, (Int32)actualResult_length_119);
        }
    }

    [TestMethod]
    public void computeSpacesTest_94_2()
    {
        using (ShimsContext.Create())
        {
            
            /* Arrange */
            String string93 = null;
            String name = string93;
            String string104 = "LinWriteVerifyErrorNotificationInformation";
            String value = string104;
            /* Act */
            String actualResult = (String)typeof(DefineGenerationItem).GetMethod("computeSpaces", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{name, value});
            /* Assert */
            Object actualResult_length_120 = typeof(String).GetProperty("Length", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)203, (Int32)actualResult_length_120);
        }
    }

    [TestMethod]
    public void computeSpacesTest_94_3()
    {
        using (ShimsContext.Create())
        {
            Dictionary<string, string> string179 = new Dictionary<string, string>() { { "0123", "JV-01" } };
            typeof(DefineGenerationItem).GetField("QACMessage", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string179);
            /* Arrange */
            String string95 = "LinWriteVerifyErrorNotificationInformation";
            String name = string95;
            String string106 = "(&Lin_GaaConfiguration[0])";
            String value = string106;
            /* Act */
            String actualResult = (String)typeof(DefineGenerationItem).GetMethod("computeSpaces", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{name, value});
            /* Assert */
            Object actualResult_length_121 = typeof(String).GetProperty("Length", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)145, (Int32)actualResult_length_121);
        }
    }

    [TestMethod]
    public void computeSpacesTest_94_4()
    {
        using (ShimsContext.Create())
        {
            Dictionary<string, string> string179 = new Dictionary<string, string>() { { "0123", "JV-01" } };
            typeof(DefineGenerationItem).GetField("QACMessage", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string179);
            /* Arrange */
            String string97 = "LinWriteVerifyErrorNotificationInformation_information_version_autosar4.2.2222222222222222222222222222222222222222222222222222222222";
            String name = string97;
            String string108 = "STD_OFF";
            String value = string108;
            /* Act */
            String actualResult = (String)typeof(DefineGenerationItem).GetMethod("computeSpaces", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{name, value});
            /* Assert */
            Object actualResult_length_122 = typeof(String).GetProperty("Length", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)257, (Int32)actualResult_length_122);
        }
    }

    [TestMethod]
    public void computeSpacesTest_94_5()
    {
        using (ShimsContext.Create())
        {
            Dictionary<string, string> string179 = new Dictionary<string, string>() { { "0123", "JV-01" } };
            typeof(DefineGenerationItem).GetField("QACMessage", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string179);
            /* Arrange */
            String string99 = "LIN_INSTANCE_ID_VALUE";
            String name = string99;
            String string1010 = "STD_OFF";
            String value = string1010;
            /* Act */
            String actualResult = (String)typeof(DefineGenerationItem).GetMethod("computeSpaces", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{name, value});
            /* Assert */
            Object actualResult_length_123 = typeof(String).GetProperty("Length", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)145, (Int32)actualResult_length_123);
        }
    }

    [TestMethod]
    public void computeSpacesTest_94_6()
    {
        using (ShimsContext.Create())
        {
            Dictionary<string, string> string179 = new Dictionary<string, string>() { { "0123", "JV-01" } };
            typeof(DefineGenerationItem).GetField("QACMessage", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string179);
            /* Arrange */
            String string911 = "LinWriteVerifyErrorNotificationInformation_information_version_autosar4.2.2";
            String name = string911;
            String string1012 = "LinWriteVerifyErrorNotificationInformation";
            String value = string1012;
            /* Act */
            String actualResult = (String)typeof(DefineGenerationItem).GetMethod("computeSpaces", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{name, value});
            /* Assert */
            Object actualResult_length_124 = typeof(String).GetProperty("Length", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)269, (Int32)actualResult_length_124);
        }
    }

    [TestMethod]
    public void computeSpacesTest_94_7()
    {
        using (ShimsContext.Create())
        {
            Dictionary<string, string> string179 = new Dictionary<string, string>() { { "0123", "JV-01" } };
            typeof(DefineGenerationItem).GetField("QACMessage", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string179);
            /* Arrange */
            String string913 = "LIN_INSTANCE_ID_VALUE";
            String name = string913;
            String string1014 = "";
            String value = string1014;
            /* Act */
            String actualResult = (String)typeof(DefineGenerationItem).GetMethod("computeSpaces", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{name, value});
            /* Assert */
            Object actualResult_length_125 = typeof(String).GetProperty("Length", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)145, (Int32)actualResult_length_125);
        }
    }

    [TestMethod]
    public void computeSpacesTest_94_8()
    {
        using (ShimsContext.Create())
        {
            Dictionary<string, string> string179 = new Dictionary<string, string>() { { "0123", "JV-01" } };
            typeof(DefineGenerationItem).GetField("QACMessage", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string179);
            /* Arrange */
            String string915 = "PORT_E_WRITE_TIMEOUT_FAILURE";
            String name = string915;
            String string1016 = "DemConf_DemEventParameter_DemEventParameter11111111111111111111111111111111111111111111111111111111111111111111111111111";
            String value = string1016;
            /* Act */
            String actualResult = (String)typeof(DefineGenerationItem).GetMethod("computeSpaces", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{name, value});
            /* Assert */
            Object actualResult_length_126 = typeof(String).GetProperty("Length", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)269, (Int32)actualResult_length_126);
        }
    }

    [TestMethod]
    public void computeSpacesTest_94_9()
    {
        using (ShimsContext.Create())
        {
            Dictionary<string, string> string179 = new Dictionary<string, string>() { { "0123", "JV-01" } };
            typeof(DefineGenerationItem).GetField("QACMessage", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic).SetValue(_target, string179);
            /* Arrange */
            String string917 = "LinWriteVerifyErrorNotificationInformation_information_version_autosar4.2.22222222";
            String name = string917;
            String string1018 = "DemConf_DemEventParameter_DemEventParameter11111111111111111111111111111111111111111111111111111111111111111111111111111";
            String value = string1018;
            /* Act */
            String actualResult = (String)typeof(DefineGenerationItem).GetMethod("computeSpaces", BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]{typeof(String), typeof(String)}, null).Invoke(_target, new object[]{name, value});
            /* Assert */
            Object actualResult_length_127 = typeof(String).GetProperty("Length", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).GetValue(actualResult);
            Assert.AreEqual((Int32)269, (Int32)actualResult_length_127);
        }
    }


}