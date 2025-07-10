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
    public void AppendInstanceToFileNameTest_140_1()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string91 = "Icu_Cbk.h";
            String name = string91;
            String string102 = "Icu";
            typeof(BasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, string102);
            bool instanceoutputtype124 = true;
            typeof(BasicConfiguration).GetProperty("HasInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, instanceoutputtype124);
            Renesas.Generator.MCALConfGen.Data.BasicConfiguration.Fakes.ShimBasicConfiguration.AllInstances.ToInstanceValueAppendType = (BasicConfiguration instance, AppendType type) =>
            {
                String string135 = "_59_Inst0";
                return string135;
            }

            ;
            /* Act */
            String actualResult = (String)typeof(BasicConfiguration).GetMethod("AppendInstanceToFileName", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{name});
            /* Assert */
            Assert.AreEqual((String)"Icu_59_Inst0_Cbk.h", (String)actualResult);
        }
    }

    [TestMethod]
    public void AppendInstanceToFileNameTest_140_2()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string96 = "Icu_Cbk.h";
            String name = string96;
            String string107 = "Lin";
            typeof(BasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, string107);
            bool instanceoutputtype129 = true;
            typeof(BasicConfiguration).GetProperty("HasInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, instanceoutputtype129);
            Renesas.Generator.MCALConfGen.Data.BasicConfiguration.Fakes.ShimBasicConfiguration.AllInstances.ToInstanceValueAppendType = (BasicConfiguration instance, AppendType type) =>
            {
                String string1310 = "_59_Inst0";
                return string1310;
            }

            ;
            /* Act */
            String actualResult = (String)typeof(BasicConfiguration).GetMethod("AppendInstanceToFileName", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{name});
            /* Assert */
            Assert.AreEqual((String)"Icu_Cbk.h", (String)actualResult);
        }
    }

    [TestMethod]
    public void AppendInstanceToFileNameTest_140_3()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string911 = "Icu_Cbk.h";
            String name = string911;
            String string1012 = "Icu";
            typeof(BasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, string1012);
            bool instanceoutputtype1214 = false;
            typeof(BasicConfiguration).GetProperty("HasInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, instanceoutputtype1214);
            Renesas.Generator.MCALConfGen.Data.BasicConfiguration.Fakes.ShimBasicConfiguration.AllInstances.ToInstanceValueAppendType = (BasicConfiguration instance, AppendType type) =>
            {
                String string1315 = "_59_Inst0";
                return string1315;
            }

            ;
            /* Act */
            String actualResult = (String)typeof(BasicConfiguration).GetMethod("AppendInstanceToFileName", BindingFlags.Instance | BindingFlags.Public, null, new Type[]{typeof(String)}, null).Invoke(_target, new object[]{name});
            /* Assert */
            Assert.AreEqual((String)"Icu_Cbk.h", (String)actualResult);
        }
    }

    [TestMethod]
    public void AppendInstanceToFileNameTest_140_4()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string911 = "";
            String name = string911;
            String string1012 = "Icu";
            typeof(BasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, string1012);
            bool instanceoutputtype1214 = false;
            typeof(BasicConfiguration).GetProperty("HasInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, instanceoutputtype1214);
            Renesas.Generator.MCALConfGen.Data.BasicConfiguration.Fakes.ShimBasicConfiguration.AllInstances.ToInstanceValueAppendType = (BasicConfiguration instance, AppendType type) =>
            {
                String string1315 = "_59_Inst0";
                return string1315;
            }

            ;
            /* Act */
            String actualResult = (String)typeof(BasicConfiguration).GetMethod("AppendInstanceToFileName", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String) }, null).Invoke(_target, new object[] { name });
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
        }
    }

    [TestMethod]
    public void AppendInstanceToFileNameTest_140_5()
    {
        using (ShimsContext.Create())
        {
            /* Arrange */
            String string911 = null;
            String name = string911;
            String string1012 = "Icu";
            typeof(BasicConfiguration).GetProperty("ModuleName", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, string1012);
            bool instanceoutputtype1214 = false;
            typeof(BasicConfiguration).GetProperty("HasInstanceSetting", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public).SetValue(_target, instanceoutputtype1214);
            Renesas.Generator.MCALConfGen.Data.BasicConfiguration.Fakes.ShimBasicConfiguration.AllInstances.ToInstanceValueAppendType = (BasicConfiguration instance, AppendType type) =>
            {
                String string1315 = "_59_Inst0";
                return string1315;
            }

            ;
            /* Act */
            String actualResult = (String)typeof(BasicConfiguration).GetMethod("AppendInstanceToFileName", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(String) }, null).Invoke(_target, new object[] { name });
            /* Assert */
            Assert.AreEqual((String)"", (String)actualResult);
        }
    }
}