using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Renesas.Generator.MCALConfGen.Data.BasicConfiguration;

public partial class TestBasicConfiguration
{
    [TestMethod]
    public void AppendInstanceToMacroTest_166_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "Icu_GaaConfiguration[]";
            String macro = string91;
            AppendType appendtype102 = AppendType.FULL_UPPER;
            AppendType type = appendtype102;
            String string113 = "Icu";
            typeof(BasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, string113);
            Boolean boolean135 = true;
            typeof(BasicConfiguration).GetProperty("HasInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, boolean135);
            Renesas.Generator.MCALConfGen.Data.BasicConfiguration.Fakes.ShimBasicConfiguration.AllInstances.ToInstanceValueAppendType = (BasicConfiguration instance, AppendType _type) =>
            {
                String string146 = "_59_INST0";
                return string146;
            }

            ;
            /* Act */
            String actualResult = (String)typeof(BasicConfiguration).GetMethod("AppendInstanceToMacro", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(AppendType) }, null).Invoke(_target, new object[] { macro, type });
            /* Assert */
            Assert.AreEqual((String)"Icu_59_INST0_GaaConfiguration[]", (String)actualResult);
        }
    }

    [TestMethod]
    public void AppendInstanceToMacroTest_166_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string97 = "Icu_GaaConfiguration[]";
            String macro = string97;
            AppendType appendtype108 = AppendType.ORIGINAL;
            AppendType type = appendtype108;
            String string119 = "Icu";
            typeof(BasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, string119);
            Boolean boolean1311 = true;
            typeof(BasicConfiguration).GetProperty("HasInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, boolean1311);
            Renesas.Generator.MCALConfGen.Data.BasicConfiguration.Fakes.ShimBasicConfiguration.AllInstances.ToInstanceValueAppendType = (BasicConfiguration instance, AppendType _type) =>
            {
                String string1412 = "_59_Inst0";
                return string1412;
            }

            ;
            /* Act */
            String actualResult = (String)typeof(BasicConfiguration).GetMethod("AppendInstanceToMacro", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(AppendType) }, null).Invoke(_target, new object[] { macro, type });
            /* Assert */
            Assert.AreEqual((String)"Icu_59_Inst0_GaaConfiguration[]", (String)actualResult);
        }
    }

    [TestMethod]
    public void AppendInstanceToMacroTest_166_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string97 = "Icu_GaaConfiguration[]";
            String macro = string97;
            AppendType appendtype108 = AppendType.ORIGINAL;
            AppendType type = appendtype108;
            String string119 = "Icu";
            typeof(BasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, string119);
            Boolean boolean1311 = false;
            typeof(BasicConfiguration).GetProperty("HasInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, boolean1311);
            Renesas.Generator.MCALConfGen.Data.BasicConfiguration.Fakes.ShimBasicConfiguration.AllInstances.ToInstanceValueAppendType = (BasicConfiguration instance, AppendType _type) =>
            {
                String string1412 = "_59_Inst0";
                return string1412;
            }

            ;
            /* Act */
            String actualResult = (String)typeof(BasicConfiguration).GetMethod("AppendInstanceToMacro", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(AppendType) }, null).Invoke(_target, new object[] { macro, type });
            /* Assert */
            Assert.AreEqual((String)"Icu_GaaConfiguration[]", (String)actualResult);
        }
    }

    [TestMethod]
    public void AppendInstanceToMacroTest_166_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string931 = "******";
            String macro = string931;
            AppendType appendtype1032 = AppendType.FULL_UPPER;
            AppendType type = appendtype1032;
            String string1133 = "Icu";
            typeof(BasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, string1133);
            Boolean boolean1335 = true;
            typeof(BasicConfiguration).GetProperty("HasInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, boolean1335);
            Renesas.Generator.MCALConfGen.Data.BasicConfiguration.Fakes.ShimBasicConfiguration.AllInstances.ToInstanceValueAppendType = (BasicConfiguration instance, AppendType _type) =>
            {
                String string1436 = "_59_Inst0";
                return string1436;
            }

            ;
            /* Act */
            String actualResult = (String)typeof(BasicConfiguration).GetMethod("AppendInstanceToMacro", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(AppendType) }, null).Invoke(_target, new object[] { macro, type });
            /* Assert */
            Assert.AreEqual((String)"******", (String)actualResult);
        }
    }
    [TestMethod]
    public void AppendInstanceToMacroTest_166_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string931 = "";
            String macro = string931;
            AppendType appendtype1032 = AppendType.FULL_UPPER;
            AppendType type = appendtype1032;
            String string1133 = "Icu";
            typeof(BasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, string1133);
            Boolean boolean1335 = true;
            typeof(BasicConfiguration).GetProperty("HasInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, boolean1335);
            Renesas.Generator.MCALConfGen.Data.BasicConfiguration.Fakes.ShimBasicConfiguration.AllInstances.ToInstanceValueAppendType = (BasicConfiguration instance, AppendType _type) =>
            {
                String string1436 = "_59_Inst0";
                return string1436;
            }

            ;
            /* Act */
            String actualResult = (String)typeof(BasicConfiguration).GetMethod("AppendInstanceToMacro", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(AppendType) }, null).Invoke(_target, new object[] { macro, type });
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
        }
    }

    [TestMethod]
    public void AppendInstanceToMacroTest_166_6()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string931 = null;
            String macro = string931;
            AppendType appendtype1032 = AppendType.FULL_UPPER;
            AppendType type = appendtype1032;
            String string1133 = "Icu";
            typeof(BasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, string1133);
            Boolean boolean1335 = true;
            typeof(BasicConfiguration).GetProperty("HasInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, boolean1335);
            Renesas.Generator.MCALConfGen.Data.BasicConfiguration.Fakes.ShimBasicConfiguration.AllInstances.ToInstanceValueAppendType = (BasicConfiguration instance, AppendType _type) =>
            {
                String string1436 = "_59_Inst0";
                return string1436;
            }

            ;
            /* Act */
            String actualResult = (String)typeof(BasicConfiguration).GetMethod("AppendInstanceToMacro", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String), typeof(AppendType) }, null).Invoke(_target, new object[] { macro, type });
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
        }
    }
}